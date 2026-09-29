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
    /// Part of the response to the CompleteReadSetUpload API, including metadata.
    /// </summary>
    public partial class CompleteReadSetUploadPartListItem
    {
        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        ///  A unique identifier used to confirm that parts are being added to the correct upload.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property PartNumber. 
        /// <para>
        ///  A number identifying the part in a read set upload. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public int? PartNumber { get; set; }

        /// <summary>
        /// Checks to see if the PartNumber property is set.
        /// </summary>
        internal bool IsSetPartNumber() => this.PartNumber.HasValue;

        /// <summary>
        /// Gets and sets the property PartSource. 
        /// <para>
        ///  The source file of the part being uploaded. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReadSetPartSource PartSource { get; set; }

        /// <summary>
        /// Checks to see if the PartSource property is set.
        /// </summary>
        internal bool IsSetPartSource() => this.PartSource != null;
    }
}
