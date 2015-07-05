using KoreanTrainer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanTrainer.Interfaces
{
    public interface IDataProviderService
    {
        Vocable RetrieveNewVocable();
    }
}
