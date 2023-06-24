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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// An attribute value.
    /// </summary>
    public partial class AttributeValue
    {
        private string _b;
        private List<string> _bs = new List<string>();
        private string _n;
        private List<string> _ns = new List<string>();
        private string _s;
        private List<string> _ss = new List<string>();

        /// <summary>
        /// Gets and sets the property B. 
        /// <para>
        /// A binary value.
        /// </para>
        /// </summary>
        public string B
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
        /// Gets and sets the property BS. 
        /// <para>
        /// A list of binary values.
        /// </para>
        /// </summary>
        public List<string> BS
        {
            get { return this._bs; }
            set { this._bs = value; }
        }

        // Check to see if BS property is set
        internal bool IsSetBS()
        {
            return this._bs != null && this._bs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property N. 
        /// <para>
        /// A number.
        /// </para>
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
        /// <para>
        /// A list of numbers.
        /// </para>
        /// </summary>
        public List<string> NS
        {
            get { return this._ns; }
            set { this._ns = value; }
        }

        // Check to see if NS property is set
        internal bool IsSetNS()
        {
            return this._ns != null && this._ns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S. 
        /// <para>
        /// A string.
        /// </para>
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
        /// <para>
        /// A list of strings.
        /// </para>
        /// </summary>
        public List<string> SS
        {
            get { return this._ss; }
            set { this._ss = value; }
        }

        // Check to see if SS property is set
        internal bool IsSetSS()
        {
            return this._ss != null && this._ss.Count > 0; 
        }

    }
}