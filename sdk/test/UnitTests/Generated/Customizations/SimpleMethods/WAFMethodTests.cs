/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.WAF.Model;
using Amazon.WAF;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class WAFMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("WAF")]
        public void WAFSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "CreateByteMatchSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "CreateIPSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "CreateRule", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "CreateSqlInjectionMatchSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "DeleteByteMatchSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "DeleteIPSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "DeleteRule", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "DeleteSqlInjectionMatchSet", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "DeleteWebACL", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "GetByteMatchSet", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "GetChangeTokenStatus", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "GetIPSet", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "GetRule", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "GetSqlInjectionMatchSet", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "GetWebACL", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "UpdateByteMatchSet", new Type[] { typeof(string), typeof(List<ByteMatchSetUpdate>), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "UpdateIPSet", new Type[] { typeof(string), typeof(List<IPSetUpdate>), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "UpdateRule", new Type[] { typeof(string), typeof(List<RuleUpdate>), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.WAF.AmazonWAFClient), "UpdateSqlInjectionMatchSet", new Type[] { typeof(string), typeof(List<SqlInjectionMatchSetUpdate>), typeof(string), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}