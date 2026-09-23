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
    /// This is the response object from the ListInstrumentationConfigurations operation.
    /// </summary>
    public partial class ListInstrumentationConfigurationsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Changed. 
        /// <para>
        /// Indicates whether there are configuration changes since the provided <c>SyncedAt</c>
        /// timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Changed { get; set; }

        /// <summary>
        /// Checks to see if the Changed property is set.
        /// </summary>
        internal bool IsSetChanged() => this.Changed.HasValue;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment associated with the returned configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property LatestConfigurations. 
        /// <para>
        /// The current set of active instrumentation configurations for the service and environment.
        /// Items omit service and environment because they are provided in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstrumentationConfigurationWithoutServiceEnv> LatestConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<InstrumentationConfigurationWithoutServiceEnv>() : null;

        /// <summary>
        /// Checks to see if the LatestConfigurations property is set.
        /// </summary>
        internal bool IsSetLatestConfigurations() => this.LatestConfigurations != null && (this.LatestConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token to continue listing configurations when more results are available.
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
        /// The service name associated with the returned configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property SyncInterval. 
        /// <para>
        /// The suggested number of seconds to wait before the next sync request. This is at least
        /// 60 seconds to prevent excessive polling.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60)]
        public int? SyncInterval { get; set; }

        /// <summary>
        /// Checks to see if the SyncInterval property is set.
        /// </summary>
        internal bool IsSetSyncInterval() => this.SyncInterval.HasValue;

        /// <summary>
        /// Gets and sets the property SyncedAt. 
        /// <para>
        /// The server timestamp to supply on the next sync call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SyncedAt { get; set; }

        /// <summary>
        /// Checks to see if the SyncedAt property is set.
        /// </summary>
        internal bool IsSetSyncedAt() => this.SyncedAt.HasValue;
    }
}
