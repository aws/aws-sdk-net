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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
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
namespace Amazon.SQS.Model
{
    /// <summary>
    /// This is the response object from the StartMessageMoveTask operation.
    /// </summary>
    public partial class StartMessageMoveTaskResponse : AmazonWebServiceResponse
    {
        private string _taskHandle;

        /// <summary>
        /// Gets and sets the property TaskHandle. 
        /// <para>
        /// An identifier associated with a message movement task. You can use this identifier
        /// to cancel a specified message movement task using the <c>CancelMessageMoveTask</c>
        /// action.
        /// </para>
        /// </summary>
        public string TaskHandle
        {
            get { return this._taskHandle; }
            set { this._taskHandle = value; }
        }

        // Check to see if TaskHandle property is set
        internal bool IsSetTaskHandle()
        {
            return this._taskHandle != null;
        }

    }
}