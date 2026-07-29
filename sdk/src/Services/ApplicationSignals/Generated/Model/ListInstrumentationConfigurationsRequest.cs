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
    /// Container for the parameters to the ListInstrumentationConfigurations operation.
    /// Returns all active instrumentation configurations for a service and environment. SDKs
    /// use this operation to sync configurations and apply client-side filters locally.
    /// 
    ///  
    /// <para>
    /// Include the previous <c>SyncedAt</c> value to perform incremental syncs. When no changes
    /// are detected, the response sets <c>Changed</c> to <c>false</c> and omits configuration
    /// details.
    /// </para>
    /// </summary>
    public partial class ListInstrumentationConfigurationsRequest : AmazonApplicationSignalsRequest
    {
        private string _environment;
        private InstrumentationType _instrumentationType;
        private int? _maxResults;
        private string _nextToken;
        private string _service;
        private DateTime? _syncedAt;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment that the service is running in.
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
        /// Gets and sets the property InstrumentationType. 
        /// <para>
        /// Type of instrumentation configuration (BREAKPOINT or PROBE). Required to determine
        /// which backing store to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstrumentationType InstrumentationType
        {
            get { return this._instrumentationType; }
            set { this._instrumentationType = value; }
        }

        // Check to see if InstrumentationType property is set
        internal bool IsSetInstrumentationType()
        {
            return this._instrumentationType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of configurations to return in one call. The default is 50 and
        /// the maximum is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use the token returned by a previous call to retrieve the next page of configurations.
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
        /// The name of the service to retrieve instrumentation configurations for.
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
        /// The timestamp from the last successful sync. When provided, the response returns <c>Changed</c>
        /// as <c>false</c> if nothing is new since this time, or returns the latest configurations
        /// when changes exist.
        /// </para>
        /// </summary>
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

    }
}