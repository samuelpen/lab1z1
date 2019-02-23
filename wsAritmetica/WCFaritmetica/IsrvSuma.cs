using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFaritmetica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IsrvSuma
    {

        [OperationContract]

        clsSuma suma(int numero1, int numero2);
        // TODO: Add your service operations here
    }

    [DataContract]
    public class clsSuma
    {
        [DataMember]
        public int numeroA { get; set; }
        [DataMember]
        public int numeroB { get; set; }
        [DataMember]
        public int resultado { get; set; }


    }

}
