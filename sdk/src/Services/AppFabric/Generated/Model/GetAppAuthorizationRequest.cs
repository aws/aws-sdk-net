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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
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
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Container for the parameters to the GetAppAuthorization operation.
    /// Returns information about an app authorization.
    /// </summary>
    public partial class GetAppAuthorizationRequest : AmazonAppFabricRequest
    {
        private string _appAuthorizationIdentifier;
        private string _appBundleIdentifier;

        /// <summary>
        /// Gets and sets the property AppAuthorizationIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or Universal Unique Identifier (UUID) of the app authorization
        /// to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string AppAuthorizationIdentifier
        {
            get { return this._appAuthorizationIdentifier; }
            set { this._appAuthorizationIdentifier = value; }
        }

        // Check to see if AppAuthorizationIdentifier property is set
        internal bool IsSetAppAuthorizationIdentifier()
        {
            return this._appAuthorizationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property AppBundleIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or Universal Unique Identifier (UUID) of the app bundle
        /// to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string AppBundleIdentifier
        {
            get { return this._appBundleIdentifier; }
            set { this._appBundleIdentifier = value; }
        }

        // Check to see if AppBundleIdentifier property is set
        internal bool IsSetAppBundleIdentifier()
        {
            return this._appBundleIdentifier != null;
        }

    }
}