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
    ///  
    /// <para>
    /// The IAM role or user passed to this API defines the permissions to access the app.
    /// Once the presigned URL is created, no additional permission is required to access
    /// this URL. IAM authorization policies for this API are also enforced for every HTTP
    /// request and WebSocket frame that attempts to connect to the app.
    /// </para>
    ///  
    /// <para>
    /// You can restrict access to this API and to the URL that it returns to a list of IP
    /// addresses, Amazon VPCs or Amazon VPC Endpoints that you specify. For more information,
    /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-interface-endpoint.html">Connect
    /// to SageMaker Studio Through an Interface VPC Endpoint</a> .
    /// </para>
    ///  <note> 
    /// <para>
    /// The URL that you get from a call to <code>CreatePresignedDomainUrl</code> has a default
    /// timeout of 5 minutes. You can configure this value using <code>ExpiresInSeconds</code>.
    /// If you try to use the URL after the timeout limit expires, you are directed to the
    /// Amazon Web Services console sign-in page.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePresignedDomainUrlRequest : AmazonSageMakerRequest
    {
        private string _domainId;
        private int? _expiresInSeconds;
        private int? _sessionExpirationDurationInSeconds;
        private string _spaceName;
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
        /// Gets and sets the property ExpiresInSeconds. 
        /// <para>
        /// The number of seconds until the pre-signed URL expires. This value defaults to 300.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=300)]
        public int ExpiresInSeconds
        {
            get { return this._expiresInSeconds.GetValueOrDefault(); }
            set { this._expiresInSeconds = value; }
        }

        // Check to see if ExpiresInSeconds property is set
        internal bool IsSetExpiresInSeconds()
        {
            return this._expiresInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionExpirationDurationInSeconds. 
        /// <para>
        /// The session expiration duration in seconds. This value defaults to 43200.
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
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
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