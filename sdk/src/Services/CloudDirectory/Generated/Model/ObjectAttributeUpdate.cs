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
    public partial class ObjectAttributeUpdate
    {
        private ObjectAttributeAction _objectAttributeAction;
        private AttributeKey _objectAttributeKey;

        /// <summary>
        /// Gets and sets the property ObjectAttributeAction. 
        /// <para>
        /// The action to perform as part of the attribute update.
        /// </para>
        /// </summary>
        public ObjectAttributeAction ObjectAttributeAction
        {
            get { return this._objectAttributeAction; }
            set { this._objectAttributeAction = value; }
        }

        // Check to see if ObjectAttributeAction property is set
        internal bool IsSetObjectAttributeAction()
        {
            return this._objectAttributeAction != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectAttributeKey. 
        /// <para>
        /// The key of the attribute being updated.
        /// </para>
        /// </summary>
        public AttributeKey ObjectAttributeKey
        {
            get { return this._objectAttributeKey; }
            set { this._objectAttributeKey = value; }
        }

        // Check to see if ObjectAttributeKey property is set
        internal bool IsSetObjectAttributeKey()
        {
            return this._objectAttributeKey != null;
        }

    }
}