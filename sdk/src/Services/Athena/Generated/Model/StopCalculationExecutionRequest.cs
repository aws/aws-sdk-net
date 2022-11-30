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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the StopCalculationExecution operation.
    /// Requests the cancellation of a calculation. A <code>StopCalculationExecution</code>
    /// call on a calculation that is already in a terminal state (for example, <code>STOPPED</code>,
    /// <code>FAILED</code>, or <code>COMPLETED</code>) succeeds but has no effect.
    /// 
    ///  <note> 
    /// <para>
    /// Cancelling a calculation is done on a best effort basis. If a calculation cannot be
    /// cancelled, you can be charged for its completion. If you are concerned about being
    /// charged for a calculation that cannot be cancelled, consider terminating the session
    /// in which the calculation is running.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StopCalculationExecutionRequest : AmazonAthenaRequest
    {
        private string _calculationExecutionId;

        /// <summary>
        /// Gets and sets the property CalculationExecutionId. 
        /// <para>
        /// The calculation execution UUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string CalculationExecutionId
        {
            get { return this._calculationExecutionId; }
            set { this._calculationExecutionId = value; }
        }

        // Check to see if CalculationExecutionId property is set
        internal bool IsSetCalculationExecutionId()
        {
            return this._calculationExecutionId != null;
        }

    }
}