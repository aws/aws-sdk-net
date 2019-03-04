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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The service setting data structure.
    /// 
    ///  
    /// <para>
    ///  <code>ServiceSetting</code> is an account-level setting for an AWS service. This
    /// setting defines how a user interacts with or uses a service or a feature of a service.
    /// For example, if an AWS service charges money to the account based on feature or service
    /// usage, then the AWS service team might create a default setting of "false". This means
    /// the user can't use this feature unless they change the setting to "true" and intentionally
    /// opt in for a paid feature.
    /// </para>
    ///  
    /// <para>
    /// Services map a <code>SettingId</code> object to a setting value. AWS services teams
    /// define the default value for a <code>SettingId</code>. You can't create a new <code>SettingId</code>,
    /// but you can overwrite the default value if you have the <code>ssm:UpdateServiceSetting</code>
    /// permission for the setting. Use the <a>UpdateServiceSetting</a> API action to change
    /// the default setting. Or, use the <a>ResetServiceSetting</a> to change the value back
    /// to the original value defined by the AWS service team.
    /// </para>
    /// </summary>
    public partial class ServiceSetting
    {
        private string _arn;
        private DateTime? _lastModifiedDate;
        private string _lastModifiedUser;
        private string _settingId;
        private string _settingValue;
        private string _status;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the service setting.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last time the service setting was modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedUser. 
        /// <para>
        /// The ARN of the last modified user. This field is populated only if the setting value
        /// was overwritten.
        /// </para>
        /// </summary>
        public string LastModifiedUser
        {
            get { return this._lastModifiedUser; }
            set { this._lastModifiedUser = value; }
        }

        // Check to see if LastModifiedUser property is set
        internal bool IsSetLastModifiedUser()
        {
            return this._lastModifiedUser != null;
        }

        /// <summary>
        /// Gets and sets the property SettingId. 
        /// <para>
        /// The ID of the service setting.
        /// </para>
        /// </summary>
        public string SettingId
        {
            get { return this._settingId; }
            set { this._settingId = value; }
        }

        // Check to see if SettingId property is set
        internal bool IsSetSettingId()
        {
            return this._settingId != null;
        }

        /// <summary>
        /// Gets and sets the property SettingValue. 
        /// <para>
        /// The value of the service setting.
        /// </para>
        /// </summary>
        public string SettingValue
        {
            get { return this._settingValue; }
            set { this._settingValue = value; }
        }

        // Check to see if SettingValue property is set
        internal bool IsSetSettingValue()
        {
            return this._settingValue != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service setting. The value can be Default, Customized or PendingUpdate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Default: The current setting uses a default value provisioned by the AWS service team.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customized: The current setting use a custom value specified by the customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PendingUpdate: The current setting uses a default or custom value, but a setting change
        /// request is pending approval.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}