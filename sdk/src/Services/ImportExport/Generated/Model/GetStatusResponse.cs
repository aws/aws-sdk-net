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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
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
namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// Output structure for the GetStatus operation.
    /// </summary>
    public partial class GetStatusResponse : AmazonWebServiceResponse
    {
        private List<Artifact> _artifactList = AWSConfigs.InitializeCollections ? new List<Artifact>() : null;
        private string _carrier;
        private DateTime? _creationDate;
        private string _currentManifest;
        private int? _errorCount;
        private string _jobId;
        private JobType _jobType;
        private string _locationCode;
        private string _locationMessage;
        private string _logBucket;
        private string _logKey;
        private string _progressCode;
        private string _progressMessage;
        private string _signature;
        private string _signatureFileContents;
        private string _trackingNumber;

        /// <summary>
        /// Gets and sets the property ArtifactList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Artifact> ArtifactList
        {
            get { return this._artifactList; }
            set { this._artifactList = value; }
        }

        // Check to see if ArtifactList property is set
        internal bool IsSetArtifactList()
        {
            return this._artifactList != null && (this._artifactList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Carrier.
        /// </summary>
        public string Carrier
        {
            get { return this._carrier; }
            set { this._carrier = value; }
        }

        // Check to see if Carrier property is set
        internal bool IsSetCarrier()
        {
            return this._carrier != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate.
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentManifest.
        /// </summary>
        public string CurrentManifest
        {
            get { return this._currentManifest; }
            set { this._currentManifest = value; }
        }

        // Check to see if CurrentManifest property is set
        internal bool IsSetCurrentManifest()
        {
            return this._currentManifest != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCount.
        /// </summary>
        public int? ErrorCount
        {
            get { return this._errorCount; }
            set { this._errorCount = value; }
        }

        // Check to see if ErrorCount property is set
        internal bool IsSetErrorCount()
        {
            return this._errorCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId.
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobType.
        /// </summary>
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property LocationCode.
        /// </summary>
        public string LocationCode
        {
            get { return this._locationCode; }
            set { this._locationCode = value; }
        }

        // Check to see if LocationCode property is set
        internal bool IsSetLocationCode()
        {
            return this._locationCode != null;
        }

        /// <summary>
        /// Gets and sets the property LocationMessage.
        /// </summary>
        public string LocationMessage
        {
            get { return this._locationMessage; }
            set { this._locationMessage = value; }
        }

        // Check to see if LocationMessage property is set
        internal bool IsSetLocationMessage()
        {
            return this._locationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LogBucket.
        /// </summary>
        public string LogBucket
        {
            get { return this._logBucket; }
            set { this._logBucket = value; }
        }

        // Check to see if LogBucket property is set
        internal bool IsSetLogBucket()
        {
            return this._logBucket != null;
        }

        /// <summary>
        /// Gets and sets the property LogKey.
        /// </summary>
        public string LogKey
        {
            get { return this._logKey; }
            set { this._logKey = value; }
        }

        // Check to see if LogKey property is set
        internal bool IsSetLogKey()
        {
            return this._logKey != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressCode.
        /// </summary>
        public string ProgressCode
        {
            get { return this._progressCode; }
            set { this._progressCode = value; }
        }

        // Check to see if ProgressCode property is set
        internal bool IsSetProgressCode()
        {
            return this._progressCode != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressMessage.
        /// </summary>
        public string ProgressMessage
        {
            get { return this._progressMessage; }
            set { this._progressMessage = value; }
        }

        // Check to see if ProgressMessage property is set
        internal bool IsSetProgressMessage()
        {
            return this._progressMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Signature.
        /// </summary>
        public string Signature
        {
            get { return this._signature; }
            set { this._signature = value; }
        }

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this._signature != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureFileContents.
        /// </summary>
        public string SignatureFileContents
        {
            get { return this._signatureFileContents; }
            set { this._signatureFileContents = value; }
        }

        // Check to see if SignatureFileContents property is set
        internal bool IsSetSignatureFileContents()
        {
            return this._signatureFileContents != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingNumber.
        /// </summary>
        public string TrackingNumber
        {
            get { return this._trackingNumber; }
            set { this._trackingNumber = value; }
        }

        // Check to see if TrackingNumber property is set
        internal bool IsSetTrackingNumber()
        {
            return this._trackingNumber != null;
        }

    }
}