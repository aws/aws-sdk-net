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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
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
namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSpeakerEnrollmentJob operation.
    /// Describes the specified speaker enrollment job.
    /// </summary>
    public partial class DescribeSpeakerEnrollmentJobRequest : AmazonVoiceIDRequest
    {
        private string _domainId;
        private string _jobId;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the speaker enrollment job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier of the speaker enrollment job you are describing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
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

    }
}