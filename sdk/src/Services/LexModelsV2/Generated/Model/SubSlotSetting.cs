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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Specifications for the constituent sub slots and the expression for the composite
    /// slot.
    /// </summary>
    public partial class SubSlotSetting
    {
        private string _expression;
        private Dictionary<string, Specifications> _slotSpecifications = AWSConfigs.InitializeCollections ? new Dictionary<string, Specifications>() : null;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression text for defining the constituent sub slots in the composite slot using
        /// logical AND and OR operators.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=640)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property SlotSpecifications. 
        /// <para>
        /// Specifications for the constituent sub slots of a composite slot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public Dictionary<string, Specifications> SlotSpecifications
        {
            get { return this._slotSpecifications; }
            set { this._slotSpecifications = value; }
        }

        // Check to see if SlotSpecifications property is set
        internal bool IsSetSlotSpecifications()
        {
            return this._slotSpecifications != null && (this._slotSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}