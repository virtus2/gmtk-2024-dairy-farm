using System.Collections.Generic;
using UnityEngine;

public enum ResourceType
{
    Gold,
    Diamond,
    Pearl,
}
public class AnimalSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Gold;

    [SerializeField]
    private GameObject Diamond;

    [SerializeField]
    private GameObject Pearl;

    [SerializeField]
    private GameObject Food;

    [SerializeField]
    private GameObject SpawnCube;

    public List<GameObject> foods = new List<GameObject>(1000);
    public PlayerData playerData;
    public Dictionary<Animal, List<GameObject>> animals = new Dictionary<Animal, List<GameObject>>();

    private Bounds SpawnBounds;

    private void Awake()
    {
        SpawnBounds = new Bounds(SpawnCube.transform.position, SpawnCube.transform.localScale);
    }

    public void Spawn(AnimalData data)
    {
        var target = new Vector3(
            Random.Range(SpawnBounds.min.x, SpawnBounds.max.x),
            Random.Range(SpawnBounds.min.y, SpawnBounds.max.y),
            Random.Range(SpawnBounds.min.z, SpawnBounds.max.z)
        );

        var controller = Instantiate(data.AnimalController);
        var character = Instantiate(data.AnimalToSpawn, target, Quaternion.identity) as AnimalCharacter;
        controller.SetCharacter(character);
        character.SetController(controller);
        character.SetAnimalData(data, this);

        if (!animals.ContainsKey(data.animal))
        {
            animals.Add(data.animal, new List<GameObject>());
        }
        animals[data.animal].Add(character.gameObject);
    }

    public void Despawn(Animal animal, GameObject go)
    {
        animals[animal].Remove(go);
        AudioManager.Instance.sfxDie.Play();
    }

    public void SpawnFood(Vector3 position)
    {
        if (playerData.gameData.foodMaxCount  + PlayerData.foodCountUpgrade > foods.Count)
        {
            if(PlayerData.balance >= playerData.gameData.foodPrice)
            {
                PlayerData.balance -= playerData.gameData.foodPrice;
                var food = Instantiate(Food, position, Random.rotation);
                foods.Add(food);
            }
        }
    }
    
    public void DespawnFood(GameObject go)
    {
        foods.Remove(go);
        Destroy(go);
    }

    public void SpawnGold(Vector3 position, ResourceType resource)
    {
        GameObject prefab = null;
        switch (resource)
        {
            case ResourceType.Gold:
                prefab = Gold;
                break;
            case ResourceType.Diamond:
                prefab = Diamond;
                break;
            case ResourceType.Pearl:
                prefab = Pearl;
                break;
            default:
                break;
        }

        Instantiate(prefab, position, Random.rotation);
    }
}
