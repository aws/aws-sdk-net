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
    /// Output structure for the CreateJob operation.
    /// </summary>
    public partial class CreateJobResponse : AmazonWebServiceResponse
    {
        private List<Artifact> _artifactList = AWSConfigs.InitializeCollections ? new List<Artifact>() : null;
        private string _jobId;
        private JobType _jobType;
        private string _signature;
        private string _signatureFileContents;
        private string _warningMessage;

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
        /// Gets and sets the property WarningMessage.
        /// </summary>
        public string WarningMessage
        {
            get { return this._warningMessage; }
            set { this._warningMessage = value; }
        }

        // Check to see if WarningMessage property is set
        internal bool IsSetWarningMessage()
        {
            return this._warningMessage != null;
        }

    }
}