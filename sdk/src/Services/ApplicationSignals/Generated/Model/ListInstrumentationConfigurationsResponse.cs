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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
        private bool? _changed;
        private string _environment;
        private List<InstrumentationConfigurationWithoutServiceEnv> _latestConfigurations = AWSConfigs.InitializeCollections ? new List<InstrumentationConfigurationWithoutServiceEnv>() : null;
        private string _nextToken;
        private string _service;
        private DateTime? _syncedAt;
        private int? _syncInterval;

        /// <summary>
        /// Gets and sets the property Changed. 
        /// <para>
        /// Indicates whether there are configuration changes since the provided <c>SyncedAt</c>
        /// timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Changed
        {
            get { return this._changed; }
            set { this._changed = value; }
        }

        // Check to see if Changed property is set
        internal bool IsSetChanged()
        {
            return this._changed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment associated with the returned configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property LatestConfigurations. 
        /// <para>
        /// The current set of active instrumentation configurations for the service and environment.
        /// Items omit service and environment because they are provided in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstrumentationConfigurationWithoutServiceEnv> LatestConfigurations
        {
            get { return this._latestConfigurations; }
            set { this._latestConfigurations = value; }
        }

        // Check to see if LatestConfigurations property is set
        internal bool IsSetLatestConfigurations()
        {
            return this._latestConfigurations != null && (this._latestConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token to continue listing configurations when more results are available.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service name associated with the returned configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property SyncedAt. 
        /// <para>
        /// The server timestamp to supply on the next sync call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SyncedAt
        {
            get { return this._syncedAt; }
            set { this._syncedAt = value; }
        }

        // Check to see if SyncedAt property is set
        internal bool IsSetSyncedAt()
        {
            return this._syncedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SyncInterval. 
        /// <para>
        /// The suggested number of seconds to wait before the next sync request. This is at least
        /// 60 seconds to prevent excessive polling.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60)]
        public int? SyncInterval
        {
            get { return this._syncInterval; }
            set { this._syncInterval = value; }
        }

        // Check to see if SyncInterval property is set
        internal bool IsSetSyncInterval()
        {
            return this._syncInterval.HasValue; 
        }

    }
}