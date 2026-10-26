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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Avail Settings
    /// </summary>
    public partial class AvailSettings
    {
        /// <summary>
        /// Gets and sets the property Esam.
        /// </summary>
        public Esam Esam { get; set; }

        /// <summary>
        /// Checks to see if the Esam property is set.
        /// </summary>
        internal bool IsSetEsam() => this.Esam != null;

        /// <summary>
        /// Gets and sets the property Scte35SpliceInsert.
        /// </summary>
        public Scte35SpliceInsert Scte35SpliceInsert { get; set; }

        /// <summary>
        /// Checks to see if the Scte35SpliceInsert property is set.
        /// </summary>
        internal bool IsSetScte35SpliceInsert() => this.Scte35SpliceInsert != null;

        /// <summary>
        /// Gets and sets the property Scte35TimeSignalApos.
        /// </summary>
        public Scte35TimeSignalApos Scte35TimeSignalApos { get; set; }

        /// <summary>
        /// Checks to see if the Scte35TimeSignalApos property is set.
        /// </summary>
        internal bool IsSetScte35TimeSignalApos() => this.Scte35TimeSignalApos != null;
    }
}
