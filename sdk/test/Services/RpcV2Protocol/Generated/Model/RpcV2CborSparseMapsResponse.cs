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
 * Do not modify this file. This file is generated from the rpcv2protocol-2020-07-14.normal.json service model.
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
namespace Amazon.RpcV2Protocol.Model
{
    /// <summary>
    /// This is the response object from the RpcV2CborSparseMaps operation.
    /// </summary>
    public partial class RpcV2CborSparseMapsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, bool?> _sparseBooleanMap = AWSConfigs.InitializeCollections ? new Dictionary<string, bool?>() : null;
        private Dictionary<string, int?> _sparseNumberMap = AWSConfigs.InitializeCollections ? new Dictionary<string, int?>() : null;
        private Dictionary<string, List<string>> _sparseSetMap = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private Dictionary<string, string> _sparseStringMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, GreetingStruct> _sparseStructMap = AWSConfigs.InitializeCollections ? new Dictionary<string, GreetingStruct>() : null;

        /// <summary>
        /// Gets and sets the property SparseBooleanMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, bool?> SparseBooleanMap
        {
            get { return this._sparseBooleanMap; }
            set { this._sparseBooleanMap = value; }
        }

        // Check to see if SparseBooleanMap property is set
        internal bool IsSetSparseBooleanMap()
        {
            return this._sparseBooleanMap != null && (this._sparseBooleanMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparseNumberMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int?> SparseNumberMap
        {
            get { return this._sparseNumberMap; }
            set { this._sparseNumberMap = value; }
        }

        // Check to see if SparseNumberMap property is set
        internal bool IsSetSparseNumberMap()
        {
            return this._sparseNumberMap != null && (this._sparseNumberMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparseSetMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> SparseSetMap
        {
            get { return this._sparseSetMap; }
            set { this._sparseSetMap = value; }
        }

        // Check to see if SparseSetMap property is set
        internal bool IsSetSparseSetMap()
        {
            return this._sparseSetMap != null && (this._sparseSetMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparseStringMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SparseStringMap
        {
            get { return this._sparseStringMap; }
            set { this._sparseStringMap = value; }
        }

        // Check to see if SparseStringMap property is set
        internal bool IsSetSparseStringMap()
        {
            return this._sparseStringMap != null && (this._sparseStringMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparseStructMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, GreetingStruct> SparseStructMap
        {
            get { return this._sparseStructMap; }
            set { this._sparseStructMap = value; }
        }

        // Check to see if SparseStructMap property is set
        internal bool IsSetSparseStructMap()
        {
            return this._sparseStructMap != null && (this._sparseStructMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}