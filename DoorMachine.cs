using System;

class DoorMachine
{
    private enum State { Terkunci, Terbuka }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci; // State awal terkunci
    }

    public void KunciPintu()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        currentState = State.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }
}