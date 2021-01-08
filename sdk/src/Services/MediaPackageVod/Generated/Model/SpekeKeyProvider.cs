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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// A configuration for accessing an external Secure Packager and Encoder Key Exchange
    /// (SPEKE) service that will provide encryption keys.
    /// </summary>
    public partial class SpekeKeyProvider
    {
        private string _roleArn;
        private List<string> _systemIds = new List<string>();
        private string _url;

        /// <summary>
        /// Gets and sets the property RoleArn. An Amazon Resource Name (ARN) of an IAM role that
        /// AWS ElementalMediaPackage will assume when accessing the key provider service.
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SystemIds. The system IDs to include in key requests.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SystemIds
        {
            get { return this._systemIds; }
            set { this._systemIds = value; }
        }

        // Check to see if SystemIds property is set
        internal bool IsSetSystemIds()
        {
            return this._systemIds != null && this._systemIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Url. The URL of the external key provider service.
        /// </summary>
        [AWSProperty(Required=true)]
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