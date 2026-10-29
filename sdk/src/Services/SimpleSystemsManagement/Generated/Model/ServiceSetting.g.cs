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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The service setting data structure.
    /// 
    ///  
    /// <para>
    ///  <c>ServiceSetting</c> is an account-level setting for an Amazon Web Services service.
    /// This setting defines how a user interacts with or uses a service or a feature of a
    /// service. For example, if an Amazon Web Services service charges money to the account
    /// based on feature or service usage, then the Amazon Web Services service team might
    /// create a default setting of "false". This means the user can't use this feature unless
    /// they change the setting to "true" and intentionally opt in for a paid feature.
    /// </para>
    ///  
    /// <para>
    /// Services map a <c>SettingId</c> object to a setting value. Amazon Web Services services
    /// teams define the default value for a <c>SettingId</c>. You can't create a new <c>SettingId</c>,
    /// but you can overwrite the default value if you have the <c>ssm:UpdateServiceSetting</c>
    /// permission for the setting. Use the <a>UpdateServiceSetting</a> API operation to change
    /// the default setting. Or, use the <a>ResetServiceSetting</a> to change the value back
    /// to the original value defined by the Amazon Web Services service team.
    /// </para>
    /// </summary>
    public partial class ServiceSetting
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the service setting.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last time the service setting was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedUser. 
        /// <para>
        /// The ARN of the last modified user. This field is populated only if the setting value
        /// was overwritten.
        /// </para>
        /// </summary>
        public string LastModifiedUser { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedUser property is set.
        /// </summary>
        internal bool IsSetLastModifiedUser() => this.LastModifiedUser != null;

        /// <summary>
        /// Gets and sets the property SettingId. 
        /// <para>
        /// The ID of the service setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string SettingId { get; set; }

        /// <summary>
        /// Checks to see if the SettingId property is set.
        /// </summary>
        internal bool IsSetSettingId() => this.SettingId != null;

        /// <summary>
        /// Gets and sets the property SettingValue. 
        /// <para>
        /// The value of the service setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string SettingValue { get; set; }

        /// <summary>
        /// Checks to see if the SettingValue property is set.
        /// </summary>
        internal bool IsSetSettingValue() => this.SettingValue != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service setting. The value can be Default, Customized or PendingUpdate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Default: The current setting uses a default value provisioned by the Amazon Web Services
        /// service team.
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
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
