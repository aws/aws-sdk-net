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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the CreateList operation.
    /// Creates a list. 
    /// 
    ///  
    /// <para>
    /// List is a set of input data for a variable in your event dataset. You use the input
    /// data in a rule that's associated with your detector. For more information, see <a
    /// href="https://docs.aws.amazon.com/frauddetector/latest/ug/lists.html">Lists</a>.
    /// </para>
    /// </summary>
    public partial class CreateListRequest : AmazonFraudDetectorRequest
    {
        private string _description;
        private List<string> _elements = new List<string>();
        private string _name;
        private List<Tag> _tags = new List<Tag>();
        private string _variableType;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Elements. 
        /// <para>
        ///  The names of the elements, if providing. You can also create an empty list and add
        /// elements later using the <a href="https://docs.aws.amazon.com/frauddetector/latest/api/API_Updatelist.html">UpdateList</a>
        /// API. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public List<string> Elements
        {
            get { return this._elements; }
            set { this._elements = value; }
        }

        // Check to see if Elements property is set
        internal bool IsSetElements()
        {
            return this._elements != null && this._elements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the list. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A collection of the key and value pairs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VariableType. 
        /// <para>
        ///  The variable type of the list. You can only assign the variable type with String
        /// data type. For more information, see <a href="https://docs.aws.amazon.com/frauddetector/latest/ug/create-a-variable.html#variable-types">Variable
        /// types</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string VariableType
        {
            get { return this._variableType; }
            set { this._variableType = value; }
        }

        // Check to see if VariableType property is set
        internal bool IsSetVariableType()
        {
            return this._variableType != null;
        }

    }
}