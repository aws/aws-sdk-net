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
    /// Returns a description of the settings for the specified         configuration
    /// set, that is, either a configuration template or the         configuration set associated
    /// with a running environment.        
    /// 
    ///       
    /// <para>
    ///          When describing the settings for the configuration set associated with a
    ///         running environment, it is possible to receive two sets of setting descriptions.
    ///         One is the deployed configuration set, and the other is a draft configuration
    ///         of an environment that is either in the process of deployment or that failed
    /// to         deploy.         
    /// </para>
    ///       
    /// <para>
    /// Related Topics
    /// </para>
    ///       <ul>         <li>            <a>DeleteEnvironmentConfiguration</a>         </li>
    ///      </ul>
    /// </summary>
    public partial class DescribeConfigurationSettingsRequest : AmazonWebServiceRequest
    {
        private string _applicationName;
        private string _environmentName;
        private string _templateName;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///          The application for the environment or configuration template.        
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }


        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConfigurationSettingsRequest WithApplicationName(string applicationName)
        {
            this._applicationName = applicationName;
            return this;
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }


        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        ///          The name of the environment to describe.         
        /// </para>
        ///          
        /// <para>
        ///          Condition: You must specify either this or a TemplateName, but not both.
        /// If you specify both, AWS Elastic Beanstalk returns an <code>InvalidParameterCombination</code>
        /// error.          If you do not specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
        /// error.        
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }


        /// <summary>
        /// Sets the EnvironmentName property
        /// </summary>
        /// <param name="environmentName">The value to set for the EnvironmentName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConfigurationSettingsRequest WithEnvironmentName(string environmentName)
        {
            this._environmentName = environmentName;
            return this;
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }


        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///          The name of the configuration template to describe.          
        /// </para>
        ///          
        /// <para>
        ///          Conditional: You must specify either this parameter or an EnvironmentName,
        /// but not both. If you specify both, AWS Elastic Beanstalk returns an <code>InvalidParameterCombination</code>
        /// error.          If you do not specify either, AWS Elastic Beanstalk returns a <code>MissingRequiredParameter</code>
        /// error.        
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }


        /// <summary>
        /// Sets the TemplateName property
        /// </summary>
        /// <param name="templateName">The value to set for the TemplateName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConfigurationSettingsRequest WithTemplateName(string templateName)
        {
            this._templateName = templateName;
            return this;
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}