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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Represents a share request for a custom framework in Audit Manager.
    /// </summary>
    public partial class AssessmentFrameworkShareRequest
    {
        private string _comment;
        private string _complianceType;
        private DateTime? _creationTime;
        private int? _customControlsCount;
        private string _destinationAccount;
        private string _destinationRegion;
        private DateTime? _expirationTime;
        private string _frameworkDescription;
        private string _frameworkId;
        private string _frameworkName;
        private string _id;
        private DateTime? _lastUpdated;
        private string _sourceAccount;
        private int? _standardControlsCount;
        private ShareRequestStatus _status;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        ///  An optional comment from the sender about the share request. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The compliance type that the shared custom framework supports, such as CIS or HIPAA.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=100)]
        public string ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time when the share request was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomControlsCount. 
        /// <para>
        /// The number of custom controls that are part of the shared custom framework.
        /// </para>
        /// </summary>
        public int? CustomControlsCount
        {
            get { return this._customControlsCount; }
            set { this._customControlsCount = value; }
        }

        // Check to see if CustomControlsCount property is set
        internal bool IsSetCustomControlsCount()
        {
            return this._customControlsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationAccount. 
        /// <para>
        ///  The Amazon Web Services account of the recipient. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DestinationAccount
        {
            get { return this._destinationAccount; }
            set { this._destinationAccount = value; }
        }

        // Check to see if DestinationAccount property is set
        internal bool IsSetDestinationAccount()
        {
            return this._destinationAccount != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        ///  The Amazon Web Services Region of the recipient. 
        /// </para>
        /// </summary>
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        ///  The time when the share request expires. 
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FrameworkDescription. 
        /// <para>
        /// The description of the shared custom framework.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string FrameworkDescription
        {
            get { return this._frameworkDescription; }
            set { this._frameworkDescription = value; }
        }

        // Check to see if FrameworkDescription property is set
        internal bool IsSetFrameworkDescription()
        {
            return this._frameworkDescription != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkId. 
        /// <para>
        /// The unique identifier for the shared custom framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string FrameworkId
        {
            get { return this._frameworkId; }
            set { this._frameworkId = value; }
        }

        // Check to see if FrameworkId property is set
        internal bool IsSetFrameworkId()
        {
            return this._frameworkId != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkName. 
        /// <para>
        ///  The name of the custom framework that the share request is for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string FrameworkName
        {
            get { return this._frameworkName; }
            set { this._frameworkName = value; }
        }

        // Check to see if FrameworkName property is set
        internal bool IsSetFrameworkName()
        {
            return this._frameworkName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the share request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property LastUpdated. 
        /// <para>
        ///  Specifies when the share request was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceAccount. 
        /// <para>
        ///  The Amazon Web Services account of the sender. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string SourceAccount
        {
            get { return this._sourceAccount; }
            set { this._sourceAccount = value; }
        }

        // Check to see if SourceAccount property is set
        internal bool IsSetSourceAccount()
        {
            return this._sourceAccount != null;
        }

        /// <summary>
        /// Gets and sets the property StandardControlsCount. 
        /// <para>
        /// The number of standard controls that are part of the shared custom framework. 
        /// </para>
        /// </summary>
        public int? StandardControlsCount
        {
            get { return this._standardControlsCount; }
            set { this._standardControlsCount = value; }
        }

        // Check to see if StandardControlsCount property is set
        internal bool IsSetStandardControlsCount()
        {
            return this._standardControlsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the share request. 
        /// </para>
        /// </summary>
        public ShareRequestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}