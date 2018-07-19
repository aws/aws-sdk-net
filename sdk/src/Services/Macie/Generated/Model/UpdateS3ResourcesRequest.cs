/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateS3Resources operation.
    /// Updates the classification types for the specified S3 resources. If memberAccountId
    /// isn't specified, the action updates the classification types of the S3 resources associated
    /// with Amazon Macie for the current master account. If memberAccountId is specified,
    /// the action updates the classification types of the S3 resources associated with Amazon
    /// Macie for the specified member account.
    /// </summary>
    public partial class UpdateS3ResourcesRequest : AmazonMacieRequest
    {
        private string _memberAccountId;
        private List<S3ResourceClassificationUpdate> _s3ResourcesUpdate = new List<S3ResourceClassificationUpdate>();

        /// <summary>
        /// Gets and sets the property MemberAccountId. 
        /// <para>
        /// The AWS ID of the Amazon Macie member account whose S3 resources' classification types
        /// you want to update. 
        /// </para>
        /// </summary>
        public string MemberAccountId
        {
            get { return this._memberAccountId; }
            set { this._memberAccountId = value; }
        }

        // Check to see if MemberAccountId property is set
        internal bool IsSetMemberAccountId()
        {
            return this._memberAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property S3ResourcesUpdate. 
        /// <para>
        /// The S3 resources whose classification types you want to update.
        /// </para>
        /// </summary>
        public List<S3ResourceClassificationUpdate> S3ResourcesUpdate
        {
            get { return this._s3ResourcesUpdate; }
            set { this._s3ResourcesUpdate = value; }
        }

        // Check to see if S3ResourcesUpdate property is set
        internal bool IsSetS3ResourcesUpdate()
        {
            return this._s3ResourcesUpdate != null && this._s3ResourcesUpdate.Count > 0; 
        }

    }
}