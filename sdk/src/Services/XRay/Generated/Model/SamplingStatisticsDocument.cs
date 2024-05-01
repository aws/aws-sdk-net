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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Request sampling results for a single rule from a service. Results are for the last
    /// 10 seconds unless the service has been assigned a longer reporting interval after
    /// a previous call to <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingTargets.html">GetSamplingTargets</a>.
    /// </summary>
    public partial class SamplingStatisticsDocument
    {
        private int? _borrowCount;
        private string _clientID;
        private int? _requestCount;
        private string _ruleName;
        private int? _sampledCount;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property BorrowCount. 
        /// <para>
        /// The number of requests recorded with borrowed reservoir quota.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? BorrowCount
        {
            get { return this._borrowCount; }
            set { this._borrowCount = value; }
        }

        // Check to see if BorrowCount property is set
        internal bool IsSetBorrowCount()
        {
            return this._borrowCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientID. 
        /// <para>
        /// A unique identifier for the service in hexadecimal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=24)]
        public string ClientID
        {
            get { return this._clientID; }
            set { this._clientID = value; }
        }

        // Check to see if ClientID property is set
        internal bool IsSetClientID()
        {
            return this._clientID != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCount. 
        /// <para>
        /// The number of requests that matched the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? RequestCount
        {
            get { return this._requestCount; }
            set { this._requestCount = value; }
        }

        // Check to see if RequestCount property is set
        internal bool IsSetRequestCount()
        {
            return this._requestCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the sampling rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property SampledCount. 
        /// <para>
        /// The number of requests recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? SampledCount
        {
            get { return this._sampledCount; }
            set { this._sampledCount = value; }
        }

        // Check to see if SampledCount property is set
        internal bool IsSetSampledCount()
        {
            return this._sampledCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The current time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}