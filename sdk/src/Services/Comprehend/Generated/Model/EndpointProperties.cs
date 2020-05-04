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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Specifies information about the specified endpoint.
    /// </summary>
    public partial class EndpointProperties
    {
        private DateTime? _creationTime;
        private int? _currentInferenceUnits;
        private int? _desiredInferenceUnits;
        private string _endpointArn;
        private DateTime? _lastModifiedTime;
        private string _message;
        private string _modelArn;
        private EndpointStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation date and time of the endpoint.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentInferenceUnits. 
        /// <para>
        /// The number of inference units currently used by the model using this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int CurrentInferenceUnits
        {
            get { return this._currentInferenceUnits.GetValueOrDefault(); }
            set { this._currentInferenceUnits = value; }
        }

        // Check to see if CurrentInferenceUnits property is set
        internal bool IsSetCurrentInferenceUnits()
        {
            return this._currentInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredInferenceUnits. 
        /// <para>
        /// The desired number of inference units to be used by the model using this endpoint.
        /// Each inference unit represents of a throughput of 100 characters per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int DesiredInferenceUnits
        {
            get { return this._desiredInferenceUnits.GetValueOrDefault(); }
            set { this._desiredInferenceUnits = value; }
        }

        // Check to see if DesiredInferenceUnits property is set
        internal bool IsSetDesiredInferenceUnits()
        {
            return this._desiredInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the endpoint was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Specifies a reason for failure in cases of <code>Failed</code> status.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the model to which the endpoint is attached.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of the endpoint. Because the endpoint updates and creation are
        /// asynchronous, so customers will need to wait for the endpoint to be <code>Ready</code>
        /// status before making inference requests.
        /// </para>
        /// </summary>
        public EndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}