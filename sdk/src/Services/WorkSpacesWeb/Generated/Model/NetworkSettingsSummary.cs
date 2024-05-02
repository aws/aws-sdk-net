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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The summary of network settings.
    /// </summary>
    public partial class NetworkSettingsSummary
    {
        private string _networkSettingsArn;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property NetworkSettingsArn. 
        /// <para>
        /// The ARN of the network settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string NetworkSettingsArn
        {
            get { return this._networkSettingsArn; }
            set { this._networkSettingsArn = value; }
        }

        // Check to see if NetworkSettingsArn property is set
        internal bool IsSetNetworkSettingsArn()
        {
            return this._networkSettingsArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID of the network settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}