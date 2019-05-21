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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PrivateLinkConfig
    {
        private string _privateLinkEndpoint;
        private List<string> _securityGroupArns = new List<string>();
        private List<string> _subnetArns = new List<string>();

        /// <summary>
        /// Gets and sets the property PrivateLinkEndpoint.
        /// </summary>
        public string PrivateLinkEndpoint
        {
            get { return this._privateLinkEndpoint; }
            set { this._privateLinkEndpoint = value; }
        }

        // Check to see if PrivateLinkEndpoint property is set
        internal bool IsSetPrivateLinkEndpoint()
        {
            return this._privateLinkEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupArns.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SecurityGroupArns
        {
            get { return this._securityGroupArns; }
            set { this._securityGroupArns = value; }
        }

        // Check to see if SecurityGroupArns property is set
        internal bool IsSetSecurityGroupArns()
        {
            return this._securityGroupArns != null && this._securityGroupArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetArns.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SubnetArns
        {
            get { return this._subnetArns; }
            set { this._subnetArns = value; }
        }

        // Check to see if SubnetArns property is set
        internal bool IsSetSubnetArns()
        {
            return this._subnetArns != null && this._subnetArns.Count > 0; 
        }

    }
}