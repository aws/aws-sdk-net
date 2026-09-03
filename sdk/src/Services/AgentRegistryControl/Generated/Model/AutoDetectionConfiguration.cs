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
    /// The customer-defined auto-detection settings for a registry.
    /// </summary>
    public partial class AutoDetectionConfiguration
    {
        private bool? _enabled;
        private AutoDetectionScope _scope;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether auto-detection is requested for the registry. Setting this to <c>true</c>
        /// is necessary but not sufficient for auto-detection to become active; the preconditions
        /// of the configured scope must also be met.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The source from which resources are detected. For example, <c>ORGANIZATION</c> sources
        /// resources from all member accounts of an Amazon Web Services organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoDetectionScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}