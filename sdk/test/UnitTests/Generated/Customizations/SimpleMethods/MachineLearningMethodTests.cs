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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.MachineLearning.Model;
using Amazon.MachineLearning;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class MachineLearningMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("MachineLearning")]
        public void MachineLearningSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "CreateRealtimeEndpoint", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "DeleteBatchPrediction", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "DeleteDataSource", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "DeleteEvaluation", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "DeleteMLModel", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "DeleteRealtimeEndpoint", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "GetBatchPrediction", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "GetDataSource", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "GetDataSource", new Type[] { typeof(string), typeof(bool), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "GetEvaluation", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "GetMLModel", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "GetMLModel", new Type[] { typeof(string), typeof(bool), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "Predict", new Type[] { typeof(string), typeof(string), typeof(Dictionary<string, string>), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "UpdateBatchPrediction", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "UpdateDataSource", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "UpdateEvaluation", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.MachineLearning.AmazonMachineLearningClient), "UpdateMLModel", new Type[] { typeof(string), typeof(string), typeof(float), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}