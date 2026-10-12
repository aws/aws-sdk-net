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
    /// Contains a summary of information about a watchlist.
    /// </summary>
    public partial class WatchlistSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the watchlist was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultWatchlist. 
        /// <para>
        /// Whether the specified watchlist is the default watchlist of a domain.
        /// </para>
        /// </summary>
        public bool? DefaultWatchlist { get; set; }

        /// <summary>
        /// Checks to see if the DefaultWatchlist property is set.
        /// </summary>
        internal bool IsSetDefaultWatchlist() => this.DefaultWatchlist.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the watchlist.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the watchlist.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the watchlist.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the watchlist was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WatchlistId. 
        /// <para>
        /// The identifier of the watchlist.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string WatchlistId { get; set; }

        /// <summary>
        /// Checks to see if the WatchlistId property is set.
        /// </summary>
        internal bool IsSetWatchlistId() => this.WatchlistId != null;
    }
}
