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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// This is the response object from the UploadLayerPart operation.
    /// </summary>
    public partial class UploadLayerPartResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LastByteReceived. 
        /// <para>
        /// The integer value of the last byte that's received in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LastByteReceived { get; set; }

        /// <summary>
        /// Checks to see if the LastByteReceived property is set.
        /// </summary>
        internal bool IsSetLastByteReceived() => this.LastByteReceived.HasValue;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID that's associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name that's associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 205)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The upload ID that's associated with the request.
        /// </para>
        /// </summary>
        public string UploadId { get; set; }

        /// <summary>
        /// Checks to see if the UploadId property is set.
        /// </summary>
        internal bool IsSetUploadId() => this.UploadId != null;
    }
}
