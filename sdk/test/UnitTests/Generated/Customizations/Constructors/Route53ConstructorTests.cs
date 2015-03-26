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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Route53;
using Amazon.Route53.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class Route53ConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Route53")]
        public void ChangeResourceRecordSetsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Route53.Model.ChangeResourceRecordSetsRequest), new System.Type[] { typeof(string), typeof(ChangeBatch), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Route53")]
        public void CreateHostedZoneRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Route53.Model.CreateHostedZoneRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Route53")]
        public void DeleteHostedZoneRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Route53.Model.DeleteHostedZoneRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Route53")]
        public void GetChangeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Route53.Model.GetChangeRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Route53")]
        public void GetHostedZoneRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Route53.Model.GetHostedZoneRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Route53")]
        public void ListHostedZonesRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Route53")]
        public void ListResourceRecordSetsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Route53.Model.ListResourceRecordSetsRequest), new System.Type[] { typeof(string), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}