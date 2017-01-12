using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace OhceKata
{
    public class SampleTestShould
    {
        [Fact]
        public void Pass()
        {
            true.Should().BeTrue();
        }
    }
}
