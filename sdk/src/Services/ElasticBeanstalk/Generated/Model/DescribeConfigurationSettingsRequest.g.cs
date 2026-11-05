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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeConfigurationSettings operation. Returns
    /// a description of the settings for the specified configuration set, that is, either
    /// a configuration template or the configuration set associated with a running environment.
    /// <para> When describing the settings for the configuration set associated with a running
    /// environment, it is possible to receive two sets of setting descriptions. One is the
    /// deployed configuration set, and the other is a draft configuration of an environment
    /// that is either in the process of deployment or that failed to deploy. </para> <para>
    /// This action only returns information about resources that the calling principle has
    /// IAM permissions to access. For example, consider a case where a user only has permission
    /// to access one of three resources. When the user calls the this action, the response
    /// will only include the one resource that the user has permission to access instead
    /// of all three resources. If the user doesn’t have access to any of the resources an
    /// empty result is returned. </para> <note> <para> The <a href="https://docs.aws.amazon.com/aws-managed-policy/latest/reference/AWSElasticBeanstalkReadOnly.html">AWSElasticBeanstalkReadOnly</a>
    /// managed policy allows operators to view information about resources related to Elastic
    /// Beanstalk. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html">
    /// Managing Elastic Beanstalk user policies</a> in the <i>Elastic Beanstalk Developer
    /// Guide</i>. For detailed instructions to attach a policy to a user or group, see the
    /// section <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#iam-userpolicies-managed">
    /// Controlling access with managed policies</a> in the same topic. </para> </note> <para>
    /// Related Topics </para> <ul> <li> <para> <a>DeleteEnvironmentConfiguration</a> </para>
    /// </li> </ul>
    /// </summary>
    public partial class DescribeConfigurationSettingsRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeConfigurationSettingsRequest() { }

        /// <summary>
        /// Instantiates DescribeConfigurationSettingsRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The application for the environment or configuration template.</param>
        public DescribeConfigurationSettingsRequest(string applicationName)
        {
            this.ApplicationName = applicationName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application for the environment or configuration template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment to describe.
        /// </para>
        ///  
        /// <para>
        ///  Condition: You must specify either this or a TemplateName, but not both. If you specify
        /// both, Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. If you
        /// do not specify either, Elastic Beanstalk returns <c>MissingRequiredParameter</c> error.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template to describe.
        /// </para>
        ///  
        /// <para>
        ///  Conditional: You must specify either this parameter or an EnvironmentName, but not
        /// both. If you specify both, Elastic Beanstalk returns an <c>InvalidParameterCombination</c>
        /// error. If you do not specify either, Elastic Beanstalk returns a <c>MissingRequiredParameter</c>
        /// error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
