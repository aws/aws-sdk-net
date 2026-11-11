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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateClone operation. Manages a cloned blue/green
    /// upgrade that is in progress on a domain. Use it to shift a percentage of search traffic
    /// to the cloned cluster, to cut over to the cloned cluster or back to the primary cluster,
    /// or to change the retention period. Specify exactly one of <c>TrafficSplitOptions</c>,
    /// <c>CutoverOptions</c>, or <c>RetentionOptions</c> in each request.
    /// </summary>
    public partial class UpdateCloneRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property CutoverOptions. 
        /// <para>
        /// Cuts the domain over to the cloned cluster or back to the primary cluster.
        /// </para>
        /// </summary>
        public CutoverRequestOptions CutoverOptions { get; set; }

        /// <summary>
        /// Checks to see if the CutoverOptions property is set.
        /// </summary>
        internal bool IsSetCutoverOptions() => this.CutoverOptions != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that has a cloned blue/green upgrade in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property RetentionOptions. 
        /// <para>
        /// Changes the retention period, or ends it after cutover completes.
        /// </para>
        /// </summary>
        public RetentionOptions RetentionOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetentionOptions property is set.
        /// </summary>
        internal bool IsSetRetentionOptions() => this.RetentionOptions != null;

        /// <summary>
        /// Gets and sets the property TrafficSplitOptions. 
        /// <para>
        /// Shifts a percentage of search traffic from the primary cluster to the cloned cluster.
        /// </para>
        /// </summary>
        public TrafficSplitRequestOptions TrafficSplitOptions { get; set; }

        /// <summary>
        /// Checks to see if the TrafficSplitOptions property is set.
        /// </summary>
        internal bool IsSetTrafficSplitOptions() => this.TrafficSplitOptions != null;
    }
}
