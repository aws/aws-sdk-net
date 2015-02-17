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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.ElastiCache;
using Amazon.ElastiCache.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class ElastiCacheConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void CreateCacheClusterRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.CreateCacheClusterRequest), new System.Type[] { typeof(string), typeof(int), typeof(string), typeof(string), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void CreateCacheParameterGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.CreateCacheParameterGroupRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void CreateCacheSecurityGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.CreateCacheSecurityGroupRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void DeleteCacheClusterRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.DeleteCacheClusterRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void DeleteCacheParameterGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.DeleteCacheParameterGroupRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void DeleteCacheSecurityGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.DeleteCacheSecurityGroupRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void DescribeCacheClustersRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void DescribeCacheParameterGroupsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.DescribeCacheParameterGroupsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void DescribeCacheParametersRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.DescribeCacheParametersRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void DescribeCacheSecurityGroupsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.DescribeCacheSecurityGroupsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void DescribeEngineDefaultParametersRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.DescribeEngineDefaultParametersRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void DescribeEventsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void ModifyCacheClusterRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.ModifyCacheClusterRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void ModifyCacheParameterGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.ModifyCacheParameterGroupRequest), new System.Type[] { typeof(string), typeof(List<ParameterNameValue>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void RebootCacheClusterRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.RebootCacheClusterRequest), new System.Type[] { typeof(string), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElastiCache")]
        public void ResetCacheParameterGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElastiCache.Model.ResetCacheParameterGroupRequest), new System.Type[] { typeof(string), typeof(List<ParameterNameValue>), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}