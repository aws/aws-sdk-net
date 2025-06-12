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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <c>Permission</c> structure.
    /// </summary>
    public partial class Permission
    {
        private List<string> _access = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _grantee;
        private string _granteeType;

        /// <summary>
        /// Gets and sets the property Access. 
        /// <para>
        ///  The permission that you want to give to the AWS user that is listed in Grantee. Valid
        /// values include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READ</c>: The grantee can read the thumbnails and metadata for thumbnails that
        /// Elastic Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READ_ACP</c>: The grantee can read the object ACL for thumbnails that Elastic
        /// Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WRITE_ACP</c>: The grantee can write the ACL for the thumbnails that Elastic Transcoder
        /// adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FULL_CONTROL</c>: The grantee has READ, READ_ACP, and WRITE_ACP permissions for
        /// the thumbnails that Elastic Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public List<string> Access
        {
            get { return this._access; }
            set { this._access = value; }
        }

        // Check to see if Access property is set
        internal bool IsSetAccess()
        {
            return this._access != null && (this._access.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Grantee. 
        /// <para>
        /// The AWS user or group that you want to have access to transcoded files and playlists.
        /// To identify the user or group, you can specify the canonical user ID for an AWS account,
        /// an origin access identity for a CloudFront distribution, the registered email address
        /// of an AWS account, or a predefined Amazon S3 group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Grantee
        {
            get { return this._grantee; }
            set { this._grantee = value; }
        }

        // Check to see if Grantee property is set
        internal bool IsSetGrantee()
        {
            return this._grantee != null;
        }

        /// <summary>
        /// Gets and sets the property GranteeType. 
        /// <para>
        /// The type of value that appears in the Grantee object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Canonical</c>: Either the canonical user ID for an AWS account or an origin access
        /// identity for an Amazon CloudFront distribution.
        /// </para>
        ///  <important> 
        /// <para>
        /// A canonical user ID is not the same as an AWS account number.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <c>Email</c>: The registered email address of an AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Group</c>: One of the following predefined Amazon S3 groups: <c>AllUsers</c>,
        /// <c>AuthenticatedUsers</c>, or <c>LogDelivery</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string GranteeType
        {
            get { return this._granteeType; }
            set { this._granteeType = value; }
        }

        // Check to see if GranteeType property is set
        internal bool IsSetGranteeType()
        {
            return this._granteeType != null;
        }

    }
}