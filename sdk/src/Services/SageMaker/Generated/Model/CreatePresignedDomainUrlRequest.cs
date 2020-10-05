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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePresignedDomainUrl operation.
    /// Creates a URL for a specified UserProfile in a Domain. When accessed in a web browser,
    /// the user will be automatically signed in to Amazon SageMaker Studio, and granted access
    /// to all of the Apps and files associated with the Domain's Amazon Elastic File System
    /// (EFS) volume. This operation can only be called when the authentication mode equals
    /// IAM. 
    /// 
    ///  <note> 
    /// <para>
    /// The URL that you get from a call to <code>CreatePresignedDomainUrl</code> is valid
    /// only for 5 minutes. If you try to use the URL after the 5-minute limit expires, you
    /// are directed to the AWS console sign-in page.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePresignedDomainUrlRequest : AmazonSageMakerRequest
    {
        private string _domainId;
        private int? _sessionExpirationDurationInSeconds;
        private string _userProfileName;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// Gets and sets the property SessionExpirationDurationInSeconds. 
        /// <para>
        /// The session expiration duration in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1800, Max=43200)]
        public int SessionExpirationDurationInSeconds
        {
            get { return this._sessionExpirationDurationInSeconds.GetValueOrDefault(); }
            set { this._sessionExpirationDurationInSeconds = value; }
        }

        // Check to see if SessionExpirationDurationInSeconds property is set
        internal bool IsSetSessionExpirationDurationInSeconds()
        {
            return this._sessionExpirationDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The name of the UserProfile to sign-in as.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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

    }
}