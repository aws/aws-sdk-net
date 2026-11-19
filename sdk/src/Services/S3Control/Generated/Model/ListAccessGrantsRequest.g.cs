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
    /// Container for the parameters to the ListAccessGrants operation. Returns the list of
    /// access grants in your S3 Access Grants instance. <dl> <dt>Permissions</dt> <dd> <para>
    /// You must have the <c>s3:ListAccessGrants</c> permission to use this operation. </para>
    /// </dd> </dl>
    /// </summary>
    public partial class ListAccessGrantsRequest : AmazonS3ControlRequest
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
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Web Services IAM Identity Center application
        /// associated with your Identity Center instance. If the grant includes an application
        /// ARN, the grantee can only access the S3 data through this application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property GrantScope. 
        /// <para>
        /// The S3 path of the data to which you are granting access. It is the result of appending
        /// the <c>Subprefix</c> to the location scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string GrantScope { get; set; }

        /// <summary>
        /// Checks to see if the GrantScope property is set.
        /// </summary>
        internal bool IsSetGrantScope() => this.GrantScope != null;

        /// <summary>
        /// Gets and sets the property GranteeIdentifier. 
        /// <para>
        /// The unique identifer of the <c>Grantee</c>. If the grantee type is <c>IAM</c>, the
        /// identifier is the IAM Amazon Resource Name (ARN) of the user or role. If the grantee
        /// type is a directory user or group, the identifier is 128-bit universally unique identifier
        /// (UUID) in the format <c>a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c>. You can obtain this
        /// UUID from your Amazon Web Services IAM Identity Center instance.
        /// </para>
        /// </summary>
        public string GranteeIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GranteeIdentifier property is set.
        /// </summary>
        internal bool IsSetGranteeIdentifier() => this.GranteeIdentifier != null;

        /// <summary>
        /// Gets and sets the property GranteeType. 
        /// <para>
        /// The type of the grantee to which access has been granted. It can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IAM</c> - An IAM user or role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIRECTORY_USER</c> - Your corporate directory user. You can use this option if
        /// you have added your corporate identity directory to IAM Identity Center and associated
        /// the IAM Identity Center instance with your S3 Access Grants instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIRECTORY_GROUP</c> - Your corporate directory group. You can use this option
        /// if you have added your corporate identity directory to IAM Identity Center and associated
        /// the IAM Identity Center instance with your S3 Access Grants instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GranteeType GranteeType { get; set; }

        /// <summary>
        /// Checks to see if the GranteeType property is set.
        /// </summary>
        internal bool IsSetGranteeType() => this.GranteeType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of access grants that you would like returned in the <c>List Access
        /// Grants</c> response. If the results include the pagination token <c>NextToken</c>,
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
        /// <c>List Access Grants</c> request in order to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The type of permission granted to your S3 data, which can be set to one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READ</c> – Grant read-only access to the S3 data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WRITE</c> – Grant write-only access to the S3 data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READWRITE</c> – Grant both read and write access to the S3 data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Permission Permission { get; set; }

        /// <summary>
        /// Checks to see if the Permission property is set.
        /// </summary>
        internal bool IsSetPermission() => this.Permission != null;
    }
}
