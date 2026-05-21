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
 * Do not modify this file. This file is generated from the rpccbordataplane-1999-12-31.normal.json service model.
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
namespace Amazon.RpcCborDataPlane.Model
{
    /// <summary>
    /// <pre><c>The famous recursive structure from Amazon DynamoDB. </c></pre>
    /// </summary>
    public partial class AttributeValue
    {
        private MemoryStream _b;
        private bool? _bool;
        private List<MemoryStream> _bs = AWSConfigs.InitializeCollections ? new List<MemoryStream>() : null;
        private List<AttributeValue> _l = AWSConfigs.InitializeCollections ? new List<AttributeValue>() : null;
        private Dictionary<string, AttributeValue> _m = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private string _n;
        private List<string> _ns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _null;
        private string _s;
        private List<string> _ss = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property B.
        /// </summary>
        public MemoryStream B
        {
            get { return this._b; }
            set { this._b = value; }
        }

        // Check to see if B property is set
        internal bool IsSetB()
        {
            return this._b != null;
        }

        /// <summary>
        /// Gets and sets the property BOOL.
        /// </summary>
        public bool? BOOL
        {
            get { return this._bool; }
            set { this._bool = value; }
        }

        // Check to see if BOOL property is set
        internal bool IsSetBOOL()
        {
            return this._bool.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BS.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemoryStream> BS
        {
            get { return this._bs; }
            set { this._bs = value; }
        }

        // Check to see if BS property is set
        internal bool IsSetBS()
        {
            return this._bs != null && (this._bs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property L.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeValue> L
        {
            get { return this._l; }
            set { this._l = value; }
        }

        // Check to see if L property is set
        internal bool IsSetL()
        {
            return this._l != null && (this._l.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property M.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> M
        {
            get { return this._m; }
            set { this._m = value; }
        }

        // Check to see if M property is set
        internal bool IsSetM()
        {
            return this._m != null && (this._m.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property N.
        /// </summary>
        public string N
        {
            get { return this._n; }
            set { this._n = value; }
        }

        // Check to see if N property is set
        internal bool IsSetN()
        {
            return this._n != null;
        }

        /// <summary>
        /// Gets and sets the property NS.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NS
        {
            get { return this._ns; }
            set { this._ns = value; }
        }

        // Check to see if NS property is set
        internal bool IsSetNS()
        {
            return this._ns != null && (this._ns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NULL.
        /// </summary>
        public bool? NULL
        {
            get { return this._null; }
            set { this._null = value; }
        }

        // Check to see if NULL property is set
        internal bool IsSetNULL()
        {
            return this._null.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S.
        /// </summary>
        public string S
        {
            get { return this._s; }
            set { this._s = value; }
        }

        // Check to see if S property is set
        internal bool IsSetS()
        {
            return this._s != null;
        }

        /// <summary>
        /// Gets and sets the property SS.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SS
        {
            get { return this._ss; }
            set { this._ss = value; }
        }

        // Check to see if SS property is set
        internal bool IsSetSS()
        {
            return this._ss != null && (this._ss.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}