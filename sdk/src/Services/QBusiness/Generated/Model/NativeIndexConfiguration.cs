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
        private long? _version;

        /// <summary>
        /// Gets and sets the property BoostingOverride. 
        /// <para>
        /// Overrides the default boosts applied by Amazon Q Business to supported document attribute
        /// data types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A read-only field that specifies the version of the <c>NativeIndexConfiguration</c>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Q Business introduces enhanced document retrieval capabilities in version 2
        /// of <c>NativeIndexConfiguration</c>, focusing on streamlined metadata boosting that
        /// prioritizes recency and source relevance to deliver more accurate responses to your
        /// queries. Version 2 has the following differences from version 1:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Version 2 supports a single Date field (created_at OR last_updated_at) for recency
        /// boosting
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version 2 supports a single String field with an ordered list of up to 5 values
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version 2 introduces number-based boost levels (ONE, TWO) alongside the text-based
        /// levels
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version 2 allows specifying prioritization between Date and String fields
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version 2 maintains backward compatibility with existing configurations
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}