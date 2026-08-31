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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The metadata of a single transport stream program.
    /// </summary>
    public partial class TransportStreamProgram
    {
        /// <summary>
        /// Gets and sets the property PcrPid. 
        /// <para>
        ///  The Program Clock Reference (PCR) Packet ID (PID) as it is reported in the Program
        /// Association Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? PcrPid { get; set; }

        /// <summary>
        /// Checks to see if the PcrPid property is set.
        /// </summary>
        internal bool IsSetPcrPid() => this.PcrPid.HasValue;

        /// <summary>
        /// Gets and sets the property ProgramName. 
        /// <para>
        ///  The program name as it is reported in the Program Association Table.
        /// </para>
        /// </summary>
        public string ProgramName { get; set; }

        /// <summary>
        /// Checks to see if the ProgramName property is set.
        /// </summary>
        internal bool IsSetProgramName() => this.ProgramName != null;

        /// <summary>
        /// Gets and sets the property ProgramNumber. 
        /// <para>
        ///  The program number as it is reported in the Program Association Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProgramNumber { get; set; }

        /// <summary>
        /// Checks to see if the ProgramNumber property is set.
        /// </summary>
        internal bool IsSetProgramNumber() => this.ProgramNumber.HasValue;

        /// <summary>
        /// Gets and sets the property ProgramPid. 
        /// <para>
        ///  The program Packet ID (PID) as it is reported in the Program Association Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProgramPid { get; set; }

        /// <summary>
        /// Checks to see if the ProgramPid property is set.
        /// </summary>
        internal bool IsSetProgramPid() => this.ProgramPid.HasValue;

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        ///  The list of elementary transport streams in the program. The list includes video,
        /// audio, and data streams.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TransportStream> Streams { get; set; } = AWSConfigs.InitializeCollections ? new List<TransportStream>() : null;

        /// <summary>
        /// Checks to see if the Streams property is set.
        /// </summary>
        internal bool IsSetStreams() => this.Streams != null && (this.Streams.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
