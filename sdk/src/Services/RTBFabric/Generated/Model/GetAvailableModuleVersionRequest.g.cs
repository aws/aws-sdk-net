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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Container for the parameters to the GetAvailableModuleVersion operation. Returns an
    /// ACTIVE or DEPRECATED version of a module that you can attach. If you can't attach
    /// the module, or the version is in another status, the operation returns ResourceNotFoundException,
    /// the same as for a missing one.
    /// </summary>
    public partial class GetAvailableModuleVersionRequest : AmazonRTBFabricRequest
    {
        /// <summary>
        /// Gets and sets the property ModuleId. 
        /// <para>
        /// The module's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModuleId { get; set; }

        /// <summary>
        /// Checks to see if the ModuleId property is set.
        /// </summary>
        internal bool IsSetModuleId() => this.ModuleId != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
