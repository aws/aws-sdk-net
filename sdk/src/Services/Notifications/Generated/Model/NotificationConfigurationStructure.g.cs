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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Contains the complete list of fields for a NotificationConfiguration.
    /// </summary>
    public partial class NotificationConfigurationStructure
    {
        /// <summary>
        /// Gets and sets the property AggregationDuration. 
        /// <para>
        /// The aggregation preference of the <c>NotificationConfiguration</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LONG</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aggregate notifications for long periods of time (12 hours).
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>SHORT</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aggregate notifications for short periods of time (5 minutes).
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NONE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Don't aggregate notifications.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        public AggregationDuration AggregationDuration { get; set; }

        /// <summary>
        /// Checks to see if the AggregationDuration property is set.
        /// </summary>
        internal bool IsSetAggregationDuration() => this.AggregationDuration != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>NotificationConfiguration</c> resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the <c>NotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the <c>NotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>NotificationConfiguration</c>. Supports RFC 3986's unreserved characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the <c>NotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Subtype. 
        /// <para>
        /// The subtype of the notification configuration.
        /// </para>
        /// </summary>
        public NotificationConfigurationSubtype Subtype { get; set; }

        /// <summary>
        /// Checks to see if the Subtype property is set.
        /// </summary>
        internal bool IsSetSubtype() => this.Subtype != null;
    }
}
