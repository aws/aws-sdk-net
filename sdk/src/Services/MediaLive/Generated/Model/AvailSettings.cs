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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private Esam _esam;
        private Scte35SpliceInsert _scte35SpliceInsert;
        private Scte35TimeSignalApos _scte35TimeSignalApos;

        /// <summary>
        /// Gets and sets the property Esam.
        /// </summary>
        public Esam Esam
        {
            get { return this._esam; }
            set { this._esam = value; }
        }

        // Check to see if Esam property is set
        internal bool IsSetEsam()
        {
            return this._esam != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35SpliceInsert.
        /// </summary>
        public Scte35SpliceInsert Scte35SpliceInsert
        {
            get { return this._scte35SpliceInsert; }
            set { this._scte35SpliceInsert = value; }
        }

        // Check to see if Scte35SpliceInsert property is set
        internal bool IsSetScte35SpliceInsert()
        {
            return this._scte35SpliceInsert != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35TimeSignalApos.
        /// </summary>
        public Scte35TimeSignalApos Scte35TimeSignalApos
        {
            get { return this._scte35TimeSignalApos; }
            set { this._scte35TimeSignalApos = value; }
        }

        // Check to see if Scte35TimeSignalApos property is set
        internal bool IsSetScte35TimeSignalApos()
        {
            return this._scte35TimeSignalApos != null;
        }

    }
}