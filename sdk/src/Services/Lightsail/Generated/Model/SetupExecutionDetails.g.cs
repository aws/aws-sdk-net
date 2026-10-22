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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Returns details about the commands that were run.
    /// </summary>
    public partial class SetupExecutionDetails
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that was executed.
        /// </para>
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null;

        /// <summary>
        /// Gets and sets the property DateTime. 
        /// <para>
        /// The timestamp for when the request was run.
        /// </para>
        /// </summary>
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Checks to see if the DateTime property is set.
        /// </summary>
        internal bool IsSetDateTime() => this.DateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the target resource.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StandardError. 
        /// <para>
        /// The text written by the command to stderr.
        /// </para>
        /// </summary>
        public string StandardError { get; set; }

        /// <summary>
        /// Checks to see if the StandardError property is set.
        /// </summary>
        internal bool IsSetStandardError() => this.StandardError != null;

        /// <summary>
        /// Gets and sets the property StandardOutput. 
        /// <para>
        /// The text written by the command to stdout.
        /// </para>
        /// </summary>
        public string StandardOutput { get; set; }

        /// <summary>
        /// Checks to see if the StandardOutput property is set.
        /// </summary>
        internal bool IsSetStandardOutput() => this.StandardOutput != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the <c>SetupInstanceHttps</c> request.
        /// </para>
        /// </summary>
        public SetupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the script..
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
