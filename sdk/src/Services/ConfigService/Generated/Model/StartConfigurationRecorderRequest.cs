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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the StartConfigurationRecorder operation.
    /// Starts the customer managed configuration recorder. The customer managed configuration
    /// recorder will begin recording configuration changes for the resource types you specify.
    /// 
    ///  
    /// <para>
    /// You must have created a delivery channel to successfully start the customer managed
    /// configuration recorder. You can use the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_PutDeliveryChannel.html">PutDeliveryChannel</a>
    /// operation to create a delivery channel.
    /// </para>
    /// </summary>
    public partial class StartConfigurationRecorderRequest : AmazonConfigServiceRequest
    {
        private string _configurationRecorderName;

        /// <summary>
        /// Gets and sets the property ConfigurationRecorderName. 
        /// <para>
        /// The name of the customer managed configuration recorder that you want to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConfigurationRecorderName
        {
            get { return this._configurationRecorderName; }
            set { this._configurationRecorderName = value; }
        }

        // Check to see if ConfigurationRecorderName property is set
        internal bool IsSetConfigurationRecorderName()
        {
            return this._configurationRecorderName != null;
        }

    }
}