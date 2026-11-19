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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about data that GuardDuty retrieved during an investigation,
    /// including what GuardDuty requested and what it received.
    /// </summary>
    public partial class FetchRecord
    {
        /// <summary>
        /// Gets and sets the property FetchType. 
        /// <para>
        /// The kind of data that GuardDuty retrieved. The value determines which members of <c>Query</c>
        /// and <c>Result</c> can be set. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FINDINGS</c> – GuardDuty findings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DETECTOR</c> – The configuration of a GuardDuty detector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPUTATION</c> – Reputation information about a threat indicator, such as an IP
        /// address, a domain, or a file hash.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINDING_TYPE_DOCUMENTATION</c> – The documentation for a finding type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLOUD_TRAIL_RAW_EVENTS</c> – Amazon Web Services CloudTrail events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNTIME_SIGNALS</c> – Runtime signals.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEMBER_ACCOUNTS</c> – A list of member accounts.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FetchType FetchType { get; set; }

        /// <summary>
        /// Checks to see if the FetchType property is set.
        /// </summary>
        internal bool IsSetFetchType() => this.FetchType != null;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The request that GuardDuty made. Not every record includes a query.
        /// </para>
        /// </summary>
        public FetchQuery Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The data that GuardDuty received in response to the request. Not every record includes
        /// a result.
        /// </para>
        /// </summary>
        public FetchResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;
    }
}
