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
    /// Describes the status of the application.
    /// </summary>
    public partial class ApplicationInfo
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the owner of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

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
        ///  Indicates whether auto-configuration is turned on for this application. 
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
        /// Gets and sets the property DiscoveryType. 
        /// <para>
        ///  The method used by Application Insights to onboard your resources. 
        /// </para>
        /// </summary>
        public DiscoveryType DiscoveryType { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryType property is set.
        /// </summary>
        internal bool IsSetDiscoveryType() => this.DiscoveryType != null;

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// The lifecycle of the application. 
        /// </para>
        /// </summary>
        public string LifeCycle { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycle property is set.
        /// </summary>
        internal bool IsSetLifeCycle() => this.LifeCycle != null;

        /// <summary>
        /// Gets and sets the property OpsCenterEnabled. 
        /// <para>
        ///  Indicates whether Application Insights will create opsItems for any problem detected
        /// by Application Insights for an application. 
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
        /// opsItems to receive SNS notifications for opsItem updates. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 300)]
        public string OpsItemSNSTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the OpsItemSNSTopicArn property is set.
        /// </summary>
        internal bool IsSetOpsItemSNSTopicArn() => this.OpsItemSNSTopicArn != null;

        /// <summary>
        /// Gets and sets the property Remarks. 
        /// <para>
        /// The issues on the user side that block Application Insights from successfully monitoring
        /// an application. Example remarks include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// “Configuring application, detected 1 Errors, 3 Warnings”
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// “Configuring application, detected 1 Unconfigured Components”
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// Checks to see if the Remarks property is set.
        /// </summary>
        internal bool IsSetRemarks() => this.Remarks != null;

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group used for the application.
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
        ///  The SNS topic ARN that is associated with SNS notifications for updates or issues.
        /// 
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
