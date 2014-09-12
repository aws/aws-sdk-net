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
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class DynamoDBConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void BatchGetItemRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.BatchGetItemRequest), new System.Type[] { typeof(Dictionary<string, KeysAndAttributes>), });
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.BatchGetItemRequest), new System.Type[] { typeof(Dictionary<string, KeysAndAttributes>), typeof(ReturnConsumedCapacity), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void BatchWriteItemRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.BatchWriteItemRequest), new System.Type[] { typeof(Dictionary<string, List<WriteRequest>>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void CreateTableRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.CreateTableRequest), new System.Type[] { typeof(string), typeof(List<KeySchemaElement>), });
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.CreateTableRequest), new System.Type[] { typeof(string), typeof(List<KeySchemaElement>), typeof(List<AttributeDefinition>), typeof(ProvisionedThroughput), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void DeleteItemRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.DeleteItemRequest), new System.Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), });
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.DeleteItemRequest), new System.Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(ReturnValue), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void DeleteTableRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.DeleteTableRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void DescribeTableRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.DescribeTableRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void GetItemRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.GetItemRequest), new System.Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), });
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.GetItemRequest), new System.Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(bool), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void ListTablesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.ListTablesRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.ListTablesRequest), new System.Type[] { typeof(string), typeof(int), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void PutItemRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.PutItemRequest), new System.Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), });
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.PutItemRequest), new System.Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(ReturnValue), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void QueryRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.QueryRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void ScanRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.ScanRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void UpdateItemRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.UpdateItemRequest), new System.Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(Dictionary<string, AttributeValueUpdate>), });
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.UpdateItemRequest), new System.Type[] { typeof(string), typeof(Dictionary<string, AttributeValue>), typeof(Dictionary<string, AttributeValueUpdate>), typeof(ReturnValue), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("DynamoDB")]
        public void UpdateTableRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.DynamoDBv2.Model.UpdateTableRequest), new System.Type[] { typeof(string), typeof(ProvisionedThroughput), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}