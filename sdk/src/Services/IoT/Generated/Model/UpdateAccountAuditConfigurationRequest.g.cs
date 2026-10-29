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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountAuditConfiguration operation. Configures
    /// or reconfigures the Device Defender audit settings for this account. Settings include
    /// how audit notifications are sent and which audit checks are enabled or disabled. <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateAccountAuditConfiguration</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateAccountAuditConfigurationRequest : AmazonIoTRequest
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AuditCheckConfiguration> AuditCheckConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AuditCheckConfiguration>() : null;

        /// <summary>
        /// Checks to see if the AuditCheckConfigurations property is set.
        /// </summary>
        internal bool IsSetAuditCheckConfigurations() => this.AuditCheckConfigurations != null && (this.AuditCheckConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuditNotificationTargetConfigurations. 
        /// <para>
        /// Information about the targets to which audit notifications are sent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AuditNotificationTarget> AuditNotificationTargetConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AuditNotificationTarget>() : null;

        /// <summary>
        /// Checks to see if the AuditNotificationTargetConfigurations property is set.
        /// </summary>
        internal bool IsSetAuditNotificationTargetConfigurations() => this.AuditNotificationTargetConfigurations != null && (this.AuditNotificationTargetConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that grants permission to IoT to access
        /// information about your devices, policies, certificates, and other items as required
        /// when performing an audit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
