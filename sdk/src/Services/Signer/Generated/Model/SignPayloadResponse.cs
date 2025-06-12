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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
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
namespace Amazon.Signer.Model
{
    /// <summary>
    /// This is the response object from the SignPayload operation.
    /// </summary>
    public partial class SignPayloadResponse : AmazonWebServiceResponse
    {
        private string _jobId;
        private string _jobOwner;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private MemoryStream _signature;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Unique identifier of the signing job.
        /// </para>
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
        /// Gets and sets the property JobOwner. 
        /// <para>
        /// The AWS account ID of the job owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string JobOwner
        {
            get { return this._jobOwner; }
            set { this._jobOwner = value; }
        }

        // Check to see if JobOwner property is set
        internal bool IsSetJobOwner()
        {
            return this._jobOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Information including the signing profile ARN and the signing job ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// A cryptographic signature.
        /// </para>
        /// </summary>
        public MemoryStream Signature
        {
            get { return this._signature; }
            set { this._signature = value; }
        }

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this._signature != null;
        }

    }
}