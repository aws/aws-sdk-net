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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about a task submitted to a resource .
    /// </summary>
    public partial class TaskSubmittedEventDetails
    {
        private string _output;
        private HistoryEventExecutionDataDetails _outputDetails;
        private string _resource;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The response from a resource when a task has started. Length constraints apply to
        /// the payload size, and are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDetails. 
        /// <para>
        /// Contains details about the output of an execution history event.
        /// </para>
        /// </summary>
        public HistoryEventExecutionDataDetails OutputDetails
        {
            get { return this._outputDetails; }
            set { this._outputDetails = value; }
        }

        // Check to see if OutputDetails property is set
        internal bool IsSetOutputDetails()
        {
            return this._outputDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The action of the resource called by a task state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The service name of the resource in a task state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}