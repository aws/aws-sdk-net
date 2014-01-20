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
    /// <para> The output of the DescribeAccountLimitsResult action. </para>
    /// </summary>
    public partial class DescribeAccountLimitsResult
    {
        
        private int? maxNumberOfAutoScalingGroups;
        private int? maxNumberOfLaunchConfigurations;

        /// <summary>
        /// The maximum number of Auto Scaling groups set for your AWS account.
        ///  
        /// </summary>
        public int MaxNumberOfAutoScalingGroups
        {
            get { return this.maxNumberOfAutoScalingGroups ?? default(int); }
            set { this.maxNumberOfAutoScalingGroups = value; }
        }

        /// <summary>
        /// Sets the MaxNumberOfAutoScalingGroups property
        /// </summary>
        /// <param name="maxNumberOfAutoScalingGroups">The value to set for the MaxNumberOfAutoScalingGroups property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAccountLimitsResult WithMaxNumberOfAutoScalingGroups(int maxNumberOfAutoScalingGroups)
        {
            this.maxNumberOfAutoScalingGroups = maxNumberOfAutoScalingGroups;
            return this;
        }
            

        // Check to see if MaxNumberOfAutoScalingGroups property is set
        internal bool IsSetMaxNumberOfAutoScalingGroups()
        {
            return this.maxNumberOfAutoScalingGroups.HasValue;
        }

        /// <summary>
        /// The maximum number of launch configurations set for your AWS account.
        ///  
        /// </summary>
        public int MaxNumberOfLaunchConfigurations
        {
            get { return this.maxNumberOfLaunchConfigurations ?? default(int); }
            set { this.maxNumberOfLaunchConfigurations = value; }
        }

        /// <summary>
        /// Sets the MaxNumberOfLaunchConfigurations property
        /// </summary>
        /// <param name="maxNumberOfLaunchConfigurations">The value to set for the MaxNumberOfLaunchConfigurations property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAccountLimitsResult WithMaxNumberOfLaunchConfigurations(int maxNumberOfLaunchConfigurations)
        {
            this.maxNumberOfLaunchConfigurations = maxNumberOfLaunchConfigurations;
            return this;
        }
            

        // Check to see if MaxNumberOfLaunchConfigurations property is set
        internal bool IsSetMaxNumberOfLaunchConfigurations()
        {
            return this.maxNumberOfLaunchConfigurations.HasValue;
        }
    }
}
