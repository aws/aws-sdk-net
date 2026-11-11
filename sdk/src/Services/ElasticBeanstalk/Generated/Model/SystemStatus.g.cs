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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// CPU utilization and load average metrics for an Amazon EC2 instance.
    /// </summary>
    public partial class SystemStatus
    {
        /// <summary>
        /// Gets and sets the property CPUUtilization. 
        /// <para>
        /// CPU utilization metrics for the instance.
        /// </para>
        /// </summary>
        public CPUUtilization CPUUtilization { get; set; }

        /// <summary>
        /// Checks to see if the CPUUtilization property is set.
        /// </summary>
        internal bool IsSetCPUUtilization() => this.CPUUtilization != null;

        /// <summary>
        /// Gets and sets the property LoadAverage. 
        /// <para>
        /// Load average in the last 1-minute, 5-minute, and 15-minute periods. For more information,
        /// see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-metrics.html#health-enhanced-metrics-os">Operating
        /// System Metrics</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> LoadAverage { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the LoadAverage property is set.
        /// </summary>
        internal bool IsSetLoadAverage() => this.LoadAverage != null && (this.LoadAverage.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
