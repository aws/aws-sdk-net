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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
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
namespace Amazon.SagemakerEdgeManager.Model
{
    /// <summary>
    /// This is the response object from the GetDeviceRegistration operation.
    /// </summary>
    public partial class GetDeviceRegistrationResponse : AmazonWebServiceResponse
    {
        private string _cacheTTL;
        private string _deviceRegistration;

        /// <summary>
        /// Gets and sets the property CacheTTL. 
        /// <para>
        /// The amount of time, in seconds, that the registration status is stored on the device’s
        /// cache before it is refreshed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string CacheTTL
        {
            get { return this._cacheTTL; }
            set { this._cacheTTL = value; }
        }

        // Check to see if CacheTTL property is set
        internal bool IsSetCacheTTL()
        {
            return this._cacheTTL != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceRegistration. 
        /// <para>
        /// Describes if the device is currently registered with SageMaker Edge Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string DeviceRegistration
        {
            get { return this._deviceRegistration; }
            set { this._deviceRegistration = value; }
        }

        // Check to see if DeviceRegistration property is set
        internal bool IsSetDeviceRegistration()
        {
            return this._deviceRegistration != null;
        }

    }
}