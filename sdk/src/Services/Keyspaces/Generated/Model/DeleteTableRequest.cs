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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTable operation.
    /// The <code>DeleteTable</code> operation deletes a table and all of its data. After
    /// a <code>DeleteTable</code> request is received, the specified table is in the <code>DELETING</code>
    /// state until Amazon Keyspaces completes the deletion. If the table is in the <code>ACTIVE</code>
    /// state, you can delete it. If a table is either in the <code>CREATING</code> or <code>UPDATING</code>
    /// states, then Amazon Keyspaces returns a <code>ResourceInUseException</code>. If the
    /// specified table does not exist, Amazon Keyspaces returns a <code>ResourceNotFoundException</code>.
    /// If the table is already in the <code>DELETING</code> state, no error is returned.
    /// </summary>
    public partial class DeleteTableRequest : AmazonKeyspacesRequest
    {
        private string _keyspaceName;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace of the to be deleted table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}