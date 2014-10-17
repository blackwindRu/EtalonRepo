
using EtalonLibrary;

namespace EtalonConsole
{
    public class EtalonBuilder
    {
        public string GetEtalonNameById(int id)
        {
            //if(id < =1)
            //return string.Empty;
            var etalon = (EtalonNamedObject)EtalonFactory.Instance();
            return etalon.Name;
        }
    }
}
