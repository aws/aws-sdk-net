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

namespace Amazon.SageMakerTrainingSessionRuntime.Model
{
    /// <summary>
    /// The configuration for a forward-only pass through the model. This computes loss values
    /// without computing gradients.
    /// </summary>
    public partial class ForwardConfig
    {
        /// <summary>
        /// Gets and sets the property DatumList. 
        /// <para>
        /// The list of input data to feed through the model. Must contain at least one datum,
        /// and each datum must have a non-empty modelInput with at least one chunk.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Datum> DatumList { get; set; } = AWSConfigs.InitializeCollections ? new List<Datum>() : null;

        /// <summary>
        /// Checks to see if the DatumList property is set.
        /// </summary>
        internal bool IsSetDatumList() => this.DatumList != null && (this.DatumList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LossFnConfig. 
        /// <para>
        /// Additional loss function configuration passed to the engine. Supported keys are <c>clip_low_threshold</c>
        /// (valid range: 0 to 1) and <c>clip_high_threshold</c> (valid range: 1 to 10). Unsupported
        /// keys are rejected.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document LossFnConfig { get; set; }

        /// <summary>
        /// Checks to see if the LossFnConfig property is set.
        /// </summary>
        internal bool IsSetLossFnConfig() => !this.LossFnConfig.IsNull();

        /// <summary>
        /// Gets and sets the property LossFnName. 
        /// <para>
        /// The name of the loss function to evaluate during the forward pass.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LossFnName LossFnName { get; set; }

        /// <summary>
        /// Checks to see if the LossFnName property is set.
        /// </summary>
        internal bool IsSetLossFnName() => this.LossFnName != null;
    }
}
