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
    /// Container for the parameters to the DisassociateS3Resources operation.
    /// Removes specified S3 resources from being monitored by Amazon Macie. If memberAccountId
    /// isn't specified, the action removes specified S3 resources from Macie for the current
    /// master account. If memberAccountId is specified, the action removes specified S3 resources
    /// from Macie for the specified member account.
    /// </summary>
    public partial class DisassociateS3ResourcesRequest : AmazonMacieRequest
    {
        private List<S3Resource> _associateds3Resources = new List<S3Resource>();
        private string _memberAccountId;

        /// <summary>
        /// Gets and sets the property AssociatedS3Resources. 
        /// <para>
        /// The S3 resources (buckets or prefixes) that you want to remove from being monitored
        /// and classified by Amazon Macie. 
        /// </para>
        /// </summary>
        public List<S3Resource> AssociatedS3Resources
        {
            get { return this._associateds3Resources; }
            set { this._associateds3Resources = value; }
        }

        // Check to see if AssociatedS3Resources property is set
        internal bool IsSetAssociatedS3Resources()
        {
            return this._associateds3Resources != null && this._associateds3Resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MemberAccountId. 
        /// <para>
        /// The ID of the Amazon Macie member account whose resources you want to remove from
        /// being monitored by Amazon Macie. 
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

    }
}