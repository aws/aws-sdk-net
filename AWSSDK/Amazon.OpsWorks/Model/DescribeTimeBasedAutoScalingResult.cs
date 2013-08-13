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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeTimeBasedAutoScaling</c> request.</para>
    /// </summary>
    public class DescribeTimeBasedAutoScalingResult
    {
        
        private List<TimeBasedAutoScalingConfiguration> timeBasedAutoScalingConfigurations = new List<TimeBasedAutoScalingConfiguration>();

        /// <summary>
        /// An array of <c>TimeBasedAutoScalingConfiguration</c> objects that describe the configuration for the specified instances.
        ///  
        /// </summary>
        public List<TimeBasedAutoScalingConfiguration> TimeBasedAutoScalingConfigurations
        {
            get { return this.timeBasedAutoScalingConfigurations; }
            set { this.timeBasedAutoScalingConfigurations = value; }
        }
        /// <summary>
        /// Adds elements to the TimeBasedAutoScalingConfigurations collection
        /// </summary>
        /// <param name="timeBasedAutoScalingConfigurations">The values to add to the TimeBasedAutoScalingConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTimeBasedAutoScalingResult WithTimeBasedAutoScalingConfigurations(params TimeBasedAutoScalingConfiguration[] timeBasedAutoScalingConfigurations)
        {
            foreach (TimeBasedAutoScalingConfiguration element in timeBasedAutoScalingConfigurations)
            {
                this.timeBasedAutoScalingConfigurations.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TimeBasedAutoScalingConfigurations collection
        /// </summary>
        /// <param name="timeBasedAutoScalingConfigurations">The values to add to the TimeBasedAutoScalingConfigurations collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTimeBasedAutoScalingResult WithTimeBasedAutoScalingConfigurations(IEnumerable<TimeBasedAutoScalingConfiguration> timeBasedAutoScalingConfigurations)
        {
            foreach (TimeBasedAutoScalingConfiguration element in timeBasedAutoScalingConfigurations)
            {
                this.timeBasedAutoScalingConfigurations.Add(element);
            }

            return this;
        }

        // Check to see if TimeBasedAutoScalingConfigurations property is set
        internal bool IsSetTimeBasedAutoScalingConfigurations()
        {
            return this.timeBasedAutoScalingConfigurations.Count > 0;
        }
    }
}
