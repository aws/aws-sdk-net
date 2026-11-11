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
    /// Container for the parameters to the UpdateSecurityProfile operation. <note> <para>
    /// The IoT Device Defender detect feature will no longer be available to new customers
    /// starting August 31, 2026. If you would like to use the detect feature, sign up prior
    /// to August 31, 2026. To learn about alternatives to IoT Device Defender detect, see
    /// IoT Device Defender detect feature availability change in the IoT Device Defender
    /// Developer Guide. There is no change to IoT Device Defender audit availability. </para>
    /// </note> <para> Updates a Device Defender security profile. </para> <para> Requires
    /// permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateSecurityProfile</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateSecurityProfileRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalMetricsToRetain. 
        /// <para>
        ///  <i>Please use <a>UpdateSecurityProfileRequest$additionalMetricsToRetainV2</a> instead.</i>
        /// 
        /// </para>
        ///  
        /// <para>
        /// A list of metrics whose data is retained (stored). By default, data is retained for
        /// any metric used in the profile's <c>behaviors</c>, but it is also retained for any
        /// metric specified here. Can be used with custom metrics; cannot be used with dimensions.
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
        /// Gets and sets the property DeleteAdditionalMetricsToRetain. 
        /// <para>
        /// If true, delete all <c>additionalMetricsToRetain</c> defined for this security profile.
        /// If any <c>additionalMetricsToRetain</c> are defined in the current invocation, an
        /// exception occurs.
        /// </para>
        /// </summary>
        public bool? DeleteAdditionalMetricsToRetain { get; set; }

        /// <summary>
        /// Checks to see if the DeleteAdditionalMetricsToRetain property is set.
        /// </summary>
        internal bool IsSetDeleteAdditionalMetricsToRetain() => this.DeleteAdditionalMetricsToRetain.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteAlertTargets. 
        /// <para>
        /// If true, delete all <c>alertTargets</c> defined for this security profile. If any
        /// <c>alertTargets</c> are defined in the current invocation, an exception occurs.
        /// </para>
        /// </summary>
        public bool? DeleteAlertTargets { get; set; }

        /// <summary>
        /// Checks to see if the DeleteAlertTargets property is set.
        /// </summary>
        internal bool IsSetDeleteAlertTargets() => this.DeleteAlertTargets.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteBehaviors. 
        /// <para>
        /// If true, delete all <c>behaviors</c> defined for this security profile. If any <c>behaviors</c>
        /// are defined in the current invocation, an exception occurs.
        /// </para>
        /// </summary>
        public bool? DeleteBehaviors { get; set; }

        /// <summary>
        /// Checks to see if the DeleteBehaviors property is set.
        /// </summary>
        internal bool IsSetDeleteBehaviors() => this.DeleteBehaviors.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteMetricsExportConfig. 
        /// <para>
        /// Set the value as true to delete metrics export related configurations.
        /// </para>
        /// </summary>
        public bool? DeleteMetricsExportConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeleteMetricsExportConfig property is set.
        /// </summary>
        internal bool IsSetDeleteMetricsExportConfig() => this.DeleteMetricsExportConfig.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// The expected version of the security profile. A new version is generated whenever
        /// the security profile is updated. If you specify a value that is different from the
        /// actual version, a <c>VersionConflictException</c> is thrown.
        /// </para>
        /// </summary>
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedVersion property is set.
        /// </summary>
        internal bool IsSetExpectedVersion() => this.ExpectedVersion.HasValue;

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
        /// Gets and sets the property SecurityProfileDescription. 
        /// <para>
        /// A description of the security profile.
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
        /// The name of the security profile you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string SecurityProfileName { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProfileName property is set.
        /// </summary>
        internal bool IsSetSecurityProfileName() => this.SecurityProfileName != null;
    }
}
