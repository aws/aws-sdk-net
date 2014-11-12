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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The <code>LaunchConfigurationsType</code> data type.
    /// </summary>
    public partial class DescribeLaunchConfigurationsResult
    {
        private List<LaunchConfiguration> _launchConfigurations = new List<LaunchConfiguration>();
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property LaunchConfigurations. 
        /// <para>
        ///             A list of launch configurations.        
        /// </para>
        /// </summary>
        public List<LaunchConfiguration> LaunchConfigurations
        {
            get { return this._launchConfigurations; }
            set { this._launchConfigurations = value; }
        }

        /// <summary>
        /// Sets the LaunchConfigurations property
        /// </summary>
        /// <param name="launchConfigurations">The values to add to the LaunchConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLaunchConfigurationsResult WithLaunchConfigurations(params LaunchConfiguration[] launchConfigurations)
        {
            foreach (var element in launchConfigurations)
            {
                this._launchConfigurations.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the LaunchConfigurations property
        /// </summary>
        /// <param name="launchConfigurations">The values to add to the LaunchConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLaunchConfigurationsResult WithLaunchConfigurations(IEnumerable<LaunchConfiguration> launchConfigurations)
        {
            foreach (var element in launchConfigurations)
            {
                this._launchConfigurations.Add(element);
            }
            return this;
        }
        // Check to see if LaunchConfigurations property is set
        internal bool IsSetLaunchConfigurations()
        {
            return this._launchConfigurations != null && this._launchConfigurations.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///             A string that marks the start of the next batch of returned results. 
        ///                   
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }


        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLaunchConfigurationsResult WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}