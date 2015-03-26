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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class ElasticBeanstalkConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void CheckDNSAvailabilityRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.CheckDNSAvailabilityRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void CreateApplicationRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.CreateApplicationRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void CreateApplicationVersionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.CreateApplicationVersionRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void CreateConfigurationTemplateRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void CreateEnvironmentRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.CreateEnvironmentRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DeleteApplicationRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.DeleteApplicationRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DeleteApplicationVersionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.DeleteApplicationVersionRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DeleteConfigurationTemplateRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.DeleteConfigurationTemplateRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DeleteEnvironmentConfigurationRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.DeleteEnvironmentConfigurationRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DescribeApplicationsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DescribeApplicationVersionsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DescribeConfigurationOptionsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DescribeConfigurationSettingsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.DescribeConfigurationSettingsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DescribeEnvironmentResourcesRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DescribeEnvironmentsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void DescribeEventsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void RebuildEnvironmentRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void RequestEnvironmentInfoRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.RequestEnvironmentInfoRequest), new System.Type[] { typeof(EnvironmentInfoType), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void RestartAppServerRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void RetrieveEnvironmentInfoRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.RetrieveEnvironmentInfoRequest), new System.Type[] { typeof(EnvironmentInfoType), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void TerminateEnvironmentRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void UpdateApplicationRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.UpdateApplicationRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void UpdateApplicationVersionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.UpdateApplicationVersionRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void UpdateConfigurationTemplateRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.UpdateConfigurationTemplateRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void UpdateEnvironmentRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("ElasticBeanstalk")]
        public void ValidateConfigurationSettingsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.ElasticBeanstalk.Model.ValidateConfigurationSettingsRequest), new System.Type[] { typeof(string), typeof(List<ConfigurationOptionSetting>), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}