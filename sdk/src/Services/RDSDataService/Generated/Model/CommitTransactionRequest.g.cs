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

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Container for the parameters to the CommitTransaction operation. Ends a SQL transaction
    /// started with the <c>BeginTransaction</c> operation and commits the changes.
    /// </summary>
    public partial class CommitTransactionRequest : AmazonRDSDataServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Aurora Serverless DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 570)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 570)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The identifier of the transaction to end and commit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 192)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;
    }
}
