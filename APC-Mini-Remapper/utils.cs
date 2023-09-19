using WindowsInput.Native;

class KeyId
{
    public readonly string label;
    public readonly VirtualKeyCode value;
    public KeyId(string label, VirtualKeyCode value)
    {
        this.label = label;
        this.value = value;
    }
}

