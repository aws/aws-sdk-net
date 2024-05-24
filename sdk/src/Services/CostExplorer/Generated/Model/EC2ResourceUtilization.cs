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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Utilization metrics for the instance.
    /// </summary>
    public partial class EC2ResourceUtilization
    {
        private DiskResourceUtilization _diskResourceUtilization;
        private EBSResourceUtilization _ebsResourceUtilization;
        private string _maxCpuUtilizationPercentage;
        private string _maxMemoryUtilizationPercentage;
        private string _maxStorageUtilizationPercentage;
        private NetworkResourceUtilization _networkResourceUtilization;

        /// <summary>
        /// Gets and sets the property DiskResourceUtilization. 
        /// <para>
        /// The field that contains a list of disk (local storage) metrics that are associated
        /// with the current instance. 
        /// </para>
        /// </summary>
        public DiskResourceUtilization DiskResourceUtilization
        {
            get { return this._diskResourceUtilization; }
            set { this._diskResourceUtilization = value; }
        }

        // Check to see if DiskResourceUtilization property is set
        internal bool IsSetDiskResourceUtilization()
        {
            return this._diskResourceUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property EBSResourceUtilization. 
        /// <para>
        /// The EBS field that contains a list of EBS metrics that are associated with the current
        /// instance. 
        /// </para>
        /// </summary>
        public EBSResourceUtilization EBSResourceUtilization
        {
            get { return this._ebsResourceUtilization; }
            set { this._ebsResourceUtilization = value; }
        }

        // Check to see if EBSResourceUtilization property is set
        internal bool IsSetEBSResourceUtilization()
        {
            return this._ebsResourceUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCpuUtilizationPercentage. 
        /// <para>
        /// The maximum observed or expected CPU utilization of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MaxCpuUtilizationPercentage
        {
            get { return this._maxCpuUtilizationPercentage; }
            set { this._maxCpuUtilizationPercentage = value; }
        }

        // Check to see if MaxCpuUtilizationPercentage property is set
        internal bool IsSetMaxCpuUtilizationPercentage()
        {
            return this._maxCpuUtilizationPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property MaxMemoryUtilizationPercentage. 
        /// <para>
        /// The maximum observed or expected memory utilization of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MaxMemoryUtilizationPercentage
        {
            get { return this._maxMemoryUtilizationPercentage; }
            set { this._maxMemoryUtilizationPercentage = value; }
        }

        // Check to see if MaxMemoryUtilizationPercentage property is set
        internal bool IsSetMaxMemoryUtilizationPercentage()
        {
            return this._maxMemoryUtilizationPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property MaxStorageUtilizationPercentage. 
        /// <para>
        /// The maximum observed or expected storage utilization of the instance. This doesn't
        /// include EBS storage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MaxStorageUtilizationPercentage
        {
            get { return this._maxStorageUtilizationPercentage; }
            set { this._maxStorageUtilizationPercentage = value; }
        }

        // Check to see if MaxStorageUtilizationPercentage property is set
        internal bool IsSetMaxStorageUtilizationPercentage()
        {
            return this._maxStorageUtilizationPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkResourceUtilization. 
        /// <para>
        /// The network field that contains a list of network metrics that are associated with
        /// the current instance. 
        /// </para>
        /// </summary>
        public NetworkResourceUtilization NetworkResourceUtilization
        {
            get { return this._networkResourceUtilization; }
            set { this._networkResourceUtilization = value; }
        }

        // Check to see if NetworkResourceUtilization property is set
        internal bool IsSetNetworkResourceUtilization()
        {
            return this._networkResourceUtilization != null;
        }

    }
}