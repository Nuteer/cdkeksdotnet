using Amazon.CDK;

namespace EksEtc
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new EksEtcStack(app);
            app.Synth();
        }
    }
}
