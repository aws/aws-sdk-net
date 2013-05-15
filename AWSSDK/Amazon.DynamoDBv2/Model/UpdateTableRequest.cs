/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTable operation.
    /// <para>Updates the provisioned throughput for the given table. Setting the throughput for a table helps you manage performance and is part of
    /// the provisioned throughput feature of Amazon DynamoDB.</para> <para>The provisioned throughput values can be upgraded or downgraded based on
    /// the maximums and minimums listed in the Limits section in the <i>Amazon DynamoDB Developer Guide</i> .</para> <para>The table must be in
    /// the <c>ACTIVE</c> state for this operation to succeed. <i>UpdateTable</i> is an asynchronous operation; while executing the operation, the
    /// table is in the <c>UPDATING</c> state. While the table is in the <c>UPDATING</c> state, the table still has the provisioned throughput from
    /// before the call. The new provisioned throughput setting is in effect only when the table returns to the <c>ACTIVE</c> state after the
    /// <i>UpdateTable</i> operation. </para> <para>You cannot add, modify or delete local secondary indexes using <i>UpdateTable</i> . Local
    /// secondary indexes can only be defined at table creation time.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.UpdateTable"/>
    public class UpdateTableRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private ProvisionedThroughput provisionedThroughput;

        /// <summary>
        /// The name of the table to be updated.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this.tableName; }
            set { this.tableName = value; }
        }

        /// <summary>
        /// Sets the TableName property
        /// </summary>
        /// <param name="tableName">The value to set for the TableName property </param>
        /// <returns>this instance</returns>
        public UpdateTableRequest WithTableName(string tableName)
        {
            this.tableName = tableName;
            return this;
        }
            

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this.tableName != null;
        }

        /// <summary>
        /// The provisioned throughput settings for the specified table. The settings can be modified using the <i>UpdateTable</i> operation. For
        /// current minimum and maximum provisioned throughput values, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Limits</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        ///  
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput
        {
            get { return this.provisionedThroughput; }
            set { this.provisionedThroughput = value; }
        }

        /// <summary>
        /// Sets the ProvisionedThroughput property
        /// </summary>
        /// <param name="provisionedThroughput">The value to set for the ProvisionedThroughput property </param>
        /// <returns>this instance</returns>
        public UpdateTableRequest WithProvisionedThroughput(ProvisionedThroughput provisionedThroughput)
        {
            this.provisionedThroughput = provisionedThroughput;
            return this;
        }
            

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this.provisionedThroughput != null;
        }
    }
}
    
