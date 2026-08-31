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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// The auto-detection properties for a registry, including the requested configuration
    /// and the current detection status. When auto-detection is enabled and the scope preconditions
    /// are met, the registry is automatically populated with discovered resources.
    /// </summary>
    public partial class AutoDetection
    {
        private AutoDetectionConfiguration _configuration;
        private AutoDetectionStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The auto-detection settings that control how resources are discovered for the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoDetectionConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current auto-detection status. <c>ACTIVE</c> indicates that the registry is actively
        /// being populated with detected resources. <c>INACTIVE</c> indicates that the preconditions
        /// required at the configured scope are not currently met.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoDetectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable explanation of the current auto-detection status. Typically populated
        /// when the status requires additional context.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}