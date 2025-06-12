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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// The structured message for the message signal. It can be defined with either a <c>primitiveMessageDefinition</c>,
    /// <c>structuredMessageListDefinition</c>, or <c>structuredMessageDefinition</c> recursively.
    /// </summary>
    public partial class StructuredMessage
    {
        private PrimitiveMessageDefinition _primitiveMessageDefinition;
        private List<StructuredMessageFieldNameAndDataTypePair> _structuredMessageDefinition = AWSConfigs.InitializeCollections ? new List<StructuredMessageFieldNameAndDataTypePair>() : null;
        private StructuredMessageListDefinition _structuredMessageListDefinition;

        /// <summary>
        /// Gets and sets the property PrimitiveMessageDefinition. 
        /// <para>
        /// Represents a primitive type node of the complex data structure.
        /// </para>
        /// </summary>
        public PrimitiveMessageDefinition PrimitiveMessageDefinition
        {
            get { return this._primitiveMessageDefinition; }
            set { this._primitiveMessageDefinition = value; }
        }

        // Check to see if PrimitiveMessageDefinition property is set
        internal bool IsSetPrimitiveMessageDefinition()
        {
            return this._primitiveMessageDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property StructuredMessageDefinition. 
        /// <para>
        /// Represents a struct type node of the complex data structure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<StructuredMessageFieldNameAndDataTypePair> StructuredMessageDefinition
        {
            get { return this._structuredMessageDefinition; }
            set { this._structuredMessageDefinition = value; }
        }

        // Check to see if StructuredMessageDefinition property is set
        internal bool IsSetStructuredMessageDefinition()
        {
            return this._structuredMessageDefinition != null && (this._structuredMessageDefinition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StructuredMessageListDefinition. 
        /// <para>
        /// Represents a list type node of the complex data structure.
        /// </para>
        /// </summary>
        public StructuredMessageListDefinition StructuredMessageListDefinition
        {
            get { return this._structuredMessageListDefinition; }
            set { this._structuredMessageListDefinition = value; }
        }

        // Check to see if StructuredMessageListDefinition property is set
        internal bool IsSetStructuredMessageListDefinition()
        {
            return this._structuredMessageListDefinition != null;
        }

    }
}