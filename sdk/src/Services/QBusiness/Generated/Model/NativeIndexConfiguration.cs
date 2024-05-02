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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Configuration information for an Amazon Q Business index.
    /// </summary>
    public partial class NativeIndexConfiguration
    {
        private Dictionary<string, DocumentAttributeBoostingConfiguration> _boostingOverride = AWSConfigs.InitializeCollections ? new Dictionary<string, DocumentAttributeBoostingConfiguration>() : null;
        private string _indexId;

        /// <summary>
        /// Gets and sets the property BoostingOverride. 
        /// <para>
        /// Overrides the default boosts applied by Amazon Q Business to supported document attribute
        /// data types.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public Dictionary<string, DocumentAttributeBoostingConfiguration> BoostingOverride
        {
            get { return this._boostingOverride; }
            set { this._boostingOverride = value; }
        }

        // Check to see if BoostingOverride property is set
        internal bool IsSetBoostingOverride()
        {
            return this._boostingOverride != null && (this._boostingOverride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier for the Amazon Q Business index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

    }
}