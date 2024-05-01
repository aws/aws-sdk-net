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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The name of a field in the request payload that contains part or all of your customer's
    /// primary physical address. 
    /// 
    ///  
    /// <para>
    /// This data type is used in the <c>RequestInspectionACFP</c> data type. 
    /// </para>
    /// </summary>
    public partial class AddressField
    {
        private string _identifier;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The name of a single primary address field. 
        /// </para>
        ///  
        /// <para>
        /// How you specify the address fields depends on the request inspection payload type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For JSON payloads, specify the field identifiers in JSON pointer syntax. For information
        /// about the JSON Pointer syntax, see the Internet Engineering Task Force (IETF) documentation
        /// <a href="https://tools.ietf.org/html/rfc6901">JavaScript Object Notation (JSON) Pointer</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, for the JSON payload <c>{ "form": { "primaryaddressline1": "THE_ADDRESS1",
        /// "primaryaddressline2": "THE_ADDRESS2", "primaryaddressline3": "THE_ADDRESS3" } }</c>,
        /// the address field idenfiers are <c>/form/primaryaddressline1</c>, <c>/form/primaryaddressline2</c>,
        /// and <c>/form/primaryaddressline3</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For form encoded payload types, use the HTML form names.
        /// </para>
        ///  
        /// <para>
        /// For example, for an HTML form with input elements named <c>primaryaddressline1</c>,
        /// <c>primaryaddressline2</c>, and <c>primaryaddressline3</c>, the address fields identifiers
        /// are <c>primaryaddressline1</c>, <c>primaryaddressline2</c>, and <c>primaryaddressline3</c>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}