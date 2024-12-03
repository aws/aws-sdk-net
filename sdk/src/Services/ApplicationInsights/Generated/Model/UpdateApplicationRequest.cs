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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
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
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates the application.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonApplicationInsightsRequest
    {
        private bool? _attachMissingPermission;
        private bool? _autoConfigEnabled;
        private bool? _cweMonitorEnabled;
        private bool? _opsCenterEnabled;
        private string _opsItemSNSTopicArn;
        private bool? _removeSNSTopic;
        private string _resourceGroupName;
        private string _snsNotificationArn;

        /// <summary>
        /// Gets and sets the property AttachMissingPermission. 
        /// <para>
        /// If set to true, the managed policies for SSM and CW will be attached to the instance
        /// roles if they are missing.
        /// </para>
        /// </summary>
        public bool? AttachMissingPermission
        {
            get { return this._attachMissingPermission; }
            set { this._attachMissingPermission = value; }
        }

        // Check to see if AttachMissingPermission property is set
        internal bool IsSetAttachMissingPermission()
        {
            return this._attachMissingPermission.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoConfigEnabled. 
        /// <para>
        ///  Turns auto-configuration on or off. 
        /// </para>
        /// </summary>
        public bool? AutoConfigEnabled
        {
            get { return this._autoConfigEnabled; }
            set { this._autoConfigEnabled = value; }
        }

        // Check to see if AutoConfigEnabled property is set
        internal bool IsSetAutoConfigEnabled()
        {
            return this._autoConfigEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CWEMonitorEnabled. 
        /// <para>
        ///  Indicates whether Application Insights can listen to CloudWatch events for the application
        /// resources, such as <c>instance terminated</c>, <c>failed deployment</c>, and others.
        /// 
        /// </para>
        /// </summary>
        public bool? CWEMonitorEnabled
        {
            get { return this._cweMonitorEnabled; }
            set { this._cweMonitorEnabled = value; }
        }

        // Check to see if CWEMonitorEnabled property is set
        internal bool IsSetCWEMonitorEnabled()
        {
            return this._cweMonitorEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpsCenterEnabled. 
        /// <para>
        ///  When set to <c>true</c>, creates opsItems for any problems detected on an application.
        /// 
        /// </para>
        /// </summary>
        public bool? OpsCenterEnabled
        {
            get { return this._opsCenterEnabled; }
            set { this._opsCenterEnabled = value; }
        }

        // Check to see if OpsCenterEnabled property is set
        internal bool IsSetOpsCenterEnabled()
        {
            return this._opsCenterEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpsItemSNSTopicArn. 
        /// <para>
        ///  The SNS topic provided to Application Insights that is associated to the created
        /// opsItem. Allows you to receive notifications for updates to the opsItem.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=300)]
        public string OpsItemSNSTopicArn
        {
            get { return this._opsItemSNSTopicArn; }
            set { this._opsItemSNSTopicArn = value; }
        }

        // Check to see if OpsItemSNSTopicArn property is set
        internal bool IsSetOpsItemSNSTopicArn()
        {
            return this._opsItemSNSTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveSNSTopic. 
        /// <para>
        ///  Disassociates the SNS topic from the opsItem created for detected problems.
        /// </para>
        /// </summary>
        public bool? RemoveSNSTopic
        {
            get { return this._removeSNSTopic; }
            set { this._removeSNSTopic = value; }
        }

        // Check to see if RemoveSNSTopic property is set
        internal bool IsSetRemoveSNSTopic()
        {
            return this._removeSNSTopic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }

        // Check to see if ResourceGroupName property is set
        internal bool IsSetResourceGroupName()
        {
            return this._resourceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SNSNotificationArn. 
        /// <para>
        ///  The SNS topic ARN. Allows you to receive SNS notifications for updates and issues
        /// with an application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=300)]
        public string SNSNotificationArn
        {
            get { return this._snsNotificationArn; }
            set { this._snsNotificationArn = value; }
        }

        // Check to see if SNSNotificationArn property is set
        internal bool IsSetSNSNotificationArn()
        {
            return this._snsNotificationArn != null;
        }

    }
}