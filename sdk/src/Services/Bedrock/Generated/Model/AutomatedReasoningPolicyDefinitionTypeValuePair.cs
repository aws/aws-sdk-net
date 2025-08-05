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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Associates a type name with a specific value name, used for referencing type values
    /// in rules and other policy elements.
    /// </summary>
    public partial class AutomatedReasoningPolicyDefinitionTypeValuePair
    {
        private string _typeName;
        private string _valueName;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the custom type that contains the referenced value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property ValueName. 
        /// <para>
        /// The name of the specific value within the type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ValueName
        {
            get { return this._valueName; }
            set { this._valueName = value; }
        }

        // Check to see if ValueName property is set
        internal bool IsSetValueName()
        {
            return this._valueName != null;
        }

    }
}