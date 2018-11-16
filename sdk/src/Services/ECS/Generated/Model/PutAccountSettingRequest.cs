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

/*
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountSetting operation.
    /// Modifies the ARN and resource ID format of a resource for a specified IAM user, IAM
    /// role, or the root user for an account. You can specify whether the new ARN and resource
    /// ID format are enabled for new resources that are created. Enabling this setting is
    /// required to use new Amazon ECS features such as resource tagging.
    /// </summary>
    public partial class PutAccountSettingRequest : AmazonECSRequest
    {
        private SettingName _name;
        private string _principalArn;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The resource name for which to enable the new format. If <code>serviceLongArnFormat</code>
        /// is specified, the ARN for your Amazon ECS services is affected. If <code>taskLongArnFormat</code>
        /// is specified, the ARN and resource ID for your Amazon ECS tasks is affected. If <code>containerInstanceLongArnFormat</code>
        /// is specified, the ARN and resource ID for your Amazon ECS container instances is affected.
        /// </para>
        /// </summary>
        public SettingName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the principal, which can be an IAM user, IAM role, or the root user. If
        /// you specify the root user, it modifies the ARN and resource ID format for all IAM
        /// users, IAM roles, and the root user of the account unless an IAM user or role explicitly
        /// overrides these settings for themselves. If this field is omitted, the setting are
        /// changed only for the authenticated user.
        /// </para>
        /// </summary>
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The account setting value for the specified principal ARN. Accepted values are <code>ENABLED</code>
        /// and <code>DISABLED</code>.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}