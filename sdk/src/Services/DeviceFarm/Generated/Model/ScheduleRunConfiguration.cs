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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
        private List<string> _auxiliaryApps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private BillingMethod _billingMethod;
        private CustomerArtifactPaths _customerArtifactPaths;
        private DeviceProxy _deviceProxy;
        private string _extraDataPackageArn;
        private string _locale;
        private Location _location;
        private string _networkProfileArn;
        private Radios _radios;
        private List<string> _vpceConfigurationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AuxiliaryApps. 
        /// <para>
        /// A list of upload ARNs for app packages to be installed with your app.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuxiliaryApps
        {
            get { return this._auxiliaryApps; }
            set { this._auxiliaryApps = value; }
        }

        // Check to see if AuxiliaryApps property is set
        internal bool IsSetAuxiliaryApps()
        {
            return this._auxiliaryApps != null && (this._auxiliaryApps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public BillingMethod BillingMethod
        {
            get { return this._billingMethod; }
            set { this._billingMethod = value; }
        }

        // Check to see if BillingMethod property is set
        internal bool IsSetBillingMethod()
        {
            return this._billingMethod != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerArtifactPaths. 
        /// <para>
        /// Input <c>CustomerArtifactPaths</c> object for the scheduled run configuration.
        /// </para>
        /// </summary>
        public CustomerArtifactPaths CustomerArtifactPaths
        {
            get { return this._customerArtifactPaths; }
            set { this._customerArtifactPaths = value; }
        }

        // Check to see if CustomerArtifactPaths property is set
        internal bool IsSetCustomerArtifactPaths()
        {
            return this._customerArtifactPaths != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceProxy. 
        /// <para>
        /// The device proxy to be configured on the device for the run.
        /// </para>
        /// </summary>
        public DeviceProxy DeviceProxy
        {
            get { return this._deviceProxy; }
            set { this._deviceProxy = value; }
        }

        // Check to see if DeviceProxy property is set
        internal bool IsSetDeviceProxy()
        {
            return this._deviceProxy != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraDataPackageArn. 
        /// <para>
        /// The ARN of the extra data for the run. The extra data is a .zip file that AWS Device
        /// Farm extracts to external data for Android or the app's sandbox for iOS.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string ExtraDataPackageArn
        {
            get { return this._extraDataPackageArn; }
            set { this._extraDataPackageArn = value; }
        }

        // Check to see if ExtraDataPackageArn property is set
        internal bool IsSetExtraDataPackageArn()
        {
            return this._extraDataPackageArn != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// Information about the locale that is used for the run.
        /// </para>
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the location that is used for the run.
        /// </para>
        /// </summary>
        public Location Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkProfileArn. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string NetworkProfileArn
        {
            get { return this._networkProfileArn; }
            set { this._networkProfileArn = value; }
        }

        // Check to see if NetworkProfileArn property is set
        internal bool IsSetNetworkProfileArn()
        {
            return this._networkProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property Radios. 
        /// <para>
        /// Information about the radio states for the run.
        /// </para>
        /// </summary>
        public Radios Radios
        {
            get { return this._radios; }
            set { this._radios = value; }
        }

        // Check to see if Radios property is set
        internal bool IsSetRadios()
        {
            return this._radios != null;
        }

        /// <summary>
        /// Gets and sets the property VpceConfigurationArns. 
        /// <para>
        /// An array of ARNs for your VPC endpoint configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpceConfigurationArns
        {
            get { return this._vpceConfigurationArns; }
            set { this._vpceConfigurationArns = value; }
        }

        // Check to see if VpceConfigurationArns property is set
        internal bool IsSetVpceConfigurationArns()
        {
            return this._vpceConfigurationArns != null && (this._vpceConfigurationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}