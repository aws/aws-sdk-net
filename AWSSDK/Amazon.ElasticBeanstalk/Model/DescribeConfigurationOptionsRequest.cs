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
    /// Container for the parameters to the DescribeConfigurationOptions operation.
    /// <para> Describes the configuration options that are used in a particular configuration template or environment, or that a specified solution
    /// stack defines. The description includes the values the options, their default values, and an indication of the required action on a running
    /// environment if an option value is changed. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeConfigurationOptions"/>
    public class DescribeConfigurationOptionsRequest : AmazonWebServiceRequest
    {
        private string applicationName;
        private string templateName;
        private string environmentName;
        private string solutionStackName;
        private List<OptionSpecification> options = new List<OptionSpecification>();

        /// <summary>
        /// The name of the application associated with the configuration template or environment. Only needed if you want to describe the configuration
        /// options associated with either the configuration template or environment.
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
        public DescribeConfigurationOptionsRequest WithApplicationName(string applicationName)
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
        /// The name of the configuration template whose configuration options you want to describe.
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
        public DescribeConfigurationOptionsRequest WithTemplateName(string templateName)
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
        /// The name of the environment whose configuration options you want to describe.
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
        public DescribeConfigurationOptionsRequest WithEnvironmentName(string environmentName)
        {
            this.environmentName = environmentName;
            return this;
        }
            

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;       
        }

        /// <summary>
        /// The name of the solution stack whose configuration options you want to describe.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this.solutionStackName; }
            set { this.solutionStackName = value; }
        }

        /// <summary>
        /// Sets the SolutionStackName property
        /// </summary>
        /// <param name="solutionStackName">The value to set for the SolutionStackName property </param>
        /// <returns>this instance</returns>
        public DescribeConfigurationOptionsRequest WithSolutionStackName(string solutionStackName)
        {
            this.solutionStackName = solutionStackName;
            return this;
        }
            

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this.solutionStackName != null;       
        }

        /// <summary>
        /// If specified, restricts the descriptions to only the specified options.
        ///  
        /// </summary>
        public List<OptionSpecification> Options
        {
            get { return this.options; }
            set { this.options = value; }
        }
        /// <summary>
        /// Adds elements to the Options collection
        /// </summary>
        /// <param name="options">The values to add to the Options collection </param>
        /// <returns>this instance</returns>
        public DescribeConfigurationOptionsRequest WithOptions(params OptionSpecification[] options)
        {
            foreach (OptionSpecification element in options)
            {
                this.options.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Options collection
        /// </summary>
        /// <param name="options">The values to add to the Options collection </param>
        /// <returns>this instance</returns>
        public DescribeConfigurationOptionsRequest WithOptions(IEnumerable<OptionSpecification> options)
        {
            foreach (OptionSpecification element in options)
            {
                this.options.Add(element);
            }

            return this;
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this.options.Count > 0;       
        }
    }
}
    
