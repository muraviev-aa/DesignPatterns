namespace CreationalPatterns.Builder
{
    internal abstract class Builder
    {
        protected House house;
        public abstract House BuildHouse();
    }
}
