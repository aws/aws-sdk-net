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

namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Information about client compatibility and supported model versions.
    /// </summary>
    public partial class CompatibilityInformation
    {
        /// <summary>
        /// Gets and sets the property ClientCompatibilityVersion. 
        /// <para>
        /// The client compatibility version that was requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ClientCompatibilityVersion { get; set; }

        /// <summary>
        /// Checks to see if the ClientCompatibilityVersion property is set.
        /// </summary>
        internal bool IsSetClientCompatibilityVersion() => this.ClientCompatibilityVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Additional information about compatibility requirements or recommendations.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property SupportedModelIds. 
        /// <para>
        /// A list of model IDs that are supported for the client compatibility version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SupportedModelIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedModelIds property is set.
        /// </summary>
        internal bool IsSetSupportedModelIds() => this.SupportedModelIds != null && (this.SupportedModelIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
