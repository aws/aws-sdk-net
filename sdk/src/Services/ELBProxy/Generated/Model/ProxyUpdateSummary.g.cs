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
    /// Summary information about a proxy update.
    /// </summary>
    public partial class ProxyUpdateSummary
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. The date and time that the update's propagation
        /// status became `complete`, `failed`, or `cancelled`. This value is absent while the
        /// update is `in-progress` or `skipped`.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

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
        /// Gets and sets the property SubmittedAt. The date and time that the update was submitted.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedAt property is set.
        /// </summary>
        internal bool IsSetSubmittedAt() => this.SubmittedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Type. The type of the update.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyUpdateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdateId. The ID of the update.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UpdateId { get; set; }

        /// <summary>
        /// Checks to see if the UpdateId property is set.
        /// </summary>
        internal bool IsSetUpdateId() => this.UpdateId != null;

        /// <summary>
        /// Gets and sets the property ValidatedAt. The date and time that the update was first
        /// successfully applied to a proxy node. This value is absent until the update is valid.
        /// </summary>
        public DateTime? ValidatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ValidatedAt property is set.
        /// </summary>
        internal bool IsSetValidatedAt() => this.ValidatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationStatus. Whether the configuration submitted with
        /// the update works.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyUpdateValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;
    }
}
