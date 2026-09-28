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

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// A batch job identifier in which the batch jobs to run are identified by an Amazon
    /// S3 location.
    /// </summary>
    public partial class S3BatchJobIdentifier
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon S3 bucket that contains the batch job definitions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Identifies the batch job definition. This identifier can also point to any batch job
        /// definition that already exists in the application or to one of the batch job definitions
        /// within the directory that is specified in <c>keyPrefix</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobIdentifier Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// The key prefix that specifies the path to the folder in the S3 bucket that has the
        /// batch job definitions.
        /// </para>
        /// </summary>
        public string KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the KeyPrefix property is set.
        /// </summary>
        internal bool IsSetKeyPrefix() => this.KeyPrefix != null;
    }
}
