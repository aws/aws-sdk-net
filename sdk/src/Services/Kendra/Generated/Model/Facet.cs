/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Information a document attribute
    /// </summary>
    public partial class Facet
    {
        private string _documentAttributeKey;

        /// <summary>
        /// Gets and sets the property DocumentAttributeKey. 
        /// <para>
        /// The unique key for the document attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string DocumentAttributeKey
        {
            get { return this._documentAttributeKey; }
            set { this._documentAttributeKey = value; }
        }

        // Check to see if DocumentAttributeKey property is set
        internal bool IsSetDocumentAttributeKey()
        {
            return this._documentAttributeKey != null;
        }

    }
}