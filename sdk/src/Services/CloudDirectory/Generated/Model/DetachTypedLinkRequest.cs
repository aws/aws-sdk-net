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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the DetachTypedLink operation.
    /// Detaches a typed link from a specified source and target object. For more information,
    /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
    /// Links</a>.
    /// </summary>
    public partial class DetachTypedLinkRequest : AmazonCloudDirectoryRequest
    {
        private string _directoryArn;
        private TypedLinkSpecifier _typedLinkSpecifier;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the directory where you want to detach the typed
        /// link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property TypedLinkSpecifier. 
        /// <para>
        /// Used to accept a typed link specifier as input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TypedLinkSpecifier TypedLinkSpecifier
        {
            get { return this._typedLinkSpecifier; }
            set { this._typedLinkSpecifier = value; }
        }

        // Check to see if TypedLinkSpecifier property is set
        internal bool IsSetTypedLinkSpecifier()
        {
            return this._typedLinkSpecifier != null;
        }

    }
}