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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the destination Amazon Simple Storage Service (Amazon S3) bucket name and
    /// object keys of a recommendations export file, and its associated metadata file.
    /// </summary>
    public partial class S3Destination
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket used as the destination of an export file.
        /// </para>
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The Amazon S3 bucket key of an export file.
        /// </para>
        ///  
        /// <para>
        /// The key uniquely identifies the object, or export file, in the S3 bucket.
        /// </para>
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property MetadataKey. 
        /// <para>
        /// The Amazon S3 bucket key of a metadata file.
        /// </para>
        ///  
        /// <para>
        /// The key uniquely identifies the object, or metadata file, in the S3 bucket.
        /// </para>
        /// </summary>
        public string MetadataKey { get; set; }

        /// <summary>
        /// Checks to see if the MetadataKey property is set.
        /// </summary>
        internal bool IsSetMetadataKey() => this.MetadataKey != null;
    }
}
