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
    /// Information about the imported model.
    /// </summary>
    public partial class ImportedModelSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        /// The Amazon Resource Name (ARN) of the imported model.
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
        /// Name of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;
    }
}
