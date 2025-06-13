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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The metadata table configuration for a general purpose bucket.
    /// </summary>
    public partial class MetadataTableConfiguration
    {
        private S3TablesDestination _s3TablesDestination;

        /// <summary>
        /// Gets and sets the property S3TablesDestination. 
        /// <para>
        ///  The destination information for the metadata table configuration. The destination
        /// table bucket must be in the same Region and Amazon Web Services account as the general
        /// purpose bucket. The specified metadata table name must be unique within the <c>aws_s3_metadata</c>
        /// namespace in the destination table bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3TablesDestination S3TablesDestination
        {
            get { return this._s3TablesDestination; }
            set { this._s3TablesDestination = value; }
        }

        // Check to see if S3TablesDestination property is set
        internal bool IsSetS3TablesDestination()
        {
            return this._s3TablesDestination != null;
        }

    }
}