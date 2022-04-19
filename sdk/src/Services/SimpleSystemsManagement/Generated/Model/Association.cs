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
    /// Describes an association of a Amazon Web Services Systems Manager document (SSM document)
    /// and a managed node.
    /// </summary>
    public partial class Association
    {
        private string _associationId;
        private string _associationName;
        private string _associationVersion;
        private string _documentVersion;
        private string _instanceId;
        private DateTime? _lastExecutionDate;
        private string _name;
        private AssociationOverview _overview;
        private string _scheduleExpression;
        private int? _scheduleOffset;
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID created by the system when you create an association. An association is a binding
        /// between a document and a set of targets with a schedule.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationName. 
        /// <para>
        /// The association name.
        /// </para>
        /// </summary>
        public string AssociationName
        {
            get { return this._associationName; }
            set { this._associationName = value; }
        }

        // Check to see if AssociationName property is set
        internal bool IsSetAssociationName()
        {
            return this._associationName != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationVersion. 
        /// <para>
        /// The association version.
        /// </para>
        /// </summary>
        public string AssociationVersion
        {
            get { return this._associationVersion; }
            set { this._associationVersion = value; }
        }

        // Check to see if AssociationVersion property is set
        internal bool IsSetAssociationVersion()
        {
            return this._associationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of the document used in the association. If you change a document version
        /// for a State Manager association, Systems Manager immediately runs the association
        /// unless you previously specifed the <code>apply-only-at-cron-interval</code> parameter.
        /// </para>
        ///  <important> 
        /// <para>
        /// State Manager doesn't support running associations that use a new version of a document
        /// if that document is shared from another account. State Manager always runs the <code>default</code>
        /// version of a document if shared from another account, even though the Systems Manager
        /// console shows that a new version was processed. If you want to run an association
        /// using a new version of a document shared form another account, you must set the document
        /// version to <code>default</code>.
        /// </para>
        ///  </important>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The managed node ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LastExecutionDate. 
        /// <para>
        /// The date on which the association was last run.
        /// </para>
        /// </summary>
        public DateTime LastExecutionDate
        {
            get { return this._lastExecutionDate.GetValueOrDefault(); }
            set { this._lastExecutionDate = value; }
        }

        // Check to see if LastExecutionDate property is set
        internal bool IsSetLastExecutionDate()
        {
            return this._lastExecutionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM document.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Overview. 
        /// <para>
        /// Information about the association.
        /// </para>
        /// </summary>
        public AssociationOverview Overview
        {
            get { return this._overview; }
            set { this._overview = value; }
        }

        // Check to see if Overview property is set
        internal bool IsSetOverview()
        {
            return this._overview != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A cron expression that specifies a schedule when the association runs. The schedule
        /// runs in Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleOffset. 
        /// <para>
        /// Number of days to wait after the scheduled day to run an association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public int ScheduleOffset
        {
            get { return this._scheduleOffset.GetValueOrDefault(); }
            set { this._scheduleOffset = value; }
        }

        // Check to see if ScheduleOffset property is set
        internal bool IsSetScheduleOffset()
        {
            return this._scheduleOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The managed nodes targeted by the request to create an association. You can target
        /// all managed nodes in an Amazon Web Services account by specifying the <code>InstanceIds</code>
        /// key with a value of <code>*</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}