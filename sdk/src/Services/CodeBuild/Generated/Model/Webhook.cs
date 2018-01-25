/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about a webhook in GitHub that connects repository events to a build project
    /// in AWS CodeBuild.
    /// </summary>
    public partial class Webhook
    {
        private string _payloadUrl;
        private string _secret;
        private string _url;

        /// <summary>
        /// Gets and sets the property PayloadUrl. 
        /// <para>
        /// This is the server endpoint that will receive the webhook payload.
        /// </para>
        /// </summary>
        public string PayloadUrl
        {
            get { return this._payloadUrl; }
            set { this._payloadUrl = value; }
        }

        // Check to see if PayloadUrl property is set
        internal bool IsSetPayloadUrl()
        {
            return this._payloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// Use this secret while creating a webhook in GitHub for Enterprise. The secret allows
        /// webhook requests sent by GitHub for Enterprise to be authenticated by AWS CodeBuild.
        /// </para>
        /// </summary>
        public string Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }

        // Check to see if Secret property is set
        internal bool IsSetSecret()
        {
            return this._secret != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to the webhook.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}