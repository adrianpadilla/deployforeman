
using System.Collections.Generic;
namespace adrianpadilla.deployforeman
{
    public interface ICheckListParser
    {
        IEnumerable<ConfigCheck> ParseCheckList();


    }
}
