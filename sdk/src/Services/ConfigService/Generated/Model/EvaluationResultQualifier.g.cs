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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Identifies an Config rule that evaluated an Amazon Web Services resource, and provides
    /// the type and ID of the resource that the rule evaluated.
    /// </summary>
    public partial class EvaluationResultQualifier
    {
        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the Config rule that was used in the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigRuleName property is set.
        /// </summary>
        internal bool IsSetConfigRuleName() => this.ConfigRuleName != null;

        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// The mode of an evaluation. The valid values are Detective or Proactive.
        /// </para>
        /// </summary>
        public EvaluationMode EvaluationMode { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationMode property is set.
        /// </summary>
        internal bool IsSetEvaluationMode() => this.EvaluationMode != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the evaluated Amazon Web Services resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 768)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
