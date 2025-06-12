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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountAuditConfiguration operation.
    /// Configures or reconfigures the Device Defender audit settings for this account. Settings
    /// include how audit notifications are sent and which audit checks are enabled or disabled.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateAccountAuditConfiguration</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateAccountAuditConfigurationRequest : AmazonIoTRequest
    {
        private Dictionary<string, AuditCheckConfiguration> _auditCheckConfigurations = AWSConfigs.InitializeCollections ? new Dictionary<string, AuditCheckConfiguration>() : null;
        private Dictionary<string, AuditNotificationTarget> _auditNotificationTargetConfigurations = AWSConfigs.InitializeCollections ? new Dictionary<string, AuditNotificationTarget>() : null;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AuditCheckConfigurations. 
        /// <para>
        /// Specifies which audit checks are enabled and disabled for this account. Use <c>DescribeAccountAuditConfiguration</c>
        /// to see the list of all checks, including those that are currently enabled.
        /// </para>
        ///  
        /// <para>
        /// Some data collection might start immediately when certain checks are enabled. When
        /// a check is disabled, any data collected so far in relation to the check is deleted.
        /// </para>
        ///  
        /// <para>
        /// You cannot disable a check if it's used by any scheduled audit. You must first delete
        /// the check from the scheduled audit or delete the scheduled audit itself.
        /// </para>
        ///  
        /// <para>
        /// On the first call to <c>UpdateAccountAuditConfiguration</c>, this parameter is required
        /// and must specify at least one enabled check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AuditCheckConfiguration> AuditCheckConfigurations
        {
            get { return this._auditCheckConfigurations; }
            set { this._auditCheckConfigurations = value; }
        }

        // Check to see if AuditCheckConfigurations property is set
        internal bool IsSetAuditCheckConfigurations()
        {
            return this._auditCheckConfigurations != null && (this._auditCheckConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuditNotificationTargetConfigurations. 
        /// <para>
        /// Information about the targets to which audit notifications are sent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AuditNotificationTarget> AuditNotificationTargetConfigurations
        {
            get { return this._auditNotificationTargetConfigurations; }
            set { this._auditNotificationTargetConfigurations = value; }
        }

        // Check to see if AuditNotificationTargetConfigurations property is set
        internal bool IsSetAuditNotificationTargetConfigurations()
        {
            return this._auditNotificationTargetConfigurations != null && (this._auditNotificationTargetConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that grants permission to IoT to access
        /// information about your devices, policies, certificates, and other items as required
        /// when performing an audit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}