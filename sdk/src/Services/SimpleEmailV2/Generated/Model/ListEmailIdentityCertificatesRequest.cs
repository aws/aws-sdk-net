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
    /// Container for the parameters to the ListEmailIdentityCertificates operation.
    /// Lists the S/MIME certificates that are associated with the specified email identity.
    /// The results include certificates in all states, such as <c>PROVISIONING</c>, <c>ACTIVE</c>,
    /// <c>INACTIVE</c>, <c>DEPROVISIONING</c>, and <c>FAILED</c>.
    /// 
    ///  
    /// <para>
    /// If a certificate has passed its expiration time, it's returned with a status of <c>FAILED</c>.
    /// </para>
    ///  
    /// <para>
    /// We recommend using pagination to ensure that the operation returns quickly and successfully.
    /// When there are more results than fit in a single response, the response includes a
    /// <c>NextToken</c> value that you use in a subsequent call to retrieve the next set
    /// of results.
    /// </para>
    /// </summary>
    public partial class ListEmailIdentityCertificatesRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _emailIdentity;
        private string _nextToken;
        private int? _pageSize;

        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The email identity whose certificate associations you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string EmailIdentity
        {
            get { return this._emailIdentity; }
            set { this._emailIdentity = value; }
        }

        // Check to see if EmailIdentity property is set
        internal bool IsSetEmailIdentity()
        {
            return this._emailIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token returned from a previous call to <c>ListEmailIdentityCertificates</c> to indicate
        /// the position in the list of certificates.
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
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of results to show in a single call to <c>ListEmailIdentityCertificates</c>.
        /// If the number of results is larger than the number you specified in this parameter,
        /// then the response includes a <c>NextToken</c> element, which you can use to obtain
        /// additional results.
        /// </para>
        /// </summary>
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

    }
}