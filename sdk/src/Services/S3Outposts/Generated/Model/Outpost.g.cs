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

namespace Amazon.S3Outposts.Model
{
    /// <summary>
    /// Contains the details for the Outpost object.
    /// </summary>
    public partial class Outpost
    {
        /// <summary>
        /// Gets and sets the property CapacityInBytes. 
        /// <para>
        /// The Amazon S3 capacity of the outpost in bytes.
        /// </para>
        /// </summary>
        public long? CapacityInBytes { get; set; }

        /// <summary>
        /// Checks to see if the CapacityInBytes property is set.
        /// </summary>
        internal bool IsSetCapacityInBytes() => this.CapacityInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) for the outpost.
        /// </para>
        /// </summary>
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// Specifies the unique identifier for the outpost.
        /// </para>
        /// </summary>
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// Returns the Amazon Web Services account ID of the outpost owner. Useful for comparing
        /// owned versus shared outposts.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property S3OutpostArn. 
        /// <para>
        /// Specifies the unique S3 on Outposts ARN for use with Resource Access Manager (RAM).
        /// </para>
        /// </summary>
        public string S3OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the S3OutpostArn property is set.
        /// </summary>
        internal bool IsSetS3OutpostArn() => this.S3OutpostArn != null;
    }
}
