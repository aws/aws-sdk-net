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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Represents a copy of an entire cluster as of the time when the snapshot was taken.
    /// </summary>
    public partial class Snapshot
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the snapshot.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property ClusterConfiguration. 
        /// <para>
        /// The configuration of the cluster from which the snapshot was taken
        /// </para>
        /// </summary>
        public ClusterConfiguration ClusterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ClusterConfiguration property is set.
        /// </summary>
        internal bool IsSetClusterConfiguration() => this.ClusterConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataTiering. 
        /// <para>
        /// Enables data tiering. Data tiering is only supported for clusters using the r6gd node
        /// type. This parameter must be set when using r6gd nodes. For more information, see
        /// <a href="https://docs.aws.amazon.com/memorydb/latest/devguide/data-tiering.html">Data
        /// tiering</a>.
        /// </para>
        /// </summary>
        public DataTieringStatus DataTiering { get; set; }

        /// <summary>
        /// Checks to see if the DataTiering property is set.
        /// </summary>
        internal bool IsSetDataTiering() => this.DataTiering != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the snapshot.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the snapshot
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Indicates whether the snapshot is from an automatic backup (automated) or was created
        /// manually (manual).
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the snapshot. Valid values: creating | available | restoring | copying
        /// | deleting.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
