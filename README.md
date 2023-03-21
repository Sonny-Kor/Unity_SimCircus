# 🎪 SimCircus
![이미지](https://github.com/Sonny-Kor/Unity_SimCircus/blob/main/Image/MainScene.png)
# 👬 멤버구성
강동현 | 배진열 |손승재
---- | ---- | ----
서커스 무대 연출, Animal 구현 | 게임 시나리오 작성 & GUI 이벤트 처리 | Player 객체 구현, 상점, 게임 진행 처리 구현

# ⏰ 개발기간 및 협업 방법
멤버들의 스케줄을 고려하여 매주 금, 토, 일  4시간을 투자하여 게임에서 작성 요구되는 플레이어 및 무대 연출 설계 부분, 동물 및 상점 설계 부분, 전체적인 UI부분으로 나누어 관련된 기능을 각자 구현한 후 Unity main프로그램에 병합 사용한 버전은 Unity 2021.3.9f1 으로 구현 


# 📃 서론
* 본 프로젝트 에서는 시뮬레이션 게임의 대표작인 Princess Maker나 SimCity, Sims 등의 게임처럼 플레이어의 선택에 따라 수치변동 , 이벤트 발생을 통해 진행되는 2D 경영 시뮬레이션 게임을 만들어 보았다. 직접 시나리오와 게임 규칙을 정하였고 사용자가 게임의 재미와 흥미를 느낄 수 있는 요소를 추가하여 게임의 몰입감을 주었다.


* In this project, we created a 2D management simulation game such as Princess Maker, SimCity, Sims, etc which proceeds numerical fluctuations and events according to the player’s selection. The scenario and game rules were directly set by us and elements that allowed users to feel the fun and interest of the game were added to give them a sense of immersion in the game.
# ✏ 게임 개요
게임명 | Sim Circus 
---- | ----
난이도 | ★☆☆☆☆(1.0)
플레이 시간 | 5분 - 15분
게임 소재 | 의
게임 플랫폼 | Unity (C#) -> 2D -> Windows 운영체제
장르 | 2D 경영 시뮬레이션 게임
설명 | 서커스단장이 되어 서커스단을 운영하고 동물들을 성장시켜 최고의 서커스 공연을 통해 돈을 벌어보자.

# 🎬 시나리오
어느 한 마을 가난한 집안에 첫째로 태어난 애븐(Adven)은 어렸을때부터 일찍 철이 들어 꼭 돈을 많이 벌어 성공을 하겠다는 꿈이 있었다. 

마침 애븐(Adven)은 순회 공연을 하러온 서커스를 보게 되었는데 거기서 우연히 서커스 단장의 수입을 보고 경악을 금치 못하였다.

서커스 공연을 보고 집으로 돌아온 후 애븐(Adven)은 서커스단을 만들기로 결심했다. 그 후로, 자기와 일평생을 함께한 반려견 벤투(ventu)를 데리고 도시로 떠났다.

모든 공연을 끝마치고 정산을 하다 한 아이와 눈이 마주쳤다.
그 아이는 눈을 반짝이고 있었다. 애븐(Adven)은 그 시선을 무시한 채 정산을 끝내고 그 아이가 있던 자리를 바라보니 아이는 이미 사라지고 난 뒤였고, 애븐(Adven)은 설레는 마음으로 다시 돌아갈 생각에 기분이 한껏 들떴다. 그 후 애븐(Adven)은 서커스단을 처분하고 고향으로 돌아와 부모님과 함께 행복하게 잘 살게 되었다.

# 🎮 게임 룰
* 본 게임의 최종 목표는 하루하루 마다 진행되는 공연을 통해 서커스단의 세력을 넓히고 최종 목표인 10,000,000 골드를 모으면 게임은 종료 된다.
* 플레이어는 초기 상태로 개 와 10000골드를 소지한 상태로 시작한다.
* 플레이어는 7일 마다 공연을 하게 되고 플레이어의 동물들의 상태에 따라 공연의 수입을 획득할 수 있고 동물들의 능력치는 감소된다. 공연이 아닌 6일동안 유지비를 지불하면서 동물을 사고 팔거나 동물들을 성장시켜 수입을 늘릴 수 있다.
* 공연은 동물들의 상태에 따라 성공여부가 정해지게 되고 레벨이 상승하게 된다. 또 공연 진행시 동물들의 능력치가 감소하게 된다.
* 동물들은 체력이 0 이하일 때 공연을 진행하게되면 죽게 되고 매력, 컨디션, 포만감이 0이하 인 상태에서 공연을 진행시 패널티로 5000골드가 차감된다. 체력과 매력은 훈련하기를 통해 증가 시킬수 있고 컨디션과 포만감은 관리하기를 통해 증가시킬 수 있다.
* 벤투가 죽거나 애븐의 돈이 0보다 작다면 게임이 종료된다.
* 동물들은 7종류(말,사자,호랑이,원숭이,곰,코끼리,개) 가 있으며 종류마다 능력치가 다르고 공연을 통해 획득할 수 있는 돈이 다르다. 상점을 통해 플레이어가 가진 동물들을 돈을 지불하여 사거나 팔아서 돈을 획득할 수 있다.
* 동물들을 늘리기 위해서는 철장을 구매해야하며 가격은 10000골드이다, 동물의 최대 수는 4개 이고 철장은 2개 구매 가능하고 기본적으로 1개는 제공되어있다.

## 💸 공연 진행 시 골드 획득 량
레벨 | 코끼리 | 말 | 사자 | 호랑이 | 곰 | 원숭이 | 개
---- | ---- | ---- | ---- | ---- | ---- | ---- | ----
1LV | 10000 | 8000 | 15000 | 13000 | 8000 | 3000 | 2000
2LV | 15000 | 13000 | 20000 | 18000 | 13000 | 4000 | 2500
3Lv | 21000 | 19000 | 25000 | 24000 | 19000 | 6000 | 3500
4LV | 30000 | 28000 | 35000 | 33000 | 28000 | 9000 | 6500
5LV | 40000 | 38000 | 45000 | 43000 | 38000 | 12000 | 9000
6LV | 50000 | 48000 | 60000 | 53000 | 48000 | 18000 | 13000
7LV | 65000 | 55000 | 80000 | 70000 | 63000 | 25000 | 17000
8LV | 80000 | 65000 | 100000 | 85000 | 78000 | 38000 | 25000
9LV | 100000 | 88000 | 150000 | 120000 | 98000 | 50000 | 35000
10LV | 150000 | 110000 | 200000 | 175000 | 148000 | 65000 | 45000

## 🏁 공연 진행시 생기는 패널티
공연 성공확률 | ( (LV + (체력/10) + (매력/10) + (포만감/10) + 건강상태 ) * 2 ) % 
---- | ----
공연 유지 비용 | 공연에서 번 획득 량의 5% 
동물 훈련 비용 | 2000 골드
기본적인 스탯 감소 | 7일째가 되는날 공연을 끝마치고 동물들의 스탯이 감소(1~5사이의 랜덤 값)

## 🐣 상점 알 가격 및 확률
알 종류 | 골드 | 원숭이 | 말 | 곰 | 코끼리 | 호랑이 | 사자
---- | ---- | ---- | ---- | ---- | ---- | ---- | ----
원숭이 알 | 6000골드 | 45% | 15% | 15% | 15% | 10% | 5% 
말 알 | 8000골드 | 20% | 35% | 15% | 13% | 10% | 7%
곰 알 | 10000골드 | 20% | 15% | 35% | 13% | 10% | 7%
코끼리 알 | 12000골드 | 5% | 15% | 15% | 30% | 20% | 15% 

# 📈 흐름도 (FLOWCHART)
![flowchart](https://github.com/Sonny-Kor/Unity_SimCircus/blob/main/Image/Flowchart.png)
# 📙 클래스 다이어그램 (Class Diagram)
![image](https://github.com/Sonny-Kor/Unity_SimCircus/blob/main/Image/ClassDiagram.png)

# ⚙ 모듈 설명
## 🧑 Player.cs
메소드 | 입력값 | 출력값 | 기능 
---- | ---- | ---- | ----
buyAnimal | 돈 | 동물 정보 | 동물 사는 기능, 동물 정보 저장
sellAnimal | 동물 정보 | 돈 | 동물 파는 기능
nextDay | - | - | 다음날로 진행 시키는 기능, 동물들의 상태 변화와 유지비 지불, 7일마다 서커스 진행을 통해 골드 증가
care | 동물 | - | 동물의 컨디션 상승
train | 동물 | - | 동물의 스탯 증가
Change Gold | 골드 변화량 | - | player의 골드를 증가, 감소 시키는 함수
circus | - | 서커스 진행 화면 | 서커스 성공 확률 및 획득 골드량 계산
CheckCage | AnimalList | 빈 케이지 번호 | 비어있는 케이지 인덱스 번호 반환
CheckCount | - | - | 비어 있는 케이지의 갯수 반환
display_text | - | - | UI 출력
buyprision | 돈 | 케이지 해금 | 동물을 살 수 있는 슬롯 증설
curcusing | Animal Game Object | 서커스 이미지 | 가지고 있는 동물들의 애니메이션을 출력

## 🦊 Animal.cs

메소드 | 입력값 | 출력값 | 기능
Start | - | - | 동물들의 INIT 설정
expected Profit | 동물정보 | 골드 | 공연을 통한 수입 계산

# 🎬 PREVIEW
## 🎲 PlayScene
![playScene](https://github.com/Sonny-Kor/Unity_SimCircus/blob/main/Image/playScene.png)
## 🎪 Circusing
![circusing](https://github.com/Sonny-Kor/Unity_SimCircus/blob/main/Image/Circusing.png)
## 📦 Shop
![shop](https://github.com/Sonny-Kor/Unity_SimCircus/blob/main/Image/Shop.png)
## 😁 HappyEnding
![end](https://github.com/Sonny-Kor/Unity_SimCircus/blob/main/Image/GoodEnd.png)
## 😰 BadEnding
![bend](https://github.com/Sonny-Kor/Unity_SimCircus/blob/main/Image/BadEnd.png)

