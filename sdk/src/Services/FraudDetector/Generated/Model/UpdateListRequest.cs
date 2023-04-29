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
    /// Container for the parameters to the UpdateList operation.
    /// Updates a list.
    /// </summary>
    public partial class UpdateListRequest : AmazonFraudDetectorRequest
    {
        private string _description;
        private List<string> _elements = new List<string>();
        private string _name;
        private ListUpdateMode _updateMode;
        private string _variableType;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The new description. 
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
        ///  One or more list elements to add or replace. If you are providing the elements, make
        /// sure to specify the <code>updateMode</code> to use. 
        /// </para>
        ///  
        /// <para>
        /// If you are deleting all elements from the list, use <code>REPLACE</code> for the <code>updateMode</code>
        /// and provide an empty list (0 elements).
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
        ///  The name of the list to update. 
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
        /// Gets and sets the property UpdateMode. 
        /// <para>
        ///  The update mode (type). 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <code>APPEND</code> if you are adding elements to the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>REPLACE</code> if you replacing existing elements in the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>REMOVE</code> if you are removing elements from the list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ListUpdateMode UpdateMode
        {
            get { return this._updateMode; }
            set { this._updateMode = value; }
        }

        // Check to see if UpdateMode property is set
        internal bool IsSetUpdateMode()
        {
            return this._updateMode != null;
        }

        /// <summary>
        /// Gets and sets the property VariableType. 
        /// <para>
        ///  The variable type you want to assign to the list. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot update a variable type of a list that already has a variable type assigned
        /// to it. You can assign a variable type to a list only if the list does not already
        /// have a variable type.
        /// </para>
        ///  </note>
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