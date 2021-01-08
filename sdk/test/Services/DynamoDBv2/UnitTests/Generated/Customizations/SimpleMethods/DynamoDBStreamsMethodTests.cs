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
 * Do not modify this file. This file is generated from the dynamodbstreams-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class DynamoDBStreamsMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("DynamoDBv2")]
        public void DynamoDBStreamsSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBStreamsClient), "DescribeStream", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBStreamsClient), "GetRecords", new Type[] { typeof(string), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}