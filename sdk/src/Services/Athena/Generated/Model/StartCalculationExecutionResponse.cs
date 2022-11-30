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
    /// This is the response object from the StartCalculationExecution operation.
    /// </summary>
    public partial class StartCalculationExecutionResponse : AmazonWebServiceResponse
    {
        private string _calculationExecutionId;
        private CalculationExecutionState _state;

        /// <summary>
        /// Gets and sets the property CalculationExecutionId. 
        /// <para>
        /// The calculation execution UUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        ///  <code>CREATING</code> - The calculation is in the process of being created.
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATED</code> - The calculation has been created and is ready to run.
        /// </para>
        ///  
        /// <para>
        ///  <code>QUEUED</code> - The calculation has been queued for processing.
        /// </para>
        ///  
        /// <para>
        ///  <code>RUNNING</code> - The calculation is running.
        /// </para>
        ///  
        /// <para>
        ///  <code>CANCELING</code> - A request to cancel the calculation has been received and
        /// the system is working to stop it.
        /// </para>
        ///  
        /// <para>
        ///  <code>CANCELED</code> - The calculation is no longer running as the result of a cancel
        /// request.
        /// </para>
        ///  
        /// <para>
        ///  <code>COMPLETED</code> - The calculation has completed without error.
        /// </para>
        ///  
        /// <para>
        ///  <code>FAILED</code> - The calculation failed and is no longer running.
        /// </para>
        /// </summary>
        public CalculationExecutionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}