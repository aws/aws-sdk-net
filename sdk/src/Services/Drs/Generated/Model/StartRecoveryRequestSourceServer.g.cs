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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// An object representing the Source Server to recover.
    /// </summary>
    public partial class StartRecoveryRequestSourceServer
    {
        /// <summary>
        /// Gets and sets the property RecoverySnapshotID. 
        /// <para>
        /// The ID of a Recovery Snapshot we want to recover from. Omit this field to launch from
        /// the latest data by taking an on-demand snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string RecoverySnapshotID { get; set; }

        /// <summary>
        /// Checks to see if the RecoverySnapshotID property is set.
        /// </summary>
        internal bool IsSetRecoverySnapshotID() => this.RecoverySnapshotID != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The ID of the Source Server you want to recover.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;
    }
}
