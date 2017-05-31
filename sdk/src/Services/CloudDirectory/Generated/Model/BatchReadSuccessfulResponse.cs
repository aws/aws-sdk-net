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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
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
    /// Represents the output of a <code>BatchRead</code> success response operation.
    /// </summary>
    public partial class BatchReadSuccessfulResponse
    {
        private BatchListObjectAttributesResponse _listObjectAttributes;
        private BatchListObjectChildrenResponse _listObjectChildren;

        /// <summary>
        /// Gets and sets the property ListObjectAttributes. 
        /// <para>
        /// Lists all attributes that are associated with an object.
        /// </para>
        /// </summary>
        public BatchListObjectAttributesResponse ListObjectAttributes
        {
            get { return this._listObjectAttributes; }
            set { this._listObjectAttributes = value; }
        }

        // Check to see if ListObjectAttributes property is set
        internal bool IsSetListObjectAttributes()
        {
            return this._listObjectAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ListObjectChildren. 
        /// <para>
        /// Returns a paginated list of child objects that are associated with a given object.
        /// </para>
        /// </summary>
        public BatchListObjectChildrenResponse ListObjectChildren
        {
            get { return this._listObjectChildren; }
            set { this._listObjectChildren = value; }
        }

        // Check to see if ListObjectChildren property is set
        internal bool IsSetListObjectChildren()
        {
            return this._listObjectChildren != null;
        }

    }
}