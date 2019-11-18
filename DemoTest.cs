namespace CourseApp.Tests
{
    public class DemoTest
    {
        
        public void TestFunctionCalculationVal(double a, double b, double x, double exp)
        {
            var res = Program.EqualFunction(a, b, x);
            Assert.Equal(exp, res, 3);
        }
        [Fact]
        public void Test1()
        {
            Assert.True(true);
            Xunit.Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.EqualFunction(0.0, 0.0, 0.0);
            Xunit.Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            var mass = new double[0];
            var res = Program.TaskB(2, 2, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            var x = new double[] { 1.88, 2.26, 3.84, 4.55, -6.21 };
            var res = Program.TaskB(0.8, 0.4, x);
            var expy = new double[] { 1.949734730591048, 2.095663440867529, 2.549253987133699, 2.709362097084625, -3.386980099129981 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
