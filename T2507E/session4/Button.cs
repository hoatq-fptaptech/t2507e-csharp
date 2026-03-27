namespace T2507E.session4;

public class Button
{
    public event PrintMessage Click;

    public void OnClick(PrintMessage f)
    {
        Click += f;
    }

    public void Clicked(string s)
    {
        Click(s);
    }
}