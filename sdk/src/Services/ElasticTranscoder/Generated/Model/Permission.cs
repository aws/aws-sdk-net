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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <code>Permission</code> structure.
    /// </summary>
    public partial class Permission
    {
        private List<string> _access = new List<string>();
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
        ///  <code>READ</code>: The grantee can read the thumbnails and metadata for thumbnails
        /// that Elastic Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>READ_ACP</code>: The grantee can read the object ACL for thumbnails that Elastic
        /// Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WRITE_ACP</code>: The grantee can write the ACL for the thumbnails that Elastic
        /// Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FULL_CONTROL</code>: The grantee has READ, READ_ACP, and WRITE_ACP permissions
        /// for the thumbnails that Elastic Transcoder adds to the Amazon S3 bucket.
        /// </para>
        ///  </li> </ul>
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
            return this._access != null && this._access.Count > 0; 
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
        ///  <code>Canonical</code>: Either the canonical user ID for an AWS account or an origin
        /// access identity for an Amazon CloudFront distribution.
        /// </para>
        ///  <important> 
        /// <para>
        /// A canonical user ID is not the same as an AWS account number.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <code>Email</code>: The registered email address of an AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Group</code>: One of the following predefined Amazon S3 groups: <code>AllUsers</code>,
        /// <code>AuthenticatedUsers</code>, or <code>LogDelivery</code>.
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