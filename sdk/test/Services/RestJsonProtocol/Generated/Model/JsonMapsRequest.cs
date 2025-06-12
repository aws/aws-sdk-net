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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the JsonMaps operation.
    /// The example tests basic map serialization.
    /// </summary>
    public partial class JsonMapsRequest : AmazonRestJsonProtocolRequest
    {
        private Dictionary<string, bool> _denseBooleanMap = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;
        private Dictionary<string, int> _denseNumberMap = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private Dictionary<string, List<string>> _denseSetMap = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private Dictionary<string, string> _denseStringMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, GreetingStruct> _denseStructMap = AWSConfigs.InitializeCollections ? new Dictionary<string, GreetingStruct>() : null;

        /// <summary>
        /// Gets and sets the property DenseBooleanMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, bool> DenseBooleanMap
        {
            get { return this._denseBooleanMap; }
            set { this._denseBooleanMap = value; }
        }

        // Check to see if DenseBooleanMap property is set
        internal bool IsSetDenseBooleanMap()
        {
            return this._denseBooleanMap != null && (this._denseBooleanMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DenseNumberMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> DenseNumberMap
        {
            get { return this._denseNumberMap; }
            set { this._denseNumberMap = value; }
        }

        // Check to see if DenseNumberMap property is set
        internal bool IsSetDenseNumberMap()
        {
            return this._denseNumberMap != null && (this._denseNumberMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DenseSetMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> DenseSetMap
        {
            get { return this._denseSetMap; }
            set { this._denseSetMap = value; }
        }

        // Check to see if DenseSetMap property is set
        internal bool IsSetDenseSetMap()
        {
            return this._denseSetMap != null && (this._denseSetMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DenseStringMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DenseStringMap
        {
            get { return this._denseStringMap; }
            set { this._denseStringMap = value; }
        }

        // Check to see if DenseStringMap property is set
        internal bool IsSetDenseStringMap()
        {
            return this._denseStringMap != null && (this._denseStringMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DenseStructMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, GreetingStruct> DenseStructMap
        {
            get { return this._denseStructMap; }
            set { this._denseStructMap = value; }
        }

        // Check to see if DenseStructMap property is set
        internal bool IsSetDenseStructMap()
        {
            return this._denseStructMap != null && (this._denseStructMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}