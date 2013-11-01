/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateQueue operation.
    /// <para>The <c>CreateQueue</c> action creates a new queue, or returns the URL of an existing one. When you request <c>CreateQueue</c> , you
    /// provide a name for the queue. To successfully create a new queue, you must provide a name that is unique within the scope of your own
    /// queues.</para> <para>You may pass one or more attributes in the request. If you do not provide a value for any attribute, the queue will
    /// have the default value for that attribute. Permitted attributes are the same that can be set using SetQueueAttributes.</para> <para>If you
    /// provide the name of an existing queue, a new queue isn't created. If the values of attributes provided with the request match up with those
    /// on the existing queue, the queue URL is returned. Otherwise, a <c>QueueNameExists</c> error is returned.</para>
    /// </summary>
    public partial class CreateQueueRequest : AmazonSQSRequest
    {
        private string queueName;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();


        /// <summary>
        /// The name for the queue to be created.
        ///  
        /// </summary>
        public string QueueName
        {
            get { return this.queueName; }
            set { this.queueName = value; }
        }

        // Check to see if QueueName property is set
        internal bool IsSetQueueName()
        {
            return this.queueName != null;
        }

        /// <summary>
        /// A map of attributes with their corresponding values.
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }

    }
}
    
