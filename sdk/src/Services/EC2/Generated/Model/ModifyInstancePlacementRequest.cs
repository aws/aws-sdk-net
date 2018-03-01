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
    /// Container for the parameters to the ModifyInstancePlacement operation.
    /// Modifies the placement attributes for a specified instance. You can do the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Modify the affinity between an instance and a <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
    /// Host</a>. When affinity is set to <code>host</code> and the instance is not associated
    /// with a specific Dedicated Host, the next time the instance is launched, it is automatically
    /// associated with the host on which it lands. If the instance is restarted or rebooted,
    /// this relationship persists.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change the Dedicated Host with which an instance is associated.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change the instance tenancy of an instance from <code>host</code> to <code>dedicated</code>,
    /// or from <code>dedicated</code> to <code>host</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Move an instance to or from a <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">placement
    /// group</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// At least one attribute for affinity, host ID, tenancy, or placement group name must
    /// be specified in the request. Affinity and tenancy can be modified in the same request.
    /// </para>
    ///  
    /// <para>
    /// To modify the host ID, tenancy, or placement group for an instance, the instance must
    /// be in the <code>stopped</code> state.
    /// </para>
    /// </summary>
    public partial class ModifyInstancePlacementRequest : AmazonEC2Request
    {
        private Affinity _affinity;
        private string _groupName;
        private string _hostId;
        private string _instanceId;
        private HostTenancy _tenancy;

        /// <summary>
        /// Gets and sets the property Affinity. 
        /// <para>
        /// The affinity setting for the instance.
        /// </para>
        /// </summary>
        public Affinity Affinity
        {
            get { return this._affinity; }
            set { this._affinity = value; }
        }

        // Check to see if Affinity property is set
        internal bool IsSetAffinity()
        {
            return this._affinity != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the placement group in which to place the instance. For spread placement
        /// groups, the instance must have a tenancy of <code>default</code>. For cluster placement
        /// groups, the instance must have a tenancy of <code>default</code> or <code>dedicated</code>.
        /// </para>
        ///  
        /// <para>
        /// To remove an instance from a placement group, specify an empty string ("").
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        /// The ID of the Dedicated Host with which to associate the instance.
        /// </para>
        /// </summary>
        public string HostId
        {
            get { return this._hostId; }
            set { this._hostId = value; }
        }

        // Check to see if HostId property is set
        internal bool IsSetHostId()
        {
            return this._hostId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance that you are modifying.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// The tenancy for the instance.
        /// </para>
        /// </summary>
        public HostTenancy Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

    }
}