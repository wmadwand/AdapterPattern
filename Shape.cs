using System;
namespace Adapter
{
    public class Shape
    {
        public Shape()
        {
        }

        public virtual void BoundingBox(float bottomLeft, float topRight)
        {

        }

        public virtual Manipulator CreateManipulator() { return new Manipulator(); }
    }

    public interface ITextView
    {
        void GetOrigin(float x, float y);

        void GetExtent(float width, float height);

        bool IsEmpty(bool flag);
    }

    public class Manipulator
    {

    }

    public class TextManipulator : Manipulator
    {

    }
}
