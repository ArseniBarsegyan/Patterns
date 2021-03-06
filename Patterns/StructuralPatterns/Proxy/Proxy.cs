﻿using StructuralPatterns.Proxy.Abstract;

namespace StructuralPatterns.Proxy
{
    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}