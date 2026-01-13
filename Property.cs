####################
        C#
####################

// 프로퍼티 Property
//외부에서 마음대로 변경 못 하게 막음
//상태 변경은 함수로만 통제
//로직용 상태 값 관리, 외부 시스템과의 인터페이스 등

//프로퍼티 기본구조
class Player
{
    private int _hp;

    public int Hp
    {
        get { return _hp; }
        set { _hp = value; }
    }
}

//외부에서 사용
player.Hp = 100;     // set 호출
int hp = player.Hp; // get 호출

//자동 프로퍼티
class Player
{
    public int Hp { get; set; }
}

//읽기 전용
public int Level { get; }

//외부 쓰기 제한
public int Hp { get; private set; }

//응용
private int MaxHp { get; set; }
private int _hp;

public int Hp
{
    get { return (float)Hp / MaxHp; }
    set
    {
        if (value < 0)
            _hp = 0;
        else
            _hp = value;
    }
}

//약식
public int Attack => Strength * 2;
