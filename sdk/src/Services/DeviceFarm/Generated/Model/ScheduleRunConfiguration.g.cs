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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the settings for a run. Includes things like location, radio states, auxiliary
    /// apps, and network profiles.
    /// </summary>
    public partial class ScheduleRunConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuxiliaryApps. 
        /// <para>
        /// A list of upload ARNs for app packages to be installed with your app.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuxiliaryApps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuxiliaryApps property is set.
        /// </summary>
        internal bool IsSetAuxiliaryApps() => this.AuxiliaryApps != null && (this.AuxiliaryApps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingMethod. 
        /// <para>
        /// Specifies the billing method for a test run: <c>metered</c> or <c>unmetered</c>. If
        /// the parameter is not specified, the default value is <c>metered</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you have purchased unmetered device slots, you must set this parameter to <c>unmetered</c>
        /// to make use of them. Otherwise, your run counts against your metered time.
        /// </para>
        ///  </note>
        /// </summary>
        public BillingMethod BillingMethod { get; set; }

        /// <summary>
        /// Checks to see if the BillingMethod property is set.
        /// </summary>
        internal bool IsSetBillingMethod() => this.BillingMethod != null;

        /// <summary>
        /// Gets and sets the property CustomerArtifactPaths. 
        /// <para>
        /// Input <c>CustomerArtifactPaths</c> object for the scheduled run configuration.
        /// </para>
        /// </summary>
        public CustomerArtifactPaths CustomerArtifactPaths { get; set; }

        /// <summary>
        /// Checks to see if the CustomerArtifactPaths property is set.
        /// </summary>
        internal bool IsSetCustomerArtifactPaths() => this.CustomerArtifactPaths != null;

        /// <summary>
        /// Gets and sets the property DeviceProxy. 
        /// <para>
        /// The device proxy to be configured on the device for the run.
        /// </para>
        /// </summary>
        public DeviceProxy DeviceProxy { get; set; }

        /// <summary>
        /// Checks to see if the DeviceProxy property is set.
        /// </summary>
        internal bool IsSetDeviceProxy() => this.DeviceProxy != null;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables associated with the run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public List<EnvironmentVariable> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentVariable>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// An IAM role to be assumed by the test host for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property ExtraDataPackageArn. 
        /// <para>
        /// The ARN of the extra data for the run. The extra data is a .zip file that AWS Device
        /// Farm extracts to external data for Android or the app's sandbox for iOS.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string ExtraDataPackageArn { get; set; }

        /// <summary>
        /// Checks to see if the ExtraDataPackageArn property is set.
        /// </summary>
        internal bool IsSetExtraDataPackageArn() => this.ExtraDataPackageArn != null;

        /// <summary>
        /// Gets and sets the property InsightsTypes. 
        /// <para>
        /// The types of insights to generate for a run. Specify one or more values to opt in
        /// to insights generation when scheduling a run.
        /// </para>
        ///  
        /// <para>
        /// Insights are currently supported for custom mode runs with Instrumentation, Appium
        /// Java TestNG, and XCTest UI test types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> InsightsTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InsightsTypes property is set.
        /// </summary>
        internal bool IsSetInsightsTypes() => this.InsightsTypes != null && (this.InsightsTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// Information about the locale that is used for the run.
        /// </para>
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the location that is used for the run.
        /// </para>
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property NetworkProfileArn. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string NetworkProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the NetworkProfileArn property is set.
        /// </summary>
        internal bool IsSetNetworkProfileArn() => this.NetworkProfileArn != null;

        /// <summary>
        /// Gets and sets the property Radios. 
        /// <para>
        /// Information about the radio states for the run.
        /// </para>
        /// </summary>
        public Radios Radios { get; set; }

        /// <summary>
        /// Checks to see if the Radios property is set.
        /// </summary>
        internal bool IsSetRadios() => this.Radios != null;

        /// <summary>
        /// Gets and sets the property VpceConfigurationArns. 
        /// <para>
        /// An array of ARNs for your VPC endpoint configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpceConfigurationArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpceConfigurationArns property is set.
        /// </summary>
        internal bool IsSetVpceConfigurationArns() => this.VpceConfigurationArns != null && (this.VpceConfigurationArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
