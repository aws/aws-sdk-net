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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// CellInput object contains the data needed to create or update cells in a table. 
    /// 
    ///  <note> 
    /// <para>
    ///  CellInput object has only a facts field or a fact field, but not both. A 400 bad
    /// request will be thrown if both fact and facts field are present. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CellInput
    {
        private string _fact;
        private List<string> _facts = new List<string>();

        /// <summary>
        /// Gets and sets the property Fact. 
        /// <para>
        ///  Fact represents the data that is entered into a cell. This data can be free text
        /// or a formula. Formulas need to start with the equals (=) sign. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=8192)]
        public string Fact
        {
            get { return this._fact; }
            set { this._fact = value; }
        }

        // Check to see if Fact property is set
        internal bool IsSetFact()
        {
            return this._fact != null;
        }

        /// <summary>
        /// Gets and sets the property Facts. 
        /// <para>
        ///  A list representing the values that are entered into a ROWSET cell. Facts list can
        /// have either only values or rowIDs, and rowIDs should from the same table. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=220)]
        public List<string> Facts
        {
            get { return this._facts; }
            set { this._facts = value; }
        }

        // Check to see if Facts property is set
        internal bool IsSetFacts()
        {
            return this._facts != null && this._facts.Count > 0; 
        }

    }
}