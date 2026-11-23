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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Specifies changes to the clone configuration of an FSx for ONTAP volume.
    /// </summary>
    public partial class UpdateCloneConfiguration
    {
        /// <summary>
        /// Gets and sets the property SplitAction. 
        /// <para>
        /// Set to <c>START</c> to split the clone from its parent volume. Splitting copies the
        /// data that the clone shares with the parent volume, so that the clone becomes an independent
        /// volume that no longer depends on the parent. After the split, the volume uses storage
        /// for all of its data.
        /// </para>
        ///  
        /// <para>
        /// When you split a clone, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SplitAction</c> must be the only property that you change in the <c>UpdateVolume</c>
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't split a data protection (<c>DP</c>) clone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The split fails if the clone has locked snapshots, such as snapshots that a SnapMirror
        /// relationship uses or that a retention period protects, or if a backup of the clone
        /// is in progress. To allow the split, Amazon FSx deletes the snapshots that it created
        /// for backups of the clone, so the next backup transfers more data. Amazon FSx doesn't
        /// delete snapshots that you created.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The split runs in the background. To monitor its progress, use the <c>VOLUME_CLONE_SPLIT</c>
        /// administrative action in the volume's <c>AdministrativeActions</c>. When the split
        /// completes, the volume no longer has a <c>CloneConfiguration</c>.
        /// </para>
        /// </summary>
        public CloneSplitAction SplitAction { get; set; }

        /// <summary>
        /// Checks to see if the SplitAction property is set.
        /// </summary>
        internal bool IsSetSplitAction() => this.SplitAction != null;
    }
}
