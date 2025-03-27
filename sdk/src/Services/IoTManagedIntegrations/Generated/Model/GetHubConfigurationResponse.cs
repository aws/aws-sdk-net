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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// This is the response object from the GetHubConfiguration operation.
    /// </summary>
    public partial class GetHubConfigurationResponse : AmazonWebServiceResponse
    {
        private long? _hubTokenTimerExpirySettingInSeconds;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property HubTokenTimerExpirySettingInSeconds. 
        /// <para>
        /// A user-defined integer value that represents the hub token timer expiry setting in
        /// seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? HubTokenTimerExpirySettingInSeconds
        {
            get { return this._hubTokenTimerExpirySettingInSeconds; }
            set { this._hubTokenTimerExpirySettingInSeconds = value; }
        }

        // Check to see if HubTokenTimerExpirySettingInSeconds property is set
        internal bool IsSetHubTokenTimerExpirySettingInSeconds()
        {
            return this._hubTokenTimerExpirySettingInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp value of when the hub configuration was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}