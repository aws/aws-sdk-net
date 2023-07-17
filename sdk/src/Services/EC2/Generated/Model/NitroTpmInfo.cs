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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the supported NitroTPM versions for the instance type.
    /// </summary>
    public partial class NitroTpmInfo
    {
        private List<string> _supportedVersions = new List<string>();

        /// <summary>
        /// Gets and sets the property SupportedVersions. 
        /// <para>
        /// Indicates the supported NitroTPM versions.
        /// </para>
        /// </summary>
        public List<string> SupportedVersions
        {
            get { return this._supportedVersions; }
            set { this._supportedVersions = value; }
        }

        // Check to see if SupportedVersions property is set
        internal bool IsSetSupportedVersions()
        {
            return this._supportedVersions != null && this._supportedVersions.Count > 0; 
        }

    }
}