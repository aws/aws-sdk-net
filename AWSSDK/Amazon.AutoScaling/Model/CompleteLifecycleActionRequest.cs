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
    /// Container for the parameters to the CompleteLifecycleAction operation.
    /// 
    /// </summary>
    public partial class CompleteLifecycleActionRequest : AmazonWebServiceRequest
    {
        private string _autoScalingGroupName;
        private string _lifecycleActionResult;
        private string _lifecycleActionToken;
        private string _lifecycleHookName;


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
        public CompleteLifecycleActionRequest WithAutoScalingGroupName(string autoScalingGroupName)
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
        /// Gets and sets the property LifecycleActionResult.
        /// </summary>
        public string LifecycleActionResult
        {
            get { return this._lifecycleActionResult; }
            set { this._lifecycleActionResult = value; }
        }


        /// <summary>
        /// Sets the LifecycleActionResult property
        /// </summary>
        /// <param name="lifecycleActionResult">The value to set for the LifecycleActionResult property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CompleteLifecycleActionRequest WithLifecycleActionResult(string lifecycleActionResult)
        {
            this._lifecycleActionResult = lifecycleActionResult;
            return this;
        }

        // Check to see if LifecycleActionResult property is set
        internal bool IsSetLifecycleActionResult()
        {
            return this._lifecycleActionResult != null;
        }


        /// <summary>
        /// Gets and sets the property LifecycleActionToken.
        /// </summary>
        public string LifecycleActionToken
        {
            get { return this._lifecycleActionToken; }
            set { this._lifecycleActionToken = value; }
        }


        /// <summary>
        /// Sets the LifecycleActionToken property
        /// </summary>
        /// <param name="lifecycleActionToken">The value to set for the LifecycleActionToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CompleteLifecycleActionRequest WithLifecycleActionToken(string lifecycleActionToken)
        {
            this._lifecycleActionToken = lifecycleActionToken;
            return this;
        }

        // Check to see if LifecycleActionToken property is set
        internal bool IsSetLifecycleActionToken()
        {
            return this._lifecycleActionToken != null;
        }


        /// <summary>
        /// Gets and sets the property LifecycleHookName.
        /// </summary>
        public string LifecycleHookName
        {
            get { return this._lifecycleHookName; }
            set { this._lifecycleHookName = value; }
        }


        /// <summary>
        /// Sets the LifecycleHookName property
        /// </summary>
        /// <param name="lifecycleHookName">The value to set for the LifecycleHookName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CompleteLifecycleActionRequest WithLifecycleHookName(string lifecycleHookName)
        {
            this._lifecycleHookName = lifecycleHookName;
            return this;
        }

        // Check to see if LifecycleHookName property is set
        internal bool IsSetLifecycleHookName()
        {
            return this._lifecycleHookName != null;
        }

    }
}