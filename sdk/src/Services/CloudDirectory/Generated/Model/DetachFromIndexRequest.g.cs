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
    /// Container for the parameters to the DetachFromIndex operation. Detaches the specified
    /// object from the specified index.
    /// </summary>
    public partial class DetachFromIndexRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the directory the index and object exist in.
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
        /// A reference to the index object.
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
        /// A reference to the object being detached from the index.
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
