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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The quick response fields to order the quick response query results by.
    /// 
    ///  
    /// <para>
    /// The following is the list of supported field names.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// description
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// shortcutKey
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// isActive
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// channels
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// language
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// contentType
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// createdTime
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// lastModifiedTime
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// lastModifiedBy
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// groupingConfiguration.criteria
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// groupingConfiguration.values
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class QuickResponseOrderField
    {
        private string _name;
        private Order _order;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute to order the quick response query results by.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order at which the quick responses are sorted by.
        /// </para>
        /// </summary>
        public Order Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

    }
}