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

namespace Amazon.DynamoDB.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTable operation.
    /// <para>Adds a new table to your account.</para> <para>The table name must be unique among those associated with the AWS Account issuing the
    /// request, and the AWS Region that receives the request (e.g. <c>us-east-1</c> ).</para> <para>The <c>CreateTable</c> operation triggers an
    /// asynchronous workflow to begin creating the table. Amazon DynamoDB immediately returns the state of the table ( <c>CREATING</c> ) until the
    /// table is in the <c>ACTIVE</c> state. Once the table is in the <c>ACTIVE</c> state, you can perform data plane operations.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.CreateTable"/>
    public class CreateTableRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private KeySchema keySchema;
        private ProvisionedThroughput provisionedThroughput;

        /// <summary>
        /// The name of the table you want to create. Allowed characters are <c>a-z</c>, <c>A-Z</c>, <c>0-9</c>, <c>_</c> (underscore), <c>-</c>
        /// (hyphen) and <c>.</c> (period).
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
        public CreateTableRequest WithTableName(string tableName)
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
        /// The KeySchema identifies the primary key as a one attribute primary key (hash) or a composite two attribute (hash-and-range) primary key.
        /// Single attribute primary keys have one index value: a <c>HashKeyElement</c>. A composite hash-and-range primary key contains two attribute
        /// values: a <c>HashKeyElement</c> and a <c>RangeKeyElement</c>.
        ///  
        /// </summary>
        public KeySchema KeySchema
        {
            get { return this.keySchema; }
            set { this.keySchema = value; }
        }

        /// <summary>
        /// Sets the KeySchema property
        /// </summary>
        /// <param name="keySchema">The value to set for the KeySchema property </param>
        /// <returns>this instance</returns>
        public CreateTableRequest WithKeySchema(KeySchema keySchema)
        {
            this.keySchema = keySchema;
            return this;
        }
            

        // Check to see if KeySchema property is set
        internal bool IsSetKeySchema()
        {
            return this.keySchema != null;       
        }

        /// <summary>
        /// Provisioned throughput reserves the required read and write resources for your table in terms of <c>ReadCapacityUnits</c> and
        /// <c>WriteCapacityUnits</c>. Values for provisioned throughput depend upon your expected read/write rates, item size, and consistency. Provide
        /// the expected number of read and write operations, assuming an item size of 1k and strictly consistent reads. For 2k item size, double the
        /// value. For 3k, triple the value, etc. Eventually-consistent reads consume half the resources of strictly consistent reads.
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
        public CreateTableRequest WithProvisionedThroughput(ProvisionedThroughput provisionedThroughput)
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
    
