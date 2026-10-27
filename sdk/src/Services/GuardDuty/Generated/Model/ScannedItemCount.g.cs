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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Total number of scanned files.
    /// </summary>
    public partial class ScannedItemCount
    {
        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        /// Number of files scanned.
        /// </para>
        /// </summary>
        public int? Files { get; set; }

        /// <summary>
        /// Checks to see if the Files property is set.
        /// </summary>
        internal bool IsSetFiles() => this.Files.HasValue;

        /// <summary>
        /// Gets and sets the property TotalGb. 
        /// <para>
        /// Total GB of files scanned for malware.
        /// </para>
        /// </summary>
        public int? TotalGb { get; set; }

        /// <summary>
        /// Checks to see if the TotalGb property is set.
        /// </summary>
        internal bool IsSetTotalGb() => this.TotalGb.HasValue;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// Total number of scanned volumes.
        /// </para>
        /// </summary>
        public int? Volumes { get; set; }

        /// <summary>
        /// Checks to see if the Volumes property is set.
        /// </summary>
        internal bool IsSetVolumes() => this.Volumes.HasValue;
    }
}
