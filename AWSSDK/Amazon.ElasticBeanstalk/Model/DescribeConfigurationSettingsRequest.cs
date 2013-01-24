/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConfigurationSettings operation.
    /// <para> Returns a description of the settings for the specified configuration set, that is, either a configuration template or the
    /// configuration set associated with a running environment. </para> <para> When describing the settings for the configuration set associated
    /// with a running environment, it is possible to receive two sets of setting descriptions. One is the deployed configuration set, and the other
    /// is a draft configuration of an environment that is either in the process of deployment or that failed to deploy. </para> <para>Related
    /// Topics</para>
    /// <ul>
    /// <li> DeleteEnvironmentConfiguration </li>
    /// 
    /// </ul>
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeConfigurationSettings"/>
    public class DescribeConfigurationSettingsRequest : AmazonWebServiceRequest
    {
        private string applicationName;
        private string templateName;
        private string environmentName;

        /// <summary>
        /// The application for the environment or configuration template.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        public DescribeConfigurationSettingsRequest WithApplicationName(string applicationName)
        {
            this.applicationName = applicationName;
            return this;
        }
            

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;       
        }

        /// <summary>
        /// The name of the configuration template to describe. Conditional: You must specify either this parameter or an EnvironmentName, but not both.
        /// If you specify both, AWS Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. If you do not specify either, AWS Elastic
        /// Beanstalk returns a <c>MissingRequiredParameter</c> error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this.templateName; }
            set { this.templateName = value; }
        }

        /// <summary>
        /// Sets the TemplateName property
        /// </summary>
        /// <param name="templateName">The value to set for the TemplateName property </param>
        /// <returns>this instance</returns>
        public DescribeConfigurationSettingsRequest WithTemplateName(string templateName)
        {
            this.templateName = templateName;
            return this;
        }
            

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this.templateName != null;       
        }

        /// <summary>
        /// The name of the environment to describe. Condition: You must specify either this or a TemplateName, but not both. If you specify both, AWS
        /// Elastic Beanstalk returns an <c>InvalidParameterCombination</c> error. If you do not specify either, AWS Elastic Beanstalk returns
        /// <c>MissingRequiredParameter</c> error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this.environmentName; }
            set { this.environmentName = value; }
        }

        /// <summary>
        /// Sets the EnvironmentName property
        /// </summary>
        /// <param name="environmentName">The value to set for the EnvironmentName property </param>
        /// <returns>this instance</returns>
        public DescribeConfigurationSettingsRequest WithEnvironmentName(string environmentName)
        {
            this.environmentName = environmentName;
            return this;
        }
            

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;       
        }
    }
}
    
