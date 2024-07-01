using C_BASICS;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace C_Basics_test
{
    public class UnitTest1
    {
        //Testing when Arr2's length is bigger than Arr1's
        [Fact]
        public void big_arr2()
        {

            //Assign 
            var arr1 = new int[] { 1, 2, 3,8 ,9,0,4};
            var arr2 = new int[] { 45, 4, 3,8,9,22,22,22,22 };
            var common = new int[] { 4,3,8,9};
            //Act
            C_BASICS.Program program= new C_BASICS.Program();

            var result= program.CommonElements(arr1, arr2);

            //Assert
            Assert.Equal(result,common);

        }

        //Testing when Arr1's length is bigger than Arr2's
        [Fact]
        public void big_arr1()
        {

            //Assign 
            var arr1 = new int[] { 1, 2, 3, 4 };
            var arr2 = new int[] { 45, 4};
            var common = new int[] {4};
            //Act
            C_BASICS.Program program = new C_BASICS.Program();

            var result = program.CommonElements(arr1, arr2);

            //Assert
            Assert.Equal(result, common);

        }

        //Testing when Arr1's length equals Arr2's
        [Fact]
        public void length_equal()
        {

            //Assign 
            var arr1 = new int[] { 1, 4 };
            var arr2 = new int[] { 45, 4 };
            var common = new int[] { 4 };
            //Act
            C_BASICS.Program program = new C_BASICS.Program();

            var result = program.CommonElements(arr1, arr2);

            //Assert
            Assert.Equal(result, common);

        }
    }
}