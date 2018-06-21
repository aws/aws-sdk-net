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
    /// Container for the parameters to the AssociateS3Resources operation.
    /// Associates specified S3 resources with Amazon Macie for monitoring and data classification.
    /// If memberAccountId isn't specified, the action associates specified S3 resources with
    /// Macie for the current master account. If memberAccountId is specified, the action
    /// associates specified S3 resources with Macie for the specified member account.
    /// </summary>
    public partial class AssociateS3ResourcesRequest : AmazonMacieRequest
    {
        private string _memberAccountId;
        private List<S3ResourceClassification> _s3Resources = new List<S3ResourceClassification>();

        /// <summary>
        /// Gets and sets the property MemberAccountId. 
        /// <para>
        /// The ID of the Amazon Macie member account whose resources you want to associate with
        /// Macie. 
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
        /// Gets and sets the property S3Resources. 
        /// <para>
        /// The S3 resources that you want to associate with Amazon Macie for monitoring and data
        /// classification. 
        /// </para>
        /// </summary>
        public List<S3ResourceClassification> S3Resources
        {
            get { return this._s3Resources; }
            set { this._s3Resources = value; }
        }

        // Check to see if S3Resources property is set
        internal bool IsSetS3Resources()
        {
            return this._s3Resources != null && this._s3Resources.Count > 0; 
        }

    }
}