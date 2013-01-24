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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The <c>LaunchConfigurationsType</c> data type. </para>
    /// </summary>
    public class DescribeLaunchConfigurationsResult  
    {
        
        private List<LaunchConfiguration> launchConfigurations = new List<LaunchConfiguration>();
        private string nextToken;

        /// <summary>
        /// A list of launch configurations.
        ///  
        /// </summary>
        public List<LaunchConfiguration> LaunchConfigurations
        {
            get { return this.launchConfigurations; }
            set { this.launchConfigurations = value; }
        }
        /// <summary>
        /// Adds elements to the LaunchConfigurations collection
        /// </summary>
        /// <param name="launchConfigurations">The values to add to the LaunchConfigurations collection </param>
        /// <returns>this instance</returns>
        public DescribeLaunchConfigurationsResult WithLaunchConfigurations(params LaunchConfiguration[] launchConfigurations)
        {
            foreach (LaunchConfiguration element in launchConfigurations)
            {
                this.launchConfigurations.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the LaunchConfigurations collection
        /// </summary>
        /// <param name="launchConfigurations">The values to add to the LaunchConfigurations collection </param>
        /// <returns>this instance</returns>
        public DescribeLaunchConfigurationsResult WithLaunchConfigurations(IEnumerable<LaunchConfiguration> launchConfigurations)
        {
            foreach (LaunchConfiguration element in launchConfigurations)
            {
                this.launchConfigurations.Add(element);
            }

            return this;
        }

        // Check to see if LaunchConfigurations property is set
        internal bool IsSetLaunchConfigurations()
        {
            return this.launchConfigurations.Count > 0;       
        }

        /// <summary>
        /// A string that marks the start of the next batch of returned results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public DescribeLaunchConfigurationsResult WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;       
        }
    }
}
