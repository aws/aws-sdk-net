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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeUserProfile operation.
    /// </summary>
    public partial class DescribeUserProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the domain that contains the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemUid. 
        /// <para>
        /// The ID of the user's profile in the Amazon Elastic File System volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public string HomeEfsFileSystemUid { get; set; }

        /// <summary>
        /// Checks to see if the HomeEfsFileSystemUid property is set.
        /// </summary>
        internal bool IsSetHomeEfsFileSystemUid() => this.HomeEfsFileSystemUid != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property SingleSignOnUserIdentifier. 
        /// <para>
        /// The IAM Identity Center user identifier.
        /// </para>
        /// </summary>
        public string SingleSignOnUserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SingleSignOnUserIdentifier property is set.
        /// </summary>
        internal bool IsSetSingleSignOnUserIdentifier() => this.SingleSignOnUserIdentifier != null;

        /// <summary>
        /// Gets and sets the property SingleSignOnUserValue. 
        /// <para>
        /// The IAM Identity Center user value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SingleSignOnUserValue { get; set; }

        /// <summary>
        /// Checks to see if the SingleSignOnUserValue property is set.
        /// </summary>
        internal bool IsSetSingleSignOnUserValue() => this.SingleSignOnUserValue != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public UserProfileStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserProfileArn. 
        /// <para>
        /// The user profile Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string UserProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the UserProfileArn property is set.
        /// </summary>
        internal bool IsSetUserProfileArn() => this.UserProfileArn != null;

        /// <summary>
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The user profile name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string UserProfileName { get; set; }

        /// <summary>
        /// Checks to see if the UserProfileName property is set.
        /// </summary>
        internal bool IsSetUserProfileName() => this.UserProfileName != null;

        /// <summary>
        /// Gets and sets the property UserSettings. 
        /// <para>
        /// A collection of settings.
        /// </para>
        /// </summary>
        public UserSettings UserSettings { get; set; }

        /// <summary>
        /// Checks to see if the UserSettings property is set.
        /// </summary>
        internal bool IsSetUserSettings() => this.UserSettings != null;
    }
}
