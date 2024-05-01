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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Details about clients using the deprecated resources.
    /// </summary>
    public partial class ClientStat
    {
        private DateTime? _lastRequestTime;
        private int? _numberOfRequestsLast30Days;
        private string _userAgent;

        /// <summary>
        /// Gets and sets the property LastRequestTime. 
        /// <para>
        /// The timestamp of the last request seen from the Kubernetes client.
        /// </para>
        /// </summary>
        public DateTime? LastRequestTime
        {
            get { return this._lastRequestTime; }
            set { this._lastRequestTime = value; }
        }

        // Check to see if LastRequestTime property is set
        internal bool IsSetLastRequestTime()
        {
            return this._lastRequestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRequestsLast30Days. 
        /// <para>
        /// The number of requests from the Kubernetes client seen over the last 30 days.
        /// </para>
        /// </summary>
        public int? NumberOfRequestsLast30Days
        {
            get { return this._numberOfRequestsLast30Days; }
            set { this._numberOfRequestsLast30Days = value; }
        }

        // Check to see if NumberOfRequestsLast30Days property is set
        internal bool IsSetNumberOfRequestsLast30Days()
        {
            return this._numberOfRequestsLast30Days.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The user agent of the Kubernetes client using the deprecated resource.
        /// </para>
        /// </summary>
        public string UserAgent
        {
            get { return this._userAgent; }
            set { this._userAgent = value; }
        }

        // Check to see if UserAgent property is set
        internal bool IsSetUserAgent()
        {
            return this._userAgent != null;
        }

    }
}