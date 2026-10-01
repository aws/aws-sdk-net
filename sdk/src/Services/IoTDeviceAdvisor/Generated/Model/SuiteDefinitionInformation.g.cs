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
    /// Information about the suite definition.
    /// </summary>
    public partial class SuiteDefinitionInformation
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date (in Unix epoch time) when the test suite was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultDevices. 
        /// <para>
        /// Specifies the devices that are under test for the test suite.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<DeviceUnderTest> DefaultDevices { get; set; } = AWSConfigs.InitializeCollections ? new List<DeviceUnderTest>() : null;

        /// <summary>
        /// Checks to see if the DefaultDevices property is set.
        /// </summary>
        internal bool IsSetDefaultDevices() => this.DefaultDevices != null && (this.DefaultDevices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntendedForQualification. 
        /// <para>
        /// Specifies if the test suite is intended for qualification.
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
        /// Gets the MQTT protocol that is configured in the suite definition.
        /// </para>
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionId. 
        /// <para>
        /// Suite definition ID of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string SuiteDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionId property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionId() => this.SuiteDefinitionId != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionName. 
        /// <para>
        /// Suite name of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SuiteDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionName property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionName() => this.SuiteDefinitionName != null;
    }
}
