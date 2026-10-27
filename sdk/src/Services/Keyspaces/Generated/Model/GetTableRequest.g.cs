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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the GetTable operation. Returns information about
    /// the table, including the table's name and current status, the keyspace name, configuration
    /// settings, and metadata. <para> To read table metadata using <c>GetTable</c>, the IAM
    /// principal needs <c>Select</c> action permissions for the table and the system keyspace.
    /// </para>
    /// </summary>
    public partial class GetTableRequest : AmazonKeyspacesRequest
    {
        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace that the table is stored in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceName property is set.
        /// </summary>
        internal bool IsSetKeyspaceName() => this.KeyspaceName != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
