using NUnit.Framework;
using System;
using System.Diagnostics;

namespace TestesDeDesempenho
{
    public class TesteProcessarLote
    {
        [Test]
        public void ProcessarLote()
        {
            Stopwatch stopwatch = new Stopwatch();

            
            stopwatch.Start();
            ProcessarLote(10000);
            stopwatch.Stop();

            
            Assert.That(stopwatch.ElapsedMilliseconds < 1000);
        }

        private void ProcessarLote(int quantidade)
        {
            
        }
    }
}
