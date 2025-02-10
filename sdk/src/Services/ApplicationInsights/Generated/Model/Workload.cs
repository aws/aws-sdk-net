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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
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
namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Describes the workloads on a component.
    /// </summary>
    public partial class Workload
    {
        private string _componentName;
        private bool? _missingWorkloadConfig;
        private Tier _tier;
        private string _workloadId;
        private string _workloadName;
        private string _workloadRemarks;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property MissingWorkloadConfig. 
        /// <para>
        /// Indicates whether all of the component configurations required to monitor a workload
        /// were provided.
        /// </para>
        /// </summary>
        public bool? MissingWorkloadConfig
        {
            get { return this._missingWorkloadConfig; }
            set { this._missingWorkloadConfig = value; }
        }

        // Check to see if MissingWorkloadConfig property is set
        internal bool IsSetMissingWorkloadConfig()
        {
            return this._missingWorkloadConfig.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Tier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadId. 
        /// <para>
        /// The ID of the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min=38, Max=38)]
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public string WorkloadName
        {
            get { return this._workloadName; }
            set { this._workloadName = value; }
        }

        // Check to see if WorkloadName property is set
        internal bool IsSetWorkloadName()
        {
            return this._workloadName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadRemarks. 
        /// <para>
        /// If logging is supported for the resource type, shows whether the component has configured
        /// logs to be monitored.
        /// </para>
        /// </summary>
        public string WorkloadRemarks
        {
            get { return this._workloadRemarks; }
            set { this._workloadRemarks = value; }
        }

        // Check to see if WorkloadRemarks property is set
        internal bool IsSetWorkloadRemarks()
        {
            return this._workloadRemarks != null;
        }

    }
}