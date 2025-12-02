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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration parameters for Amazon Bedrock AgentCore logging, including <c>logType</c>
    /// settings.
    /// </summary>
    public partial class LogDeliveryParameters
    {
        private List<string> _logTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LogTypes. 
        /// <para>
        /// The type of log that the source is sending.
        /// </para>
        /// </summary>
        public List<string> LogTypes
        {
            get { return this._logTypes; }
            set { this._logTypes = value; }
        }

        // Check to see if LogTypes property is set
        internal bool IsSetLogTypes()
        {
            return this._logTypes != null && (this._logTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}