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
 * Do not modify this file. This file is generated from the iotfleethub-2020-11-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTFleetHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation.
    /// Creates a Fleet Hub for AWS IoT Device Management web application.
    /// 
    ///  <note> 
    /// <para>
    /// Fleet Hub for AWS IoT Device Management is in public preview and is subject to change.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateApplicationRequest : AmazonIoTFleetHubRequest
    {
        private string _applicationDescription;
        private string _applicationName;
        private string _clientToken;
        private string _roleArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// An optional description of the web application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ApplicationDescription
        {
            get { return this._applicationDescription; }
            set { this._applicationDescription = value; }
        }

        // Check to see if ApplicationDescription property is set
        internal bool IsSetApplicationDescription()
        {
            return this._applicationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the web application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that the web application assumes when it interacts with AWS IoT
        /// Core.
        /// </para>
        ///  <note> 
        /// <para>
        /// The name of the role must be in the form <code>AWSIotFleetHub_<i>random_string</i>
        /// </code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that you can use to manage the web application resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}