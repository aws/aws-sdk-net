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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// This is the response object from the CancelQuantumTask operation.
    /// </summary>
    public partial class CancelQuantumTaskResponse : AmazonWebServiceResponse
    {
        private CancellationStatus _cancellationStatus;
        private string _quantumTaskArn;

        /// <summary>
        /// Gets and sets the property CancellationStatus. 
        /// <para>
        /// The status of the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CancellationStatus CancellationStatus
        {
            get { return this._cancellationStatus; }
            set { this._cancellationStatus = value; }
        }

        // Check to see if CancellationStatus property is set
        internal bool IsSetCancellationStatus()
        {
            return this._cancellationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property QuantumTaskArn. 
        /// <para>
        /// The ARN of the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string QuantumTaskArn
        {
            get { return this._quantumTaskArn; }
            set { this._quantumTaskArn = value; }
        }

        // Check to see if QuantumTaskArn property is set
        internal bool IsSetQuantumTaskArn()
        {
            return this._quantumTaskArn != null;
        }

    }
}