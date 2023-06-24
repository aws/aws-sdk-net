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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFraudster operation.
    /// Deletes the specified fraudster from Voice ID. This action disassociates the fraudster
    /// from any watchlists it is a part of.
    /// </summary>
    public partial class DeleteFraudsterRequest : AmazonVoiceIDRequest
    {
        private string _domainId;
        private string _fraudsterId;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the fraudster.
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
        /// Gets and sets the property FraudsterId. 
        /// <para>
        /// The identifier of the fraudster you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=25, Max=25)]
        public string FraudsterId
        {
            get { return this._fraudsterId; }
            set { this._fraudsterId = value; }
        }

        // Check to see if FraudsterId property is set
        internal bool IsSetFraudsterId()
        {
            return this._fraudsterId != null;
        }

    }
}