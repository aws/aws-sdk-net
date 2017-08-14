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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeleteConnection operation.
    /// Deletes a list of connection definitions from the Data Catalog.
    /// </summary>
    public partial class BatchDeleteConnectionRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private List<string> _connectionNameList = new List<string>();

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the connections reside. If none is supplied, the
        /// AWS account ID is used by default.
        /// </para>
        /// </summary>
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionNameList. 
        /// <para>
        /// A list of names of the connections to delete.
        /// </para>
        /// </summary>
        public List<string> ConnectionNameList
        {
            get { return this._connectionNameList; }
            set { this._connectionNameList = value; }
        }

        // Check to see if ConnectionNameList property is set
        internal bool IsSetConnectionNameList()
        {
            return this._connectionNameList != null && this._connectionNameList.Count > 0; 
        }

    }
}