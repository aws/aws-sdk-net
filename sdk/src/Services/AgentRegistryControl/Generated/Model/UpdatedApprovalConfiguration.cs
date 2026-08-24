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
    /// A wrapper for updating the approval configuration of a registry. Include this wrapper
    /// to replace the approval configuration with the specified value; omit it to leave the
    /// approval configuration unchanged.
    /// </summary>
    public partial class UpdatedApprovalConfiguration
    {
        private ApprovalConfiguration _optionalValue;

        /// <summary>
        /// Gets and sets the property OptionalValue. 
        /// <para>
        /// The value to set for this field. Omit the wrapper to leave the field unchanged.
        /// </para>
        /// </summary>
        public ApprovalConfiguration OptionalValue
        {
            get { return this._optionalValue; }
            set { this._optionalValue = value; }
        }

        // Check to see if OptionalValue property is set
        internal bool IsSetOptionalValue()
        {
            return this._optionalValue != null;
        }

    }
}