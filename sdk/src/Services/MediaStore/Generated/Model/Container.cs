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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// This section describes operations that you can perform on an AWS Elemental MediaStore
    /// container.
    /// </summary>
    public partial class Container
    {
        private bool? _accessLoggingEnabled;
        private string _arn;
        private DateTime? _creationTime;
        private string _endpoint;
        private string _name;
        private ContainerStatus _status;

        /// <summary>
        /// Gets and sets the property AccessLoggingEnabled. 
        /// <para>
        /// The state of access logging on the container. This value is <c>false</c> by default,
        /// indicating that AWS Elemental MediaStore does not send access logs to Amazon CloudWatch
        /// Logs. When you enable access logging on the container, MediaStore changes this value
        /// to <c>true</c>, indicating that the service delivers access logs for objects stored
        /// in that container to CloudWatch Logs.
        /// </para>
        /// </summary>
        public bool? AccessLoggingEnabled
        {
            get { return this._accessLoggingEnabled; }
            set { this._accessLoggingEnabled = value; }
        }

        // Check to see if AccessLoggingEnabled property is set
        internal bool IsSetAccessLoggingEnabled()
        {
            return this._accessLoggingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container. The ARN has the following format:
        /// </para>
        ///  
        /// <para>
        /// arn:aws:&lt;region&gt;:&lt;account that owns this container&gt;:container/&lt;name
        /// of container&gt; 
        /// </para>
        ///  
        /// <para>
        /// For example: arn:aws:mediastore:us-west-2:111122223333:container/movies 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Unix timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The DNS endpoint of the container. Use the endpoint to identify the specific container
        /// when sending requests to the data plane. The service assigns this value when the container
        /// is created. Once the value has been assigned, it does not change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of container creation or deletion. The status is one of the following:
        /// <c>CREATING</c>, <c>ACTIVE</c>, or <c>DELETING</c>. While the service is creating
        /// the container, the status is <c>CREATING</c>. When the endpoint is available, the
        /// status changes to <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public ContainerStatus Status
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