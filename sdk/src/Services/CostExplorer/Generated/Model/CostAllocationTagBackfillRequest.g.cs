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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The cost allocation tag backfill request structure that contains metadata and details
    /// of a certain backfill.
    /// </summary>
    public partial class CostAllocationTagBackfillRequest
    {
        /// <summary>
        /// Gets and sets the property BackfillFrom. 
        /// <para>
        ///  The date the backfill starts from. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string BackfillFrom { get; set; }

        /// <summary>
        /// Checks to see if the BackfillFrom property is set.
        /// </summary>
        internal bool IsSetBackfillFrom() => this.BackfillFrom != null;

        /// <summary>
        /// Gets and sets the property BackfillStatus. 
        /// <para>
        ///  The status of the cost allocation tag backfill request. 
        /// </para>
        /// </summary>
        public CostAllocationTagBackfillStatus BackfillStatus { get; set; }

        /// <summary>
        /// Checks to see if the BackfillStatus property is set.
        /// </summary>
        internal bool IsSetBackfillStatus() => this.BackfillStatus != null;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        ///  The backfill completion time. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  The time when the backfill status was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt != null;

        /// <summary>
        /// Gets and sets the property RequestedAt. 
        /// <para>
        ///  The time when the backfill was requested. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string RequestedAt { get; set; }

        /// <summary>
        /// Checks to see if the RequestedAt property is set.
        /// </summary>
        internal bool IsSetRequestedAt() => this.RequestedAt != null;
    }
}
