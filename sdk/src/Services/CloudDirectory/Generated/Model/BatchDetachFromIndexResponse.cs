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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the output of a <a>DetachFromIndex</a> response operation.
    /// </summary>
    public partial class BatchDetachFromIndexResponse
    {
        private string _detachedObjectIdentifier;

        /// <summary>
        /// Gets and sets the property DetachedObjectIdentifier. 
        /// <para>
        /// The <code>ObjectIdentifier</code> of the object that was detached from the index.
        /// </para>
        /// </summary>
        public string DetachedObjectIdentifier
        {
            get { return this._detachedObjectIdentifier; }
            set { this._detachedObjectIdentifier = value; }
        }

        // Check to see if DetachedObjectIdentifier property is set
        internal bool IsSetDetachedObjectIdentifier()
        {
            return this._detachedObjectIdentifier != null;
        }

    }
}