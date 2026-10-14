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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Contains a summary of information about a fraudster.
    /// </summary>
    public partial class FraudsterSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the fraudster summary was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the fraudster summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property GeneratedFraudsterId. 
        /// <para>
        /// The service-generated identifier for the fraudster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 25, Max = 25)]
        public string GeneratedFraudsterId { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedFraudsterId property is set.
        /// </summary>
        internal bool IsSetGeneratedFraudsterId() => this.GeneratedFraudsterId != null;

        /// <summary>
        /// Gets and sets the property WatchlistIds. 
        /// <para>
        /// The identifier of the watchlists the fraudster is a part of.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WatchlistIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WatchlistIds property is set.
        /// </summary>
        internal bool IsSetWatchlistIds() => this.WatchlistIds != null && (this.WatchlistIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
