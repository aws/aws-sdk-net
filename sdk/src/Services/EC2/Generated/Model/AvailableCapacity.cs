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
    /// The capacity information for instances launched onto the Dedicated Host.
    /// </summary>
    public partial class AvailableCapacity
    {
        private List<InstanceCapacity> _availableInstanceCapacity = new List<InstanceCapacity>();
        private int? _availableVCpus;

        /// <summary>
        /// Gets and sets the property AvailableInstanceCapacity. 
        /// <para>
        /// The total number of instances that the Dedicated Host supports.
        /// </para>
        /// </summary>
        public List<InstanceCapacity> AvailableInstanceCapacity
        {
            get { return this._availableInstanceCapacity; }
            set { this._availableInstanceCapacity = value; }
        }

        // Check to see if AvailableInstanceCapacity property is set
        internal bool IsSetAvailableInstanceCapacity()
        {
            return this._availableInstanceCapacity != null && this._availableInstanceCapacity.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AvailableVCpus. 
        /// <para>
        /// The number of vCPUs available on the Dedicated Host.
        /// </para>
        /// </summary>
        public int AvailableVCpus
        {
            get { return this._availableVCpus.GetValueOrDefault(); }
            set { this._availableVCpus = value; }
        }

        // Check to see if AvailableVCpus property is set
        internal bool IsSetAvailableVCpus()
        {
            return this._availableVCpus.HasValue; 
        }

    }
}