using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(1, 2, 2, -1.939)]
        [InlineData(1, 2, 5, 2.936)]
        public void TestEquat(double a, double b, double x, double exp)
        {
            Assert.Equal(Program.EquatFunction(a, b, x), exp, 3);
        }

        [Fact]
        public void TestTaskAArray0()
        {
            var res = Program.TaskA(0.8, 0.4, 1.23, 0.23, 1.2);
            Assert.Equal(res, new double[0]);
        }

        [Fact]
        public void TestTaskAArray1()
        {
            var res = Program.TaskA(0.8, 0.4, 1.23, 7.23, 6).Length;
            Assert.Equal(1, res);
        }

        [Fact]
        public void TestTaskBArray0()
        {
            double[] e = new double[0];
            var res = Program.TaskB(0.8, 0.4, e);
            Assert.Equal(res, new double[0]);
        }

        [Fact]
        public void TestTaskBWork()
        {
            double[] mass = new double[5] { 1.88, 2.26, 3.84, 4.55, -6.21 };
            var res = Program.TaskB(0.8, 0.4, mass);
            Assert.Equal(5, res.Length);
        }
    }
}