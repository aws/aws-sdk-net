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
    /// Describes the status of the application.
    /// </summary>
    public partial class ApplicationInfo
    {
        private string _accountId;
        private bool? _attachMissingPermission;
        private bool? _autoConfigEnabled;
        private bool? _cweMonitorEnabled;
        private DiscoveryType _discoveryType;
        private string _lifeCycle;
        private bool? _opsCenterEnabled;
        private string _opsItemSNSTopicArn;
        private string _remarks;
        private string _resourceGroupName;
        private string _snsNotificationArn;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the owner of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

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
        ///  Indicates whether auto-configuration is turned on for this application. 
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
        /// Gets and sets the property DiscoveryType. 
        /// <para>
        ///  The method used by Application Insights to onboard your resources. 
        /// </para>
        /// </summary>
        public DiscoveryType DiscoveryType
        {
            get { return this._discoveryType; }
            set { this._discoveryType = value; }
        }

        // Check to see if DiscoveryType property is set
        internal bool IsSetDiscoveryType()
        {
            return this._discoveryType != null;
        }

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// The lifecycle of the application. 
        /// </para>
        /// </summary>
        public string LifeCycle
        {
            get { return this._lifeCycle; }
            set { this._lifeCycle = value; }
        }

        // Check to see if LifeCycle property is set
        internal bool IsSetLifeCycle()
        {
            return this._lifeCycle != null;
        }

        /// <summary>
        /// Gets and sets the property OpsCenterEnabled. 
        /// <para>
        ///  Indicates whether Application Insights will create opsItems for any problem detected
        /// by Application Insights for an application. 
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
        /// opsItems to receive SNS notifications for opsItem updates. 
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
        public string Remarks
        {
            get { return this._remarks; }
            set { this._remarks = value; }
        }

        // Check to see if Remarks property is set
        internal bool IsSetRemarks()
        {
            return this._remarks != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group used for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        ///  The SNS topic ARN that is associated with SNS notifications for updates or issues.
        /// 
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