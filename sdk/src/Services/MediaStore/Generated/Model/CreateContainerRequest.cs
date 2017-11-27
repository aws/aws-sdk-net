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
    /// Container for the parameters to the CreateContainer operation.
    /// Creates a storage container to hold objects. A container is similar to a bucket in
    /// the Amazon S3 service.
    /// </summary>
    public partial class CreateContainerRequest : AmazonMediaStoreRequest
    {
        private string _containerName;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name for the container. The name must be from 1 to 255 characters. Container names
        /// must be unique to your AWS account within a specific region. As an example, you could
        /// create a container named <code>movies</code> in every region, as long as you don’t
        /// have an existing container with that name.
        /// </para>
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

    }
}