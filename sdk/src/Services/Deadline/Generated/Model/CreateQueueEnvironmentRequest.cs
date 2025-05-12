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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the CreateQueueEnvironment operation.
    /// Creates an environment for a queue that defines how jobs in the queue run.
    /// </summary>
    public partial class CreateQueueEnvironmentRequest : AmazonDeadlineRequest
    {
        private string _clientToken;
        private string _farmId;
        private int? _priority;
        private string _queueId;
        private string _template;
        private EnvironmentTemplateType _templateType;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The unique token which the server uses to recognize retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the farm to connect to the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Sets the priority of the environments in the queue from 0 to 10,000, where 0 is the
        /// highest priority (activated first and deactivated last). If two environments share
        /// the same priority value, the environment created first takes higher priority.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue ID to connect the queue and environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The environment template to use in the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=15000)]
        public string Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The template's file type, <c>JSON</c> or <c>YAML</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnvironmentTemplateType TemplateType
        {
            get { return this._templateType; }
            set { this._templateType = value; }
        }

        // Check to see if TemplateType property is set
        internal bool IsSetTemplateType()
        {
            return this._templateType != null;
        }

    }
}