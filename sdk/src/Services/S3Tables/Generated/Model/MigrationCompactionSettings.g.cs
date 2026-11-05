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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// The compaction settings that a migration applies to the destination table.
    /// </summary>
    public partial class MigrationCompactionSettings
    {
        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The compaction strategy. The only valid value is <c>binpack</c>, which is the default.
        /// </para>
        /// </summary>
        public IcebergCompactionStrategy Strategy { get; set; }

        /// <summary>
        /// Checks to see if the Strategy property is set.
        /// </summary>
        internal bool IsSetStrategy() => this.Strategy != null;

        /// <summary>
        /// Gets and sets the property TargetFileSizeMB. 
        /// <para>
        /// The target size, from 64 to 512 MB, of the data files that the migration writes, and
        /// of the files that compaction writes after you complete the migration. The default
        /// is 512.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 512)]
        public int? TargetFileSizeMB { get; set; }

        /// <summary>
        /// Checks to see if the TargetFileSizeMB property is set.
        /// </summary>
        internal bool IsSetTargetFileSizeMB() => this.TargetFileSizeMB.HasValue;
    }
}
