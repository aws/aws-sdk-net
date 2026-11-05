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
    /// Container for the parameters to the CancelBulkOperation operation. Cancels an in-progress
    /// bulk operation asynchronously. Cancellation doesn't remove items that the operation
    /// has already written. Use <c>DescribeBulkOperation</c> to monitor the operation until
    /// it reaches a terminal status.
    /// </summary>
    public partial class CancelBulkOperationRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Gets and sets the property BulkOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bulk operation to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 37, Max = 1024)]
        public string BulkOperationArn { get; set; }

        /// <summary>
        /// Checks to see if the BulkOperationArn property is set.
        /// </summary>
        internal bool IsSetBulkOperationArn() => this.BulkOperationArn != null;
    }
}
