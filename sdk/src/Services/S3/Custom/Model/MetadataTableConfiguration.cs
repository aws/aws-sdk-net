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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// <para>
    /// The metadata table configuration for a general purpose bucket.
    /// </para>
    /// </summary>
    public class MetadataTableConfiguration
    {
        private S3TablesDestination s3TablesDestination;

        /// <summary>
        /// <para>
        /// The destination information for the metadata table configuration. The destination table bucket
        /// must be in the same Region and Amazon Web Services account as the general purpose bucket. The specified metadata
        /// table name must be unique within the <c>aws_s3_metadata</c> namespace in the destination 
        /// table bucket.
        /// </para>
        /// </summary>
        public S3TablesDestination S3TablesDestination
        {
            get { return this.s3TablesDestination; }
            set { this.s3TablesDestination = value; }
        }

        internal bool IsSetS3TablesDestination()
        {
            return s3TablesDestination != null;
        }
    }
}
