using System;
namespace Adapter
{
    // Get the access to operations form TextView through its interface without knowing the realization and
    // any internal details. Similar approach to IPointerDownHandler in Unity.

    public class TextShapeAdapterForClass : Shape, ITextView
    {
        private float _bottomLeft;
        private float _topRight;

        public TextShapeAdapterForClass()
        {
        }

        public override void BoundingBox(float bottomLeft, float topRight)
        {
            //GetExtent(); // Used to set values for

            bottomLeft = _bottomLeft;
            topRight = _topRight;
        }

        public override Manipulator CreateManipulator()
        {
            return new TextManipulator();
        }

        /// <summary>
        /// Whatever happens here, just dummy operations to get the main idea
        /// </summary>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        public void GetExtent(float width, float height)
        {
            _bottomLeft = width + height;
            _topRight = width * 2 + height * 2;
        }

        public void GetOrigin(float x, float y)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty(bool flag)
        {
            return flag;
        }

        public bool IsThisEmpty()
        {
            return IsEmpty();
        }
    }
}
