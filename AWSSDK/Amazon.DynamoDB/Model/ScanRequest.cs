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
    /// Container for the parameters to the Scan operation.
    /// <para>Retrieves one or more items and its attributes by performing a full scan of a table.</para> <para>Provide a <c>ScanFilter</c> to get
    /// more specific results.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.Scan"/>
    public class ScanRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private List<string> attributesToGet = new List<string>();
        private int? limit;
        private bool? count;
        private Dictionary<string,Condition> scanFilter = new Dictionary<string,Condition>();
        private Key exclusiveStartKey;

        /// <summary>
        /// The name of the table in which you want to scan. Allowed characters are <c>a-z</c>, <c>A-Z</c>, <c>0-9</c>, <c>_</c> (underscore), <c>-</c>
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
        public ScanRequest WithTableName(string tableName)
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
        /// List of <c>Attribute</c> names. If attribute names are not specified then all attributes will be returned. If some attributes are not found,
        /// they will not appear in the result.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this.attributesToGet; }
            set { this.attributesToGet = value; }
        }
        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        public ScanRequest WithAttributesToGet(params string[] attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        public ScanRequest WithAttributesToGet(IEnumerable<string> attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this.attributesToGet.Count > 0;       
        }

        /// <summary>
        /// The maximum number of items to return. If Amazon DynamoDB hits this limit while scanning the table, it stops the scan and returns the
        /// matching values up to the limit, and a <c>LastEvaluatedKey</c> to apply in a subsequent operation to continue the scan. Also, if the scanned
        /// data set size exceeds 1 MB before Amazon DynamoDB hits this limit, it stops the scan and returns the matching values up to the limit, and a
        /// <c>LastEvaluatedKey</c> to apply in a subsequent operation to continue the scan.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        public ScanRequest WithLimit(int limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;       
        }

        /// <summary>
        /// If set to <c>true</c>, Amazon DynamoDB returns a total number of items for the <c>Scan</c> operation, even if the operation has no matching
        /// items for the assigned filter. Do not set <c>Count</c> to <c>true</c> while providing a list of <c>AttributesToGet</c>, otherwise Amazon
        /// DynamoDB returns a validation error.
        ///  
        /// </summary>
        public bool Count
        {
            get { return this.count ?? default(bool); }
            set { this.count = value; }
        }

        /// <summary>
        /// Sets the Count property
        /// </summary>
        /// <param name="count">The value to set for the Count property </param>
        /// <returns>this instance</returns>
        public ScanRequest WithCount(bool count)
        {
            this.count = count;
            return this;
        }
            

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this.count.HasValue;       
        }

        /// <summary>
        /// Evaluates the scan results and returns only the desired values.
        ///  
        /// </summary>
        public Dictionary<string,Condition> ScanFilter
        {
            get { return this.scanFilter; }
            set { this.scanFilter = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the ScanFilter dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the ScanFilter dictionary.</param>
        /// <returns>this instance</returns>
        public ScanRequest WithScanFilter(params KeyValuePair<string, Condition>[] pairs)
        {
            foreach (KeyValuePair<string, Condition> pair in pairs)
            {
                this.ScanFilter[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if ScanFilter property is set
        internal bool IsSetScanFilter()
        {
            return this.scanFilter != null;       
        }

        /// <summary>
        /// Primary key of the item from which to continue an earlier scan. An earlier scan might provide this value if that scan operation was
        /// interrupted before scanning the entire table; either because of the result set size or the <c>Limit</c> parameter. The
        /// <c>LastEvaluatedKey</c> can be passed back in a new scan request to continue the operation from that point.
        ///  
        /// </summary>
        public Key ExclusiveStartKey
        {
            get { return this.exclusiveStartKey; }
            set { this.exclusiveStartKey = value; }
        }

        /// <summary>
        /// Sets the ExclusiveStartKey property
        /// </summary>
        /// <param name="exclusiveStartKey">The value to set for the ExclusiveStartKey property </param>
        /// <returns>this instance</returns>
        public ScanRequest WithExclusiveStartKey(Key exclusiveStartKey)
        {
            this.exclusiveStartKey = exclusiveStartKey;
            return this;
        }
            

        // Check to see if ExclusiveStartKey property is set
        internal bool IsSetExclusiveStartKey()
        {
            return this.exclusiveStartKey != null;       
        }
    }
}
    
