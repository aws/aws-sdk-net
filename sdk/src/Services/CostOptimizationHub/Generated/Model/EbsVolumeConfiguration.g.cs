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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The Amazon Elastic Block Store volume configuration used for recommendations.
    /// </summary>
    public partial class EbsVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property AttachmentState. 
        /// <para>
        /// The Amazon Elastic Block Store attachment state.
        /// </para>
        /// </summary>
        public string AttachmentState { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentState property is set.
        /// </summary>
        internal bool IsSetAttachmentState() => this.AttachmentState != null;

        /// <summary>
        /// Gets and sets the property Performance. 
        /// <para>
        /// The Amazon Elastic Block Store performance configuration.
        /// </para>
        /// </summary>
        public BlockStoragePerformanceConfiguration Performance { get; set; }

        /// <summary>
        /// Checks to see if the Performance property is set.
        /// </summary>
        internal bool IsSetPerformance() => this.Performance != null;

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The disk storage of the Amazon Elastic Block Store volume.
        /// </para>
        /// </summary>
        public StorageConfiguration Storage { get; set; }

        /// <summary>
        /// Checks to see if the Storage property is set.
        /// </summary>
        internal bool IsSetStorage() => this.Storage != null;
    }
}
