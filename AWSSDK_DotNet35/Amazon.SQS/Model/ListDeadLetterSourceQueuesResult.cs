/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// A list of your dead letter source queues.
    /// </summary>
    public partial class ListDeadLetterSourceQueuesResult : AmazonWebServiceResponse
    {
        private List<string> _queueUrls = new List<string>();


        /// <summary>
        /// Gets and sets the property QueueUrls. A list of source queue URLs that have the RedrivePolicy
        /// queue attribute configured with a dead letter queue.
        /// </summary>
        public List<string> QueueUrls
        {
            get { return this._queueUrls; }
            set { this._queueUrls = value; }
        }

        // Check to see if QueueUrls property is set
        internal bool IsSetQueueUrls()
        {
            return this._queueUrls != null && this._queueUrls.Count > 0; 
        }

    }
}