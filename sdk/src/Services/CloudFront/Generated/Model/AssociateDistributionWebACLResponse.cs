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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the AssociateDistributionWebACL operation.
    /// </summary>
    public partial class AssociateDistributionWebACLResponse : AmazonWebServiceResponse
    {
        private string _eTag;
        private string _id;
        private string _webACLArn;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version of the distribution.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the distribution.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property WebACLArn. 
        /// <para>
        /// The ARN of the WAF web ACL that you associated with the distribution.
        /// </para>
        /// </summary>
        public string WebACLArn
        {
            get { return this._webACLArn; }
            set { this._webACLArn = value; }
        }

        // Check to see if WebACLArn property is set
        internal bool IsSetWebACLArn()
        {
            return this._webACLArn != null;
        }

    }
}