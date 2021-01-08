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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Details about the query.
    /// </summary>
    public partial class QueryInfo
    {
        private List<FieldInfo> _selectFields = new List<FieldInfo>();

        /// <summary>
        /// Gets and sets the property SelectFields. 
        /// <para>
        /// Returns a <code>FieldInfo</code> object.
        /// </para>
        /// </summary>
        public List<FieldInfo> SelectFields
        {
            get { return this._selectFields; }
            set { this._selectFields = value; }
        }

        // Check to see if SelectFields property is set
        internal bool IsSetSelectFields()
        {
            return this._selectFields != null && this._selectFields.Count > 0; 
        }

    }
}