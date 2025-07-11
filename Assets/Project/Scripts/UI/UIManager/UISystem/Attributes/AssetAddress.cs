using System;

namespace UI.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class AssetAddress : Attribute
    {
        public string Address { get; }

        public AssetAddress(string address)
        {
            Address = address;
        }
    }
}