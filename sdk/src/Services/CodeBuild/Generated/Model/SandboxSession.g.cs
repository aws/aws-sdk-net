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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains information about the sandbox session.
    /// </summary>
    public partial class SandboxSession
    {
        /// <summary>
        /// Gets and sets the property CurrentPhase. 
        /// <para>
        /// The current phase for the sandbox.
        /// </para>
        /// </summary>
        public string CurrentPhase { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPhase property is set.
        /// </summary>
        internal bool IsSetCurrentPhase() => this.CurrentPhase != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the sandbox session ended, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the sandbox session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Logs.
        /// </summary>
        public LogsLocation Logs { get; set; }

        /// <summary>
        /// Checks to see if the Logs property is set.
        /// </summary>
        internal bool IsSetLogs() => this.Logs != null;

        /// <summary>
        /// Gets and sets the property NetworkInterface.
        /// </summary>
        public NetworkInterface NetworkInterface { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterface property is set.
        /// </summary>
        internal bool IsSetNetworkInterface() => this.NetworkInterface != null;

        /// <summary>
        /// Gets and sets the property Phases. 
        /// <para>
        ///  An array of <c>SandboxSessionPhase</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SandboxSessionPhase> Phases { get; set; } = AWSConfigs.InitializeCollections ? new List<SandboxSessionPhase>() : null;

        /// <summary>
        /// Checks to see if the Phases property is set.
        /// </summary>
        internal bool IsSetPhases() => this.Phases != null && (this.Phases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResolvedSourceVersion. 
        /// <para>
        /// An identifier for the version of this sandbox's source code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ResolvedSourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedSourceVersion property is set.
        /// </summary>
        internal bool IsSetResolvedSourceVersion() => this.ResolvedSourceVersion != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the sandbox session started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the sandbox session.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
