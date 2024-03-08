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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the JsonMaps operation.
    /// The example tests basic map serialization.
    /// </summary>
    public partial class JsonMapsRequest : AmazonRestJsonProtocolRequest
    {
        private Dictionary<string, bool> _denseBooleanMap = new Dictionary<string, bool>();
        private Dictionary<string, int> _denseNumberMap = new Dictionary<string, int>();
        private Dictionary<string, List<string>> _denseSetMap = new Dictionary<string, List<string>>();
        private Dictionary<string, string> _denseStringMap = new Dictionary<string, string>();
        private Dictionary<string, GreetingStruct> _denseStructMap = new Dictionary<string, GreetingStruct>();
        private Dictionary<string, bool> _sparseBooleanMap = new Dictionary<string, bool>();
        private Dictionary<string, int> _sparseNumberMap = new Dictionary<string, int>();
        private Dictionary<string, List<string>> _sparseSetMap = new Dictionary<string, List<string>>();
        private Dictionary<string, string> _sparseStringMap = new Dictionary<string, string>();
        private Dictionary<string, GreetingStruct> _sparseStructMap = new Dictionary<string, GreetingStruct>();

        /// <summary>
        /// Gets and sets the property DenseBooleanMap.
        /// </summary>
        public Dictionary<string, bool> DenseBooleanMap
        {
            get { return this._denseBooleanMap; }
            set { this._denseBooleanMap = value; }
        }

        // Check to see if DenseBooleanMap property is set
        internal bool IsSetDenseBooleanMap()
        {
            return this._denseBooleanMap != null && this._denseBooleanMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DenseNumberMap.
        /// </summary>
        public Dictionary<string, int> DenseNumberMap
        {
            get { return this._denseNumberMap; }
            set { this._denseNumberMap = value; }
        }

        // Check to see if DenseNumberMap property is set
        internal bool IsSetDenseNumberMap()
        {
            return this._denseNumberMap != null && this._denseNumberMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DenseSetMap.
        /// </summary>
        public Dictionary<string, List<string>> DenseSetMap
        {
            get { return this._denseSetMap; }
            set { this._denseSetMap = value; }
        }

        // Check to see if DenseSetMap property is set
        internal bool IsSetDenseSetMap()
        {
            return this._denseSetMap != null && this._denseSetMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DenseStringMap.
        /// </summary>
        public Dictionary<string, string> DenseStringMap
        {
            get { return this._denseStringMap; }
            set { this._denseStringMap = value; }
        }

        // Check to see if DenseStringMap property is set
        internal bool IsSetDenseStringMap()
        {
            return this._denseStringMap != null && this._denseStringMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DenseStructMap.
        /// </summary>
        public Dictionary<string, GreetingStruct> DenseStructMap
        {
            get { return this._denseStructMap; }
            set { this._denseStructMap = value; }
        }

        // Check to see if DenseStructMap property is set
        internal bool IsSetDenseStructMap()
        {
            return this._denseStructMap != null && this._denseStructMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SparseBooleanMap.
        /// </summary>
        public Dictionary<string, bool> SparseBooleanMap
        {
            get { return this._sparseBooleanMap; }
            set { this._sparseBooleanMap = value; }
        }

        // Check to see if SparseBooleanMap property is set
        internal bool IsSetSparseBooleanMap()
        {
            return this._sparseBooleanMap != null && this._sparseBooleanMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SparseNumberMap.
        /// </summary>
        public Dictionary<string, int> SparseNumberMap
        {
            get { return this._sparseNumberMap; }
            set { this._sparseNumberMap = value; }
        }

        // Check to see if SparseNumberMap property is set
        internal bool IsSetSparseNumberMap()
        {
            return this._sparseNumberMap != null && this._sparseNumberMap.Count > 0; 
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
            return this._sparseSetMap != null && this._sparseSetMap.Count > 0; 
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
            return this._sparseStringMap != null && this._sparseStringMap.Count > 0; 
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
            return this._sparseStructMap != null && this._sparseStructMap.Count > 0; 
        }

    }
}