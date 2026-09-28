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
    /// Container for the parameters to the AttachObject operation. Attaches an existing object
    /// to another object. An object can be accessed in two ways: <ol> <li> <para> Using the
    /// path </para> </li> <li> <para> Using <c>ObjectIdentifier</c> </para> </li> </ol>
    /// </summary>
    public partial class AttachObjectRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property ChildReference. 
        /// <para>
        /// The child object reference to be attached to the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference ChildReference { get; set; }

        /// <summary>
        /// Checks to see if the ChildReference property is set.
        /// </summary>
        internal bool IsSetChildReference() => this.ChildReference != null;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// Amazon Resource Name (ARN) that is associated with the <a>Directory</a> where both
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
        /// The link name with which the child object is attached to the parent.
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
        /// The parent object reference.
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
