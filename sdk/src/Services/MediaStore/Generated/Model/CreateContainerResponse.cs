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
    /// This is the response object from the CreateContainer operation.
    /// </summary>
    public partial class CreateContainerResponse : AmazonWebServiceResponse
    {
        private Container _container;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// ContainerARN: The Amazon Resource Name (ARN) of the newly created container. The ARN
        /// has the following format: arn:aws:&lt;region&gt;:&lt;account that owns this container&gt;:container/&lt;name
        /// of container&gt;. For example: arn:aws:mediastore:us-west-2:111122223333:container/movies
        /// 
        /// </para>
        ///  
        /// <para>
        /// ContainerName: The container name as specified in the request.
        /// </para>
        ///  
        /// <para>
        /// CreationTime: Unix time stamp.
        /// </para>
        ///  
        /// <para>
        /// Status: The status of container creation or deletion. The status is one of the following:
        /// <code>CREATING</code>, <code>ACTIVE</code>, or <code>DELETING</code>. While the service
        /// is creating the container, the status is <code>CREATING</code>. When an endpoint is
        /// available, the status changes to <code>ACTIVE</code>.
        /// </para>
        ///  
        /// <para>
        /// The return value does not include the container's endpoint. To make downstream requests,
        /// you must obtain this value by using <a>DescribeContainer</a> or <a>ListContainers</a>.
        /// </para>
        /// </summary>
        public Container Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

    }
}