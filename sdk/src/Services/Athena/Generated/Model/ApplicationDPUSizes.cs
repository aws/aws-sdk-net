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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains the application runtime IDs and their supported DPU sizes.
    /// </summary>
    public partial class ApplicationDPUSizes
    {
        private string _applicationRuntimeId;
        private List<int> _supportedDPUSizes = new List<int>();

        /// <summary>
        /// Gets and sets the property ApplicationRuntimeId. 
        /// <para>
        /// The name of the supported application runtime (for example, <code>Athena notebook
        /// version 1</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ApplicationRuntimeId
        {
            get { return this._applicationRuntimeId; }
            set { this._applicationRuntimeId = value; }
        }

        // Check to see if ApplicationRuntimeId property is set
        internal bool IsSetApplicationRuntimeId()
        {
            return this._applicationRuntimeId != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedDPUSizes. 
        /// <para>
        /// A list of the supported DPU sizes that the application runtime supports.
        /// </para>
        /// </summary>
        public List<int> SupportedDPUSizes
        {
            get { return this._supportedDPUSizes; }
            set { this._supportedDPUSizes = value; }
        }

        // Check to see if SupportedDPUSizes property is set
        internal bool IsSetSupportedDPUSizes()
        {
            return this._supportedDPUSizes != null && this._supportedDPUSizes.Count > 0; 
        }

    }
}