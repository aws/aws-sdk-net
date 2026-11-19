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
    /// Describes the source of an enhanced snapshot. For a snapshot that was created from
    /// an application, <c>SourceApplicationDescription</c> is present. For an imported snapshot,
    /// <c>S3PrefixLocation</c> is present.
    /// </summary>
    public partial class SnapshotSourceDescription
    {
        /// <summary>
        /// Gets and sets the property S3PrefixLocation. 
        /// <para>
        /// The Amazon S3 location that the snapshot was imported from. This field is present
        /// only if <c>SnapshotInitiatorOperation</c> is <c>ImportSnapshot</c>.
        /// </para>
        /// </summary>
        public S3PrefixLocation S3PrefixLocation { get; set; }

        /// <summary>
        /// Checks to see if the S3PrefixLocation property is set.
        /// </summary>
        internal bool IsSetS3PrefixLocation() => this.S3PrefixLocation != null;

        /// <summary>
        /// Gets and sets the property SourceApplicationDescription. 
        /// <para>
        /// Describes the application that the snapshot was created from. This field is not present
        /// for imported snapshots.
        /// </para>
        /// </summary>
        public SourceApplicationDescription SourceApplicationDescription { get; set; }

        /// <summary>
        /// Checks to see if the SourceApplicationDescription property is set.
        /// </summary>
        internal bool IsSetSourceApplicationDescription() => this.SourceApplicationDescription != null;
    }
}
