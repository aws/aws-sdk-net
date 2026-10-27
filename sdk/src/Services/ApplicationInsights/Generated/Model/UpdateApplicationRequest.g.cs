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

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation. Updates the application.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonApplicationInsightsRequest
    {
        /// <summary>
        /// Gets and sets the property AttachMissingPermission. 
        /// <para>
        /// If set to true, the managed policies for SSM and CW will be attached to the instance
        /// roles if they are missing.
        /// </para>
        /// </summary>
        public bool? AttachMissingPermission { get; set; }

        /// <summary>
        /// Checks to see if the AttachMissingPermission property is set.
        /// </summary>
        internal bool IsSetAttachMissingPermission() => this.AttachMissingPermission.HasValue;

        /// <summary>
        /// Gets and sets the property AutoConfigEnabled. 
        /// <para>
        ///  Turns auto-configuration on or off. 
        /// </para>
        /// </summary>
        public bool? AutoConfigEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutoConfigEnabled property is set.
        /// </summary>
        internal bool IsSetAutoConfigEnabled() => this.AutoConfigEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CWEMonitorEnabled. 
        /// <para>
        ///  Indicates whether Application Insights can listen to CloudWatch events for the application
        /// resources, such as <c>instance terminated</c>, <c>failed deployment</c>, and others.
        /// 
        /// </para>
        /// </summary>
        public bool? CWEMonitorEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CWEMonitorEnabled property is set.
        /// </summary>
        internal bool IsSetCWEMonitorEnabled() => this.CWEMonitorEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OpsCenterEnabled. 
        /// <para>
        ///  When set to <c>true</c>, creates opsItems for any problems detected on an application.
        /// 
        /// </para>
        /// </summary>
        public bool? OpsCenterEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OpsCenterEnabled property is set.
        /// </summary>
        internal bool IsSetOpsCenterEnabled() => this.OpsCenterEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OpsItemSNSTopicArn. 
        /// <para>
        ///  The SNS topic provided to Application Insights that is associated to the created
        /// opsItem. Allows you to receive notifications for updates to the opsItem.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 300)]
        public string OpsItemSNSTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the OpsItemSNSTopicArn property is set.
        /// </summary>
        internal bool IsSetOpsItemSNSTopicArn() => this.OpsItemSNSTopicArn != null;

        /// <summary>
        /// Gets and sets the property RemoveSNSTopic. 
        /// <para>
        ///  Disassociates the SNS topic from the opsItem created for detected problems.
        /// </para>
        /// </summary>
        public bool? RemoveSNSTopic { get; set; }

        /// <summary>
        /// Checks to see if the RemoveSNSTopic property is set.
        /// </summary>
        internal bool IsSetRemoveSNSTopic() => this.RemoveSNSTopic.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupName property is set.
        /// </summary>
        internal bool IsSetResourceGroupName() => this.ResourceGroupName != null;

        /// <summary>
        /// Gets and sets the property SNSNotificationArn. 
        /// <para>
        ///  The SNS topic ARN. Allows you to receive SNS notifications for updates and issues
        /// with an application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 300)]
        public string SNSNotificationArn { get; set; }

        /// <summary>
        /// Checks to see if the SNSNotificationArn property is set.
        /// </summary>
        internal bool IsSetSNSNotificationArn() => this.SNSNotificationArn != null;
    }
}
