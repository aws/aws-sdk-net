/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    public static class AssertExtensions
    {
        public static Exception ExpectException(Action action)
        {
            bool gotException = false;
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                gotException = true;
                exception = e;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception");
            return exception;
        }

        public static T ExpectException<T>(Action action) where T : Exception
        {
            var exceptionType = typeof(T);
            return (T)ExpectException(action, exceptionType);
        }

        public static Exception ExpectException(Action action, Type exceptionType, string exceptionMessage = null)
        {
            bool gotException = false;
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e;
                Assert.AreEqual(exceptionType, e.GetType());
                if (exceptionMessage != null)
                {
                    Assert.AreEqual(exceptionMessage, e.Message);
                }
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception: " + exceptionType.FullName);
            return exception;
        }
    }
}
