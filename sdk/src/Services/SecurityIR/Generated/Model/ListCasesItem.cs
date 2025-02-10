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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListCasesItem
    {
        private string _caseArn;
        private string _caseId;
        private CaseStatus _caseStatus;
        private DateTime? _closedDate;
        private DateTime? _createdDate;
        private EngagementType _engagementType;
        private DateTime? _lastUpdatedDate;
        private PendingAction _pendingAction;
        private ResolverType _resolverType;
        private string _title;

        /// <summary>
        /// Gets and sets the property CaseArn.
        /// </summary>
        [AWSProperty(Min=12, Max=80)]
        public string CaseArn
        {
            get { return this._caseArn; }
            set { this._caseArn = value; }
        }

        // Check to see if CaseArn property is set
        internal bool IsSetCaseArn()
        {
            return this._caseArn != null;
        }

        /// <summary>
        /// Gets and sets the property CaseId.
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=32)]
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property CaseStatus.
        /// </summary>
        public CaseStatus CaseStatus
        {
            get { return this._caseStatus; }
            set { this._caseStatus = value; }
        }

        // Check to see if CaseStatus property is set
        internal bool IsSetCaseStatus()
        {
            return this._caseStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClosedDate.
        /// </summary>
        public DateTime? ClosedDate
        {
            get { return this._closedDate; }
            set { this._closedDate = value; }
        }

        // Check to see if ClosedDate property is set
        internal bool IsSetClosedDate()
        {
            return this._closedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedDate.
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngagementType.
        /// </summary>
        public EngagementType EngagementType
        {
            get { return this._engagementType; }
            set { this._engagementType = value; }
        }

        // Check to see if EngagementType property is set
        internal bool IsSetEngagementType()
        {
            return this._engagementType != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate.
        /// </summary>
        public DateTime? LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingAction.
        /// </summary>
        public PendingAction PendingAction
        {
            get { return this._pendingAction; }
            set { this._pendingAction = value; }
        }

        // Check to see if PendingAction property is set
        internal bool IsSetPendingAction()
        {
            return this._pendingAction != null;
        }

        /// <summary>
        /// Gets and sets the property ResolverType.
        /// </summary>
        public ResolverType ResolverType
        {
            get { return this._resolverType; }
            set { this._resolverType = value; }
        }

        // Check to see if ResolverType property is set
        internal bool IsSetResolverType()
        {
            return this._resolverType != null;
        }

        /// <summary>
        /// Gets and sets the property Title.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=300)]
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