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
    /// The action to take on the object attribute.
    /// </summary>
    public partial class ObjectAttributeAction
    {
        private UpdateActionType _objectAttributeActionType;
        private TypedAttributeValue _objectAttributeUpdateValue;

        /// <summary>
        /// Gets and sets the property ObjectAttributeActionType. 
        /// <para>
        /// A type that can be either <c>Update</c> or <c>Delete</c>.
        /// </para>
        /// </summary>
        public UpdateActionType ObjectAttributeActionType
        {
            get { return this._objectAttributeActionType; }
            set { this._objectAttributeActionType = value; }
        }

        // Check to see if ObjectAttributeActionType property is set
        internal bool IsSetObjectAttributeActionType()
        {
            return this._objectAttributeActionType != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectAttributeUpdateValue. 
        /// <para>
        /// The value that you want to update to.
        /// </para>
        /// </summary>
        public TypedAttributeValue ObjectAttributeUpdateValue
        {
            get { return this._objectAttributeUpdateValue; }
            set { this._objectAttributeUpdateValue = value; }
        }

        // Check to see if ObjectAttributeUpdateValue property is set
        internal bool IsSetObjectAttributeUpdateValue()
        {
            return this._objectAttributeUpdateValue != null;
        }

    }
}