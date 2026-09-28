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

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Gets the suite definition configuration.
    /// </summary>
    public partial class SuiteDefinitionConfiguration
    {
        /// <summary>
        /// Gets and sets the property DevicePermissionRoleArn. 
        /// <para>
        /// Gets the device permission ARN. This is a required parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DevicePermissionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DevicePermissionRoleArn property is set.
        /// </summary>
        internal bool IsSetDevicePermissionRoleArn() => this.DevicePermissionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// Gets the devices configured.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<DeviceUnderTest> Devices { get; set; } = AWSConfigs.InitializeCollections ? new List<DeviceUnderTest>() : null;

        /// <summary>
        /// Checks to see if the Devices property is set.
        /// </summary>
        internal bool IsSetDevices() => this.Devices != null && (this.Devices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntendedForQualification. 
        /// <para>
        /// Gets the tests intended for qualification in a suite.
        /// </para>
        /// </summary>
        public bool? IntendedForQualification { get; set; }

        /// <summary>
        /// Checks to see if the IntendedForQualification property is set.
        /// </summary>
        internal bool IsSetIntendedForQualification() => this.IntendedForQualification.HasValue;

        /// <summary>
        /// Gets and sets the property IsLongDurationTest. 
        /// <para>
        /// Verifies if the test suite is a long duration test.
        /// </para>
        /// </summary>
        public bool? IsLongDurationTest { get; set; }

        /// <summary>
        /// Checks to see if the IsLongDurationTest property is set.
        /// </summary>
        internal bool IsSetIsLongDurationTest() => this.IsLongDurationTest.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// Sets the MQTT protocol that is configured in the suite definition.
        /// </para>
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RootGroup. 
        /// <para>
        /// Gets the test suite root group. This is a required parameter. For updating or creating
        /// the latest qualification suite, if <c>intendedForQualification</c> is set to true,
        /// <c>rootGroup</c> can be an empty string. If <c>intendedForQualification</c> is false,
        /// <c>rootGroup</c> cannot be an empty string. If <c>rootGroup</c> is empty, and <c>intendedForQualification</c>
        /// is set to true, all the qualification tests are included, and the configuration is
        /// default.
        /// </para>
        ///  
        /// <para>
        ///  For a qualification suite, the minimum length is 0, and the maximum is 2048. For
        /// a non-qualification suite, the minimum length is 1, and the maximum is 2048. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string RootGroup { get; set; }

        /// <summary>
        /// Checks to see if the RootGroup property is set.
        /// </summary>
        internal bool IsSetRootGroup() => this.RootGroup != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionName. 
        /// <para>
        /// Gets the suite definition name. This is a required parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SuiteDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionName property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionName() => this.SuiteDefinitionName != null;
    }
}
