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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUserProfile operation.
    /// Creates a user profile. A user profile represents a single user within a domain, and
    /// is the main way to reference a "person" for the purposes of sharing, reporting, and
    /// other user-oriented features. This entity is created when a user onboards to a domain.
    /// If an administrator invites a person by email or imports them from IAM Identity Center,
    /// a user profile is automatically created. A user profile is the primary holder of settings
    /// for an individual user and has a reference to the user's private Amazon Elastic File
    /// System home directory.
    /// </summary>
    public partial class CreateUserProfileRequest : AmazonSageMakerRequest
    {
        private string _domainId;
        private string _singleSignOnUserIdentifier;
        private string _singleSignOnUserValue;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _userProfileName;
        private UserSettings _userSettings;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the associated Domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property SingleSignOnUserIdentifier. 
        /// <para>
        /// A specifier for the type of value specified in SingleSignOnUserValue. Currently, the
        /// only supported value is "UserName". If the Domain's AuthMode is IAM Identity Center,
        /// this field is required. If the Domain's AuthMode is not IAM Identity Center, this
        /// field cannot be specified. 
        /// </para>
        /// </summary>
        public string SingleSignOnUserIdentifier
        {
            get { return this._singleSignOnUserIdentifier; }
            set { this._singleSignOnUserIdentifier = value; }
        }

        // Check to see if SingleSignOnUserIdentifier property is set
        internal bool IsSetSingleSignOnUserIdentifier()
        {
            return this._singleSignOnUserIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SingleSignOnUserValue. 
        /// <para>
        /// The username of the associated Amazon Web Services Single Sign-On User for this UserProfile.
        /// If the Domain's AuthMode is IAM Identity Center, this field is required, and must
        /// match a valid username of a user in your directory. If the Domain's AuthMode is not
        /// IAM Identity Center, this field cannot be specified. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SingleSignOnUserValue
        {
            get { return this._singleSignOnUserValue; }
            set { this._singleSignOnUserValue = value; }
        }

        // Check to see if SingleSignOnUserValue property is set
        internal bool IsSetSingleSignOnUserValue()
        {
            return this._singleSignOnUserValue != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// </para>
        ///  
        /// <para>
        /// Tags that you specify for the User Profile are also added to all Apps that the User
        /// Profile launches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// A name for the UserProfile. This value is not case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string UserProfileName
        {
            get { return this._userProfileName; }
            set { this._userProfileName = value; }
        }

        // Check to see if UserProfileName property is set
        internal bool IsSetUserProfileName()
        {
            return this._userProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property UserSettings. 
        /// <para>
        /// A collection of settings.
        /// </para>
        /// </summary>
        public UserSettings UserSettings
        {
            get { return this._userSettings; }
            set { this._userSettings = value; }
        }

        // Check to see if UserSettings property is set
        internal bool IsSetUserSettings()
        {
            return this._userSettings != null;
        }

    }
}