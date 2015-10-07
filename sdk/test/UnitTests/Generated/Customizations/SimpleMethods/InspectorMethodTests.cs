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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Inspector.Model;
using Amazon.Inspector;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class InspectorMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("Inspector")]
        public void InspectorSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "CreateApplication", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "CreateResourceGroup", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DeleteApplication", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DeleteAssessment", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DeleteRun", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DescribeApplication", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DescribeAssessment", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DescribeFinding", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DescribeResourceGroup", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DescribeRulesPackage", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DescribeRun", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "DetachAssessmentAndRulesPackage", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "GetAssessmentTelemetry", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "ListApplications", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "ListApplications", new Type[] { typeof(ApplicationsFilter), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "ListAssessmentAgents", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "ListAssessmentAgents", new Type[] { typeof(string), typeof(AgentsFilter), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "ListAssessments", new Type[] { typeof(List<string>), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "ListAssessments", new Type[] { typeof(List<string>), typeof(AssessmentsFilter), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "ListRuns", new Type[] { typeof(List<string>), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "ListRuns", new Type[] { typeof(List<string>), typeof(RunsFilter), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "ListTagsForResource", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "PreviewAgentsForResourceGroup", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "RegisterCrossAccountAccessRole", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "RunAssessment", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "SetTagsForResource", new Type[] { typeof(string), typeof(List<Tag>), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "StartDataCollection", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "StopDataCollection", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.Inspector.AmazonInspectorClient), "UpdateApplication", new Type[] { typeof(string), typeof(string), typeof(string), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}