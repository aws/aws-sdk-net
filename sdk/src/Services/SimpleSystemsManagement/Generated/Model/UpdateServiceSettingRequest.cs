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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
    /// Container for the parameters to the UpdateServiceSetting operation.
    /// <c>ServiceSetting</c> is an account-level setting for an Amazon Web Services service.
    /// This setting defines how a user interacts with or uses a service or a feature of a
    /// service. For example, if an Amazon Web Services service charges money to the account
    /// based on feature or service usage, then the Amazon Web Services service team might
    /// create a default setting of "false". This means the user can't use this feature unless
    /// they change the setting to "true" and intentionally opt in for a paid feature.
    /// 
    ///  
    /// <para>
    /// Services map a <c>SettingId</c> object to a setting value. Amazon Web Services services
    /// teams define the default value for a <c>SettingId</c>. You can't create a new <c>SettingId</c>,
    /// but you can overwrite the default value if you have the <c>ssm:UpdateServiceSetting</c>
    /// permission for the setting. Use the <a>GetServiceSetting</a> API operation to view
    /// the current value. Or, use the <a>ResetServiceSetting</a> to change the value back
    /// to the original value defined by the Amazon Web Services service team.
    /// </para>
    ///  
    /// <para>
    /// Update the service setting for the account. 
    /// </para>
    /// </summary>
    public partial class UpdateServiceSettingRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _settingId;
        private string _settingValue;

        /// <summary>
        /// Gets and sets the property SettingId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service setting to update. For example, <c>arn:aws:ssm:us-east-1:111122223333:servicesetting/ssm/parameter-store/high-throughput-enabled</c>.
        /// The setting ID can be one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>/ssm/managed-instance/default-ec2-instance-management-role</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/ssm/automation/customer-script-log-destination</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/ssm/automation/customer-script-log-group-name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/ssm/documents/console/public-sharing-permission</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/ssm/managed-instance/activation-tier</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/ssm/opsinsights/opscenter</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/ssm/parameter-store/default-parameter-tier</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/ssm/parameter-store/high-throughput-enabled</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Permissions to update the <c>/ssm/managed-instance/default-ec2-instance-management-role</c>
        /// setting should only be provided to administrators. Implement least privilege access
        /// when allowing individuals to configure or modify the Default Host Management Configuration.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
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
        /// The new value to specify for the service setting. The following list specifies the
        /// available values for each setting.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>/ssm/managed-instance/default-ec2-instance-management-role</c>, enter the name
        /// of an IAM role. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>/ssm/automation/customer-script-log-destination</c>, enter <c>CloudWatch</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>/ssm/automation/customer-script-log-group-name</c>, enter the name of an Amazon
        /// CloudWatch Logs log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>/ssm/documents/console/public-sharing-permission</c>, enter <c>Enable</c> or
        /// <c>Disable</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>/ssm/managed-instance/activation-tier</c>, enter <c>standard</c> or <c>advanced</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For <c>/ssm/opsinsights/opscenter</c>, enter <c>Enabled</c> or <c>Disabled</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>/ssm/parameter-store/default-parameter-tier</c>, enter <c>Standard</c>, <c>Advanced</c>,
        /// or <c>Intelligent-Tiering</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>/ssm/parameter-store/high-throughput-enabled</c>, enter <c>true</c> or <c>false</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
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

    }
}