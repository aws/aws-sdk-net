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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the CheckpointDurableExecution operation.
    /// Saves the progress of a <a href="https://docs.aws.amazon.com/lambda/latest/dg/durable-functions.html">durable
    /// function</a> execution during runtime. This API is used by the Lambda durable functions
    /// SDK to checkpoint completed steps and schedule asynchronous operations. You typically
    /// don't need to call this API directly as the SDK handles checkpointing automatically.
    /// 
    ///  
    /// <para>
    /// Each checkpoint operation consumes the current checkpoint token and returns a new
    /// one for the next checkpoint. This ensures that checkpoints are applied in the correct
    /// order and prevents duplicate or out-of-order state updates.
    /// </para>
    /// </summary>
    public partial class CheckpointDurableExecutionRequest : AmazonLambdaRequest
    {
        private string _checkpointToken;
        private string _clientToken;
        private string _durableExecutionArn;
        private List<OperationUpdate> _updates = AWSConfigs.InitializeCollections ? new List<OperationUpdate>() : null;

        /// <summary>
        /// Gets and sets the property CheckpointToken. 
        /// <para>
        /// A unique token that identifies the current checkpoint state. This token is provided
        /// by the Lambda runtime and must be used to ensure checkpoints are applied in the correct
        /// order. Each checkpoint operation consumes this token and returns a new one.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string CheckpointToken
        {
            get { return this._checkpointToken; }
            set { this._checkpointToken = value; }
        }

        // Check to see if CheckpointToken property is set
        internal bool IsSetCheckpointToken()
        {
            return this._checkpointToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An optional idempotency token to ensure that duplicate checkpoint requests are handled
        /// correctly. If provided, Lambda uses this token to detect and handle duplicate requests
        /// within a 15-minute window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DurableExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the durable execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string DurableExecutionArn
        {
            get { return this._durableExecutionArn; }
            set { this._durableExecutionArn = value; }
        }

        // Check to see if DurableExecutionArn property is set
        internal bool IsSetDurableExecutionArn()
        {
            return this._durableExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of state updates to apply during this checkpoint. Each update represents
        /// a change to the execution state, such as completing a step, starting a callback, or
        /// scheduling a timer. Updates are applied atomically as part of the checkpoint operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OperationUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && (this._updates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}