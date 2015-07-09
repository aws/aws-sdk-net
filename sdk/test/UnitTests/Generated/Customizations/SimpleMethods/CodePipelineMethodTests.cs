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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CodePipeline.Model;
using Amazon.CodePipeline;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class CodePipelineMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("CodePipeline")]
        public void CodePipelineSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "AcknowledgeJob", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "AcknowledgeThirdPartyJob", new Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "CreatePipeline", new Type[] { typeof(PipelineDeclaration), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "DeletePipeline", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "GetJobDetails", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "GetPipeline", new Type[] { typeof(string), typeof(int), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "GetPipeline", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "GetPipelineState", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "GetThirdPartyJobDetails", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "ListActionTypes", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "ListActionTypes", new Type[] { typeof(ActionOwner), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "ListPipelines", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "PutJobFailureResult", new Type[] { typeof(string), typeof(FailureDetails), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "PutThirdPartyJobFailureResult", new Type[] { typeof(string), typeof(string), typeof(FailureDetails), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "StartPipelineExecution", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CodePipeline.AmazonCodePipelineClient), "UpdatePipeline", new Type[] { typeof(PipelineDeclaration), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}