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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// An object that represents the result of a single upsert row request.
    /// </summary>
    public partial class UpsertRowsResult
    {
        private List<string> _rowIds = new List<string>();
        private UpsertAction _upsertAction;

        /// <summary>
        /// Gets and sets the property RowIds. 
        /// <para>
        ///  The list of row ids that were changed as part of an upsert row operation. If the
        /// upsert resulted in an update, this list could potentially contain multiple rows that
        /// matched the filter and hence got updated. If the upsert resulted in an append, this
        /// list would only have the single row that was appended. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> RowIds
        {
            get { return this._rowIds; }
            set { this._rowIds = value; }
        }

        // Check to see if RowIds property is set
        internal bool IsSetRowIds()
        {
            return this._rowIds != null && this._rowIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpsertAction. 
        /// <para>
        ///  The result of the upsert action. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpsertAction UpsertAction
        {
            get { return this._upsertAction; }
            set { this._upsertAction = value; }
        }

        // Check to see if UpsertAction property is set
        internal bool IsSetUpsertAction()
        {
            return this._upsertAction != null;
        }

    }
}