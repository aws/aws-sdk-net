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
    /// Container for the parameters to the CreateApplication operation. Adds an application
    /// that is created from a resource group.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonApplicationInsightsRequest
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
        ///  Indicates whether Application Insights automatically configures unmonitored resources
        /// in the resource group. 
        /// </para>
        /// </summary>
        public bool? AutoConfigEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutoConfigEnabled property is set.
        /// </summary>
        internal bool IsSetAutoConfigEnabled() => this.AutoConfigEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property AutoCreate. 
        /// <para>
        ///  Configures all of the resources in the resource group by applying the recommended
        /// configurations. 
        /// </para>
        /// </summary>
        public bool? AutoCreate { get; set; }

        /// <summary>
        /// Checks to see if the AutoCreate property is set.
        /// </summary>
        internal bool IsSetAutoCreate() => this.AutoCreate.HasValue;

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
        /// Gets and sets the property GroupingType. 
        /// <para>
        /// Application Insights can create applications based on a resource group or on an account.
        /// To create an account-based application using all of the resources in the account,
        /// set this parameter to <c>ACCOUNT_BASED</c>. 
        /// </para>
        /// </summary>
        public GroupingType GroupingType { get; set; }

        /// <summary>
        /// Checks to see if the GroupingType property is set.
        /// </summary>
        internal bool IsSetGroupingType() => this.GroupingType != null;

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
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupName property is set.
        /// </summary>
        internal bool IsSetResourceGroupName() => this.ResourceGroupName != null;

        /// <summary>
        /// Gets and sets the property SNSNotificationArn. 
        /// <para>
        ///  The SNS notification topic ARN. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 300)]
        public string SNSNotificationArn { get; set; }

        /// <summary>
        /// Checks to see if the SNSNotificationArn property is set.
        /// </summary>
        internal bool IsSetSNSNotificationArn() => this.SNSNotificationArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags to add to the application. tag key (<c>Key</c>) and an associated tag
        /// value (<c>Value</c>). The maximum length of a tag key is 128 characters. The maximum
        /// length of a tag value is 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
