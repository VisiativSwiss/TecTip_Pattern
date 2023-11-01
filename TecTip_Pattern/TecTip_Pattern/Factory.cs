namespace TecTip_Pattern
{
    public abstract class FeatureCreator
    {
        public abstract IFeature CreateFeature();
    }

    public class CircleCreator : FeatureCreator
    {
        public override IFeature CreateFeature()
        {
            return new CircleFeature();
        }
    }

    public class RectangleCreator : FeatureCreator
    {
        public override IFeature CreateFeature()
        {
            return new RectangleFeature();
        }
    }

    public interface IFeature
    {
        void Create();
    }

    public class CircleFeature : IFeature
    {
        public void Create()
        {
            // Implementation for creating a circle in SolidWorks
        }
    }

    public class RectangleFeature : IFeature
    {
        public void Create()
        {
            // Implementation for creating a rectangle in SolidWorks
        }
    }
}
