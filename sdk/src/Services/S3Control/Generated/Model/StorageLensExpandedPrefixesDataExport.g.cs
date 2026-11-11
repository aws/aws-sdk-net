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
    /// A container for your S3 Storage Lens expanded prefix metrics report configuration.
    /// Unlike the default Storage Lens metrics report, the enhanced prefix metrics report
    /// includes all S3 Storage Lens storage and activity data related to the full list of
    /// prefixes in your Storage Lens configuration.
    /// </summary>
    public partial class StorageLensExpandedPrefixesDataExport
    {
        /// <summary>
        /// Gets and sets the property S3BucketDestination.
        /// </summary>
        public S3BucketDestination S3BucketDestination { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketDestination property is set.
        /// </summary>
        internal bool IsSetS3BucketDestination() => this.S3BucketDestination != null;

        /// <summary>
        /// Gets and sets the property StorageLensTableDestination. 
        /// <para>
        /// A container for the bucket where the S3 Storage Lens metric export files are located.
        /// At least one export destination must be specified.
        /// </para>
        /// </summary>
        public StorageLensTableDestination StorageLensTableDestination { get; set; }

        /// <summary>
        /// Checks to see if the StorageLensTableDestination property is set.
        /// </summary>
        internal bool IsSetStorageLensTableDestination() => this.StorageLensTableDestination != null;
    }
}
