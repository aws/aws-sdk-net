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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains additional information about the verification status for the
    /// identity.
    /// </summary>
    public partial class VerificationInfo
    {
        private VerificationError _errorType;
        private DateTime? _lastCheckedTimestamp;
        private DateTime? _lastSuccessTimestamp;
        private SOARecord _soaRecord;

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        /// Provides the reason for the failure describing why Amazon SES was not able to successfully
        /// verify the identity. Below are the possible values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INVALID_VALUE</c> – Amazon SES was able to find the record, but the value contained
        /// within the record was invalid. Ensure you have published the correct values for the
        /// record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TYPE_NOT_FOUND</c> – The queried hostname exists but does not have the requested
        /// type of DNS record. Ensure that you have published the correct type of DNS record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOST_NOT_FOUND</c> – The queried hostname does not exist or was not reachable
        /// at the time of the request. Ensure that you have published the required DNS record(s).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE_ERROR</c> – A temporary issue is preventing Amazon SES from determining
        /// the verification status of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DNS_SERVER_ERROR</c> – The DNS server encountered an issue and was unable to complete
        /// the request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VerificationError ErrorType
        {
            get { return this._errorType; }
            set { this._errorType = value; }
        }

        // Check to see if ErrorType property is set
        internal bool IsSetErrorType()
        {
            return this._errorType != null;
        }

        /// <summary>
        /// Gets and sets the property LastCheckedTimestamp. 
        /// <para>
        /// The last time a verification attempt was made for this identity.
        /// </para>
        /// </summary>
        public DateTime? LastCheckedTimestamp
        {
            get { return this._lastCheckedTimestamp; }
            set { this._lastCheckedTimestamp = value; }
        }

        // Check to see if LastCheckedTimestamp property is set
        internal bool IsSetLastCheckedTimestamp()
        {
            return this._lastCheckedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessTimestamp. 
        /// <para>
        /// The last time a successful verification was made for this identity.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessTimestamp
        {
            get { return this._lastSuccessTimestamp; }
            set { this._lastSuccessTimestamp = value; }
        }

        // Check to see if LastSuccessTimestamp property is set
        internal bool IsSetLastSuccessTimestamp()
        {
            return this._lastSuccessTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SOARecord. 
        /// <para>
        /// An object that contains information about the start of authority (SOA) record associated
        /// with the identity.
        /// </para>
        /// </summary>
        public SOARecord SOARecord
        {
            get { return this._soaRecord; }
            set { this._soaRecord = value; }
        }

        // Check to see if SOARecord property is set
        internal bool IsSetSOARecord()
        {
            return this._soaRecord != null;
        }

    }
}