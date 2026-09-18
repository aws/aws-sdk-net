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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// provides information about the Amazon S3 Public Access Block configuration for accounts.
    /// </summary>
    public partial class AwsS3AccountPublicAccessBlockDetails
    {
        /// <summary>
        /// Gets and sets the property BlockPublicAcls. 
        /// <para>
        /// Indicates whether to reject calls to update an S3 bucket if the calls include a public
        /// access control list (ACL).
        /// </para>
        /// </summary>
        public bool? BlockPublicAcls { get; set; }

        /// <summary>
        /// Checks to see if the BlockPublicAcls property is set.
        /// </summary>
        internal bool IsSetBlockPublicAcls() => this.BlockPublicAcls.HasValue;

        /// <summary>
        /// Gets and sets the property BlockPublicPolicy. 
        /// <para>
        /// Indicates whether to reject calls to update the access policy for an S3 bucket or
        /// access point if the policy allows public access.
        /// </para>
        /// </summary>
        public bool? BlockPublicPolicy { get; set; }

        /// <summary>
        /// Checks to see if the BlockPublicPolicy property is set.
        /// </summary>
        internal bool IsSetBlockPublicPolicy() => this.BlockPublicPolicy.HasValue;

        /// <summary>
        /// Gets and sets the property IgnorePublicAcls. 
        /// <para>
        /// Indicates whether Amazon S3 ignores public ACLs that are associated with an S3 bucket.
        /// </para>
        /// </summary>
        public bool? IgnorePublicAcls { get; set; }

        /// <summary>
        /// Checks to see if the IgnorePublicAcls property is set.
        /// </summary>
        internal bool IsSetIgnorePublicAcls() => this.IgnorePublicAcls.HasValue;

        /// <summary>
        /// Gets and sets the property RestrictPublicBuckets. 
        /// <para>
        /// Indicates whether to restrict access to an access point or S3 bucket that has a public
        /// policy to only Amazon Web Services service principals and authorized users within
        /// the S3 bucket owner's account.
        /// </para>
        /// </summary>
        public bool? RestrictPublicBuckets { get; set; }

        /// <summary>
        /// Checks to see if the RestrictPublicBuckets property is set.
        /// </summary>
        internal bool IsSetRestrictPublicBuckets() => this.RestrictPublicBuckets.HasValue;
    }
}
