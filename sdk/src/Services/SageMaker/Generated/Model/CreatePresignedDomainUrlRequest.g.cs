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
    /// Container for the parameters to the CreatePresignedDomainUrl operation. Creates a
    /// URL for a specified UserProfile in a Domain. When accessed in a web browser, the user
    /// will be automatically signed in to the domain, and granted access to all of the Apps
    /// and files associated with the Domain's Amazon Elastic File System volume. This operation
    /// can only be called when the authentication mode equals IAM. <para> The IAM role or
    /// user passed to this API defines the permissions to access the app. Once the presigned
    /// URL is created, no additional permission is required to access this URL. IAM authorization
    /// policies for this API are also enforced for every HTTP request and WebSocket frame
    /// that attempts to connect to the app. </para> <para> You can restrict access to this
    /// API and to the URL that it returns to a list of IP addresses, Amazon VPCs or Amazon
    /// VPC Endpoints that you specify. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-interface-endpoint.html">Connect
    /// to Amazon SageMaker AI Studio Through an Interface VPC Endpoint</a> . </para> <note>
    /// <ul> <li> <para> The URL that you get from a call to <c>CreatePresignedDomainUrl</c>
    /// has a default timeout of 5 minutes. You can configure this value using <c>ExpiresInSeconds</c>.
    /// If you try to use the URL after the timeout limit expires, you are directed to the
    /// Amazon Web Services console sign-in page. </para> </li> <li> <para> The JupyterLab
    /// session default expiration time is 12 hours. You can configure this value using SessionExpirationDurationInSeconds.
    /// </para> </li> </ul> </note>
    /// </summary>
    public partial class CreatePresignedDomainUrlRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property ExpiresInSeconds. 
        /// <para>
        /// The number of seconds until the pre-signed URL expires. This value defaults to 300.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 300)]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresInSeconds property is set.
        /// </summary>
        internal bool IsSetExpiresInSeconds() => this.ExpiresInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property LandingUri. 
        /// <para>
        /// The landing page that the user is directed to when accessing the presigned URL. Using
        /// this value, users can access Studio or Studio Classic, even if it is not the default
        /// experience for the domain. The supported values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>studio::relative/path</c>: Directs users to the relative path in Studio.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>app:JupyterServer:relative/path</c>: Directs users to the relative path in the
        /// Studio Classic application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>app:JupyterLab:relative/path</c>: Directs users to the relative path in the JupyterLab
        /// application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>app:RStudioServerPro:relative/path</c>: Directs users to the relative path in
        /// the RStudio application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>app:CodeEditor:relative/path</c>: Directs users to the relative path in the Code
        /// Editor, based on Code-OSS, Visual Studio Code - Open Source application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>app:Canvas:relative/path</c>: Directs users to the relative path in the Canvas
        /// application.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1023)]
        public string LandingUri { get; set; }

        /// <summary>
        /// Checks to see if the LandingUri property is set.
        /// </summary>
        internal bool IsSetLandingUri() => this.LandingUri != null;

        /// <summary>
        /// Gets and sets the property SessionExpirationDurationInSeconds. 
        /// <para>
        /// The session expiration duration in seconds. This value defaults to 43200.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1800, Max = 43200)]
        public int? SessionExpirationDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionExpirationDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetSessionExpirationDurationInSeconds() => this.SessionExpirationDurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string SpaceName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceName property is set.
        /// </summary>
        internal bool IsSetSpaceName() => this.SpaceName != null;

        /// <summary>
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The name of the UserProfile to sign-in as.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string UserProfileName { get; set; }

        /// <summary>
        /// Checks to see if the UserProfileName property is set.
        /// </summary>
        internal bool IsSetUserProfileName() => this.UserProfileName != null;
    }
}
