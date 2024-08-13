/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.IO;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class BindingRedirectCheckHandlerTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CheckIsBindingError()
        {
            var fe = new FileNotFoundException("Could not load file or assembly 'System.Runtime.CompilerServices.Unsafe, Version=4.0.4.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies.");
            Assert.IsTrue(BindingRedirectCheckHandler.IsBindingException(fe));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CheckIsNotBindingError()
        {
            var fe = new FileNotFoundException("Could not load file or assembly 'AWSSDK.S3, Version=4.0.0.0, Culture=neutral, PublicKeyToken=aaaaaaaaaaa' or one of its dependencies.");
            Assert.IsFalse(BindingRedirectCheckHandler.IsBindingException(fe));
        }
    }
}
