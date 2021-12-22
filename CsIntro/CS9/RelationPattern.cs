namespace RelationPatternNamespace
{
    public static class RelationPattern{
        public static string Classtify(double measurement) => measurement switch{
            < -4.0 => "Too low",
            > 10.0 => "Too high",
            double.NaN  =>  "Unknow",
            _ => "Acceptable",
        };
    }
}