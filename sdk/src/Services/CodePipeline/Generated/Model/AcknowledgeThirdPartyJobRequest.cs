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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the AcknowledgeThirdPartyJob operation.
    /// Confirms a job worker has received the specified job. Used for partner actions only.
    /// </summary>
    public partial class AcknowledgeThirdPartyJobRequest : AmazonCodePipelineRequest
    {
        private string _clientToken;
        private string _jobId;
        private string _nonce;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The clientToken portion of the clientId and clientToken pair used to verify that the
        /// calling entity is allowed access to the job and its details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique system-generated ID of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// Gets and sets the property Nonce. 
        /// <para>
        /// A system-generated random number that CodePipeline uses to ensure that the job is
        /// being worked on by only one job worker. Get this number from the response to a <a>GetThirdPartyJobDetails</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Nonce
        {
            get { return this._nonce; }
            set { this._nonce = value; }
        }

        // Check to see if Nonce property is set
        internal bool IsSetNonce()
        {
            return this._nonce != null;
        }

    }
}