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
    /// Container for the parameters to the PutLifecycleHook operation.
    /// 
    /// </summary>
    public partial class PutLifecycleHookRequest : AmazonWebServiceRequest
    {
        private string _autoScalingGroupName;
        private string _defaultResult;
        private int? _heartbeatTimeout;
        private string _lifecycleHookName;
        private string _lifecycleTransition;
        private string _notificationMetadata;
        private string _notificationTargetARN;
        private string _roleARN;


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
        public PutLifecycleHookRequest WithAutoScalingGroupName(string autoScalingGroupName)
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
        /// Gets and sets the property DefaultResult.
        /// </summary>
        public string DefaultResult
        {
            get { return this._defaultResult; }
            set { this._defaultResult = value; }
        }


        /// <summary>
        /// Sets the DefaultResult property
        /// </summary>
        /// <param name="defaultResult">The value to set for the DefaultResult property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutLifecycleHookRequest WithDefaultResult(string defaultResult)
        {
            this._defaultResult = defaultResult;
            return this;
        }

        // Check to see if DefaultResult property is set
        internal bool IsSetDefaultResult()
        {
            return this._defaultResult != null;
        }


        /// <summary>
        /// Gets and sets the property HeartbeatTimeout.
        /// </summary>
        public int HeartbeatTimeout
        {
            get { return this._heartbeatTimeout.GetValueOrDefault(); }
            set { this._heartbeatTimeout = value; }
        }


        /// <summary>
        /// Sets the HeartbeatTimeout property
        /// </summary>
        /// <param name="heartbeatTimeout">The value to set for the HeartbeatTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutLifecycleHookRequest WithHeartbeatTimeout(int heartbeatTimeout)
        {
            this._heartbeatTimeout = heartbeatTimeout;
            return this;
        }

        // Check to see if HeartbeatTimeout property is set
        internal bool IsSetHeartbeatTimeout()
        {
            return this._heartbeatTimeout.HasValue; 
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
        public PutLifecycleHookRequest WithLifecycleHookName(string lifecycleHookName)
        {
            this._lifecycleHookName = lifecycleHookName;
            return this;
        }

        // Check to see if LifecycleHookName property is set
        internal bool IsSetLifecycleHookName()
        {
            return this._lifecycleHookName != null;
        }


        /// <summary>
        /// Gets and sets the property LifecycleTransition.
        /// </summary>
        public string LifecycleTransition
        {
            get { return this._lifecycleTransition; }
            set { this._lifecycleTransition = value; }
        }


        /// <summary>
        /// Sets the LifecycleTransition property
        /// </summary>
        /// <param name="lifecycleTransition">The value to set for the LifecycleTransition property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutLifecycleHookRequest WithLifecycleTransition(string lifecycleTransition)
        {
            this._lifecycleTransition = lifecycleTransition;
            return this;
        }

        // Check to see if LifecycleTransition property is set
        internal bool IsSetLifecycleTransition()
        {
            return this._lifecycleTransition != null;
        }


        /// <summary>
        /// Gets and sets the property NotificationMetadata.
        /// </summary>
        public string NotificationMetadata
        {
            get { return this._notificationMetadata; }
            set { this._notificationMetadata = value; }
        }


        /// <summary>
        /// Sets the NotificationMetadata property
        /// </summary>
        /// <param name="notificationMetadata">The value to set for the NotificationMetadata property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutLifecycleHookRequest WithNotificationMetadata(string notificationMetadata)
        {
            this._notificationMetadata = notificationMetadata;
            return this;
        }

        // Check to see if NotificationMetadata property is set
        internal bool IsSetNotificationMetadata()
        {
            return this._notificationMetadata != null;
        }


        /// <summary>
        /// Gets and sets the property NotificationTargetARN.
        /// </summary>
        public string NotificationTargetARN
        {
            get { return this._notificationTargetARN; }
            set { this._notificationTargetARN = value; }
        }


        /// <summary>
        /// Sets the NotificationTargetARN property
        /// </summary>
        /// <param name="notificationTargetARN">The value to set for the NotificationTargetARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutLifecycleHookRequest WithNotificationTargetARN(string notificationTargetARN)
        {
            this._notificationTargetARN = notificationTargetARN;
            return this;
        }

        // Check to see if NotificationTargetARN property is set
        internal bool IsSetNotificationTargetARN()
        {
            return this._notificationTargetARN != null;
        }


        /// <summary>
        /// Gets and sets the property RoleARN.
        /// </summary>
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }


        /// <summary>
        /// Sets the RoleARN property
        /// </summary>
        /// <param name="roleARN">The value to set for the RoleARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutLifecycleHookRequest WithRoleARN(string roleARN)
        {
            this._roleARN = roleARN;
            return this;
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

    }
}