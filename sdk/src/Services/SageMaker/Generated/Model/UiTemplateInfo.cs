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
    /// Container for user interface template information.
    /// </summary>
    public partial class UiTemplateInfo
    {
        private string _contentSha256;
        private string _url;

        /// <summary>
        /// Gets and sets the property ContentSha256. 
        /// <para>
        /// The SHA-256 digest of the contents of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128000)]
        public string ContentSha256
        {
            get { return this._contentSha256; }
            set { this._contentSha256 = value; }
        }

        // Check to see if ContentSha256 property is set
        internal bool IsSetContentSha256()
        {
            return this._contentSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL for the user interface template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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