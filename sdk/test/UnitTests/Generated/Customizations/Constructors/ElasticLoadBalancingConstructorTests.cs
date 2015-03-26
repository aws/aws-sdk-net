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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.ElasticLoadBalancing;
using Amazon.ElasticLoadBalancing.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class ElasticLoadBalancingConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void ConfigureHealthCheckRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.ConfigureHealthCheckRequest), new System.Type[] { typeof(string), typeof(HealthCheck), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void CreateAppCookieStickinessPolicyRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.CreateAppCookieStickinessPolicyRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void CreateLBCookieStickinessPolicyRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.CreateLBCookieStickinessPolicyRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.CreateLoadBalancerRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.CreateLoadBalancerRequest), new System.Type[] { typeof(string), typeof(List<Listener>), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerListenersRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.CreateLoadBalancerListenersRequest), new System.Type[] { typeof(string), typeof(List<Listener>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void DeleteLoadBalancerRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void DeleteLoadBalancerListenersRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerListenersRequest), new System.Type[] { typeof(string), typeof(List<int>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void DeleteLoadBalancerPolicyRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.DeleteLoadBalancerPolicyRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void DeregisterInstancesFromLoadBalancerRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.DeregisterInstancesFromLoadBalancerRequest), new System.Type[] { typeof(string), typeof(List<Instance>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void DescribeInstanceHealthRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.DescribeInstanceHealthRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancersRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.DescribeLoadBalancersRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void DisableAvailabilityZonesForLoadBalancerRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.DisableAvailabilityZonesForLoadBalancerRequest), new System.Type[] { typeof(string), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void EnableAvailabilityZonesForLoadBalancerRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.EnableAvailabilityZonesForLoadBalancerRequest), new System.Type[] { typeof(string), typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void RegisterInstancesWithLoadBalancerRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.RegisterInstancesWithLoadBalancerRequest), new System.Type[] { typeof(string), typeof(List<Instance>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerListenerSSLCertificateRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.SetLoadBalancerListenerSSLCertificateRequest), new System.Type[] { typeof(string), typeof(int), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesOfListenerRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticLoadBalancing.Model.SetLoadBalancerPoliciesOfListenerRequest), new System.Type[] { typeof(string), typeof(int), typeof(List<string>), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}