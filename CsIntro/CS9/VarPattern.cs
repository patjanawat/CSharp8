namespace VarPatternNamespace
{
    public record Point(int x, int y);

    public static class VarPattern
    {
        public static Point Transform(Point point) => point switch
        {
            var (x, y) when x < y => new Point(-x, y),
            var (x, y) when x > y => new Point(x, -y),
            var (x, y) => new Point(x, y)
        };
    }
}