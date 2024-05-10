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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
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
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Information about a site plan.
    /// </summary>
    public partial class SitePlan
    {
        private List<NameValuePair> _options = AWSConfigs.InitializeCollections ? new List<NameValuePair>() : null;
        private List<NetworkResourceDefinition> _resourceDefinitions = AWSConfigs.InitializeCollections ? new List<NetworkResourceDefinition>() : null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options of the plan.
        /// </para>
        /// </summary>
        public List<NameValuePair> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceDefinitions. 
        /// <para>
        /// The resource definitions of the plan.
        /// </para>
        /// </summary>
        public List<NetworkResourceDefinition> ResourceDefinitions
        {
            get { return this._resourceDefinitions; }
            set { this._resourceDefinitions = value; }
        }

        // Check to see if ResourceDefinitions property is set
        internal bool IsSetResourceDefinitions()
        {
            return this._resourceDefinitions != null && (this._resourceDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}