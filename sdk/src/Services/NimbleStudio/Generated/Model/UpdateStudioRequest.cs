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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStudio operation.
    /// Update a Studio resource.
    /// 
    ///  
    /// <para>
    /// Currently, this operation only supports updating the displayName of your studio.
    /// </para>
    /// </summary>
    public partial class UpdateStudioRequest : AmazonNimbleStudioRequest
    {
        private string _adminRoleArn;
        private string _clientToken;
        private string _displayName;
        private string _studioId;
        private string _userRoleArn;

        /// <summary>
        /// Gets and sets the property AdminRoleArn. 
        /// <para>
        /// The IAM role that Studio Admins will assume when logging in to the Nimble Studio portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string AdminRoleArn
        {
            get { return this._adminRoleArn; }
            set { this._adminRoleArn = value; }
        }

        // Check to see if AdminRoleArn property is set
        internal bool IsSetAdminRoleArn()
        {
            return this._adminRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. If you don’t specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A friendly name for the studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The studio ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
        }

        /// <summary>
        /// Gets and sets the property UserRoleArn. 
        /// <para>
        /// The IAM role that Studio Users will assume when logging in to the Nimble Studio portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string UserRoleArn
        {
            get { return this._userRoleArn; }
            set { this._userRoleArn = value; }
        }

        // Check to see if UserRoleArn property is set
        internal bool IsSetUserRoleArn()
        {
            return this._userRoleArn != null;
        }

    }
}