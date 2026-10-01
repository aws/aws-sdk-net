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
    /// Container for the parameters to the DetachObject operation. Detaches a given object
    /// from the parent object. The object that is to be detached from the parent is specified
    /// by the link name.
    /// </summary>
    public partial class DetachObjectRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Directory</a> where
        /// objects reside. For more information, see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryArn { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryArn property is set.
        /// </summary>
        internal bool IsSetDirectoryArn() => this.DirectoryArn != null;

        /// <summary>
        /// Gets and sets the property LinkName. 
        /// <para>
        /// The link name associated with the object that needs to be detached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string LinkName { get; set; }

        /// <summary>
        /// Checks to see if the LinkName property is set.
        /// </summary>
        internal bool IsSetLinkName() => this.LinkName != null;

        /// <summary>
        /// Gets and sets the property ParentReference. 
        /// <para>
        /// The parent reference from which the object with the specified link name is detached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference ParentReference { get; set; }

        /// <summary>
        /// Checks to see if the ParentReference property is set.
        /// </summary>
        internal bool IsSetParentReference() => this.ParentReference != null;
    }
}
