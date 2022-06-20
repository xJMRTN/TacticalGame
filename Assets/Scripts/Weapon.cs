public class Weapon
{
    private string WeaponName;
    private string WeaponDescription;
    private int WeaponRange;
    private int HaltedROF;
    private int MovingROF;
    private int AntiTank;
    private int FirePower;

    public Weapon(string _weaponName, string _weaponDescription, int _weaponRange, int _haltedROF, int _movingRof, int _antiTank, int _firePower){
        WeaponName = _weaponName;
        WeaponDescription = _weaponDescription;
        WeaponRange = _weaponRange;
        HaltedROF = _haltedROF;
        MovingROF = _movingRof;
        AntiTank = _antiTank;
        FirePower = _firePower;
    }

    public string GetWeaponName(){
        return WeaponName;
    }

    public string GetWeaponDescription(){
        return WeaponDescription;
    }

    public int GetWeaponRange(){
        return WeaponRange;
    }

    public int GetWeaponHaltedROF(){
        return HaltedROF;
    }

    public int GetWeaponMovingROF(){
        return MovingROF;
    }

    public int GetWeaponAntiTank(){
        return AntiTank;
    }

    public int GetWeaponFirePower(){
        return FirePower;
    }
}