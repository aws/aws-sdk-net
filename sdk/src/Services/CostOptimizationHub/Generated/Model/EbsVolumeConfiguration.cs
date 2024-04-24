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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
        private string _attachmentState;
        private BlockStoragePerformanceConfiguration _performance;
        private StorageConfiguration _storage;

        /// <summary>
        /// Gets and sets the property AttachmentState. 
        /// <para>
        /// The Amazon Elastic Block Store attachment state.
        /// </para>
        /// </summary>
        public string AttachmentState
        {
            get { return this._attachmentState; }
            set { this._attachmentState = value; }
        }

        // Check to see if AttachmentState property is set
        internal bool IsSetAttachmentState()
        {
            return this._attachmentState != null;
        }

        /// <summary>
        /// Gets and sets the property Performance. 
        /// <para>
        /// The Amazon Elastic Block Store performance configuration.
        /// </para>
        /// </summary>
        public BlockStoragePerformanceConfiguration Performance
        {
            get { return this._performance; }
            set { this._performance = value; }
        }

        // Check to see if Performance property is set
        internal bool IsSetPerformance()
        {
            return this._performance != null;
        }

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The disk storage of the Amazon Elastic Block Store volume.
        /// </para>
        /// </summary>
        public StorageConfiguration Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null;
        }

    }
}