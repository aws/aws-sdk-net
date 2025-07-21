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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The configuration options for a service managed fleet's VPC.
    /// </summary>
    public partial class VpcConfiguration
    {
        private List<string> _resourceConfigurationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationArns. 
        /// <para>
        /// The ARNs of the VPC Lattice resource configurations attached to the fleet.
        /// </para>
        /// </summary>
        public List<string> ResourceConfigurationArns
        {
            get { return this._resourceConfigurationArns; }
            set { this._resourceConfigurationArns = value; }
        }

        // Check to see if ResourceConfigurationArns property is set
        internal bool IsSetResourceConfigurationArns()
        {
            return this._resourceConfigurationArns != null && (this._resourceConfigurationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}