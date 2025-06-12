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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ReleaseHosts operation.
    /// When you no longer want to use an On-Demand Dedicated Host it can be released. On-Demand
    /// billing is stopped and the host goes into <c>released</c> state. The host ID of Dedicated
    /// Hosts that have been released can no longer be specified in another request, for example,
    /// to modify the host. You must stop or terminate all instances on a host before it can
    /// be released.
    /// 
    ///  
    /// <para>
    /// When Dedicated Hosts are released, it may take some time for them to stop counting
    /// toward your limit and you may receive capacity errors when trying to allocate new
    /// Dedicated Hosts. Wait a few minutes and then try again.
    /// </para>
    ///  
    /// <para>
    /// Released hosts still appear in a <a>DescribeHosts</a> response.
    /// </para>
    /// </summary>
    public partial class ReleaseHostsRequest : AmazonEC2Request
    {
        private List<string> _hostIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property HostIds. 
        /// <para>
        /// The IDs of the Dedicated Hosts to release.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> HostIds
        {
            get { return this._hostIds; }
            set { this._hostIds = value; }
        }

        // Check to see if HostIds property is set
        internal bool IsSetHostIds()
        {
            return this._hostIds != null && (this._hostIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}