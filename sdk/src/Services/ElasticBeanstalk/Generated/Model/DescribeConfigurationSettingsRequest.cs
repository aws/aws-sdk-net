/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConfigurationSettings operation.
    /// Returns a description of the settings for the specified configuration set, that is,
    /// either a configuration template or the configuration set associated with a running
    /// environment.
    /// 
    ///  
    /// <para>
    /// When describing the settings for the configuration set associated with a running environment,
    /// it is possible to receive two sets of setting descriptions. One is the deployed configuration
    /// set, and the other is a draft configuration of an environment that is either in the
    /// process of deployment or that failed to deploy.
    /// </para>
    ///  
    /// <para>
    /// Related Topics
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteEnvironmentConfiguration</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeConfigurationSettingsRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _environmentName;
        private string _templateName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeConfigurationSettingsRequest() { }

        /// <summary>
        /// Instantiates DescribeConfigurationSettingsRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The application for the environment or configuration template.</param>
        public DescribeConfigurationSettingsRequest(string applicationName)
        {
            _applicationName = applicationName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application for the environment or configuration template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment to describe.
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify either this or a TemplateName, but not both. If you specify
        /// both, AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. If
        /// you do not specify either, AWS Elastic Beanstalk returns <c>MissingRequiredParameter</c>
        /// error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template to describe.
        /// </para>
        ///  
        /// <para>
        ///  Conditional: You must specify either this parameter or an EnvironmentName, but not
        /// both. If you specify both, AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c>
        /// error. If you do not specify either, AWS Elastic Beanstalk returns a <c>MissingRequiredParameter</c>
        /// error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}