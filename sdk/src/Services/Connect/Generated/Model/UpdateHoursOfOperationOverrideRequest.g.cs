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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHoursOfOperationOverride operation. Update
    /// the hours of operation override.
    /// </summary>
    public partial class UpdateHoursOfOperationOverrideRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// Configuration information for the hours of operation override: day, start time, and
        /// end time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<HoursOfOperationOverrideConfig> Config { get; set; } = AWSConfigs.InitializeCollections ? new List<HoursOfOperationOverrideConfig>() : null;

        /// <summary>
        /// Checks to see if the Config property is set.
        /// </summary>
        internal bool IsSetConfig() => this.Config != null && (this.Config.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the hours of operation override.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// The date from when the hours of operation override would be effective.
        /// </para>
        /// </summary>
        public string EffectiveFrom { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveFrom property is set.
        /// </summary>
        internal bool IsSetEffectiveFrom() => this.EffectiveFrom != null;

        /// <summary>
        /// Gets and sets the property EffectiveTill. 
        /// <para>
        /// The date until the hours of operation override is effective.
        /// </para>
        /// </summary>
        public string EffectiveTill { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveTill property is set.
        /// </summary>
        internal bool IsSetEffectiveTill() => this.EffectiveTill != null;

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier for the hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HoursOfOperationId { get; set; }

        /// <summary>
        /// Checks to see if the HoursOfOperationId property is set.
        /// </summary>
        internal bool IsSetHoursOfOperationId() => this.HoursOfOperationId != null;

        /// <summary>
        /// Gets and sets the property HoursOfOperationOverrideId. 
        /// <para>
        /// The identifier for the hours of operation override.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string HoursOfOperationOverrideId { get; set; }

        /// <summary>
        /// Checks to see if the HoursOfOperationOverrideId property is set.
        /// </summary>
        internal bool IsSetHoursOfOperationOverrideId() => this.HoursOfOperationOverrideId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hours of operation override.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OverrideType. 
        /// <para>
        /// Whether the override will be defined as a <i>standard</i> or as a <i>recurring event</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about how override types are applied, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/hours-of-operation-overrides.html">Build
        /// your list of overrides</a> in the <i> Administrator Guide</i>.
        /// </para>
        /// </summary>
        public OverrideType OverrideType { get; set; }

        /// <summary>
        /// Checks to see if the OverrideType property is set.
        /// </summary>
        internal bool IsSetOverrideType() => this.OverrideType != null;

        /// <summary>
        /// Gets and sets the property RecurrenceConfig. 
        /// <para>
        /// Configuration for a recurring event.
        /// </para>
        /// </summary>
        public RecurrenceConfig RecurrenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the RecurrenceConfig property is set.
        /// </summary>
        internal bool IsSetRecurrenceConfig() => this.RecurrenceConfig != null;
    }
}
