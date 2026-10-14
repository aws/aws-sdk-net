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
    /// A tensor with data, data type, and shape metadata.
    /// </summary>
    public partial class TensorData
    {
        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The raw tensor data as JSON. The format is determined by the <c>dtype</c> field: integer
        /// arrays for <c>int64</c>, floating-point arrays for <c>float32</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => !this.Data.IsNull();

        /// <summary>
        /// Gets and sets the property Dtype. 
        /// <para>
        /// The data type of the tensor elements, such as <c>int64</c> or <c>float32</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Dtype { get; set; }

        /// <summary>
        /// Checks to see if the Dtype property is set.
        /// </summary>
        internal bool IsSetDtype() => this.Dtype != null;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The dimensions of the tensor, such as [batch_size, seq_length].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Shape { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Shape property is set.
        /// </summary>
        internal bool IsSetShape() => this.Shape != null && (this.Shape.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
