namespace LabyrinthGame.Core;
public class Objective
{


public class LockedDoor() // gör en klass av Door ifall man behöver flera olika dörrar i spelet
{
    public bool IsOpen { get; set; } = false;

    public void UnlockDoor()
    {
        IsOpen=true;
    }
}
}