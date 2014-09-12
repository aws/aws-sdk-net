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

/*
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
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
    /// Container for the parameters to the ListQueues operation.
    /// Returns a list of your queues. The maximum number of      queues that can be returned
    /// is 1000. If you specify a value for the optional      <code>QueueNamePrefix</code>
    /// parameter, only queues with a name beginning with the      specified value are returned.
    /// </summary>
    public partial class ListQueuesRequest : AmazonSQSRequest
    {
        private string _queueNamePrefix;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListQueuesRequest() { }

        /// <summary>
        /// Instantiates ListQueuesRequest with the parameterized properties
        /// </summary>
        /// <param name="queueNamePrefix">A string to use for filtering the list results. Only those queues whose name   begins with the specified string are returned.</param>
        public ListQueuesRequest(string queueNamePrefix)
        {
            _queueNamePrefix = queueNamePrefix;
        }

        /// <summary>
        /// Gets and sets the property QueueNamePrefix. 
        /// <para>
        /// A string to use for filtering the list results. Only those queues whose name     
        /// begins with the specified string are returned.
        /// </para>
        /// </summary>
        public string QueueNamePrefix
        {
            get { return this._queueNamePrefix; }
            set { this._queueNamePrefix = value; }
        }

        // Check to see if QueueNamePrefix property is set
        internal bool IsSetQueueNamePrefix()
        {
            return this._queueNamePrefix != null;
        }

    }
}