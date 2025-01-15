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
    /// Container for the parameters to the SparseJsonMaps operation.
    /// The example tests serialization of JSON map values in sparse maps.
    /// </summary>
    public partial class SparseJsonMapsRequest : AmazonRestJsonProtocolRequest
    {
        private Dictionary<string, bool?> _sparseBooleanMap = AWSConfigs.InitializeCollections ? new Dictionary<string, bool?>() : null;
        private Dictionary<string, int?> _sparseNumberMap = AWSConfigs.InitializeCollections ? new Dictionary<string, int?>() : null;
        private Dictionary<string, List<string>> _sparseSetMap = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private Dictionary<string, string> _sparseStringMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, GreetingStruct> _sparseStructMap = AWSConfigs.InitializeCollections ? new Dictionary<string, GreetingStruct>() : null;

        /// <summary>
        /// Gets and sets the property SparseBooleanMap.
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