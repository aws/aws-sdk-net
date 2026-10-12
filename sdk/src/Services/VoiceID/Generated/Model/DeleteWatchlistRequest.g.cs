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
    /// Container for the parameters to the DeleteWatchlist operation. Deletes the specified
    /// watchlist from Voice ID. This API throws an exception when there are fraudsters in
    /// the watchlist that you are trying to delete. You must delete the fraudsters, and then
    /// delete the watchlist. Every domain has a default watchlist which cannot be deleted.
    /// </summary>
    public partial class DeleteWatchlistRequest : AmazonVoiceIDRequest
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the watchlist.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property WatchlistId. 
        /// <para>
        /// The identifier of the watchlist to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 22)]
        public string WatchlistId { get; set; }

        /// <summary>
        /// Checks to see if the WatchlistId property is set.
        /// </summary>
        internal bool IsSetWatchlistId() => this.WatchlistId != null;
    }
}
