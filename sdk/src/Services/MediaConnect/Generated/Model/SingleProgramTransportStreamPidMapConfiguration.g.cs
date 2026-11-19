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
    /// The configuration settings for remapping the identification numbers of elementary
    /// streams and program identifiers of a single-program transport stream.
    /// </summary>
    public partial class SingleProgramTransportStreamPidMapConfiguration
    {
        /// <summary>
        /// Gets and sets the property Auto. 
        /// <para>
        /// The settings for automatic Packet ID (PID) assignment. The default start PID is 512,
        /// with 32 PIDs per program.
        /// </para>
        /// </summary>
        public AutoPidMapConfiguration Auto { get; set; }

        /// <summary>
        /// Checks to see if the Auto property is set.
        /// </summary>
        internal bool IsSetAuto() => this.Auto != null;

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action to apply to an elementary stream that doesn't match any rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DefaultAction { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAction property is set.
        /// </summary>
        internal bool IsSetDefaultAction() => this.DefaultAction != null;

        /// <summary>
        /// Gets and sets the property ProgramClockReferencePid. 
        /// <para>
        /// The Program Clock Reference (PCR) PID settings for the router output. By default,
        /// the router output passes through the PCR PID from the source.
        /// </para>
        /// </summary>
        public ProgramClockReferencePidConfiguration ProgramClockReferencePid { get; set; }

        /// <summary>
        /// Checks to see if the ProgramClockReferencePid property is set.
        /// </summary>
        internal bool IsSetProgramClockReferencePid() => this.ProgramClockReferencePid != null;

        /// <summary>
        /// Gets and sets the property ProgramMapTablePid. 
        /// <para>
        /// The Program Map Table (PMT) PID settings for the router output. By default, the router
        /// output passes through the PMT PID from the source.
        /// </para>
        /// </summary>
        public ProgramMapTablePidConfiguration ProgramMapTablePid { get; set; }

        /// <summary>
        /// Checks to see if the ProgramMapTablePid property is set.
        /// </summary>
        internal bool IsSetProgramMapTablePid() => this.ProgramMapTablePid != null;

        /// <summary>
        /// Gets and sets the property ProgramNumber. 
        /// <para>
        /// The program number settings for the router output. By default, the router output passes
        /// through the program number from the source.
        /// </para>
        /// </summary>
        public ProgramNumberConfiguration ProgramNumber { get; set; }

        /// <summary>
        /// Checks to see if the ProgramNumber property is set.
        /// </summary>
        internal bool IsSetProgramNumber() => this.ProgramNumber != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The ordered list of up to 32 rules that determine the action for each elementary stream.
        /// MediaConnect applies the first rule that matches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 32)]
        public List<PidMapRule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<PidMapRule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransportStreamId. 
        /// <para>
        /// The transport stream ID (TSID) settings for the router output. By default, the router
        /// output passes through the TSID from the source.
        /// </para>
        /// </summary>
        public TransportStreamIdConfiguration TransportStreamId { get; set; }

        /// <summary>
        /// Checks to see if the TransportStreamId property is set.
        /// </summary>
        internal bool IsSetTransportStreamId() => this.TransportStreamId != null;
    }
}
