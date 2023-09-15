using DotnetActionsToolkit;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace dotnet_sample_action
{
    public class Program
    {
        static readonly Core _core = new Core();

        static async Task Main(string[] args)
        {
            try
            {
                string who = _core.GetInput("who");
                _core.Info(GenerateMessage(who));
            }
            catch (Exception ex)
            {
                _core.SetFailed(ex.Message);
            }
        }

        static string GenerateMessage(string who)
        {
            return $"Hello {who}";
        }
    }
}
