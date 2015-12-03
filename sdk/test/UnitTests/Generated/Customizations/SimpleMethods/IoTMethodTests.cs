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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IoT.Model;
using Amazon.IoT;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class IoTMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("IoT")]
        public void IoTSimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "AttachPrincipalPolicy", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "AttachThingPrincipal", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "CancelCertificateTransfer", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "CreateCertificateFromCsr", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "CreateCertificateFromCsr", new Type[] { typeof(string), typeof(bool), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "CreateKeysAndCertificate", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "CreateKeysAndCertificate", new Type[] { typeof(bool), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "CreatePolicy", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "CreatePolicyVersion", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "CreatePolicyVersion", new Type[] { typeof(string), typeof(string), typeof(bool), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DeleteCertificate", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DeletePolicy", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DeletePolicyVersion", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DeleteThing", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DeleteTopicRule", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DescribeCertificate", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DescribeEndpoint", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DescribeThing", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DetachPrincipalPolicy", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "DetachThingPrincipal", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "GetPolicy", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "GetPolicyVersion", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "GetTopicRule", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "ListCertificates", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "ListPolicies", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "ListPolicyVersions", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "ListPrincipalPolicies", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "ListPrincipalThings", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "ListThingPrincipals", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "ListThings", new Type[] { });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "ListTopicRules", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "RejectCertificateTransfer", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "SetDefaultPolicyVersion", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "TransferCertificate", new Type[] { typeof(string), typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.IoT.AmazonIoTClient), "UpdateCertificate", new Type[] { typeof(string), typeof(CertificateStatus), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}