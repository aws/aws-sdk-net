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

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the ListSigningJobs operation. Lists all your signing
    /// jobs. You can use the <c>maxResults</c> parameter to limit the number of signing jobs
    /// that are returned in the response. If additional jobs remain to be listed, AWS Signer
    /// returns a <c>nextToken</c> value. Use this value in subsequent calls to <c>ListSigningJobs</c>
    /// to fetch the remaining values. You can continue calling <c>ListSigningJobs</c> with
    /// your <c>maxResults</c> parameter and with new values that Signer returns in the <c>nextToken</c>
    /// parameter until all of your signing jobs have been returned.
    /// </summary>
    public partial class ListSigningJobsRequest : AmazonSignerRequest
    {
        /// <summary>
        /// Gets and sets the property IsRevoked. 
        /// <para>
        /// Filters results to return only signing jobs with revoked signatures.
        /// </para>
        /// </summary>
        public bool? IsRevoked { get; set; }

        /// <summary>
        /// Checks to see if the IsRevoked property is set.
        /// </summary>
        internal bool IsSetIsRevoked() => this.IsRevoked.HasValue;

        /// <summary>
        /// Gets and sets the property JobInvoker. 
        /// <para>
        /// Filters results to return only signing jobs initiated by a specified IAM entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string JobInvoker { get; set; }

        /// <summary>
        /// Checks to see if the JobInvoker property is set.
        /// </summary>
        internal bool IsSetJobInvoker() => this.JobInvoker != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of items to return in the response. Use this parameter
        /// when paginating results. If additional items exist beyond the number you specify,
        /// the <c>nextToken</c> element is set in the response. Use the <c>nextToken</c> value
        /// in a subsequent request to retrieve additional items. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// String for specifying the next set of paginated results to return. After you receive
        /// a response with truncated results, use this parameter in a subsequent request. Set
        /// it to the value of <c>nextToken</c> from the response that you just received.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The ID of microcontroller platform that you specified for the distribution of your
        /// code image.
        /// </para>
        /// </summary>
        public string PlatformId { get; set; }

        /// <summary>
        /// Checks to see if the PlatformId property is set.
        /// </summary>
        internal bool IsSetPlatformId() => this.PlatformId != null;

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The IAM principal that requested the signing job.
        /// </para>
        /// </summary>
        public string RequestedBy { get; set; }

        /// <summary>
        /// Checks to see if the RequestedBy property is set.
        /// </summary>
        internal bool IsSetRequestedBy() => this.RequestedBy != null;

        /// <summary>
        /// Gets and sets the property SignatureExpiresAfter. 
        /// <para>
        /// Filters results to return only signing jobs with signatures expiring after a specified
        /// timestamp.
        /// </para>
        /// </summary>
        public DateTime? SignatureExpiresAfter { get; set; }

        /// <summary>
        /// Checks to see if the SignatureExpiresAfter property is set.
        /// </summary>
        internal bool IsSetSignatureExpiresAfter() => this.SignatureExpiresAfter.HasValue;

        /// <summary>
        /// Gets and sets the property SignatureExpiresBefore. 
        /// <para>
        /// Filters results to return only signing jobs with signatures expiring before a specified
        /// timestamp.
        /// </para>
        /// </summary>
        public DateTime? SignatureExpiresBefore { get; set; }

        /// <summary>
        /// Checks to see if the SignatureExpiresBefore property is set.
        /// </summary>
        internal bool IsSetSignatureExpiresBefore() => this.SignatureExpiresBefore.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status value with which to filter your results.
        /// </para>
        /// </summary>
        public SigningStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
