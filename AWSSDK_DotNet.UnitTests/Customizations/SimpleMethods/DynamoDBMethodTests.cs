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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
    public class DynamoDBMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("DynamoDB")]
        public void DynamoDBSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "BatchGetItem", new Type[] { typeof(Dictionary<string, KeysAndAttributes>), typeof(ReturnConsumedCapacity), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "BatchGetItem", new Type[] { typeof(Dictionary<string, KeysAndAttributes>), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "BatchWriteItem", new Type[] { typeof(Dictionary<string, List<WriteRequest>>), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "CreateTable", new Type[] { typeof(string), typeof(List<KeySchemaElement>), typeof(List<AttributeDefinition>), typeof(ProvisionedThroughput), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "DeleteItem", new Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "DeleteItem", new Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(ReturnValue), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "DeleteTable", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "DescribeTable", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "GetItem", new Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "GetItem", new Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(bool), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "ListTables", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "ListTables", new Type[] { typeof(string), typeof(int), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "ListTables", new Type[] { typeof(int), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "PutItem", new Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "PutItem", new Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(ReturnValue), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "Scan", new Type[] { typeof(string), typeof(List<string>), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "Scan", new Type[] { typeof(string), typeof(Dictionary<string, Condition>), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "Scan", new Type[] { typeof(string), typeof(List<string>), typeof(Dictionary<string, Condition>), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "UpdateItem", new Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(Dictionary<string, AttributeValueUpdate>), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "UpdateItem", new Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(Dictionary<string, AttributeValueUpdate>), typeof(ReturnValue), });
            EnsureSimpleMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "UpdateTable", new Type[] { typeof(string), typeof(ProvisionedThroughput), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}