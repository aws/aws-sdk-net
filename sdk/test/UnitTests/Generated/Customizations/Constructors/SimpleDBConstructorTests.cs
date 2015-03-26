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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class SimpleDBConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void BatchDeleteAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.BatchDeleteAttributesRequest), new System.Type[] { typeof(string), typeof(List<DeletableItem>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void BatchPutAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.BatchPutAttributesRequest), new System.Type[] { typeof(string), typeof(List<ReplaceableItem>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void CreateDomainRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.CreateDomainRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void DeleteAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.DeleteAttributesRequest), new System.Type[] { typeof(string), typeof(string), });
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.DeleteAttributesRequest), new System.Type[] { typeof(string), typeof(string), typeof(List<Attribute>), });
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.DeleteAttributesRequest), new System.Type[] { typeof(string), typeof(string), typeof(List<Attribute>), typeof(UpdateCondition), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void DeleteDomainRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.DeleteDomainRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void DomainMetadataRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.DomainMetadataRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void GetAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.GetAttributesRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void ListDomainsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void PutAttributesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.PutAttributesRequest), new System.Type[] { typeof(string), typeof(string), typeof(List<ReplaceableAttribute>), });
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.PutAttributesRequest), new System.Type[] { typeof(string), typeof(string), typeof(List<ReplaceableAttribute>), typeof(UpdateCondition), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("SimpleDB")]
        public void SelectRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.SelectRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.SimpleDB.Model.SelectRequest), new System.Type[] { typeof(string), typeof(bool), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}