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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.ElasticMapReduce;
using Amazon.ElasticMapReduce.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class ElasticMapReduceConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticMapReduce")]
        public void AddInstanceGroupsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.AddInstanceGroupsRequest), new System.Type[] { typeof(string), typeof(List<InstanceGroupConfig>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticMapReduce")]
        public void AddJobFlowStepsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.AddJobFlowStepsRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.AddJobFlowStepsRequest), new System.Type[] { typeof(string), typeof(List<StepConfig>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticMapReduce")]
        public void AddTagsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.AddTagsRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.AddTagsRequest), new System.Type[] { typeof(string), typeof(List<Tag>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticMapReduce")]
        public void DescribeJobFlowsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.DescribeJobFlowsRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticMapReduce")]
        public void ModifyInstanceGroupsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.ModifyInstanceGroupsRequest), new System.Type[] { typeof(List<InstanceGroupModifyConfig>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticMapReduce")]
        public void RemoveTagsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.RemoveTagsRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.RemoveTagsRequest), new System.Type[] { typeof(string), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticMapReduce")]
        public void RunJobFlowRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.RunJobFlowRequest), new System.Type[] { typeof(string), typeof(JobFlowInstancesConfig), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticMapReduce")]
        public void TerminateJobFlowsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticMapReduce.Model.TerminateJobFlowsRequest), new System.Type[] { typeof(List<string>), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}