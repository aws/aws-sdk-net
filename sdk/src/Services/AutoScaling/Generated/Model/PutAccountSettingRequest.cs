/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountSetting operation.
    /// Modifies an account setting for your account. You can use this operation to opt in
    /// or opt out of features provided through account settings when permitted. Account settings
    /// give you control over features that might have backwards-incompatible changes. When
    /// Amazon EC2 Auto Scaling introduces such changes, account settings allow you to test
    /// and adopt new features. Some account settings are enforced after a specified date.
    /// This means that after the enforcement date, you can no longer modify the setting.
    /// </summary>
    public partial class PutAccountSettingRequest : AmazonAutoScalingRequest
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the account setting to modify. Each account setting has a unique name
        /// that identifies the specific feature it controls. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
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
        /// Gets and sets the property Value. 
        /// <para>
        ///  The value for the account setting. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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