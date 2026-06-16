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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for a self-managed Private Connection.
    /// </summary>
    public partial class SelfManagedInput
    {
        private string _certificate;
        private string _resourceConfigurationId;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// Certificate for the Private Connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfigurationId. 
        /// <para>
        /// The ID or ARN of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceConfigurationId
        {
            get { return this._resourceConfigurationId; }
            set { this._resourceConfigurationId = value; }
        }

        // Check to see if ResourceConfigurationId property is set
        internal bool IsSetResourceConfigurationId()
        {
            return this._resourceConfigurationId != null;
        }

    }
}