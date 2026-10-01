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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateComputationModel operation. Updates the
    /// computation model.
    /// </summary>
    public partial class UpdateComputationModelRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ComputationModelConfiguration. 
        /// <para>
        /// The configuration for the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputationModelConfiguration ComputationModelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ComputationModelConfiguration property is set.
        /// </summary>
        internal bool IsSetComputationModelConfiguration() => this.ComputationModelConfiguration != null;

        /// <summary>
        /// Gets and sets the property ComputationModelDataBinding. 
        /// <para>
        /// The data binding for the computation model. Key is a variable name defined in configuration.
        /// Value is a <c>ComputationModelDataBindingValue</c> referenced by the variable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, ComputationModelDataBindingValue> ComputationModelDataBinding { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComputationModelDataBindingValue>() : null;

        /// <summary>
        /// Checks to see if the ComputationModelDataBinding property is set.
        /// </summary>
        internal bool IsSetComputationModelDataBinding() => this.ComputationModelDataBinding != null && (this.ComputationModelDataBinding.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComputationModelDescription. 
        /// <para>
        /// The description of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ComputationModelDescription { get; set; }

        /// <summary>
        /// Checks to see if the ComputationModelDescription property is set.
        /// </summary>
        internal bool IsSetComputationModelDescription() => this.ComputationModelDescription != null;

        /// <summary>
        /// Gets and sets the property ComputationModelId. 
        /// <para>
        /// The ID of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ComputationModelId { get; set; }

        /// <summary>
        /// Checks to see if the ComputationModelId property is set.
        /// </summary>
        internal bool IsSetComputationModelId() => this.ComputationModelId != null;

        /// <summary>
        /// Gets and sets the property ComputationModelName. 
        /// <para>
        /// The name of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ComputationModelName { get; set; }

        /// <summary>
        /// Checks to see if the ComputationModelName property is set.
        /// </summary>
        internal bool IsSetComputationModelName() => this.ComputationModelName != null;
    }
}
