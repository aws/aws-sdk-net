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
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Describes mapping between an Amazon Kinesis stream and a Lambda function.
    /// </summary>
    public partial class AddEventSourceResult : AmazonWebServiceResponse
    {
        private int? _batchSize;
        private string _eventSource;
        private string _functionName;
        private bool? _isActive;
        private string _lastModified;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _role;
        private string _status;
        private string _uuid;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The largest number of records that AWS Lambda will POST in the invocation request
        /// to your function.
        /// </para>
        /// </summary>
        public int BatchSize
        {
            get { return this._batchSize.GetValueOrDefault(); }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kinesis stream that is the source of
        /// events.
        /// </para>
        /// </summary>
        public string EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The Lambda function to invoke when AWS Lambda detects an event on the stream.
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// Indicates whether the event source mapping is currently honored. Events are only processes
        /// if IsActive is true.
        /// </para>
        /// </summary>
        public bool IsActive
        {
            get { return this._isActive.GetValueOrDefault(); }
            set { this._isActive = value; }
        }

        // Check to see if IsActive property is set
        internal bool IsSetIsActive()
        {
            return this._isActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The UTC time string indicating the last time the event mapping was updated.
        /// </para>
        /// </summary>
        public string LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The map (key-value pairs) defining the configuration for AWS Lambda to use when reading
        /// the event source.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The ARN of the IAM role (invocation role) that AWS Lambda can assume to read from
        /// the stream and invoke the function.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The description of the health of the event source mapping. Valid values are: "PENDING",
        /// "OK", and "PROBLEM:<i>message</i>". Initially this staus is "PENDING". When AWS Lambda
        /// begins processing events, it changes the status to "OK".
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The AWS Lambda assigned opaque identifier for the mapping.
        /// </para>
        /// </summary>
        public string UUID
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if UUID property is set
        internal bool IsSetUUID()
        {
            return this._uuid != null;
        }

    }
}