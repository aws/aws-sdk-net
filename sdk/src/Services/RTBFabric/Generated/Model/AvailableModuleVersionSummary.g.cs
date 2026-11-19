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
    /// A version of a module that you can attach, as ListAvailableModuleVersions returns
    /// it. ListAvailableModuleVersions and GetAvailableModuleVersion never return how a version
    /// is implemented.
    /// </summary>
    public partial class AvailableModuleVersionSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the version was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ModuleVersionArn. 
        /// <para>
        /// The version's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string ModuleVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ModuleVersionArn property is set.
        /// </summary>
        internal bool IsSetModuleVersionArn() => this.ModuleVersionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// ACTIVE or DEPRECATED.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModuleVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
