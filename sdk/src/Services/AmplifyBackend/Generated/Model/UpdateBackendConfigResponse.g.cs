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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// This is the response object from the UpdateBackendConfig operation.
    /// </summary>
    public partial class UpdateBackendConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property BackendManagerAppId. 
        /// <para>
        /// The app ID for the backend manager.
        /// </para>
        /// </summary>
        public string BackendManagerAppId { get; set; }

        /// <summary>
        /// Checks to see if the BackendManagerAppId property is set.
        /// </summary>
        internal bool IsSetBackendManagerAppId() => this.BackendManagerAppId != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// If the request fails, this error is returned.
        /// </para>
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property LoginAuthConfig. 
        /// <para>
        /// Describes the Amazon Cognito configurations for the Admin UI auth resource to log
        /// in with.
        /// </para>
        /// </summary>
        public LoginAuthConfigReqObj LoginAuthConfig { get; set; }

        /// <summary>
        /// Checks to see if the LoginAuthConfig property is set.
        /// </summary>
        internal bool IsSetLoginAuthConfig() => this.LoginAuthConfig != null;
    }
}
