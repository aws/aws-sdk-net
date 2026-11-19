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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ModifyInstancePlacement operation. Modifies the
    /// placement attributes for a specified instance. You can do the following: <ul> <li>
    /// <para> Modify the affinity between an instance and a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
    /// Host</a>. When affinity is set to <c>host</c> and the instance is not associated with
    /// a specific Dedicated Host, the next time the instance is started, it is automatically
    /// associated with the host on which it lands. If the instance is restarted or rebooted,
    /// this relationship persists. </para> </li> <li> <para> Change the Dedicated Host with
    /// which an instance is associated. </para> </li> <li> <para> Change the instance tenancy
    /// of an instance. </para> </li> <li> <para> Move an instance to or from a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">placement
    /// group</a>. </para> </li> </ul> <para> At least one attribute for affinity, host ID,
    /// tenancy, or placement group name must be specified in the request. Affinity and tenancy
    /// can be modified in the same request. </para> <para> To modify the host ID, tenancy,
    /// placement group, or partition for an instance, the instance must be in the <c>stopped</c>
    /// state. </para>
    /// </summary>
    public partial class ModifyInstancePlacementRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Affinity. 
        /// <para>
        /// The affinity setting for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/how-dedicated-hosts-work.html#dedicated-hosts-affinity">Host
        /// affinity</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public Affinity Affinity { get; set; }

        /// <summary>
        /// Checks to see if the Affinity property is set.
        /// </summary>
        internal bool IsSetAffinity() => this.Affinity != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The Group Id of a placement group. You must specify the Placement Group <b>Group Id</b>
        /// to launch an instance in a shared placement group.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the placement group in which to place the instance. For spread placement
        /// groups, the instance must have a tenancy of <c>default</c>. For cluster and partition
        /// placement groups, the instance must have a tenancy of <c>default</c> or <c>dedicated</c>.
        /// </para>
        ///  
        /// <para>
        /// To remove an instance from a placement group, specify an empty string ("").
        /// </para>
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        /// The ID of the Dedicated Host with which to associate the instance.
        /// </para>
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// Checks to see if the HostId property is set.
        /// </summary>
        internal bool IsSetHostId() => this.HostId != null;

        /// <summary>
        /// Gets and sets the property HostResourceGroupArn. 
        /// <para>
        /// The ARN of the host resource group in which to place the instance. The instance must
        /// have a tenancy of <c>host</c> to specify this parameter.
        /// </para>
        /// </summary>
        public string HostResourceGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the HostResourceGroupArn property is set.
        /// </summary>
        internal bool IsSetHostResourceGroupArn() => this.HostResourceGroupArn != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance that you are modifying.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property PartitionNumber. 
        /// <para>
        /// The number of the partition in which to place the instance. Valid only if the placement
        /// group strategy is set to <c>partition</c>.
        /// </para>
        /// </summary>
        public int? PartitionNumber { get; set; }

        /// <summary>
        /// Checks to see if the PartitionNumber property is set.
        /// </summary>
        internal bool IsSetPartitionNumber() => this.PartitionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// The tenancy for the instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// For T3 instances, you must launch the instance on a Dedicated Host to use a tenancy
        /// of <c>host</c>. You can't change the tenancy from <c>host</c> to <c>dedicated</c>
        /// or <c>default</c>. Attempting to make one of these unsupported tenancy changes results
        /// in an <c>InvalidRequest</c> error code.
        /// </para>
        ///  </note>
        /// </summary>
        public HostTenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;
    }
}
