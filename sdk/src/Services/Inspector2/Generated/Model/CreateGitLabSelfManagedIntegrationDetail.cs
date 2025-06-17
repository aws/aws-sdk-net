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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains details required to create an integration with a self-managed GitLab instance.
    /// </summary>
    public partial class CreateGitLabSelfManagedIntegrationDetail
    {
        private string _accessToken;
        private string _instanceUrl;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The personal access token used to authenticate with the self-managed GitLab instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceUrl. 
        /// <para>
        /// The URL of the self-managed GitLab instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string InstanceUrl
        {
            get { return this._instanceUrl; }
            set { this._instanceUrl = value; }
        }

        // Check to see if InstanceUrl property is set
        internal bool IsSetInstanceUrl()
        {
            return this._instanceUrl != null;
        }

    }
}