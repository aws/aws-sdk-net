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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for a document field/attribute that you want
    /// to base query suggestions on.
    /// </summary>
    public partial class SuggestableConfig
    {
        private string _attributeName;
        private bool? _suggestable;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the document field/attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property Suggestable. 
        /// <para>
        ///  <c>TRUE</c> means the document field/attribute is suggestible, so the contents within
        /// the field can be used for query suggestions.
        /// </para>
        /// </summary>
        public bool? Suggestable
        {
            get { return this._suggestable; }
            set { this._suggestable = value; }
        }

        // Check to see if Suggestable property is set
        internal bool IsSetSuggestable()
        {
            return this._suggestable.HasValue; 
        }

    }
}