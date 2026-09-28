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
    /// Container for the parameters to the AttachToIndex operation. Attaches the specified
    /// object to the specified index.
    /// </summary>
    public partial class AttachToIndexRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the directory where the object and index exist.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryArn { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryArn property is set.
        /// </summary>
        internal bool IsSetDirectoryArn() => this.DirectoryArn != null;

        /// <summary>
        /// Gets and sets the property IndexReference. 
        /// <para>
        /// A reference to the index that you are attaching the object to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference IndexReference { get; set; }

        /// <summary>
        /// Checks to see if the IndexReference property is set.
        /// </summary>
        internal bool IsSetIndexReference() => this.IndexReference != null;

        /// <summary>
        /// Gets and sets the property TargetReference. 
        /// <para>
        /// A reference to the object that you are attaching to the index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference TargetReference { get; set; }

        /// <summary>
        /// Checks to see if the TargetReference property is set.
        /// </summary>
        internal bool IsSetTargetReference() => this.TargetReference != null;
    }
}
