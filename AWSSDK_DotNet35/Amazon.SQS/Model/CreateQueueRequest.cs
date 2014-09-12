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
    /// Container for the parameters to the CreateQueue operation.
    /// Creates a new queue, or returns the URL      of an existing one. When you request
    /// <code>CreateQueue</code>, you provide a      name for the queue. To successfully create
    /// a new queue, you must provide a name      that is unique within the scope of your
    /// own queues.
    /// 
    ///         <note>      
    /// <para>
    /// If you delete a queue, you must wait at least 60 seconds before creating a queue with
    /// the        same name.
    /// </para>
    ///           </note>    
    /// <para>
    /// You may pass one or more attributes in the request. If you do not      provide a value
    /// for any attribute, the queue will have the default value      for that attribute.
    /// Permitted attributes are the same that can be set      using <a>SetQueueAttributes</a>.
    /// </para>
    ///         <note>
    /// <para>
    /// Use <a>GetQueueUrl</a> to get a queue's URL.      <a>GetQueueUrl</a> requires only
    /// the <code>QueueName</code> parameter.
    /// </para>
    /// </note>        
    /// <para>
    /// If you provide the name of an existing queue, along with the exact names and values
    /// of all the queue's attributes,      <code>CreateQueue</code> returns the queue URL
    /// for the existing queue. If the queue name, attribute names,       or attribute values
    /// do not match an existing queue, <code>CreateQueue</code> returns an error.
    /// </para>
    ///         <note>Some API actions take lists of parameters. These lists are specified
    /// using the <code>param.n</code> notation. Values      of <code>n</code> are integers
    /// starting from 1. For example, a parameter list with two elements looks like this:
    ///     </note>    
    /// <para>
    /// <code>&amp;Attribute.1=this</code>
    /// </para>
    ///     
    /// <para>
    /// <code>&amp;Attribute.2=that</code>
    /// </para>
    /// </summary>
    public partial class CreateQueueRequest : AmazonSQSRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _queueName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateQueueRequest() { }

        /// <summary>
        /// Instantiates CreateQueueRequest with the parameterized properties
        /// </summary>
        /// <param name="queueName">The name for the queue to be created.</param>
        public CreateQueueRequest(string queueName)
        {
            _queueName = queueName;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of attributes with their corresponding values.
        /// </para>
        ///     
        /// <para>
        /// The following lists the names, descriptions, and values of the special request parameters
        /// the <code>CreateQueue</code>    action uses:
        /// </para>
        ///     
        /// <para>
        ///       <ul>                <li><code>DelaySeconds</code> - The time in seconds that
        /// the delivery of all messages in the queue will be delayed. An integer from 0 to 900
        /// (15 minutes). The default for this attribute is 0 (zero).</li>               <li><code>MaximumMessageSize</code>
        /// - The limit of how many bytes a message can contain before Amazon SQS rejects it.
        /// An integer from 1024 bytes (1 KiB) up to 262144 bytes (256 KiB). The default for this
        /// attribute is 262144 (256 KiB).</li>        <li><code>MessageRetentionPeriod</code>
        /// - The number of seconds Amazon SQS retains a message. Integer representing seconds,
        /// from 60 (1 minute) to 1209600 (14 days). The default for this attribute is 345600
        /// (4 days).</li>        <li><code>Policy</code> - The queue's policy. A valid      
        ///    form-url-encoded policy. For more information about policy          structure,
        /// see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/BasicStructure.html">Basic
        /// Policy Structure</a> in the <i>Amazon SQS Developer Guide</i>.           For more
        /// information about form-url-encoding, see           <a href="http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1">http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1</a>.</li>
        ///                        <li><code>ReceiveMessageWaitTimeSeconds</code> - The time for
        /// which a <a>ReceiveMessage</a> call will wait for a message to arrive. An integer from
        /// 0 to 20 (seconds). The default for this attribute is 0. </li>        <li><code>VisibilityTimeout</code>
        /// - The visibility timeout for the queue. An integer from 0 to 43200 (12 hours). The
        /// default for this attribute is 30. For more information about visibility timeout, 
        ///         see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.</li>      </ul>    
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueueName. 
        /// <para>
        /// The name for the queue to be created.
        /// </para>
        /// </summary>
        public string QueueName
        {
            get { return this._queueName; }
            set { this._queueName = value; }
        }

        // Check to see if QueueName property is set
        internal bool IsSetQueueName()
        {
            return this._queueName != null;
        }

    }
}