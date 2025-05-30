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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _launchedAt;
        private string _name;
        private int? _parentPid;
        private string _path;
        private int? _pid;
        private string _terminatedAt;

        /// <summary>
        /// Gets and sets the property LaunchedAt. 
        /// <para>
        /// Indicates when the process was launched.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LaunchedAt
        {
            get { return this._launchedAt; }
            set { this._launchedAt = value; }
        }

        // Check to see if LaunchedAt property is set
        internal bool IsSetLaunchedAt()
        {
            return this._launchedAt != null;
        }

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
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParentPid. 
        /// <para>
        /// The parent process ID. This field accepts positive integers between <c>O</c> and <c>2147483647</c>.
        /// </para>
        /// </summary>
        public int? ParentPid
        {
            get { return this._parentPid; }
            set { this._parentPid = value; }
        }

        // Check to see if ParentPid property is set
        internal bool IsSetParentPid()
        {
            return this._parentPid.HasValue; 
        }

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
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Pid. 
        /// <para>
        /// The process ID.
        /// </para>
        /// </summary>
        public int? Pid
        {
            get { return this._pid; }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminatedAt. 
        /// <para>
        /// Indicates when the process was terminated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string TerminatedAt
        {
            get { return this._terminatedAt; }
            set { this._terminatedAt = value; }
        }

        // Check to see if TerminatedAt property is set
        internal bool IsSetTerminatedAt()
        {
            return this._terminatedAt != null;
        }

    }
}