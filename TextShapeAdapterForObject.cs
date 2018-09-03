using System;
namespace Adapter
{
    public class TextShapeAdapterForObject : Shape
    {
        private ITextView _text;

        private float _bottomLeft;
        private float _topRight;

        public TextShapeAdapterForObject()
        {
        }

        public TextShapeAdapterForObject(ITextView text)
        {
            _text = text;
        }

        public override void BoundingBox(float bottomLeft, float topRight)
        {
            _text.GetOrigin(_bottomLeft, _topRight); // Values got set
        }

        public bool IsThisEmpty()
        {
            return _text.IsEmpty(true);
        }

    }

    //public class Main
    //{
    //    public void Start()
    //    {
    //        TextShapeAdapterForObject textShape

    //    }
    //}
}
