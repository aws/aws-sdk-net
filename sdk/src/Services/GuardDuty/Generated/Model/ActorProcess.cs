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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about a process involved in a GuardDuty finding, including process
    /// identification, execution details, and file information.
    /// </summary>
    public partial class ActorProcess
    {
        private string _name;
        private string _path;
        private string _sha256;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the process as it appears in the system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4096)]
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The full file path to the process executable on the system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4096)]
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
        /// Gets and sets the property Sha256. 
        /// <para>
        /// The SHA256 hash of the process executable file, which can be used for identification
        /// and verification purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Sha256
        {
            get { return this._sha256; }
            set { this._sha256 = value; }
        }

        // Check to see if Sha256 property is set
        internal bool IsSetSha256()
        {
            return this._sha256 != null;
        }

    }
}