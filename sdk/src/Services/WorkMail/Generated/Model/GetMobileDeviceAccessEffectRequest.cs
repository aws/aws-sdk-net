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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the GetMobileDeviceAccessEffect operation.
    /// Simulates the effect of the mobile device access rules for the given attributes of
    /// a sample access event. Use this method to test the effects of the current set of mobile
    /// device access rules for the WorkMail organization for a particular user's attributes.
    /// </summary>
    public partial class GetMobileDeviceAccessEffectRequest : AmazonWorkMailRequest
    {
        private string _deviceModel;
        private string _deviceOperatingSystem;
        private string _deviceType;
        private string _deviceUserAgent;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property DeviceModel. 
        /// <para>
        /// Device model the simulated user will report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DeviceModel
        {
            get { return this._deviceModel; }
            set { this._deviceModel = value; }
        }

        // Check to see if DeviceModel property is set
        internal bool IsSetDeviceModel()
        {
            return this._deviceModel != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceOperatingSystem. 
        /// <para>
        /// Device operating system the simulated user will report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DeviceOperatingSystem
        {
            get { return this._deviceOperatingSystem; }
            set { this._deviceOperatingSystem = value; }
        }

        // Check to see if DeviceOperatingSystem property is set
        internal bool IsSetDeviceOperatingSystem()
        {
            return this._deviceOperatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// Device type the simulated user will report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DeviceType
        {
            get { return this._deviceType; }
            set { this._deviceType = value; }
        }

        // Check to see if DeviceType property is set
        internal bool IsSetDeviceType()
        {
            return this._deviceType != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceUserAgent. 
        /// <para>
        /// Device user agent the simulated user will report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DeviceUserAgent
        {
            get { return this._deviceUserAgent; }
            set { this._deviceUserAgent = value; }
        }

        // Check to see if DeviceUserAgent property is set
        internal bool IsSetDeviceUserAgent()
        {
            return this._deviceUserAgent != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The WorkMail organization to simulate the access effect for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

    }
}