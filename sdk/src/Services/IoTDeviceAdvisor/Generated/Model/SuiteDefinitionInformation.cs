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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Get suite definition information.
    /// </summary>
    public partial class SuiteDefinitionInformation
    {
        private DateTime? _createdAt;
        private List<DeviceUnderTest> _defaultDevices = new List<DeviceUnderTest>();
        private bool? _intendedForQualification;
        private string _suiteDefinitionId;
        private string _suiteDefinitionName;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Gets the information of when the test suite was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultDevices. 
        /// <para>
        /// Specifies the devices under test.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<DeviceUnderTest> DefaultDevices
        {
            get { return this._defaultDevices; }
            set { this._defaultDevices = value; }
        }

        // Check to see if DefaultDevices property is set
        internal bool IsSetDefaultDevices()
        {
            return this._defaultDevices != null && this._defaultDevices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IntendedForQualification. 
        /// <para>
        /// Gets the test suites which will be used for qualification.
        /// </para>
        /// </summary>
        public bool IntendedForQualification
        {
            get { return this._intendedForQualification.GetValueOrDefault(); }
            set { this._intendedForQualification = value; }
        }

        // Check to see if IntendedForQualification property is set
        internal bool IsSetIntendedForQualification()
        {
            return this._intendedForQualification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionId. 
        /// <para>
        /// Get suite definition Id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SuiteDefinitionId
        {
            get { return this._suiteDefinitionId; }
            set { this._suiteDefinitionId = value; }
        }

        // Check to see if SuiteDefinitionId property is set
        internal bool IsSetSuiteDefinitionId()
        {
            return this._suiteDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionName. 
        /// <para>
        /// Get test suite name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SuiteDefinitionName
        {
            get { return this._suiteDefinitionName; }
            set { this._suiteDefinitionName = value; }
        }

        // Check to see if SuiteDefinitionName property is set
        internal bool IsSetSuiteDefinitionName()
        {
            return this._suiteDefinitionName != null;
        }

    }
}