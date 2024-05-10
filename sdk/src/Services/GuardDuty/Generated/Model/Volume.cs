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
    /// Volume used by the Kubernetes workload.
    /// </summary>
    public partial class Volume
    {
        private HostPath _hostPath;
        private string _name;

        /// <summary>
        /// Gets and sets the property HostPath. 
        /// <para>
        /// Represents a pre-existing file or directory on the host machine that the volume maps
        /// to.
        /// </para>
        /// </summary>
        public HostPath HostPath
        {
            get { return this._hostPath; }
            set { this._hostPath = value; }
        }

        // Check to see if HostPath property is set
        internal bool IsSetHostPath()
        {
            return this._hostPath != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Volume name.
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

    }
}