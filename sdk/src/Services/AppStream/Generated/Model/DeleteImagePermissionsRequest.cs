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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteImagePermissions operation.
    /// Deletes permissions for the specified private image. After you delete permissions
    /// for an image, AWS accounts to which you previously granted these permissions can no
    /// longer use the image.
    /// </summary>
    public partial class DeleteImagePermissionsRequest : AmazonAppStreamRequest
    {
        private string _name;
        private string _sharedAccountId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the private image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SharedAccountId. 
        /// <para>
        /// The 12-digit identifier of the AWS account for which to delete image permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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