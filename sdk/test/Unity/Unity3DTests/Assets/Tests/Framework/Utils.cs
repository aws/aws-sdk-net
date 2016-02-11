
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AWSSDK.Tests.Framework
{
    public class Utils
    {
        public static void AssertTrue(bool value, string message = "")
        {
            if (!value)
            {
                Assert.Fail(message);
            }
        }

        public static void AssertFalse(bool value, string message = "")
        {
            if (value)
            {
                Assert.Fail(message);
            }
        }

        public static void AssertExceptionIsNull(Exception e)
        {
            if (e != null)
            {
                Assert.Fail(string.Format("Expected null exception, got Exception with message: {0}", e.Message));
            }
        }

        public static void AssertStringIsNullOrEmpty(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                Assert.Fail(string.Format("Expected null or empty string, got: {0}", s));
            }
        }

        public static void AssertStringIsNotNullOrEmpty(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                Assert.Fail("Expected non-null and non-empty string");
            }
        }

        public static void AssertExceptionExpected(Action action)
        {
            AssertExceptionExpected(action, typeof(Exception));
        }

        public static T AssertExceptionExpected<T>(Action action) where T : Exception
        {
            return AssertExceptionExpected(action, typeof(T)) as T;
        }

        public static Exception AssertExceptionExpected(Action action, Type expectedExceptionType, string expectedExceptionMessage = null)
        {
            try
            {
                action();
                if (expectedExceptionType != null)
                {
                    Assert.Fail("Exception of type " + expectedExceptionType.FullName + " expected but not thrown!");
                }
                Console.WriteLine("Success, no exception expected or thrown");
                return null;
            }
            catch (Exception e)
            {
                if (expectedExceptionType == null)
                {
                    Assert.Fail("No exception expected, but exception thrown: " + e.ToString());
                }

                Type eType = e.GetType();
                if (!expectedExceptionType.IsAssignableFrom(eType))
                {
                    Assert.Fail("Expected exception of type " + expectedExceptionType.FullName + ", but thrown exception is of type " + eType.FullName + " : " + e.Message);
                }
                else if (
                    !string.IsNullOrEmpty(expectedExceptionMessage) &&
                    !string.Equals(expectedExceptionMessage, e.Message, StringComparison.OrdinalIgnoreCase))
                {
                    Assert.Fail("Expected exception message of [" + expectedExceptionType.FullName + "], but thrown exception has message of [" + e.Message + "]");
                }

                Console.WriteLine("Success, expected " + expectedExceptionType.FullName + ", thrown " + eType.FullName + ": " + e.Message);
                return e;
            }
        }


        /// <summary>
        /// Determines if Unity scripting backend is IL2CPP.
        /// </summary>
        /// <returns><c>true</c>If scripting backend is IL2CPP; otherwise, <c>false</c>.</returns>
        internal static bool IsIL2CPP
        {
            get
            {
                Type type = Type.GetType("Mono.Runtime");
                if (type != null)
                {
                    MethodInfo displayName = type.GetMethod("GetDisplayName", BindingFlags.NonPublic | BindingFlags.Static);
                    if (displayName != null)
                    {
                        string name = null;
                        try
                        {
                            name = displayName.Invoke(null, null).ToString();
                        }
                        catch (Exception)
                        {
                            return false;
                        }

                        if (name != null && name.ToUpper().Contains("IL2CPP"))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
