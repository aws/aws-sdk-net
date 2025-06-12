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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// Container for the parameters to the UpdateEventConfigurations operation.
    /// Updates the event configurations.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateEventConfigurations</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateEventConfigurationsRequest : AmazonIoTRequest
    {
        private Dictionary<string, Configuration> _eventConfigurations = AWSConfigs.InitializeCollections ? new Dictionary<string, Configuration>() : null;

        /// <summary>
        /// Gets and sets the property EventConfigurations. 
        /// <para>
        /// The new event configuration values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Configuration> EventConfigurations
        {
            get { return this._eventConfigurations; }
            set { this._eventConfigurations = value; }
        }

        // Check to see if EventConfigurations property is set
        internal bool IsSetEventConfigurations()
        {
            return this._eventConfigurations != null && (this._eventConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}