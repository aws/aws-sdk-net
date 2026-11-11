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
    /// Identifies an Amazon Web Services resource and indicates whether it complies with
    /// the Config rule that it was evaluated against.
    /// </summary>
    public partial class Evaluation
    {
        /// <summary>
        /// Gets and sets the property Annotation. 
        /// <para>
        /// Supplementary information about how the evaluation determined the compliance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Annotation { get; set; }

        /// <summary>
        /// Checks to see if the Annotation property is set.
        /// </summary>
        internal bool IsSetAnnotation() => this.Annotation != null;

        /// <summary>
        /// Gets and sets the property ComplianceResourceId. 
        /// <para>
        /// The ID of the Amazon Web Services resource that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 768)]
        public string ComplianceResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceResourceId property is set.
        /// </summary>
        internal bool IsSetComplianceResourceId() => this.ComplianceResourceId != null;

        /// <summary>
        /// Gets and sets the property ComplianceResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ComplianceResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceResourceType property is set.
        /// </summary>
        internal bool IsSetComplianceResourceType() => this.ComplianceResourceType != null;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// Indicates whether the Amazon Web Services resource complies with the Config rule that
        /// it was evaluated against.
        /// </para>
        ///  
        /// <para>
        /// For the <c>Evaluation</c> data type, Config supports only the <c>COMPLIANT</c>, <c>NON_COMPLIANT</c>,
        /// and <c>NOT_APPLICABLE</c> values. Config does not support the <c>INSUFFICIENT_DATA</c>
        /// value for this data type.
        /// </para>
        ///  
        /// <para>
        /// Similarly, Config does not accept <c>INSUFFICIENT_DATA</c> as the value for <c>ComplianceType</c>
        /// from a <c>PutEvaluations</c> request. For example, an Lambda function for a custom
        /// Config rule cannot pass an <c>INSUFFICIENT_DATA</c> value to Config.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComplianceType ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property OrderingTimestamp. 
        /// <para>
        /// The time of the event in Config that triggered the evaluation. For event-based evaluations,
        /// the time indicates when Config created the configuration item that triggered the evaluation.
        /// For periodic evaluations, the time indicates when Config triggered the evaluation
        /// at the frequency that you specified (for example, every 24 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? OrderingTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the OrderingTimestamp property is set.
        /// </summary>
        internal bool IsSetOrderingTimestamp() => this.OrderingTimestamp.HasValue;
    }
}
