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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.CertificateManager;
using Amazon.CertificateManager.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class CertificateManagerConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CertificateManager")]
        public void DeleteCertificateRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CertificateManager.Model.DeleteCertificateRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CertificateManager")]
        public void DescribeCertificateRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CertificateManager.Model.DescribeCertificateRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CertificateManager")]
        public void GetCertificateRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CertificateManager.Model.GetCertificateRequest), new System.Type[] { typeof(string), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}