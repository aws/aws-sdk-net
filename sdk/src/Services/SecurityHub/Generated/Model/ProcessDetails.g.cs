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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The details of process-related information about a finding.
    /// </summary>
    public partial class ProcessDetails
    {
        /// <summary>
        /// Gets and sets the property LaunchedAt. 
        /// <para>
        /// Indicates when the process was launched.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LaunchedAt { get; set; }

        /// <summary>
        /// Checks to see if the LaunchedAt property is set.
        /// </summary>
        internal bool IsSetLaunchedAt() => this.LaunchedAt != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the process.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1. Maximum of 64.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentPid. 
        /// <para>
        /// The parent process ID. This field accepts positive integers between <c>O</c> and <c>2147483647</c>.
        /// </para>
        /// </summary>
        public int? ParentPid { get; set; }

        /// <summary>
        /// Checks to see if the ParentPid property is set.
        /// </summary>
        internal bool IsSetParentPid() => this.ParentPid.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the process executable.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1. Maximum of 512.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Pid. 
        /// <para>
        /// The process ID.
        /// </para>
        /// </summary>
        public int? Pid { get; set; }

        /// <summary>
        /// Checks to see if the Pid property is set.
        /// </summary>
        internal bool IsSetPid() => this.Pid.HasValue;

        /// <summary>
        /// Gets and sets the property TerminatedAt. 
        /// <para>
        /// Indicates when the process was terminated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string TerminatedAt { get; set; }

        /// <summary>
        /// Checks to see if the TerminatedAt property is set.
        /// </summary>
        internal bool IsSetTerminatedAt() => this.TerminatedAt != null;
    }
}
