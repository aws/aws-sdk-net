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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A count of OpsItems.
    /// </summary>
    public partial class OpsItemSummary
    {
        private DateTime? _actualEndTime;
        private DateTime? _actualStartTime;
        private string _category;
        private string _createdBy;
        private DateTime? _createdTime;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private Dictionary<string, OpsItemDataValue> _operationalData = AWSConfigs.InitializeCollections ? new Dictionary<string, OpsItemDataValue>() : null;
        private string _opsItemId;
        private string _opsItemType;
        private DateTime? _plannedEndTime;
        private DateTime? _plannedStartTime;
        private int? _priority;
        private string _severity;
        private string _source;
        private OpsItemStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property ActualEndTime. 
        /// <para>
        /// The time a runbook workflow ended. Currently reported only for the OpsItem type <c>/aws/changerequest</c>.
        /// </para>
        /// </summary>
        public DateTime? ActualEndTime
        {
            get { return this._actualEndTime; }
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
        /// <c>/aws/changerequest</c>.
        /// </para>
        /// </summary>
        public DateTime? ActualStartTime
        {
            get { return this._actualStartTime; }
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
        /// A list of OpsItems by category.
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
        /// The Amazon Resource Name (ARN) of the IAM entity that created the OpsItem.
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
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM entity that created the OpsItem.
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
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperationalData. 
        /// <para>
        /// Operational data is custom data that provides useful reference details about the OpsItem.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, OpsItemDataValue> OperationalData
        {
            get { return this._operationalData; }
            set { this._operationalData = value; }
        }

        // Check to see if OperationalData property is set
        internal bool IsSetOperationalData()
        {
            return this._operationalData != null && (this._operationalData.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The type of OpsItem. Systems Manager supports the following types of OpsItems:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>/aws/issue</c> 
        /// </para>
        ///  
        /// <para>
        /// This type of OpsItem is used for default OpsItems created by OpsCenter. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/aws/changerequest</c> 
        /// </para>
        ///  
        /// <para>
        /// This type of OpsItem is used by Change Manager for reviewing and approving or rejecting
        /// change requests. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/aws/insight</c> 
        /// </para>
        ///  
        /// <para>
        /// This type of OpsItem is used by OpsCenter for aggregating and reporting on duplicate
        /// OpsItems. 
        /// </para>
        ///  </li> </ul>
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
        /// only for the OpsItem type <c>/aws/changerequest</c>.
        /// </para>
        /// </summary>
        public DateTime? PlannedEndTime
        {
            get { return this._plannedEndTime; }
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
        /// supported only for the OpsItem type <c>/aws/changerequest</c>.
        /// </para>
        /// </summary>
        public DateTime? PlannedStartTime
        {
            get { return this._plannedStartTime; }
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
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// A list of OpsItems by severity.
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
        /// The impacted Amazon Web Services resource.
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
        /// The OpsItem status.
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