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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the Amazon Web Services accounts that have been granted permission to use
    /// a shared image. For more information about sharing images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/share-custom-image.html">
    /// Share or Unshare a Custom WorkSpaces Image</a>.
    /// </summary>
    public partial class ImagePermission
    {
        private string _sharedAccountId;

        /// <summary>
        /// Gets and sets the property SharedAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that an image has been shared with.
        /// </para>
        /// </summary>
        public string SharedAccountId
        {
            get { return this._sharedAccountId; }
            set { this._sharedAccountId = value; }
        }

        // Check to see if SharedAccountId property is set
        internal bool IsSetSharedAccountId()
        {
            return this._sharedAccountId != null;
        }

    }
}