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
    /// Contains a summary of information about a fraudster.
    /// </summary>
    public partial class FraudsterSummary
    {
        private DateTime? _createdAt;
        private string _domainId;
        private string _generatedFraudsterId;
        private List<string> _watchlistIds = new List<string>();

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the fraudster summary was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the fraudster summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
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
        /// Gets and sets the property GeneratedFraudsterId. 
        /// <para>
        /// The service-generated identifier for the fraudster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=25)]
        public string GeneratedFraudsterId
        {
            get { return this._generatedFraudsterId; }
            set { this._generatedFraudsterId = value; }
        }

        // Check to see if GeneratedFraudsterId property is set
        internal bool IsSetGeneratedFraudsterId()
        {
            return this._generatedFraudsterId != null;
        }

        /// <summary>
        /// Gets and sets the property WatchlistIds. 
        /// <para>
        /// The identifier of the watchlists the fraudster is a part of.
        /// </para>
        /// </summary>
        public List<string> WatchlistIds
        {
            get { return this._watchlistIds; }
            set { this._watchlistIds = value; }
        }

        // Check to see if WatchlistIds property is set
        internal bool IsSetWatchlistIds()
        {
            return this._watchlistIds != null && this._watchlistIds.Count > 0; 
        }

    }
}