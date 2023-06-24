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
 * Do not modify this file. This file is generated from the cloudtrail-data-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrailData.Model
{
    /// <summary>
    /// This is the response object from the PutAuditEvents operation.
    /// </summary>
    public partial class PutAuditEventsResponse : AmazonWebServiceResponse
    {
        private List<ResultErrorEntry> _failed = new List<ResultErrorEntry>();
        private List<AuditEventResultEntry> _successful = new List<AuditEventResultEntry>();

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// Lists events in the provided event payload that could not be ingested into CloudTrail,
        /// and includes the error code and error message returned for events that could not be
        /// ingested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<ResultErrorEntry> Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed != null && this._failed.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Successful. 
        /// <para>
        /// Lists events in the provided event payload that were successfully ingested into CloudTrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<AuditEventResultEntry> Successful
        {
            get { return this._successful; }
            set { this._successful = value; }
        }

        // Check to see if Successful property is set
        internal bool IsSetSuccessful()
        {
            return this._successful != null && this._successful.Count > 0; 
        }

    }
}