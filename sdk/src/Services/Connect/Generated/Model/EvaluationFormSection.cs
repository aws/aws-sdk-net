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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about a section from an evaluation form. A section can contain sections
    /// and/or questions. Evaluation forms can only contain sections and subsections (two
    /// level nesting).
    /// </summary>
    public partial class EvaluationFormSection
    {
        private string _instructions;
        private List<EvaluationFormItem> _items = AWSConfigs.InitializeCollections ? new List<EvaluationFormItem>() : null;
        private string _refId;
        private string _title;
        private double? _weight;

        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        /// The instructions of the section.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Instructions
        {
            get { return this._instructions; }
            set { this._instructions = value; }
        }

        // Check to see if Instructions property is set
        internal bool IsSetInstructions()
        {
            return this._instructions != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The items of the section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<EvaluationFormItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RefId. 
        /// <para>
        /// The identifier of the section. An identifier must be unique within the evaluation
        /// form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string RefId
        {
            get { return this._refId; }
            set { this._refId = value; }
        }

        // Check to see if RefId property is set
        internal bool IsSetRefId()
        {
            return this._refId != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the section.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The scoring weight of the section.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}