using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCombined.TaskManager.Actions
{
    public class Reset : ITask
    {
        public string Name => "ResetTask";

        public async Task<bool> Run()
        {
            return true;
        }

        public void Tick()
        {
        }


        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}
