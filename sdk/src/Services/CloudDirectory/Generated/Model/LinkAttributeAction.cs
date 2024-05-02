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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// The action to take on a typed link attribute value. Updates are only supported for
    /// attributes which don’t contribute to link identity.
    /// </summary>
    public partial class LinkAttributeAction
    {
        private UpdateActionType _attributeActionType;
        private TypedAttributeValue _attributeUpdateValue;

        /// <summary>
        /// Gets and sets the property AttributeActionType. 
        /// <para>
        /// A type that can be either <c>UPDATE_OR_CREATE</c> or <c>DELETE</c>.
        /// </para>
        /// </summary>
        public UpdateActionType AttributeActionType
        {
            get { return this._attributeActionType; }
            set { this._attributeActionType = value; }
        }

        // Check to see if AttributeActionType property is set
        internal bool IsSetAttributeActionType()
        {
            return this._attributeActionType != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeUpdateValue. 
        /// <para>
        /// The value that you want to update to.
        /// </para>
        /// </summary>
        public TypedAttributeValue AttributeUpdateValue
        {
            get { return this._attributeUpdateValue; }
            set { this._attributeUpdateValue = value; }
        }

        // Check to see if AttributeUpdateValue property is set
        internal bool IsSetAttributeUpdateValue()
        {
            return this._attributeUpdateValue != null;
        }

    }
}