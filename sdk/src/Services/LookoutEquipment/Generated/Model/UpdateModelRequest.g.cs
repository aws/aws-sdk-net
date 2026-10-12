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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateModel operation. Updates a model in the
    /// account.
    /// </summary>
    public partial class UpdateModelRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property LabelsInputConfiguration.
        /// </summary>
        public LabelsInputConfiguration LabelsInputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LabelsInputConfiguration property is set.
        /// </summary>
        internal bool IsSetLabelsInputConfiguration() => this.LabelsInputConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelDiagnosticsOutputConfiguration. 
        /// <para>
        /// The Amazon S3 location where you want Amazon Lookout for Equipment to save the pointwise
        /// model diagnostics for the model. You must also specify the <c>RoleArn</c> request
        /// parameter.
        /// </para>
        /// </summary>
        public ModelDiagnosticsOutputConfiguration ModelDiagnosticsOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ModelDiagnosticsOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetModelDiagnosticsOutputConfiguration() => this.ModelDiagnosticsOutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the model to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
