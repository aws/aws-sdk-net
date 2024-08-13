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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
        private string _command;
        private DateTime? _dateTime;
        private string _name;
        private string _standardError;
        private string _standardOutput;
        private SetupStatus _status;
        private string _version;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that was executed.
        /// </para>
        /// </summary>
        public string Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property DateTime. 
        /// <para>
        /// The timestamp for when the request was run.
        /// </para>
        /// </summary>
        public DateTime? DateTime
        {
            get { return this._dateTime; }
            set { this._dateTime = value; }
        }

        // Check to see if DateTime property is set
        internal bool IsSetDateTime()
        {
            return this._dateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the target resource.
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
        /// Gets and sets the property StandardError. 
        /// <para>
        /// The text written by the command to stderr.
        /// </para>
        /// </summary>
        public string StandardError
        {
            get { return this._standardError; }
            set { this._standardError = value; }
        }

        // Check to see if StandardError property is set
        internal bool IsSetStandardError()
        {
            return this._standardError != null;
        }

        /// <summary>
        /// Gets and sets the property StandardOutput. 
        /// <para>
        /// The text written by the command to stdout.
        /// </para>
        /// </summary>
        public string StandardOutput
        {
            get { return this._standardOutput; }
            set { this._standardOutput = value; }
        }

        // Check to see if StandardOutput property is set
        internal bool IsSetStandardOutput()
        {
            return this._standardOutput != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the <c>SetupInstanceHttps</c> request.
        /// </para>
        /// </summary>
        public SetupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the script..
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}