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
    /// This is the response object from the GetImportedModel operation.
    /// </summary>
    public partial class GetImportedModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the imported model.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomModelUnits. 
        /// <para>
        /// Information about the hardware utilization for a single copy of the model.
        /// </para>
        /// </summary>
        public CustomModelUnits CustomModelUnits { get; set; }

        /// <summary>
        /// Checks to see if the CustomModelUnits property is set.
        /// </summary>
        internal bool IsSetCustomModelUnits() => this.CustomModelUnits != null;

        /// <summary>
        /// Gets and sets the property InstructSupported. 
        /// <para>
        /// Specifies if the imported model supports converse.
        /// </para>
        /// </summary>
        public bool? InstructSupported { get; set; }

        /// <summary>
        /// Checks to see if the InstructSupported property is set.
        /// </summary>
        internal bool IsSetInstructSupported() => this.InstructSupported.HasValue;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// Job Amazon Resource Name (ARN) associated with the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1011)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Job name associated with the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property ModelArchitecture. 
        /// <para>
        /// The architecture of the imported model.
        /// </para>
        /// </summary>
        public string ModelArchitecture { get; set; }

        /// <summary>
        /// Checks to see if the ModelArchitecture property is set.
        /// </summary>
        internal bool IsSetModelArchitecture() => this.ModelArchitecture != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with this imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1011)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelDataSource. 
        /// <para>
        /// The data source for this imported model.
        /// </para>
        /// </summary>
        public ModelDataSource ModelDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataSource property is set.
        /// </summary>
        internal bool IsSetModelDataSource() => this.ModelDataSource != null;

        /// <summary>
        /// Gets and sets the property ModelKmsKeyArn. 
        /// <para>
        /// The imported model is encrypted at rest using this key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ModelKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetModelKmsKeyArn() => this.ModelKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;
    }
}
