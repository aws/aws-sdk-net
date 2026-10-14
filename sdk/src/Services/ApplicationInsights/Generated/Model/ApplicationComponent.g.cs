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

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Describes a standalone resource or similarly grouped resources that the application
    /// is made up of.
    /// </summary>
    public partial class ApplicationComponent
    {
        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property ComponentRemarks. 
        /// <para>
        ///  If logging is supported for the resource type, indicates whether the component has
        /// configured logs to be monitored. 
        /// </para>
        /// </summary>
        public string ComponentRemarks { get; set; }

        /// <summary>
        /// Checks to see if the ComponentRemarks property is set.
        /// </summary>
        internal bool IsSetComponentRemarks() => this.ComponentRemarks != null;

        /// <summary>
        /// Gets and sets the property DetectedWorkload. 
        /// <para>
        ///  Workloads detected in the application component. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> DetectedWorkload { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the DetectedWorkload property is set.
        /// </summary>
        internal bool IsSetDetectedWorkload() => this.DetectedWorkload != null && (this.DetectedWorkload.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Monitor. 
        /// <para>
        /// Indicates whether the application component is monitored. 
        /// </para>
        /// </summary>
        public bool? Monitor { get; set; }

        /// <summary>
        /// Checks to see if the Monitor property is set.
        /// </summary>
        internal bool IsSetMonitor() => this.Monitor.HasValue;

        /// <summary>
        /// Gets and sets the property OsType. 
        /// <para>
        ///  The operating system of the component. 
        /// </para>
        /// </summary>
        public OsType OsType { get; set; }

        /// <summary>
        /// Checks to see if the OsType property is set.
        /// </summary>
        internal bool IsSetOsType() => this.OsType != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type. Supported resource types include EC2 instances, Auto Scaling group,
        /// Classic ELB, Application ELB, and SQS Queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The stack tier of the application component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Tier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;
    }
}
