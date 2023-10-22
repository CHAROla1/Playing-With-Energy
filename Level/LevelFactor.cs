
using System;

public class LevelFactor
{
    private string key;

    private int value;

    protected LevelFactor(string key)
    {
        value = ES3.Load<int>(key, "Player/Level", 0);
        this.key = key;
    }
    public virtual void set(int value)
    {
        this.value = value;
    }
    public virtual int get()
    {
        return value;
    }
    public string name() { return key; }

    public virtual void update(int oldValue, int newValue)
    {
        set(value + newValue - oldValue);
    }

    public virtual void update(int diff)
    {
        set(value + diff);
    }

    public void store()
    {
        ES3.Save<int>(key, value, "Player/Level");
    }



}
