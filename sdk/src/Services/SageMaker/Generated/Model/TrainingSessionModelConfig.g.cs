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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration for the base model used in a training session.
    /// </summary>
    public partial class TrainingSessionModelConfig
    {
        /// <summary>
        /// Gets and sets the property AcceptEula. 
        /// <para>
        /// Specifies whether you accept the end-user license agreement (EULA) for gated models.
        /// </para>
        /// </summary>
        public bool? AcceptEula { get; set; }

        /// <summary>
        /// Checks to see if the AcceptEula property is set.
        /// </summary>
        internal bool IsSetAcceptEula() => this.AcceptEula.HasValue;

        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the base foundation model from SageMaker Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string BaseModelArn { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelArn property is set.
        /// </summary>
        internal bool IsSetBaseModelArn() => this.BaseModelArn != null;
    }
}
