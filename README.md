# gmtk-2024-dairy-farm
![1](https://github.com/virtus2/gmtk-2024-dairy-farm/blob/main/thumbnail.png)  
**Dairy farm**은 기획 1, 프로그래머 1로 구성된 **끼에엑게임즈**가 개발한 게임입니다. **2024 GMTK 게임잼**에 출품하였습니다.  
(AI를 사용하여 생성된 이미지입니다.)  

## 게임 소개
**Dairy farm**은 광란의 수족관에 영감을 받아 개발한 게임입니다. 게임잼 주제인 `Built to Scale`을 점점 성장해나가는 농장이라는 아이디어로 구체화해서, 코인을 모아 최종적으론 미지의 동물을 구매하는 것이 목표인 게임입니다.

## 세부 사항
- 요약: 유니티 엔진을 사용하여 포인트 앤 클릭 농장 관리 게임 개발
- 기간: 2024.08.17 ~ 2024.08.21
- 팀 구성: 기획 1 [Cornminator](https://github.com/cornminator), 프로그래머 1 [virtus](https://github.com/virtus2)
- 주요 업무: 기획안에 맞춰 게임 시스템 및 컨텐츠 개발
- 상세 업무: 전반적인 게임 시스템 및 컨텐츠 개발
    - 게임잼을 여러 번 참가하고 습작을 만들어 보면서, 본인만의 유니티 템플릿이 있었으면 좋겠다고 생각하여 만든 [urp-template](https://github.com/virtus2/urp-template)을 활용 및 확장하여 개발
    - 동물 캐릭터 구현
         - 템플릿 코드 중 Character 코드를 상속받은 AnimalCharacter로 동물 캐릭터 구현([코드 폴더](https://github.com/virtus2/gmtk-2024-dairy-farm/tree/main/Assets/Scripts/Character))
         - 캐릭터의 상태는 FiniteStateMachine으로 구현하여 확장 및 수정이 용이함 ([코드 폴더](https://github.com/virtus2/gmtk-2024-dairy-farm/tree/main/Assets/Scripts/Character/States))
    - 동물 AI 구현
         - FiniteStateMachine으로 구현하여 확장 및 수정이 용이함 ([코드 폴더](https://github.com/virtus2/gmtk-2024-dairy-farm/tree/main/Assets/Scripts/AI/States))
         - 유니티 AI Navigation 패키지의 NavMesh사용하여 동물들의 이동 관련 기능 구현
         - 초식동물 AI: 일정 주기로 돌아다니고, 배고픈 상태가 되면 먹이를 찾아 먹음
         - 육식동물 AI: 일정 주기로 돌아다니고, 배고픈 상태가 되면 닭을 추격하며 닭에게 근접하면 공격하여 먹음
    - 게임 플레이 로직 구현
         - 동물 해금 및 각 동물들의 상태 정보를 데이터화하여 게임잼 진행 간 테스트 및 플레이를 반복하여 밸런싱할 수 있게 만듦 ([코드](https://github.com/virtus2/gmtk-2024-dairy-farm/blob/main/Assets/Scripts/ScriptableObject/AnimalData.cs))
    - UI 제작 및 구현 ([코드](https://github.com/virtus2/gmtk-2024-dairy-farm/tree/main/Assets/Scripts/UI))
    

## 스크린샷 및 실행 파일
[itch.io](https://corn97.itch.io/dairy-farm)

## 플레이 영상
[Youtube](https://youtu.be/c-4x2M5OQtA?si=bx8Zlcbs683UPAdK)

## 사용한 에셋
[KinematicCharacterController](https://assetstore.unity.com/packages/tools/physics/kinematic-character-controller)
 
