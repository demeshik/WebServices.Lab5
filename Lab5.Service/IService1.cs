using System.ServiceModel;

namespace Lab5.Service
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Concat(string s, double d);

        [OperationContract]
        int Add(int x, int y);

        [OperationContract]
        A Sum(A a1, A a2);
    }

}
