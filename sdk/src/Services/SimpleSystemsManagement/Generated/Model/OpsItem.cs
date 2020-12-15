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
    /// Operations engineers and IT professionals use OpsCenter to view, investigate, and
    /// remediate operational issues impacting the performance and health of their AWS resources.
    /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">AWS
    /// Systems Manager OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>.
    /// </summary>
    public partial class OpsItem
    {
        private DateTime? _actualEndTime;
        private DateTime? _actualStartTime;
        private string _category;
        private string _createdBy;
        private DateTime? _createdTime;
        private string _description;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private List<OpsItemNotification> _notifications = new List<OpsItemNotification>();
        private Dictionary<string, OpsItemDataValue> _operationalData = new Dictionary<string, OpsItemDataValue>();
        private string _opsItemId;
        private string _opsItemType;
        private DateTime? _plannedEndTime;
        private DateTime? _plannedStartTime;
        private int? _priority;
        private List<RelatedOpsItem> _relatedOpsItems = new List<RelatedOpsItem>();
        private string _severity;
        private string _source;
        private OpsItemStatus _status;
        private string _title;
        private string _version;

        /// <summary>
        /// Gets and sets the property ActualEndTime. 
        /// <para>
        /// The time a runbook workflow ended. Currently reported only for the OpsItem type <code>/aws/changerequest</code>.
        /// </para>
        /// </summary>
        public DateTime ActualEndTime
        {
            get { return this._actualEndTime.GetValueOrDefault(); }
            set { this._actualEndTime = value; }
        }

        // Check to see if ActualEndTime property is set
        internal bool IsSetActualEndTime()
        {
            return this._actualEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActualStartTime. 
        /// <para>
        /// The time a runbook workflow started. Currently reported only for the OpsItem type
        /// <code>/aws/changerequest</code>.
        /// </para>
        /// </summary>
        public DateTime ActualStartTime
        {
            get { return this._actualStartTime.GetValueOrDefault(); }
            set { this._actualStartTime = value; }
        }

        // Check to see if ActualStartTime property is set
        internal bool IsSetActualStartTime()
        {
            return this._actualStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// An OpsItem category. Category options include: Availability, Cost, Performance, Recovery,
        /// Security.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The ARN of the AWS account that created the OpsItem.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the OpsItem was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The OpsItem description.
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
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The ARN of the AWS account that last updated the OpsItem.
        /// </para>
        /// </summary>
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the OpsItem was last updated.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
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
        /// these keys, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-creating-OpsItems.html#OpsCenter-manually-create-OpsItems">Creating
        /// OpsItems manually</a> in the <i>AWS Systems Manager User Guide</i>.
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
        /// Gets and sets the property OpsItemId. 
        /// <para>
        /// The ID of the OpsItem.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OpsItemType. 
        /// <para>
        /// The type of OpsItem. Currently, the only valid values are <code>/aws/changerequest</code>
        /// and <code>/aws/issue</code>.
        /// </para>
        /// </summary>
        public string OpsItemType
        {
            get { return this._opsItemType; }
            set { this._opsItemType = value; }
        }

        // Check to see if OpsItemType property is set
        internal bool IsSetOpsItemType()
        {
            return this._opsItemType != null;
        }

        /// <summary>
        /// Gets and sets the property PlannedEndTime. 
        /// <para>
        /// The time specified in a change request for a runbook workflow to end. Currently supported
        /// only for the OpsItem type <code>/aws/changerequest</code>.
        /// </para>
        /// </summary>
        public DateTime PlannedEndTime
        {
            get { return this._plannedEndTime.GetValueOrDefault(); }
            set { this._plannedEndTime = value; }
        }

        // Check to see if PlannedEndTime property is set
        internal bool IsSetPlannedEndTime()
        {
            return this._plannedEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlannedStartTime. 
        /// <para>
        /// The time specified in a change request for a runbook workflow to start. Currently
        /// supported only for the OpsItem type <code>/aws/changerequest</code>.
        /// </para>
        /// </summary>
        public DateTime PlannedStartTime
        {
            get { return this._plannedStartTime.GetValueOrDefault(); }
            set { this._plannedStartTime = value; }
        }

        // Check to see if PlannedStartTime property is set
        internal bool IsSetPlannedStartTime()
        {
            return this._plannedStartTime.HasValue; 
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
        /// One or more OpsItems that share something in common with the current OpsItem. For
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
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the OpsItem. Severity options range from 1 to 4.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The origin of the OpsItem, such as Amazon EC2 or Systems Manager. The impacted resource
        /// is a subset of source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The OpsItem status. Status can be <code>Open</code>, <code>In Progress</code>, or
        /// <code>Resolved</code>. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-working-with-OpsItems-editing-details.html">Editing
        /// OpsItem details</a> in the <i>AWS Systems Manager User Guide</i>.
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of this OpsItem. Each time the OpsItem is edited the version number increments
        /// by one.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}