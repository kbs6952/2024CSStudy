using System.Threading.Channels;

namespace Class06
{
    // 클래스의 상속과 다형성
    // 객체지향 프로그래밍의 원칙. SOLID 원칙

    // 추상화, 은닉화, 캡슐화, 상속성, 다형성

    // 메소드 오버라이딩, 메소드 매개 길이 변수 params

    // 속성과 기능.

    // 클래스 : 
    // 데이터를 저장하는 용도로 클래스를 선언 Entity
    // 저장된 클래스를 이용하여 기능을 만드는 Handler

    class Player
    {
        // 무기를 가지고 공격을 하는 기능을 만들려고 한다.
        // 어떤 무기인가? (무기에 대한 데이터)
        
        public void Attack(WoodBat woodBat)
        {
            // 어떤 무기를 클래스로 받아와서 함수를 실행하면은 Attack함수를 하나만 써서 공격을 할 수 있게 되었다.
            Console.WriteLine($"{woodBat}무기로 공격했다!");
        }
    public void Attack(Weapon weapon)
    {

    }
    }
    class Sword : Weapon
    {

    }
    class WoodBat : Weapon
    {
        // 속성...
    }
    // 데이터로 사용할 클래스의 갯수만큼 메소드를 만들어야하는 상황에 직면하였다.
    // 이를 해결 하기위한 방법이 무엇일까? 클래스의 상속

    class Weapon
    {

    }

    // 클래스의 메소드의 확장? virtual, override, new

    class Armor
    {
        // 다형성 : 
        public virtual void Equip() // 이 virtual 키워드를 선언한 함수는 내 자식이 override해서 사용해라.
        {
            Console.WriteLine("갑옷을 장착하였습니다");
        }
        public void Equip2()
        {

        }
    }


    // 상속을 하면 부모의 데이터를 가져와서 사용할 수 있다.
    // 상속을 클래스의 확장을 도와주는 기능을 갖고 있다.

    class SpikeArmor : Armor
    {
        public override void Equip()
        {
            Console.WriteLine("갑옷을 장착하였습니다.");
            Console.WriteLine("가시가 추가로 장착되었습니다.");
        }
        public new void Equip2() // new 부모랑 같은 이름의 함수를 선언하였을때 부모의 함수를 숨기는 기능을 한다.
        {
            // new 키워드는 부모의 메서드를 숨겼기 때문에 메모리상에 부모의 함수가 남아있으며,
            // 이 남아있는 메서드를 불러와서 쓸 수 있다.
        }
    }
    
    // 1페이즈 2페이즈 종류가 달라지는 몬스터?

    // 부모와 자식간에는 형변이 가능하다.
    // 부모 -> 자식 클래스 형 변환(다운 캐스팅)
    // 자식 -> 부모 클래스 형 변환(업캐스팅)

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("밥을 먹습니다.");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍 짓습니다.");
        }
    }
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("야옹하고 웁니다.");
        }
    }
    // 건물은 scv유닛이 건물을 짓습니다.
    // Barracks 건물 클래스를 상속받습니다.
    // 유닛을 생성하는 건물입니다.
    // 배럭으로 생성할 수 있는 유닛클래스에는 마린,파이어뱃,메딕,고스트

    class SCV
    {
        public void MakeBuilding(Building building)
        {
            // 생성할 건물이 배럭인가요?
        }
    }
    class Building
    {
       
      
    }
    class Barraks : Building
    {
        public void TrainUnit(Unit unit)
        {
            
            var train = Console.ReadLine();
             
            
           
        }
    }
    enum Unit2
    {
        marin,
        firebat,
        ghost,
        medic,
    }
    class Unit
    {
        
            

    }
    class Marin : Unit
    {

    }
    class FireBat: Unit
    {

    }
    class Ghost : Unit
    {

    }
    



    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Animal[] animals = { animal, dog, cat };

            foreach(var item in animals)
            {

            }



        }
    }
}
