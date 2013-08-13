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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Describes the settings for a specified configuration set.</para>
    /// </summary>
    public class DescribeConfigurationOptionsResult  
    {
        
        private string solutionStackName;
        private List<ConfigurationOptionDescription> options = new List<ConfigurationOptionDescription>();

        /// <summary>
        /// The name of the solution stack these configuration options belong to.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConfigurationOptionsResult WithSolutionStackName(string solutionStackName)
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
        /// A list of <a>ConfigurationOptionDescription</a>.
        ///  
        /// </summary>
        public List<ConfigurationOptionDescription> Options
        {
            get { return this.options; }
            set { this.options = value; }
        }
        /// <summary>
        /// Adds elements to the Options collection
        /// </summary>
        /// <param name="options">The values to add to the Options collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConfigurationOptionsResult WithOptions(params ConfigurationOptionDescription[] options)
        {
            foreach (ConfigurationOptionDescription element in options)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeConfigurationOptionsResult WithOptions(IEnumerable<ConfigurationOptionDescription> options)
        {
            foreach (ConfigurationOptionDescription element in options)
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
