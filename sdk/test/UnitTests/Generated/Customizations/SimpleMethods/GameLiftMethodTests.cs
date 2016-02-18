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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.GameLift.Model;
using Amazon.GameLift;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class GameLiftMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("GameLift")]
        public void GameLiftSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "CreatePlayerSession", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "CreatePlayerSessions", new Type[] { typeof(string), typeof(List<string>), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "DeleteAlias", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "DeleteBuild", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "DeleteFleet", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "DescribeAlias", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "DescribeBuild", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "DescribeEC2InstanceLimits", new Type[] { typeof(EC2InstanceType), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "DescribeFleetPortSettings", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "GetGameSessionLogUrl", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "RequestUploadCredentials", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.GameLift.AmazonGameLiftClient), "ResolveAlias", new Type[] { typeof(string), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}