using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSOA2GJv11
{
    public class CapaSOA
    {
        public void WS_GetEntityAsString(String InSTREnt)
        {
            var InXML = "<BizAgiWSParam><EntityData><EntityName>" + InSTREnt + "</EntityName></EntityData></BizAgiWSParam>";
            SOABAREntityManager.EntityManagerSOASoapClient objWS = new SOABAREntityManager.EntityManagerSOASoapClient("EntityManagerSOASoap");
            var ResXML = objWS.getEntitiesAsString(InXML);
        }
    }
}