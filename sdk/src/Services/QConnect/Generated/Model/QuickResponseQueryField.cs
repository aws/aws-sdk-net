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
    /// The quick response fields to query quick responses by.
    /// 
    ///  
    /// <para>
    /// The following is the list of supported field names.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// content
    /// </para>
    ///  </li> <li> 
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
    ///  </li> </ul>
    /// </summary>
    public partial class QuickResponseQueryField
    {
        private bool? _allowFuzziness;
        private string _name;
        private QuickResponseQueryOperator _operator;
        private Priority _priority;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowFuzziness. 
        /// <para>
        /// Whether the query expects only exact matches on the attribute field values. The results
        /// of the query will only include exact matches if this parameter is set to false.
        /// </para>
        /// </summary>
        public bool? AllowFuzziness
        {
            get { return this._allowFuzziness; }
            set { this._allowFuzziness = value; }
        }

        // Check to see if AllowFuzziness property is set
        internal bool IsSetAllowFuzziness()
        {
            return this._allowFuzziness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute to query the quick responses by.
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
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to use for matching attribute field values in the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuickResponseQueryOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The importance of the attribute field when calculating query result relevancy scores.
        /// The value set for this parameter affects the ordering of search results.
        /// </para>
        /// </summary>
        public Priority Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the attribute to query the quick responses by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}