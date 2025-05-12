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
    /// This is the response object from the DescribeUserProfile operation.
    /// </summary>
    public partial class DescribeUserProfileResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _domainId;
        private string _failureReason;
        private string _homeEfsFileSystemUid;
        private DateTime? _lastModifiedTime;
        private string _singleSignOnUserIdentifier;
        private string _singleSignOnUserValue;
        private UserProfileStatus _status;
        private string _userProfileArn;
        private string _userProfileName;
        private UserSettings _userSettings;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the domain that contains the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemUid. 
        /// <para>
        /// The ID of the user's profile in the Amazon Elastic File System volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public string HomeEfsFileSystemUid
        {
            get { return this._homeEfsFileSystemUid; }
            set { this._homeEfsFileSystemUid = value; }
        }

        // Check to see if HomeEfsFileSystemUid property is set
        internal bool IsSetHomeEfsFileSystemUid()
        {
            return this._homeEfsFileSystemUid != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SingleSignOnUserIdentifier. 
        /// <para>
        /// The IAM Identity Center user identifier.
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
        /// The IAM Identity Center user value.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public UserProfileStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UserProfileArn. 
        /// <para>
        /// The user profile Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string UserProfileArn
        {
            get { return this._userProfileArn; }
            set { this._userProfileArn = value; }
        }

        // Check to see if UserProfileArn property is set
        internal bool IsSetUserProfileArn()
        {
            return this._userProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The user profile name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
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