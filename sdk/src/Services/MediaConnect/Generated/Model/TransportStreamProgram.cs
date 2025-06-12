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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The metadata of a single transport stream program.
    /// </summary>
    public partial class TransportStreamProgram
    {
        private int? _pcrPid;
        private string _programName;
        private int? _programNumber;
        private int? _programPid;
        private List<TransportStream> _streams = AWSConfigs.InitializeCollections ? new List<TransportStream>() : null;

        /// <summary>
        /// Gets and sets the property PcrPid. 
        /// <para>
        ///  The Program Clock Reference (PCR) Packet ID (PID) as it is reported in the Program
        /// Association Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? PcrPid
        {
            get { return this._pcrPid; }
            set { this._pcrPid = value; }
        }

        // Check to see if PcrPid property is set
        internal bool IsSetPcrPid()
        {
            return this._pcrPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgramName. 
        /// <para>
        ///  The program name as it is reported in the Program Association Table.
        /// </para>
        /// </summary>
        public string ProgramName
        {
            get { return this._programName; }
            set { this._programName = value; }
        }

        // Check to see if ProgramName property is set
        internal bool IsSetProgramName()
        {
            return this._programName != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramNumber. 
        /// <para>
        ///  The program number as it is reported in the Program Association Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ProgramNumber
        {
            get { return this._programNumber; }
            set { this._programNumber = value; }
        }

        // Check to see if ProgramNumber property is set
        internal bool IsSetProgramNumber()
        {
            return this._programNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgramPid. 
        /// <para>
        ///  The program Packet ID (PID) as it is reported in the Program Association Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ProgramPid
        {
            get { return this._programPid; }
            set { this._programPid = value; }
        }

        // Check to see if ProgramPid property is set
        internal bool IsSetProgramPid()
        {
            return this._programPid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        ///  The list of elementary transport streams in the program. The list includes video,
        /// audio, and data streams.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TransportStream> Streams
        {
            get { return this._streams; }
            set { this._streams = value; }
        }

        // Check to see if Streams property is set
        internal bool IsSetStreams()
        {
            return this._streams != null && (this._streams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}