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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
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
namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the ListSigningJobs operation.
    /// Lists all your signing jobs. You can use the <c>maxResults</c> parameter to limit
    /// the number of signing jobs that are returned in the response. If additional jobs remain
    /// to be listed, AWS Signer returns a <c>nextToken</c> value. Use this value in subsequent
    /// calls to <c>ListSigningJobs</c> to fetch the remaining values. You can continue calling
    /// <c>ListSigningJobs</c> with your <c>maxResults</c> parameter and with new values that
    /// Signer returns in the <c>nextToken</c> parameter until all of your signing jobs have
    /// been returned.
    /// </summary>
    public partial class ListSigningJobsRequest : AmazonSignerRequest
    {
        private bool? _isRevoked;
        private string _jobInvoker;
        private int? _maxResults;
        private string _nextToken;
        private string _platformId;
        private string _requestedBy;
        private DateTime? _signatureExpiresAfter;
        private DateTime? _signatureExpiresBefore;
        private SigningStatus _status;

        /// <summary>
        /// Gets and sets the property IsRevoked. 
        /// <para>
        /// Filters results to return only signing jobs with revoked signatures.
        /// </para>
        /// </summary>
        public bool? IsRevoked
        {
            get { return this._isRevoked; }
            set { this._isRevoked = value; }
        }

        // Check to see if IsRevoked property is set
        internal bool IsSetIsRevoked()
        {
            return this._isRevoked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobInvoker. 
        /// <para>
        /// Filters results to return only signing jobs initiated by a specified IAM entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string JobInvoker
        {
            get { return this._jobInvoker; }
            set { this._jobInvoker = value; }
        }

        // Check to see if JobInvoker property is set
        internal bool IsSetJobInvoker()
        {
            return this._jobInvoker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of items to return in the response. Use this parameter
        /// when paginating results. If additional items exist beyond the number you specify,
        /// the <c>nextToken</c> element is set in the response. Use the <c>nextToken</c> value
        /// in a subsequent request to retrieve additional items. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        /// String for specifying the next set of paginated results to return. After you receive
        /// a response with truncated results, use this parameter in a subsequent request. Set
        /// it to the value of <c>nextToken</c> from the response that you just received.
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
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The ID of microcontroller platform that you specified for the distribution of your
        /// code image.
        /// </para>
        /// </summary>
        public string PlatformId
        {
            get { return this._platformId; }
            set { this._platformId = value; }
        }

        // Check to see if PlatformId property is set
        internal bool IsSetPlatformId()
        {
            return this._platformId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The IAM principal that requested the signing job.
        /// </para>
        /// </summary>
        public string RequestedBy
        {
            get { return this._requestedBy; }
            set { this._requestedBy = value; }
        }

        // Check to see if RequestedBy property is set
        internal bool IsSetRequestedBy()
        {
            return this._requestedBy != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureExpiresAfter. 
        /// <para>
        /// Filters results to return only signing jobs with signatures expiring after a specified
        /// timestamp.
        /// </para>
        /// </summary>
        public DateTime? SignatureExpiresAfter
        {
            get { return this._signatureExpiresAfter; }
            set { this._signatureExpiresAfter = value; }
        }

        // Check to see if SignatureExpiresAfter property is set
        internal bool IsSetSignatureExpiresAfter()
        {
            return this._signatureExpiresAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SignatureExpiresBefore. 
        /// <para>
        /// Filters results to return only signing jobs with signatures expiring before a specified
        /// timestamp.
        /// </para>
        /// </summary>
        public DateTime? SignatureExpiresBefore
        {
            get { return this._signatureExpiresBefore; }
            set { this._signatureExpiresBefore = value; }
        }

        // Check to see if SignatureExpiresBefore property is set
        internal bool IsSetSignatureExpiresBefore()
        {
            return this._signatureExpiresBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status value with which to filter your results.
        /// </para>
        /// </summary>
        public SigningStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}