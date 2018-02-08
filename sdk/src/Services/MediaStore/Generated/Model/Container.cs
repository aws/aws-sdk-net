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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// This section describes operations that you can perform on an AWS Elemental MediaStore
    /// container.
    /// </summary>
    public partial class Container
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _endpoint;
        private string _name;
        private ContainerStatus _status;

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
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The DNS endpoint of the container. Use the endpoint to identify the specific container
        /// when sending requests to the data plane. The service assigns this value when the container
        /// is created. Once the value has been assigned, it does not change.
        /// </para>
        /// </summary>
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
        /// <code>CREATING</code>, <code>ACTIVE</code>, or <code>DELETING</code>. While the service
        /// is creating the container, the status is <code>CREATING</code>. When the endpoint
        /// is available, the status changes to <code>ACTIVE</code>.
        /// </para>
        /// </summary>
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