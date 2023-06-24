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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Container for the parameters to the GetBackendAPIModels operation.
    /// Gets a model introspection schema for an existing backend API resource.
    /// </summary>
    public partial class GetBackendAPIModelsRequest : AmazonAmplifyBackendRequest
    {
        private string _appId;
        private string _backendEnvironmentName;
        private string _resourceName;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property BackendEnvironmentName. 
        /// <para>
        /// The name of the backend environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackendEnvironmentName
        {
            get { return this._backendEnvironmentName; }
            set { this._backendEnvironmentName = value; }
        }

        // Check to see if BackendEnvironmentName property is set
        internal bool IsSetBackendEnvironmentName()
        {
            return this._backendEnvironmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

    }
}