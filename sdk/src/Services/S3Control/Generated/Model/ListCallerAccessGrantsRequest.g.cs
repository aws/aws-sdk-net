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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the ListCallerAccessGrants operation. Use this API
    /// to list the access grants that grant the caller access to Amazon S3 data through S3
    /// Access Grants. The caller (grantee) can be an Identity and Access Management (IAM)
    /// identity or Amazon Web Services Identity Center corporate directory identity. You
    /// must pass the Amazon Web Services account of the S3 data owner (grantor) in the request.
    /// By default, S3 Access Grants returns grants from the instance of the Amazon Web Services
    /// account ID in the request. To return grants from all instances shared with the caller's
    /// account through Amazon Web Services Resource Access Manager (RAM), set the <c>InstanceScope</c>
    /// parameter to <c>ALL</c>. You can, optionally, narrow the results by <c>GrantScope</c>,
    /// using a fragment of the data's S3 path, and S3 Access Grants will return only the
    /// grants with a path that contains the path fragment. You can also pass the <c>AllowedByApplication</c>
    /// filter in the request, which returns only the grants authorized for applications,
    /// whether the application is the caller's Identity Center application or any other application
    /// (<c>ALL</c>). For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-grants-list-grants.html">List
    /// the caller's access grants</a> in the <i>Amazon S3 User Guide</i>. <dl> <dt>Permissions</dt>
    /// <dd> <para> You must have the <c>s3:ListCallerAccessGrants</c> permission to use this
    /// operation. </para> </dd> </dl>
    /// </summary>
    public partial class ListCallerAccessGrantsRequest : AmazonS3ControlRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the S3 Access Grants instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AllowedByApplication. 
        /// <para>
        /// If this optional parameter is passed in the request, a filter is applied to the results.
        /// The results will include only the access grants for the caller's Identity Center application
        /// or for any other applications (<c>ALL</c>).
        /// </para>
        /// </summary>
        public bool? AllowedByApplication { get; set; }

        /// <summary>
        /// Checks to see if the AllowedByApplication property is set.
        /// </summary>
        internal bool IsSetAllowedByApplication() => this.AllowedByApplication.HasValue;

        /// <summary>
        /// Gets and sets the property GrantScope. 
        /// <para>
        /// The S3 path of the data that you would like to access. Must start with <c>s3://</c>.
        /// You can optionally pass only the beginning characters of a path, and S3 Access Grants
        /// will search for all applicable grants for the path fragment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string GrantScope { get; set; }

        /// <summary>
        /// Checks to see if the GrantScope property is set.
        /// </summary>
        internal bool IsSetGrantScope() => this.GrantScope != null;

        /// <summary>
        /// Gets and sets the property InstanceScope. 
        /// <para>
        /// The scope of S3 Access Grants instances to list grants from.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SELF</c> – Lists grants from the instance of the Amazon Web Services account ID
        /// in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> – Lists grants from the instance of the Amazon Web Services account ID
        /// in the request and all instances shared with the caller's account through Amazon Web
        /// Services Resource Access Manager (RAM).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceScope InstanceScope { get; set; }

        /// <summary>
        /// Checks to see if the InstanceScope property is set.
        /// </summary>
        internal bool IsSetInstanceScope() => this.InstanceScope != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of access grants that you would like returned in the <c>List Caller
        /// Access Grants</c> response. If the results include the pagination token <c>NextToken</c>,
        /// make another call using the <c>NextToken</c> to determine if there are more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token to request the next page of results. Pass this value into a subsequent
        /// <c>List Caller Access Grants</c> request in order to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
