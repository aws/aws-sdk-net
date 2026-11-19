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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// This is the response object from the GetBucket operation.
    /// </summary>
    public partial class GetBucketResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Outposts bucket requested.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date of the Outposts bucket.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property PublicAccessBlockEnabled. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public bool? PublicAccessBlockEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PublicAccessBlockEnabled property is set.
        /// </summary>
        internal bool IsSetPublicAccessBlockEnabled() => this.PublicAccessBlockEnabled.HasValue;
    }
}
