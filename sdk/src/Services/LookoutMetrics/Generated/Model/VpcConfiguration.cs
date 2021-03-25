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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Contains configuration information about the Amazon Virtual Private Cloud (VPC).
    /// </summary>
    public partial class VpcConfiguration
    {
        private List<string> _securityGroupIdList = new List<string>();
        private List<string> _subnetIdList = new List<string>();

        /// <summary>
        /// Gets and sets the property SecurityGroupIdList. 
        /// <para>
        /// An array of strings containing the list of security groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SecurityGroupIdList
        {
            get { return this._securityGroupIdList; }
            set { this._securityGroupIdList = value; }
        }

        // Check to see if SecurityGroupIdList property is set
        internal bool IsSetSecurityGroupIdList()
        {
            return this._securityGroupIdList != null && this._securityGroupIdList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetIdList. 
        /// <para>
        /// An array of strings containing the Amazon VPC subnet IDs (e.g., <code>subnet-0bb1c79de3EXAMPLE</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SubnetIdList
        {
            get { return this._subnetIdList; }
            set { this._subnetIdList = value; }
        }

        // Check to see if SubnetIdList property is set
        internal bool IsSetSubnetIdList()
        {
            return this._subnetIdList != null && this._subnetIdList.Count > 0; 
        }

    }
}