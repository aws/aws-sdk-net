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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// A list of requests that can perform update, put, delete, or check operations on multiple
    /// items in one or more tables atomically.
    /// </summary>
    public partial class TransactWriteItem
    {
        /// <summary>
        /// Gets and sets the property ConditionCheck. 
        /// <para>
        /// A request to perform a check item operation.
        /// </para>
        /// </summary>
        public ConditionCheck ConditionCheck { get; set; }

        /// <summary>
        /// Checks to see if the ConditionCheck property is set.
        /// </summary>
        internal bool IsSetConditionCheck() => this.ConditionCheck != null;

        /// <summary>
        /// Gets and sets the property Delete. 
        /// <para>
        /// A request to perform a <c>DeleteItem</c> operation.
        /// </para>
        /// </summary>
        public Delete Delete { get; set; }

        /// <summary>
        /// Checks to see if the Delete property is set.
        /// </summary>
        internal bool IsSetDelete() => this.Delete != null;

        /// <summary>
        /// Gets and sets the property Put. 
        /// <para>
        /// A request to perform a <c>PutItem</c> operation.
        /// </para>
        /// </summary>
        public Put Put { get; set; }

        /// <summary>
        /// Checks to see if the Put property is set.
        /// </summary>
        internal bool IsSetPut() => this.Put != null;

        /// <summary>
        /// Gets and sets the property Update. 
        /// <para>
        /// A request to perform an <c>UpdateItem</c> operation.
        /// </para>
        /// </summary>
        public Update Update { get; set; }

        /// <summary>
        /// Checks to see if the Update property is set.
        /// </summary>
        internal bool IsSetUpdate() => this.Update != null;
    }
}
