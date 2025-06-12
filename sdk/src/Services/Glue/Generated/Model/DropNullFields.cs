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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a transform that removes columns from the dataset if all values in the column
    /// are 'null'. By default, Glue Studio will recognize null objects, but some values such
    /// as empty strings, strings that are "null", -1 integers or other placeholders such
    /// as zeros, are not automatically recognized as nulls.
    /// </summary>
    public partial class DropNullFields
    {
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private NullCheckBoxList _nullCheckBoxList;
        private List<NullValueField> _nullTextList = AWSConfigs.InitializeCollections ? new List<NullValueField>() : null;

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The data inputs identified by their node names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the transform node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NullCheckBoxList. 
        /// <para>
        /// A structure that represents whether certain values are recognized as null values for
        /// removal.
        /// </para>
        /// </summary>
        public NullCheckBoxList NullCheckBoxList
        {
            get { return this._nullCheckBoxList; }
            set { this._nullCheckBoxList = value; }
        }

        // Check to see if NullCheckBoxList property is set
        internal bool IsSetNullCheckBoxList()
        {
            return this._nullCheckBoxList != null;
        }

        /// <summary>
        /// Gets and sets the property NullTextList. 
        /// <para>
        /// A structure that specifies a list of NullValueField structures that represent a custom
        /// null value such as zero or other value being used as a null placeholder unique to
        /// the dataset.
        /// </para>
        ///  
        /// <para>
        /// The <c>DropNullFields</c> transform removes custom null values only if both the value
        /// of the null placeholder and the datatype match the data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<NullValueField> NullTextList
        {
            get { return this._nullTextList; }
            set { this._nullTextList = value; }
        }

        // Check to see if NullTextList property is set
        internal bool IsSetNullTextList()
        {
            return this._nullTextList != null && (this._nullTextList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}