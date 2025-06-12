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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the CancelFlowExecutions operation.
    /// Cancels active runs for a flow.
    /// 
    ///  
    /// <para>
    /// You can cancel all of the active runs for a flow, or you can cancel specific runs
    /// by providing their IDs.
    /// </para>
    ///  
    /// <para>
    /// You can cancel a flow run only when the run is in progress. You can't cancel a run
    /// that has already completed or failed. You also can't cancel a run that's scheduled
    /// to occur but hasn't started yet. To prevent a scheduled run, you can deactivate the
    /// flow with the <c>StopFlow</c> action.
    /// </para>
    ///  
    /// <para>
    /// You cannot resume a run after you cancel it.
    /// </para>
    ///  
    /// <para>
    /// When you send your request, the status for each run becomes <c>CancelStarted</c>.
    /// When the cancellation completes, the status becomes <c>Canceled</c>.
    /// </para>
    ///  <note> 
    /// <para>
    /// When you cancel a run, you still incur charges for any data that the run already processed
    /// before the cancellation. If the run had already written some data to the flow destination,
    /// then that data remains in the destination. If you configured the flow to use a batch
    /// API (such as the Salesforce Bulk API 2.0), then the run will finish reading or writing
    /// its entire batch of data after the cancellation. For these operations, the data processing
    /// charges for Amazon AppFlow apply. For the pricing information, see <a href="http://aws.amazon.com/appflow/pricing/">Amazon
    /// AppFlow pricing</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CancelFlowExecutionsRequest : AmazonAppflowRequest
    {
        private List<string> _executionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _flowName;

        /// <summary>
        /// Gets and sets the property ExecutionIds. 
        /// <para>
        /// The ID of each active run to cancel. These runs must belong to the flow you specify
        /// in your request.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, your request ends all active runs that belong to the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExecutionIds
        {
            get { return this._executionIds; }
            set { this._executionIds = value; }
        }

        // Check to see if ExecutionIds property is set
        internal bool IsSetExecutionIds()
        {
            return this._executionIds != null && (this._executionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The name of a flow with active runs that you want to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string FlowName
        {
            get { return this._flowName; }
            set { this._flowName = value; }
        }

        // Check to see if FlowName property is set
        internal bool IsSetFlowName()
        {
            return this._flowName != null;
        }

    }
}