/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOpsItem operation.
    /// Edit or change an OpsItem. You must have permission in AWS Identity and Access Management
    /// (IAM) to update an OpsItem. For more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
    /// Started with OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Operations engineers and IT professionals use OpsCenter to view, investigate, and
    /// remediate operational issues impacting the performance and health of their AWS resources.
    /// For more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">AWS
    /// Systems Manager OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class UpdateOpsItemRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _description;
        private List<OpsItemNotification> _notifications = new List<OpsItemNotification>();
        private Dictionary<string, OpsItemDataValue> _operationalData = new Dictionary<string, OpsItemDataValue>();
        private List<string> _operationalDataToDelete = new List<string>();
        private string _opsItemId;
        private int? _priority;
        private List<RelatedOpsItem> _relatedOpsItems = new List<RelatedOpsItem>();
        private OpsItemStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Update the information about the OpsItem. Provide enough information so that users
        /// reading this OpsItem for the first time understand the issue. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Notifications. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an SNS topic where notifications are sent when this
        /// OpsItem is edited or changed.
        /// </para>
        /// </summary>
        public List<OpsItemNotification> Notifications
        {
            get { return this._notifications; }
            set { this._notifications = value; }
        }

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this._notifications != null && this._notifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OperationalData. 
        /// <para>
        /// Add new keys or edit existing key-value pairs of the OperationalData map in the OpsItem
        /// object.
        /// </para>
        ///  
        /// <para>
        /// Operational data is custom data that provides useful reference details about the OpsItem.
        /// For example, you can specify log files, error strings, license keys, troubleshooting
        /// tips, or other relevant data. You enter operational data as key-value pairs. The key
        /// has a maximum length of 128 characters. The value has a maximum size of 20 KB.
        /// </para>
        ///  <important> 
        /// <para>
        /// Operational data keys <i>can't</i> begin with the following: amazon, aws, amzn, ssm,
        /// /amazon, /aws, /amzn, /ssm.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can choose to make the data searchable by other users in the account or you can
        /// restrict search access. Searchable data means that all users with access to the OpsItem
        /// Overview page (as provided by the <a>DescribeOpsItems</a> API action) can view and
        /// search on the specified data. Operational data that is not searchable is only viewable
        /// by users who have access to the OpsItem (as provided by the <a>GetOpsItem</a> API
        /// action).
        /// </para>
        ///  
        /// <para>
        /// Use the <code>/aws/resources</code> key in OperationalData to specify a related resource
        /// in the request. Use the <code>/aws/automations</code> key in OperationalData to associate
        /// an Automation runbook with the OpsItem. To view AWS CLI example commands that use
        /// these keys, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-creating-OpsItems.html#OpsCenter-manually-create-OpsItems">Creating
        /// OpsItems Manually</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, OpsItemDataValue> OperationalData
        {
            get { return this._operationalData; }
            set { this._operationalData = value; }
        }

        // Check to see if OperationalData property is set
        internal bool IsSetOperationalData()
        {
            return this._operationalData != null && this._operationalData.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OperationalDataToDelete. 
        /// <para>
        /// Keys that you want to remove from the OperationalData map.
        /// </para>
        /// </summary>
        public List<string> OperationalDataToDelete
        {
            get { return this._operationalDataToDelete; }
            set { this._operationalDataToDelete = value; }
        }

        // Check to see if OperationalDataToDelete property is set
        internal bool IsSetOperationalDataToDelete()
        {
            return this._operationalDataToDelete != null && this._operationalDataToDelete.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OpsItemId. 
        /// <para>
        /// The ID of the OpsItem.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OpsItemId
        {
            get { return this._opsItemId; }
            set { this._opsItemId = value; }
        }

        // Check to see if OpsItemId property is set
        internal bool IsSetOpsItemId()
        {
            return this._opsItemId != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The importance of this OpsItem in relation to other OpsItems in the system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelatedOpsItems. 
        /// <para>
        /// One or more OpsItems that share something in common with the current OpsItems. For
        /// example, related OpsItems can include OpsItems with similar error messages, impacted
        /// resources, or statuses for the impacted resource.
        /// </para>
        /// </summary>
        public List<RelatedOpsItem> RelatedOpsItems
        {
            get { return this._relatedOpsItems; }
            set { this._relatedOpsItems = value; }
        }

        // Check to see if RelatedOpsItems property is set
        internal bool IsSetRelatedOpsItems()
        {
            return this._relatedOpsItems != null && this._relatedOpsItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The OpsItem status. Status can be <code>Open</code>, <code>In Progress</code>, or
        /// <code>Resolved</code>. For more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-working-with-OpsItems-editing-details.html">Editing
        /// OpsItem Details</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public OpsItemStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short heading that describes the nature of the OpsItem and the impacted resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}