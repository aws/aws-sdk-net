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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
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
namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterAdmin operation.
    /// Adds a user or group to the list of administrators of the private re:Post.
    /// </summary>
    public partial class RegisterAdminRequest : AmazonRepostspaceRequest
    {
        private string _adminId;
        private string _spaceId;

        /// <summary>
        /// Gets and sets the property AdminId. 
        /// <para>
        /// The ID of the administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AdminId
        {
            get { return this._adminId; }
            set { this._adminId = value; }
        }

        // Check to see if AdminId property is set
        internal bool IsSetAdminId()
        {
            return this._adminId != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SpaceId
        {
            get { return this._spaceId; }
            set { this._spaceId = value; }
        }

        // Check to see if SpaceId property is set
        internal bool IsSetSpaceId()
        {
            return this._spaceId != null;
        }

    }
}