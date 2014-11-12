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
    /// Container for the parameters to the DescribeLifecycleHooks operation.
    /// 
    /// </summary>
    public partial class DescribeLifecycleHooksRequest : AmazonWebServiceRequest
    {
        private string _autoScalingGroupName;
        private List<string> _lifecycleHookNames = new List<string>();


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName.
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }


        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLifecycleHooksRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this._autoScalingGroupName = autoScalingGroupName;
            return this;
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property LifecycleHookNames.
        /// </summary>
        public List<string> LifecycleHookNames
        {
            get { return this._lifecycleHookNames; }
            set { this._lifecycleHookNames = value; }
        }

        /// <summary>
        /// Sets the LifecycleHookNames property
        /// </summary>
        /// <param name="lifecycleHookNames">The values to add to the LifecycleHookNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLifecycleHooksRequest WithLifecycleHookNames(params string[] lifecycleHookNames)
        {
            foreach (var element in lifecycleHookNames)
            {
                this._lifecycleHookNames.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the LifecycleHookNames property
        /// </summary>
        /// <param name="lifecycleHookNames">The values to add to the LifecycleHookNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLifecycleHooksRequest WithLifecycleHookNames(IEnumerable<string> lifecycleHookNames)
        {
            foreach (var element in lifecycleHookNames)
            {
                this._lifecycleHookNames.Add(element);
            }
            return this;
        }
        // Check to see if LifecycleHookNames property is set
        internal bool IsSetLifecycleHookNames()
        {
            return this._lifecycleHookNames != null && this._lifecycleHookNames.Count > 0; 
        }

    }
}