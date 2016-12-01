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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyHosts operation.
    /// Modify the auto-placement setting of a Dedicated Host. When auto-placement is enabled,
    /// AWS will place instances that you launch with a tenancy of <code>host</code>, but
    /// without targeting a specific host ID, onto any available Dedicated Host in your account
    /// which has auto-placement enabled. When auto-placement is disabled, you need to provide
    /// a host ID if you want the instance to launch onto a specific host. If no host ID is
    /// provided, the instance will be launched onto a suitable host which has auto-placement
    /// enabled.
    /// </summary>
    public partial class ModifyHostsRequest : AmazonEC2Request
    {
        private AutoPlacement _autoPlacement;
        private List<string> _hostIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AutoPlacement. 
        /// <para>
        /// Specify whether to enable or disable auto-placement.
        /// </para>
        /// </summary>
        public AutoPlacement AutoPlacement
        {
            get { return this._autoPlacement; }
            set { this._autoPlacement = value; }
        }

        // Check to see if AutoPlacement property is set
        internal bool IsSetAutoPlacement()
        {
            return this._autoPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property HostIds. 
        /// <para>
        /// The host IDs of the Dedicated Hosts you want to modify.
        /// </para>
        /// </summary>
        public List<string> HostIds
        {
            get { return this._hostIds; }
            set { this._hostIds = value; }
        }

        // Check to see if HostIds property is set
        internal bool IsSetHostIds()
        {
            return this._hostIds != null && this._hostIds.Count > 0; 
        }

    }
}