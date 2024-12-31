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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetSegmentEstimate operation.
    /// </summary>
    public partial class GetSegmentEstimateResponse : AmazonWebServiceResponse
    {
        private string _domainName;
        private string _estimate;
        private string _estimateId;
        private string _message;
        private EstimateStatus _status;
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Estimate. 
        /// <para>
        /// The estimated number of profiles contained in the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Estimate
        {
            get { return this._estimate; }
            set { this._estimate = value; }
        }

        // Check to see if Estimate property is set
        internal bool IsSetEstimate()
        {
            return this._estimate != null;
        }

        /// <summary>
        /// Gets and sets the property EstimateId. 
        /// <para>
        /// The <c>QueryId</c> which is the same as the value passed in <c>QueryId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EstimateId
        {
            get { return this._estimateId; }
            set { this._estimateId = value; }
        }

        // Check to see if EstimateId property is set
        internal bool IsSetEstimateId()
        {
            return this._estimateId != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error message if there is any error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the query.
        /// </para>
        /// </summary>
        public EstimateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code of the segment estimate.
        /// </para>
        /// </summary>
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}