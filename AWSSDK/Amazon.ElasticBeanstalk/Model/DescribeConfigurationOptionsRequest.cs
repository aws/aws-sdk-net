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
    /// Container for the parameters to the DescribeConfigurationOptions operation.
    /// Describes the configuration options that are used in a         particular
    /// configuration template or environment, or that          a specified solution stack
    /// defines. The description includes the values the         options, their default values,
    /// and an indication of         the required action on a running environment if an option
    /// value is changed.
    /// </summary>
    public partial class DescribeConfigurationOptionsRequest : AmazonWebServiceRequest
    {
        private string _applicationName;
        private string _environmentName;
        private List<OptionSpecification> _options = new List<OptionSpecification>();
        private string _solutionStackName;
        private string _templateName;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///          The name of the application associated with the configuration template or
        ///         environment. Only needed if you want to describe the         configuration
        /// options associated with either the configuration template or         environment.        
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
        public DescribeConfigurationOptionsRequest WithApplicationName(string applicationName)
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
        ///          The name of the environment whose configuration options you want to describe.
        ///      
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
        public DescribeConfigurationOptionsRequest WithEnvironmentName(string environmentName)
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
        /// Gets and sets the property Options. 
        /// <para>
        ///          If specified, restricts the descriptions to only the specified options.        
        /// </para>
        /// </summary>
        public List<OptionSpecification> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        /// <summary>
        /// Sets the Options property
        /// </summary>
        /// <param name="options">The values to add to the Options collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConfigurationOptionsRequest WithOptions(params OptionSpecification[] options)
        {
            foreach (var element in options)
            {
                this._options.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Options property
        /// </summary>
        /// <param name="options">The values to add to the Options collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConfigurationOptionsRequest WithOptions(IEnumerable<OptionSpecification> options)
        {
            foreach (var element in options)
            {
                this._options.Add(element);
            }
            return this;
        }
        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && this._options.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        ///          The name of the solution stack whose configuration options         you want
        /// to describe.        
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this._solutionStackName; }
            set { this._solutionStackName = value; }
        }


        /// <summary>
        /// Sets the SolutionStackName property
        /// </summary>
        /// <param name="solutionStackName">The value to set for the SolutionStackName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConfigurationOptionsRequest WithSolutionStackName(string solutionStackName)
        {
            this._solutionStackName = solutionStackName;
            return this;
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this._solutionStackName != null;
        }


        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///          The name of the configuration template whose configuration options      
        ///   you want to describe.        
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
        public DescribeConfigurationOptionsRequest WithTemplateName(string templateName)
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