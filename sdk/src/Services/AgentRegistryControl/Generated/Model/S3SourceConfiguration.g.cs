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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// The settings of a source that the registry reads from Amazon S3.
    /// </summary>
    public partial class S3SourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property BucketOwnerAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the source bucket. The registry
        /// checks that the bucket belongs to this account each time it reads the source. If you
        /// omit it for a source that uses an IAM role, the registry expects the bucket to be
        /// in the role's account. If you omit it for a source that has no credential provider,
        /// which the registry reads as a public object, the request fails with a <c>ValidationException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string BucketOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the BucketOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetBucketOwnerAccountId() => this.BucketOwnerAccountId != null;
    }
}
