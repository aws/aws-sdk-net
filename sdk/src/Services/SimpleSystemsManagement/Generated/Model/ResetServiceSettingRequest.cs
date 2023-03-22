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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ResetServiceSetting operation.
    /// <code>ServiceSetting</code> is an account-level setting for an Amazon Web Services
    /// service. This setting defines how a user interacts with or uses a service or a feature
    /// of a service. For example, if an Amazon Web Services service charges money to the
    /// account based on feature or service usage, then the Amazon Web Services service team
    /// might create a default setting of "false". This means the user can't use this feature
    /// unless they change the setting to "true" and intentionally opt in for a paid feature.
    /// 
    ///  
    /// <para>
    /// Services map a <code>SettingId</code> object to a setting value. Amazon Web Services
    /// services teams define the default value for a <code>SettingId</code>. You can't create
    /// a new <code>SettingId</code>, but you can overwrite the default value if you have
    /// the <code>ssm:UpdateServiceSetting</code> permission for the setting. Use the <a>GetServiceSetting</a>
    /// API operation to view the current value. Use the <a>UpdateServiceSetting</a> API operation
    /// to change the default setting. 
    /// </para>
    ///  
    /// <para>
    /// Reset the service setting for the account to the default value as provisioned by the
    /// Amazon Web Services service team. 
    /// </para>
    /// </summary>
    public partial class ResetServiceSettingRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _settingId;

        /// <summary>
        /// Gets and sets the property SettingId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service setting to reset. The setting ID can
        /// be one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>/ssm/managed-instance/default-ec2-instance-management-role</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/ssm/automation/customer-script-log-destination</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/ssm/automation/customer-script-log-group-name</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/ssm/documents/console/public-sharing-permission</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/ssm/managed-instance/activation-tier</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/ssm/opsinsights/opscenter</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/ssm/parameter-store/default-parameter-tier</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>/ssm/parameter-store/high-throughput-enabled</code> 
        /// </para>
        ///  </li> </ul>
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

    }
}