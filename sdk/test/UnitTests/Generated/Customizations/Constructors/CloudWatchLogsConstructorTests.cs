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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.CloudWatchLogs;
using Amazon.CloudWatchLogs.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class CloudWatchLogsConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void CreateLogGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.CreateLogGroupRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void CreateLogStreamRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.CreateLogStreamRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void DeleteLogGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.DeleteLogGroupRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void DeleteLogStreamRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.DeleteLogStreamRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void DeleteMetricFilterRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.DeleteMetricFilterRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void DeleteRetentionPolicyRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.DeleteRetentionPolicyRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void DescribeLogStreamsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.DescribeLogStreamsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void DescribeMetricFiltersRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.DescribeMetricFiltersRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void GetLogEventsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.GetLogEventsRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void PutLogEventsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.PutLogEventsRequest), new System.Type[] { typeof(string), typeof(string), typeof(List<InputLogEvent>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void PutMetricFilterRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.PutMetricFilterRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), typeof(List<MetricTransformation>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudWatchLogs")]
        public void PutRetentionPolicyRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudWatchLogs.Model.PutRetentionPolicyRequest), new System.Type[] { typeof(string), typeof(int), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}