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
    /// <para> The output for the TerminateInstanceInAutoScalingGroup action. </para>
    /// </summary>
    public class TerminateInstanceInAutoScalingGroupResult
    {
        
        private Activity activity;

        /// <summary>
        /// A scaling Activity.
        ///  
        /// </summary>
        public Activity Activity
        {
            get { return this.activity; }
            set { this.activity = value; }
        }

        /// <summary>
        /// Sets the Activity property
        /// </summary>
        /// <param name="activity">The value to set for the Activity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TerminateInstanceInAutoScalingGroupResult WithActivity(Activity activity)
        {
            this.activity = activity;
            return this;
        }
            

        // Check to see if Activity property is set
        internal bool IsSetActivity()
        {
            return this.activity != null;
        }
    }
}
