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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the count of documents that match a particular attribute when doing a faceted
    /// search.
    /// </summary>
    public partial class DocumentAttributeValueCountPair
    {
        private int? _count;
        private DocumentAttributeValue _documentAttributeValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of documents in the response that have the attribute value for the key.
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentAttributeValue. 
        /// <para>
        /// The value of the attribute. For example, "HR."
        /// </para>
        /// </summary>
        public DocumentAttributeValue DocumentAttributeValue
        {
            get { return this._documentAttributeValue; }
            set { this._documentAttributeValue = value; }
        }

        // Check to see if DocumentAttributeValue property is set
        internal bool IsSetDocumentAttributeValue()
        {
            return this._documentAttributeValue != null;
        }

    }
}