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

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// The state of a proxy update.
    /// </summary>
    public partial class ProxyUpdateState
    {
        /// <summary>
        /// Gets and sets the property PropagationStatus. Whether the configuration submitted
        /// with the update was applied to all proxy nodes.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyUpdatePropagationStatus PropagationStatus { get; set; }

        /// <summary>
        /// Checks to see if the PropagationStatus property is set.
        /// </summary>
        internal bool IsSetPropagationStatus() => this.PropagationStatus != null;

        /// <summary>
        /// Gets and sets the property Reasons. The reasons for the current state of the update.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Reasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Reasons property is set.
        /// </summary>
        internal bool IsSetReasons() => this.Reasons != null && (this.Reasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidationStatus. Whether the configuration submitted with
        /// the update works. An update is valid once it is successfully applied to at least one
        /// proxy node.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyUpdateValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;
    }
}
