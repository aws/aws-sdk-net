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
    /// Represents a studio resource.
    /// 
    ///  
    /// <para>
    /// A studio is the core resource used with Nimble Studio. You must create a studio first,
    /// before any other resource type can be created. All other resources you create and
    /// manage in Nimble Studio are contained within a studio.
    /// </para>
    ///  
    /// <para>
    /// When creating a studio, you must provides two IAM roles for use with the Nimble Studio
    /// portal. These roles are assumed by your users when they log in to the Nimble Studio
    /// portal via IAM Identity Center and your identity source.
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
    /// Your studio roles must trust the <code>identity.nimble.amazonaws.com</code> service
    /// principal to function properly.
    /// </para>
    /// </summary>
    public partial class Studio
    {
        private string _adminRoleArn;
        private string _arn;
        private DateTime? _createdAt;
        private string _displayName;
        private string _homeRegion;
        private string _ssoClientId;
        private StudioState _state;
        private StudioStatusCode _statusCode;
        private string _statusMessage;
        private StudioEncryptionConfiguration _studioEncryptionConfiguration;
        private string _studioId;
        private string _studioName;
        private string _studioUrl;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _updatedAt;
        private string _userRoleArn;

        /// <summary>
        /// Gets and sets the property AdminRoleArn. 
        /// <para>
        /// The IAM role that studio admins assume when logging in to the Nimble Studio portal.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is assigned to a studio resource and uniquely
        /// identifies it. ARNs are unique across all Regions.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO timestamp in seconds for when the resource was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A friendly name for the studio.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=64)]
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
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The Amazon Web Services Region where the studio resource is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SsoClientId. 
        /// <para>
        /// The IAM Identity Center application client ID used to integrate with IAM Identity
        /// Center. This ID allows IAM Identity Center users to log in to Nimble Studio portal.
        /// </para>
        /// </summary>
        public string SsoClientId
        {
            get { return this._ssoClientId; }
            set { this._ssoClientId = value; }
        }

        // Check to see if SsoClientId property is set
        internal bool IsSetSsoClientId()
        {
            return this._ssoClientId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the studio resource.
        /// </para>
        /// </summary>
        public StudioState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Status codes that provide additional detail on the studio state.
        /// </para>
        /// </summary>
        public StudioStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional detail on the studio state.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StudioEncryptionConfiguration. 
        /// <para>
        /// Configuration of the encryption method that is used for the studio.
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
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The unique identifier for a studio resource. In Nimble Studio, all other resources
        /// are contained in a studio resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StudioName. 
        /// <para>
        /// The name of the studio, as included in the URL when accessing it in the Nimble Studio
        /// portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
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
        /// Gets and sets the property StudioUrl. 
        /// <para>
        /// The address of the web page for the studio.
        /// </para>
        /// </summary>
        public string StudioUrl
        {
            get { return this._studioUrl; }
            set { this._studioUrl = value; }
        }

        // Check to see if StudioUrl property is set
        internal bool IsSetStudioUrl()
        {
            return this._studioUrl != null;
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The ISO timestamp in seconds for when the resource was updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserRoleArn. 
        /// <para>
        /// The IAM role that studio users assume when logging in to the Nimble Studio portal.
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