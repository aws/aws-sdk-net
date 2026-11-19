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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Summary of the information about a CloudFront origin access identity.
    /// </summary>
    public partial class CloudFrontOriginAccessIdentitySummary
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CloudFrontOriginAccessIdentitySummary() { }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment for this origin access identity, as originally specified when created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for the origin access identity. For example: <c>E74FTE3AJFJ256A</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property S3CanonicalUserId. 
        /// <para>
        /// The Amazon S3 canonical user ID for the origin access identity, which you use when
        /// giving the origin access identity read permission to an object in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string S3CanonicalUserId { get; set; }

        /// <summary>
        /// Checks to see if the S3CanonicalUserId property is set.
        /// </summary>
        internal bool IsSetS3CanonicalUserId() => this.S3CanonicalUserId != null;
    }
}
