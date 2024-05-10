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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Full detail for report resource metadata.
    /// </summary>
    public partial class ReportDetail
    {
        private AcceptanceType _acceptanceType;
        private string _arn;
        private string _category;
        private string _companyName;
        private DateTime? _createdAt;
        private DateTime? _deletedAt;
        private string _description;
        private string _id;
        private DateTime? _lastModifiedAt;
        private string _name;
        private DateTime? _periodEnd;
        private DateTime? _periodStart;
        private string _productName;
        private long? _sequenceNumber;
        private string _series;
        private PublishedState _state;
        private string _statusMessage;
        private string _termArn;
        private UploadState _uploadState;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AcceptanceType. 
        /// <para>
        /// Acceptance type for report.
        /// </para>
        /// </summary>
        public AcceptanceType AcceptanceType
        {
            get { return this._acceptanceType; }
            set { this._acceptanceType = value; }
        }

        // Check to see if AcceptanceType property is set
        internal bool IsSetAcceptanceType()
        {
            return this._acceptanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// Category for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// Associated company name for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CompanyName
        {
            get { return this._companyName; }
            set { this._companyName = value; }
        }

        // Check to see if CompanyName property is set
        internal bool IsSetCompanyName()
        {
            return this._companyName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp indicating when the report resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletedAt. 
        /// <para>
        /// Timestamp indicating when the report resource was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletedAt
        {
            get { return this._deletedAt; }
            set { this._deletedAt = value; }
        }

        // Check to see if DeletedAt property is set
        internal bool IsSetDeletedAt()
        {
            return this._deletedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the report resource.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique resource ID for the report resource.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// Timestamp indicating when the report resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property PeriodEnd. 
        /// <para>
        /// Timestamp indicating the report resource effective end.
        /// </para>
        /// </summary>
        public DateTime? PeriodEnd
        {
            get { return this._periodEnd; }
            set { this._periodEnd = value; }
        }

        // Check to see if PeriodEnd property is set
        internal bool IsSetPeriodEnd()
        {
            return this._periodEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeriodStart. 
        /// <para>
        /// Timestamp indicating the report resource effective start.
        /// </para>
        /// </summary>
        public DateTime? PeriodStart
        {
            get { return this._periodStart; }
            set { this._periodStart = value; }
        }

        // Check to see if PeriodStart property is set
        internal bool IsSetPeriodStart()
        {
            return this._periodStart.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// Associated product name for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// Sequence number to enforce optimistic locking.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? SequenceNumber
        {
            get { return this._sequenceNumber; }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Series. 
        /// <para>
        /// Series for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Series
        {
            get { return this._series; }
            set { this._series = value; }
        }

        // Check to see if Series property is set
        internal bool IsSetSeries()
        {
            return this._series != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Current state of the report resource
        /// </para>
        /// </summary>
        public PublishedState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The message associated with the current upload state.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TermArn. 
        /// <para>
        /// Unique resource ARN for term resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TermArn
        {
            get { return this._termArn; }
            set { this._termArn = value; }
        }

        // Check to see if TermArn property is set
        internal bool IsSetTermArn()
        {
            return this._termArn != null;
        }

        /// <summary>
        /// Gets and sets the property UploadState. 
        /// <para>
        /// The current state of the document upload.
        /// </para>
        /// </summary>
        public UploadState UploadState
        {
            get { return this._uploadState; }
            set { this._uploadState = value; }
        }

        // Check to see if UploadState property is set
        internal bool IsSetUploadState()
        {
            return this._uploadState != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}