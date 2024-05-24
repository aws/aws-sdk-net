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
    /// Structure that contains attribute update information.
    /// </summary>
    public partial class LinkAttributeUpdate
    {
        private LinkAttributeAction _attributeAction;
        private AttributeKey _attributeKey;

        /// <summary>
        /// Gets and sets the property AttributeAction. 
        /// <para>
        /// The action to perform as part of the attribute update.
        /// </para>
        /// </summary>
        public LinkAttributeAction AttributeAction
        {
            get { return this._attributeAction; }
            set { this._attributeAction = value; }
        }

        // Check to see if AttributeAction property is set
        internal bool IsSetAttributeAction()
        {
            return this._attributeAction != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeKey. 
        /// <para>
        /// The key of the attribute being updated.
        /// </para>
        /// </summary>
        public AttributeKey AttributeKey
        {
            get { return this._attributeKey; }
            set { this._attributeKey = value; }
        }

        // Check to see if AttributeKey property is set
        internal bool IsSetAttributeKey()
        {
            return this._attributeKey != null;
        }

    }
}