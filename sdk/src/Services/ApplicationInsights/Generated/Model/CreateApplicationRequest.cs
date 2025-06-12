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
    /// Container for the parameters to the CreateApplication operation.
    /// Adds an application that is created from a resource group.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonApplicationInsightsRequest
    {
        private bool? _attachMissingPermission;
        private bool? _autoConfigEnabled;
        private bool? _autoCreate;
        private bool? _cweMonitorEnabled;
        private GroupingType _groupingType;
        private bool? _opsCenterEnabled;
        private string _opsItemSNSTopicArn;
        private string _resourceGroupName;
        private string _snsNotificationArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        ///  Indicates whether Application Insights automatically configures unmonitored resources
        /// in the resource group. 
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
        /// Gets and sets the property AutoCreate. 
        /// <para>
        ///  Configures all of the resources in the resource group by applying the recommended
        /// configurations. 
        /// </para>
        /// </summary>
        public bool? AutoCreate
        {
            get { return this._autoCreate; }
            set { this._autoCreate = value; }
        }

        // Check to see if AutoCreate property is set
        internal bool IsSetAutoCreate()
        {
            return this._autoCreate.HasValue; 
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
        /// Gets and sets the property GroupingType. 
        /// <para>
        /// Application Insights can create applications based on a resource group or on an account.
        /// To create an account-based application using all of the resources in the account,
        /// set this parameter to <c>ACCOUNT_BASED</c>. 
        /// </para>
        /// </summary>
        public GroupingType GroupingType
        {
            get { return this._groupingType; }
            set { this._groupingType = value; }
        }

        // Check to see if GroupingType property is set
        internal bool IsSetGroupingType()
        {
            return this._groupingType != null;
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
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
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
        ///  The SNS notification topic ARN. 
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags to add to the application. tag key (<c>Key</c>) and an associated tag
        /// value (<c>Value</c>). The maximum length of a tag key is 128 characters. The maximum
        /// length of a tag value is 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}