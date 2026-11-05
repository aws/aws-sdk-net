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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the UpdateSecurityProfile operation.
    /// </summary>
    public partial class UpdateSecurityProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdditionalMetricsToRetain. 
        /// <para>
        ///  <i>Please use <a>UpdateSecurityProfileResponse$additionalMetricsToRetainV2</a> instead.</i>
        /// 
        /// </para>
        ///  
        /// <para>
        /// A list of metrics whose data is retained (stored). By default, data is retained for
        /// any metric used in the security profile's <c>behaviors</c>, but it is also retained
        /// for any metric specified here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Use additionalMetricsToRetainV2.")]
        public List<string> AdditionalMetricsToRetain { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalMetricsToRetain property is set.
        /// </summary>
        internal bool IsSetAdditionalMetricsToRetain() => this.AdditionalMetricsToRetain != null && (this.AdditionalMetricsToRetain.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalMetricsToRetainV2. 
        /// <para>
        /// A list of metrics whose data is retained (stored). By default, data is retained for
        /// any metric used in the profile's behaviors, but it is also retained for any metric
        /// specified here. Can be used with custom metrics; cannot be used with dimensions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricToRetain> AdditionalMetricsToRetainV2 { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricToRetain>() : null;

        /// <summary>
        /// Checks to see if the AdditionalMetricsToRetainV2 property is set.
        /// </summary>
        internal bool IsSetAdditionalMetricsToRetainV2() => this.AdditionalMetricsToRetainV2 != null && (this.AdditionalMetricsToRetainV2.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AlertTargets. 
        /// <para>
        /// Where the alerts are sent. (Alerts are always sent to the console.)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AlertTarget> AlertTargets { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AlertTarget>() : null;

        /// <summary>
        /// Checks to see if the AlertTargets property is set.
        /// </summary>
        internal bool IsSetAlertTargets() => this.AlertTargets != null && (this.AlertTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Behaviors. 
        /// <para>
        /// Specifies the behaviors that, when violated by a device (thing), cause an alert.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Behavior> Behaviors { get; set; } = AWSConfigs.InitializeCollections ? new List<Behavior>() : null;

        /// <summary>
        /// Checks to see if the Behaviors property is set.
        /// </summary>
        internal bool IsSetBehaviors() => this.Behaviors != null && (this.Behaviors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The time the security profile was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The time the security profile was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property MetricsExportConfig. 
        /// <para>
        /// Specifies the MQTT topic and role ARN required for metric export.
        /// </para>
        /// </summary>
        public MetricsExportConfig MetricsExportConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetricsExportConfig property is set.
        /// </summary>
        internal bool IsSetMetricsExportConfig() => this.MetricsExportConfig != null;

        /// <summary>
        /// Gets and sets the property SecurityProfileArn. 
        /// <para>
        /// The ARN of the security profile that was updated.
        /// </para>
        /// </summary>
        public string SecurityProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProfileArn property is set.
        /// </summary>
        internal bool IsSetSecurityProfileArn() => this.SecurityProfileArn != null;

        /// <summary>
        /// Gets and sets the property SecurityProfileDescription. 
        /// <para>
        /// The description of the security profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string SecurityProfileDescription { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProfileDescription property is set.
        /// </summary>
        internal bool IsSetSecurityProfileDescription() => this.SecurityProfileDescription != null;

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The name of the security profile that was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SecurityProfileName { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProfileName property is set.
        /// </summary>
        internal bool IsSetSecurityProfileName() => this.SecurityProfileName != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The updated version of the security profile.
        /// </para>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
