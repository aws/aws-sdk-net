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
    /// Describes the settings for a specified configuration set.
    /// </summary>
    public partial class DescribeConfigurationOptionsResult
    {
        private List<ConfigurationOptionDescription> _options = new List<ConfigurationOptionDescription>();
        private string _solutionStackName;


        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        ///          A list of         <a>ConfigurationOptionDescription</a>.      
        /// </para>
        /// </summary>
        public List<ConfigurationOptionDescription> Options
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
        public DescribeConfigurationOptionsResult WithOptions(params ConfigurationOptionDescription[] options)
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
        public DescribeConfigurationOptionsResult WithOptions(IEnumerable<ConfigurationOptionDescription> options)
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
        ///          The name of the solution stack these configuration options belong to.        
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
        public DescribeConfigurationOptionsResult WithSolutionStackName(string solutionStackName)
        {
            this._solutionStackName = solutionStackName;
            return this;
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this._solutionStackName != null;
        }

    }
}