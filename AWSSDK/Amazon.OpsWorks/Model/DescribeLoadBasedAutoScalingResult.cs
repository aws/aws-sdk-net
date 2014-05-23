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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeLoadBasedAutoScaling</code> request.
    /// </summary>
    public partial class DescribeLoadBasedAutoScalingResult
    {
        private List<LoadBasedAutoScalingConfiguration> _loadBasedAutoScalingConfigurations = new List<LoadBasedAutoScalingConfiguration>();


        /// <summary>
        /// Gets and sets the property LoadBasedAutoScalingConfigurations. 
        /// <para>
        /// An array of <code>LoadBasedAutoScalingConfiguration</code> objects that describe each
        /// layer's configuration.
        /// </para>
        /// </summary>
        public List<LoadBasedAutoScalingConfiguration> LoadBasedAutoScalingConfigurations
        {
            get { return this._loadBasedAutoScalingConfigurations; }
            set { this._loadBasedAutoScalingConfigurations = value; }
        }

        /// <summary>
        /// Sets the LoadBasedAutoScalingConfigurations property
        /// </summary>
        /// <param name="loadBasedAutoScalingConfigurations">The values to add to the LoadBasedAutoScalingConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBasedAutoScalingResult WithLoadBasedAutoScalingConfigurations(params LoadBasedAutoScalingConfiguration[] loadBasedAutoScalingConfigurations)
        {
            foreach (var element in loadBasedAutoScalingConfigurations)
            {
                this._loadBasedAutoScalingConfigurations.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the LoadBasedAutoScalingConfigurations property
        /// </summary>
        /// <param name="loadBasedAutoScalingConfigurations">The values to add to the LoadBasedAutoScalingConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBasedAutoScalingResult WithLoadBasedAutoScalingConfigurations(IEnumerable<LoadBasedAutoScalingConfiguration> loadBasedAutoScalingConfigurations)
        {
            foreach (var element in loadBasedAutoScalingConfigurations)
            {
                this._loadBasedAutoScalingConfigurations.Add(element);
            }
            return this;
        }
        // Check to see if LoadBasedAutoScalingConfigurations property is set
        internal bool IsSetLoadBasedAutoScalingConfigurations()
        {
            return this._loadBasedAutoScalingConfigurations != null && this._loadBasedAutoScalingConfigurations.Count > 0; 
        }

    }
}