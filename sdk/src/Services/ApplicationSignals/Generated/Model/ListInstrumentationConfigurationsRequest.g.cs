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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the ListInstrumentationConfigurations operation. Returns
    /// all active instrumentation configurations for a service and environment. SDKs use
    /// this operation to sync configurations and apply client-side filters locally. <para>
    /// Include the previous <c>SyncedAt</c> value to perform incremental syncs. When no changes
    /// are detected, the response sets <c>Changed</c> to <c>false</c> and omits configuration
    /// details. </para>
    /// </summary>
    public partial class ListInstrumentationConfigurationsRequest : AmazonApplicationSignalsRequest
    {
        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment that the service is running in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property InstrumentationType. Type of instrumentation configuration
        /// (BREAKPOINT or PROBE). Required to determine which backing store to query.
        /// </summary>
        [AWSProperty(Required = true)]
        public InstrumentationType InstrumentationType { get; set; }

        /// <summary>
        /// Checks to see if the InstrumentationType property is set.
        /// </summary>
        internal bool IsSetInstrumentationType() => this.InstrumentationType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of configurations to return in one call. The default is 50 and
        /// the maximum is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use the token returned by a previous call to retrieve the next page of configurations.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the service to retrieve instrumentation configurations for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property SyncedAt. 
        /// <para>
        /// The timestamp from the last successful sync. When provided, the response returns <c>Changed</c>
        /// as <c>false</c> if nothing is new since this time, or returns the latest configurations
        /// when changes exist.
        /// </para>
        /// </summary>
        public DateTime? SyncedAt { get; set; }

        /// <summary>
        /// Checks to see if the SyncedAt property is set.
        /// </summary>
        internal bool IsSetSyncedAt() => this.SyncedAt.HasValue;
    }
}
