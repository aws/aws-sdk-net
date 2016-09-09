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
    /// Container for the parameters to the ModifyInstancePlacement operation.
    /// Set the instance affinity value for a specific stopped instance and modify the instance
    /// tenancy setting.
    /// 
    ///  
    /// <para>
    /// Instance affinity is disabled by default. When instance affinity is <code>host</code>
    /// and it is not associated with a specific Dedicated Host, the next time it is launched
    /// it will automatically be associated with the host it lands on. This relationship will
    /// persist if the instance is stopped/started, or rebooted.
    /// </para>
    ///  
    /// <para>
    /// You can modify the host ID associated with a stopped instance. If a stopped instance
    /// has a new host ID association, the instance will target that host when restarted.
    /// </para>
    ///  
    /// <para>
    /// You can modify the tenancy of a stopped instance with a tenancy of <code>host</code>
    /// or <code>dedicated</code>.
    /// </para>
    ///  
    /// <para>
    /// Affinity, hostID, and tenancy are not required parameters, but at least one of them
    /// must be specified in the request. Affinity and tenancy can be modified in the same
    /// request, but tenancy can only be modified on instances that are stopped.
    /// </para>
    /// </summary>
    public partial class ModifyInstancePlacementRequest : AmazonEC2Request
    {
        private Affinity _affinity;
        private string _hostId;
        private string _instanceId;
        private HostTenancy _tenancy;

        /// <summary>
        /// Gets and sets the property Affinity. 
        /// <para>
        /// The new affinity setting for the instance.
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
        /// Gets and sets the property HostId. 
        /// <para>
        /// The ID of the Dedicated Host that the instance will have affinity with.
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
        /// The tenancy of the instance that you are modifying.
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