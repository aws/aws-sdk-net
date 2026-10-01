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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Summary information for a custom model.
    /// </summary>
    public partial class CustomModelSummary
    {
        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        /// The base model Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string BaseModelArn { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelArn property is set.
        /// </summary>
        internal bool IsSetBaseModelArn() => this.BaseModelArn != null;

        /// <summary>
        /// Gets and sets the property BaseModelName. 
        /// <para>
        /// The base model name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string BaseModelName { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelName property is set.
        /// </summary>
        internal bool IsSetBaseModelName() => this.BaseModelName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomizationType. 
        /// <para>
        /// Specifies whether to carry out continued pre-training of a model or whether to fine-tune
        /// it. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a>.
        /// </para>
        /// </summary>
        public CustomizationType CustomizationType { get; set; }

        /// <summary>
        /// Checks to see if the CustomizationType property is set.
        /// </summary>
        internal bool IsSetCustomizationType() => this.CustomizationType != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelStatus. 
        /// <para>
        /// The current status of the custom model. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - The model is being created and validated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Active</c> - The model has been successfully created and is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - The model creation process failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelStatus ModelStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelStatus property is set.
        /// </summary>
        internal bool IsSetModelStatus() => this.ModelStatus != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The unique identifier of the account that owns the model.
        /// </para>
        /// </summary>
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;
    }
}
