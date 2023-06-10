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
    /// Container for the parameters to the CreateStudio operation.
    /// Create a new studio.
    /// 
    ///  
    /// <para>
    /// When creating a studio, two IAM roles must be provided: the admin role and the user
    /// role. These roles are assumed by your users when they log in to the Nimble Studio
    /// portal.
    /// </para>
    ///  
    /// <para>
    /// The user role must have the <code>AmazonNimbleStudio-StudioUser</code> managed policy
    /// attached for the portal to function properly.
    /// </para>
    ///  
    /// <para>
    /// The admin role must have the <code>AmazonNimbleStudio-StudioAdmin</code> managed policy
    /// attached for the portal to function properly.
    /// </para>
    ///  
    /// <para>
    /// You may optionally specify a KMS key in the <code>StudioEncryptionConfiguration</code>.
    /// </para>
    ///  
    /// <para>
    /// In Nimble Studio, resource names, descriptions, initialization scripts, and other
    /// data you provide are always encrypted at rest using an KMS key. By default, this key
    /// is owned by Amazon Web Services and managed on your behalf. You may provide your own
    /// KMS key when calling <code>CreateStudio</code> to encrypt this data using a key you
    /// own and manage.
    /// </para>
    ///  
    /// <para>
    /// When providing an KMS key during studio creation, Nimble Studio creates KMS grants
    /// in your account to provide your studio user and admin roles access to these KMS keys.
    /// </para>
    ///  
    /// <para>
    /// If you delete this grant, the studio will no longer be accessible to your portal users.
    /// </para>
    ///  
    /// <para>
    /// If you delete the studio KMS key, your studio will no longer be accessible.
    /// </para>
    /// </summary>
    public partial class CreateStudioRequest : AmazonNimbleStudioRequest
    {
        private string _adminRoleArn;
        private string _clientToken;
        private string _displayName;
        private StudioEncryptionConfiguration _studioEncryptionConfiguration;
        private string _studioName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _userRoleArn;

        /// <summary>
        /// Gets and sets the property AdminRoleArn. 
        /// <para>
        /// The IAM role that studio admins will assume when logging in to the Nimble Studio portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=64)]
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
        /// Gets and sets the property StudioEncryptionConfiguration. 
        /// <para>
        /// The studio encryption configuration.
        /// </para>
        /// </summary>
        public StudioEncryptionConfiguration StudioEncryptionConfiguration
        {
            get { return this._studioEncryptionConfiguration; }
            set { this._studioEncryptionConfiguration = value; }
        }

        // Check to see if StudioEncryptionConfiguration property is set
        internal bool IsSetStudioEncryptionConfiguration()
        {
            return this._studioEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StudioName. 
        /// <para>
        /// The studio name that is used in the URL of the Nimble Studio portal when accessed
        /// by Nimble Studio users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string StudioName
        {
            get { return this._studioName; }
            set { this._studioName = value; }
        }

        // Check to see if StudioName property is set
        internal bool IsSetStudioName()
        {
            return this._studioName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of labels, in the form of key-value pairs, that apply to this resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserRoleArn. 
        /// <para>
        /// The IAM role that studio users will assume when logging in to the Nimble Studio portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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