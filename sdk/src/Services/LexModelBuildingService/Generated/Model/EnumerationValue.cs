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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Each slot type can have a set of values. Each enumeration value represents a value
    /// the slot type can take. 
    /// 
    ///  
    /// <para>
    /// For example, a pizza ordering bot could have a slot type that specifies the type of
    /// crust that the pizza should have. The slot type could include the values 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// thick
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// thin
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// stuffed
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EnumerationValue
    {
        private List<string> _synonyms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _value;

        /// <summary>
        /// Gets and sets the property Synonyms. 
        /// <para>
        /// Additional values related to the slot type value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Synonyms
        {
            get { return this._synonyms; }
            set { this._synonyms = value; }
        }

        // Check to see if Synonyms property is set
        internal bool IsSetSynonyms()
        {
            return this._synonyms != null && (this._synonyms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}