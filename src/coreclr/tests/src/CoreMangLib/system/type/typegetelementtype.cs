using System;
using System.Globalization;
using System.Reflection;
/// <summary>
///GetElementType() 
/// </summary>
public class TypeGetElementType
{
    public static int Main()
    {
        TypeGetElementType TypeGetElementType = new TypeGetElementType();
        TestLibrary.TestFramework.BeginTestCase("TypeGetElementType");
        if (TypeGetElementType.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }

    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: returns the Type of the object encompassed or referred to by the current array.");
        try
        {
            Array myArray = Array.CreateInstance(typeof(Int32), 1);
            myArray.SetValue(1, 0);
            Type type1 = myArray.GetType();
            Type type2 = type1.GetElementType();
            if ( !type2.Equals( typeof(Int32)))
            {
                TestLibrary.TestFramework.LogError("001", "GetElementType error!");
                retVal = false;
            }
    
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest2: returns the Type of the object encompassed or referred to by the current reference type.");
        try
        {
            TestClass myClass = new TestClass();
            Type type1 = myClass.GetType();
            Type type2 = type1.GetElementType();
            if (type2!=null)
            {
                TestLibrary.TestFramework.LogError("003", "GetElementType error!");
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
   
}
public class TestClass
{
    
}
