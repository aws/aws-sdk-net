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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the location of snapshot data for a snapshot operation.
    /// </summary>
    public partial class SnapshotOperationLocationDescription
    {
        /// <summary>
        /// Gets and sets the property LocationType. 
        /// <para>
        /// The type of the location. The only supported value is <c>S3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageLocationType LocationType { get; set; }

        /// <summary>
        /// Checks to see if the LocationType property is set.
        /// </summary>
        internal bool IsSetLocationType() => this.LocationType != null;

        /// <summary>
        /// Gets and sets the property S3PrefixLocation. 
        /// <para>
        /// Describes the Amazon S3 bucket and key prefix of the location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnapshotOperationS3PrefixLocation S3PrefixLocation { get; set; }

        /// <summary>
        /// Checks to see if the S3PrefixLocation property is set.
        /// </summary>
        internal bool IsSetS3PrefixLocation() => this.S3PrefixLocation != null;
    }
}
