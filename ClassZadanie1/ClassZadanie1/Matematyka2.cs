using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassZadanie1
{
    public class MatematykaTest
    {
        [Fact]
        public void add_returns_sum_of_given_values()
        {
            //arrange

            var math = new Matematyka();

            //Matematyka math = new Matematyka();

            //act

            var result = math.Add(10, 20);


            //assert
            Assert.Equal(30, result);     //wołamy klase asser z metodą Equal
        }

        [Fact]
        public void add_returns_sum_of_given_values2()
        {
            //arrange

            var math = new Matematyka();

            //Matematyka math = new Matematyka();

            //act

            var result = math.Add(10, 20);


            //assert
            Assert.Equal(30, result);     //wołamy klase asser z metodą Equal
        }


        [Fact]
        public void subtract_returns_sum_of_given_values()
        {
            //arrange

            var math = new Matematyka();

            //Matematyka math = new Matematyka();

            //act

            var result = math.Subtract(10, 20);


            //assert
            Assert.Equal(-10, result);
            //wołamy klase asser z metodą Equal..
        }

        [Fact]
        public void division_returns_sum_of_given_values()
        {
            //arrange

            var math = new Matematyka();

            //act

            var result = math.Division(20, 2);


            //assert
            Assert.Equal(10, result);     //wołamy klase asser z metodą Equal

         //   var result1 = math.Division(20.0);


        }
               [Fact]
        public void Multiplaction_returns_sum_of_given_values()
        {
            //arrange

            var math = new Matematyka();

            //act

            var result = math.Multiplaction(20, 10);


            //assert
            Assert.Equal(200, result);
        }
    }
}
