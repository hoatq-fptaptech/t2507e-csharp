namespace T2507E.session3;

public class Tiger: Animal,IDog,ICat
{
    private List<string> girlFriend = new List<string>();

    public string this[int index]
    {
        get { return girlFriend[index]; }
        set
        {
            if (girlFriend.Count <= index)
            {
                girlFriend.Add(value);
            }
            else
            {
                girlFriend[index] = value;
            }
        }
    }
    
    public override void Eat()
    {
        throw new NotImplementedException();
    }

    public override void Sleep()
    {
        throw new NotImplementedException();
    }

    public void Bite()
    {
        throw new NotImplementedException();
    }

    public void Jump()
    {
        throw new NotImplementedException();
    }
}