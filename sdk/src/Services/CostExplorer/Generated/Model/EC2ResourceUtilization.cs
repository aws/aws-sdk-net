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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Utilization metrics of the instance.
    /// </summary>
    public partial class EC2ResourceUtilization
    {
        private EBSResourceUtilization _ebsResourceUtilization;
        private string _maxCpuUtilizationPercentage;
        private string _maxMemoryUtilizationPercentage;
        private string _maxStorageUtilizationPercentage;

        /// <summary>
        /// Gets and sets the property EBSResourceUtilization. 
        /// <para>
        ///  The EBS field that contains a list of EBS metrics associated with the current instance.
        /// 
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
        ///  Maximum observed or expected CPU utilization of the instance.
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
        ///  Maximum observed or expected memory utilization of the instance.
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
        ///  Maximum observed or expected storage utilization of the instance (does not measure
        /// EBS storage).
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

    }
}