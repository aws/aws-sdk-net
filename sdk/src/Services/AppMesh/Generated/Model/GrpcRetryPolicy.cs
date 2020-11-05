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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a retry policy. Specify at least one value for at least
    /// one of the types of <code>RetryEvents</code>, a value for <code>maxRetries</code>,
    /// and a value for <code>perRetryTimeout</code>.
    /// </summary>
    public partial class GrpcRetryPolicy
    {
        private List<string> _grpcRetryEvents = new List<string>();
        private List<string> _httpRetryEvents = new List<string>();
        private long? _maxRetries;
        private Duration _perRetryTimeout;
        private List<string> _tcpRetryEvents = new List<string>();

        /// <summary>
        /// Gets and sets the property GrpcRetryEvents. 
        /// <para>
        /// Specify at least one of the valid values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> GrpcRetryEvents
        {
            get { return this._grpcRetryEvents; }
            set { this._grpcRetryEvents = value; }
        }

        // Check to see if GrpcRetryEvents property is set
        internal bool IsSetGrpcRetryEvents()
        {
            return this._grpcRetryEvents != null && this._grpcRetryEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HttpRetryEvents. 
        /// <para>
        /// Specify at least one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>server-error</b> – HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508,
        /// 510, and 511
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>gateway-error</b> – HTTP status codes 502, 503, and 504
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>client-error</b> – HTTP status code 409
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>stream-error</b> – Retry on refused stream
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> HttpRetryEvents
        {
            get { return this._httpRetryEvents; }
            set { this._httpRetryEvents = value; }
        }

        // Check to see if HttpRetryEvents property is set
        internal bool IsSetHttpRetryEvents()
        {
            return this._httpRetryEvents != null && this._httpRetryEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of retry attempts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long MaxRetries
        {
            get { return this._maxRetries.GetValueOrDefault(); }
            set { this._maxRetries = value; }
        }

        // Check to see if MaxRetries property is set
        internal bool IsSetMaxRetries()
        {
            return this._maxRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerRetryTimeout. 
        /// <para>
        /// The timeout for each retry attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Duration PerRetryTimeout
        {
            get { return this._perRetryTimeout; }
            set { this._perRetryTimeout = value; }
        }

        // Check to see if PerRetryTimeout property is set
        internal bool IsSetPerRetryTimeout()
        {
            return this._perRetryTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property TcpRetryEvents. 
        /// <para>
        /// Specify a valid value. The event occurs before any processing of a request has started
        /// and is encountered when the upstream is temporarily or permanently unavailable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> TcpRetryEvents
        {
            get { return this._tcpRetryEvents; }
            set { this._tcpRetryEvents = value; }
        }

        // Check to see if TcpRetryEvents property is set
        internal bool IsSetTcpRetryEvents()
        {
            return this._tcpRetryEvents != null && this._tcpRetryEvents.Count > 0; 
        }

    }
}