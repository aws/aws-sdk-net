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
    /// Describes an account setting for Amazon EC2 Auto Scaling. Account settings control
    /// how certain features behave for your account. Some settings can be enforced after
    /// a specified date, meaning that after the enforcement date, you can no longer modify
    /// the setting.
    /// </summary>
    public partial class AccountSetting
    {
        private string _defaultValue;
        private string _enforcedValue;
        private DateTime? _enforcementDate;
        private string _enforcementType;
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        ///  The default value of the account setting before the enforcement date. Valid values
        /// are enabled and disabled. This parameter is only returned for settings with hard or
        /// flexible enforcement types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property EnforcedValue. 
        /// <para>
        ///  The value that will be enforced after the enforcement date. Valid values are enabled
        /// and disabled. This parameter is only returned for settings with hard or flexible enforcement
        /// types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EnforcedValue
        {
            get { return this._enforcedValue; }
            set { this._enforcedValue = value; }
        }

        // Check to see if EnforcedValue property is set
        internal bool IsSetEnforcedValue()
        {
            return this._enforcedValue != null;
        }

        /// <summary>
        /// Gets and sets the property EnforcementDate. 
        /// <para>
        ///  The date when the account setting will be enforced. After this date, for settings
        /// with hard enforcement type, you can no longer modify the setting value. This parameter
        /// is only returned for settings with hard or flexible enforcement types. 
        /// </para>
        /// </summary>
        public DateTime? EnforcementDate
        {
            get { return this._enforcementDate; }
            set { this._enforcementDate = value; }
        }

        // Check to see if EnforcementDate property is set
        internal bool IsSetEnforcementDate()
        {
            return this._enforcementDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnforcementType. 
        /// <para>
        ///  The type of enforcement for the account setting. Valid values include: <c>hard</c>
        /// (the setting has a hard enforcement date after which the setting will be enforced
        /// and cannot be modified), <c>flexible</c> (the setting has a flexible enforcement where
        /// you can always modify the setting value), and <c>none</c> (the setting has no enforcement
        /// and can always be modified). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EnforcementType
        {
            get { return this._enforcementType; }
            set { this._enforcementType = value; }
        }

        // Check to see if EnforcementType property is set
        internal bool IsSetEnforcementType()
        {
            return this._enforcementType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the account setting. Each account setting has a unique name that identifies
        /// the specific feature it controls. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        ///  The current value of the account setting. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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