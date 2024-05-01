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
    /// Container for the parameters to the RevokeSignature operation.
    /// Changes the state of a signing job to REVOKED. This indicates that the signature is
    /// no longer valid.
    /// </summary>
    public partial class RevokeSignatureRequest : AmazonSignerRequest
    {
        private string _jobId;
        private string _jobOwner;
        private string _reason;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// ID of the signing job to be revoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// AWS account ID of the job owner.
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for revoking the signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}