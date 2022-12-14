using Raylib_cs;
using Constant;

public class Actor 
{
    protected Point position = new Point(0, 0);
    private Point velocity = new Point(0, 0);
    private Color color = Constants.WHITE;
    private Rectangle rec = new Rectangle(0, 0, 0, 0);

    public Actor()
    {
    }

    /// Get and set position.
    public Point GetPosition()
    {
        return position;
    }

    public virtual void SetPosition(Point position)
    {
        if (position == null)
        {
            throw new ArgumentException("position can't be null");
        }
        this.position = position;
    }

    /// Get and set velocity.
    public Point GetVelocity()
    {
        return velocity;
    }

    public void SetVelocity(int X, int Y)
    {
        if (velocity == null)
        {
            throw new ArgumentException("velocity can't be null");
        }
        this.velocity = new Point(X, Y);
    }

    /// Get and set color
    public Color GetColor()
    {
        return color;
    }

    public void SetColor(Color color)
    {
        if (color == null)
        {
            throw new ArgumentException("color can't be null");
        }
        this.color = color;
    }

    public virtual void DrawActor()
    {

    }
}