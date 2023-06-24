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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// This is the response object from the CancelMessageMoveTask operation.
    /// </summary>
    public partial class CancelMessageMoveTaskResponse : AmazonWebServiceResponse
    {
        private long? _approximateNumberOfMessagesMoved;

        /// <summary>
        /// Gets and sets the property ApproximateNumberOfMessagesMoved. 
        /// <para>
        /// The approximate number of messages already moved to the destination queue.
        /// </para>
        /// </summary>
        public long ApproximateNumberOfMessagesMoved
        {
            get { return this._approximateNumberOfMessagesMoved.GetValueOrDefault(); }
            set { this._approximateNumberOfMessagesMoved = value; }
        }

        // Check to see if ApproximateNumberOfMessagesMoved property is set
        internal bool IsSetApproximateNumberOfMessagesMoved()
        {
            return this._approximateNumberOfMessagesMoved.HasValue; 
        }

    }
}