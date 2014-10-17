
namespace EtalonLibrary
{
    public static class EtalonFactory
    {
        public static EtalonBaseObject Instance()
        {
            return new EtalonNamedObject{Name = "DefaultName", Id = -1};
        }
    }
}
