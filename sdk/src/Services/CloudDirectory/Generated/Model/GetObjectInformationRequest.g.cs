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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the GetObjectInformation operation. Retrieves metadata
    /// about an object.
    /// </summary>
    public partial class GetObjectInformationRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property ConsistencyLevel. 
        /// <para>
        /// The consistency level at which to retrieve the object information.
        /// </para>
        /// </summary>
        public ConsistencyLevel ConsistencyLevel { get; set; }

        /// <summary>
        /// Checks to see if the ConsistencyLevel property is set.
        /// </summary>
        internal bool IsSetConsistencyLevel() => this.ConsistencyLevel != null;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The ARN of the directory being retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryArn { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryArn property is set.
        /// </summary>
        internal bool IsSetDirectoryArn() => this.DirectoryArn != null;

        /// <summary>
        /// Gets and sets the property ObjectReference. 
        /// <para>
        /// A reference to the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference ObjectReference { get; set; }

        /// <summary>
        /// Checks to see if the ObjectReference property is set.
        /// </summary>
        internal bool IsSetObjectReference() => this.ObjectReference != null;
    }
}
