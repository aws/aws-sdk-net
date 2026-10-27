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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// The details of the maintenance configuration for the application.
    /// </summary>
    public partial class ApplicationMaintenanceConfigurationDescription
    {
        /// <summary>
        /// Gets and sets the property ApplicationMaintenanceWindowEndTime. 
        /// <para>
        /// The end time for the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string ApplicationMaintenanceWindowEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationMaintenanceWindowEndTime property is set.
        /// </summary>
        internal bool IsSetApplicationMaintenanceWindowEndTime() => this.ApplicationMaintenanceWindowEndTime != null;

        /// <summary>
        /// Gets and sets the property ApplicationMaintenanceWindowStartTime. 
        /// <para>
        /// The start time for the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string ApplicationMaintenanceWindowStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationMaintenanceWindowStartTime property is set.
        /// </summary>
        internal bool IsSetApplicationMaintenanceWindowStartTime() => this.ApplicationMaintenanceWindowStartTime != null;
    }
}
