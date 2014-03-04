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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLaunchConfigurations operation.
    /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
    /// name is specified, then the full details of all launch configurations are returned. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeLaunchConfigurations"/>
    public class DescribeLaunchConfigurationsRequest : AmazonWebServiceRequest
    {
        private List<string> launchConfigurationNames = new List<string>();
        private string nextToken;
        private int? maxRecords;

        /// <summary>
        /// A list of launch configuration names.
        ///  
        /// </summary>
        public List<string> LaunchConfigurationNames
        {
            get { return this.launchConfigurationNames; }
            set { this.launchConfigurationNames = value; }
        }
        /// <summary>
        /// Adds elements to the LaunchConfigurationNames collection
        /// </summary>
        /// <param name="launchConfigurationNames">The values to add to the LaunchConfigurationNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLaunchConfigurationsRequest WithLaunchConfigurationNames(params string[] launchConfigurationNames)
        {
            foreach (string element in launchConfigurationNames)
            {
                this.launchConfigurationNames.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the LaunchConfigurationNames collection
        /// </summary>
        /// <param name="launchConfigurationNames">The values to add to the LaunchConfigurationNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLaunchConfigurationsRequest WithLaunchConfigurationNames(IEnumerable<string> launchConfigurationNames)
        {
            foreach (string element in launchConfigurationNames)
            {
                this.launchConfigurationNames.Add(element);
            }

            return this;
        }

        // Check to see if LaunchConfigurationNames property is set
        internal bool IsSetLaunchConfigurationNames()
        {
            return this.launchConfigurationNames.Count > 0;
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLaunchConfigurationsRequest WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

        /// <summary>
        /// The maximum number of launch configurations. The default is 100.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 50</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLaunchConfigurationsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }
    }
}
    
