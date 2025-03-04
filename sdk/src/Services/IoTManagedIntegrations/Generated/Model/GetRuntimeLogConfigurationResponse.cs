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
    /// This is the response object from the GetRuntimeLogConfiguration operation.
    /// </summary>
    public partial class GetRuntimeLogConfigurationResponse : AmazonWebServiceResponse
    {
        private string _managedThingId;
        private RuntimeLogConfigurations _runtimeLogConfigurations;

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The id for a managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ManagedThingId
        {
            get { return this._managedThingId; }
            set { this._managedThingId = value; }
        }

        // Check to see if ManagedThingId property is set
        internal bool IsSetManagedThingId()
        {
            return this._managedThingId != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeLogConfigurations. 
        /// <para>
        /// The runtime log configuration for a managed thing.
        /// </para>
        /// </summary>
        public RuntimeLogConfigurations RuntimeLogConfigurations
        {
            get { return this._runtimeLogConfigurations; }
            set { this._runtimeLogConfigurations = value; }
        }

        // Check to see if RuntimeLogConfigurations property is set
        internal bool IsSetRuntimeLogConfigurations()
        {
            return this._runtimeLogConfigurations != null;
        }

    }
}