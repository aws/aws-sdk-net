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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
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
    /// Container for the parameters to the ReleaseHosts operation.
    /// When you no longer want to use a Dedicated host it can be released. On-Demand billing
    /// is stopped and the host goes into <code>released</code> state. The host ID of Dedicated
    /// hosts that have been released can no longer be specified in another request, e.g.,
    /// ModifyHosts. You must stop or terminate all instances on a host before it can be released.
    /// 
    ///  
    /// <para>
    /// When Dedicated hosts are released, it make take some time for them to stop counting
    /// toward your limit and you may receive capacity errors when trying to allocate new
    /// Dedicated hosts. Try waiting a few minutes, and then try again.
    /// </para>
    ///  
    /// <para>
    /// Released hosts will still appear in a DescribeHosts response.
    /// </para>
    /// </summary>
    public partial class ReleaseHostsRequest : AmazonEC2Request
    {
        private List<string> _hostIds = new List<string>();

        /// <summary>
        /// Gets and sets the property HostIds. 
        /// <para>
        /// The IDs of the Dedicated hosts you want to release.
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