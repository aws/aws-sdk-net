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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
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
    /// 
    /// </summary>
    public partial class HostProperties
    {
        private int? _cores;
        private string _instanceType;
        private int? _sockets;
        private int? _totalVCpus;

        /// <summary>
        /// Gets and sets the property Cores. 
        /// <para>
        /// The number of cores on the Dedicated host.
        /// </para>
        /// </summary>
        public int Cores
        {
            get { return this._cores.GetValueOrDefault(); }
            set { this._cores = value; }
        }

        // Check to see if Cores property is set
        internal bool IsSetCores()
        {
            return this._cores.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type size that the Dedicated host supports (e.g., m3.medium).
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Sockets. 
        /// <para>
        /// The number of sockets on the Dedicated host.
        /// </para>
        /// </summary>
        public int Sockets
        {
            get { return this._sockets.GetValueOrDefault(); }
            set { this._sockets = value; }
        }

        // Check to see if Sockets property is set
        internal bool IsSetSockets()
        {
            return this._sockets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalVCpus. 
        /// <para>
        /// The number of vCPUs on the Dedicated host.
        /// </para>
        /// </summary>
        public int TotalVCpus
        {
            get { return this._totalVCpus.GetValueOrDefault(); }
            set { this._totalVCpus = value; }
        }

        // Check to see if TotalVCpus property is set
        internal bool IsSetTotalVCpus()
        {
            return this._totalVCpus.HasValue; 
        }

    }
}