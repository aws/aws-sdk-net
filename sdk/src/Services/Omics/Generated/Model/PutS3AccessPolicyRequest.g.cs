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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the PutS3AccessPolicy operation. Adds an access policy
    /// to the specified store.
    /// </summary>
    public partial class PutS3AccessPolicyRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property S3AccessPointArn. 
        /// <para>
        /// The S3 access point ARN where you want to put the access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string S3AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessPointArn property is set.
        /// </summary>
        internal bool IsSetS3AccessPointArn() => this.S3AccessPointArn != null;

        /// <summary>
        /// Gets and sets the property S3AccessPolicy. 
        /// <para>
        /// The resource policy that controls S3 access to the store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100000)]
        public string S3AccessPolicy { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessPolicy property is set.
        /// </summary>
        internal bool IsSetS3AccessPolicy() => this.S3AccessPolicy != null;
    }
}
