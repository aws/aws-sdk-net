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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Contains a set of IP set references.
    /// </summary>
    public partial class ReferenceSets
    {
        private Dictionary<string, IPSetReference> _ipSetReferences = AWSConfigs.InitializeCollections ? new Dictionary<string, IPSetReference>() : null;

        /// <summary>
        /// Gets and sets the property IPSetReferences. 
        /// <para>
        /// The list of IP set references.
        /// </para>
        /// </summary>
        public Dictionary<string, IPSetReference> IPSetReferences
        {
            get { return this._ipSetReferences; }
            set { this._ipSetReferences = value; }
        }

        // Check to see if IPSetReferences property is set
        internal bool IsSetIPSetReferences()
        {
            return this._ipSetReferences != null && (this._ipSetReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}