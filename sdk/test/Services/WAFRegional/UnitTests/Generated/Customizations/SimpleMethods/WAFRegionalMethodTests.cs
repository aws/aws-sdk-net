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

/*
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.WAFRegional.Model;
using Amazon.WAFRegional;

namespace AWSSDK_DotNet.UnitTests.TestTools
{
    [TestClass]
    public class WAFRegionalMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("WAFRegional")]
        public void WAFRegionalSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "CreateByteMatchSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "CreateIPSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "CreateRule", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "CreateSqlInjectionMatchSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "DeleteByteMatchSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "DeleteIPSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "DeleteRule", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "DeleteSqlInjectionMatchSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "DeleteWebACL", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "GetByteMatchSet", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "GetChangeTokenStatus", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "GetIPSet", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "GetRule", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "GetSqlInjectionMatchSet", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "GetWebACL", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "UpdateByteMatchSet", new Type[] { typeof(string), typeof(List<ByteMatchSetUpdate>), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "UpdateIPSet", new Type[] { typeof(string), typeof(List<IPSetUpdate>), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "UpdateRule", new Type[] { typeof(string), typeof(List<RuleUpdate>), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAFRegional.AmazonWAFRegionalClient), "UpdateSqlInjectionMatchSet", new Type[] { typeof(string), typeof(List<SqlInjectionMatchSetUpdate>), typeof(string), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}