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
    /// The details of an Config evaluation for an account ID and region in an aggregator.
    /// Provides the Amazon Web Services resource that was evaluated, the compliance of the
    /// resource, related time stamps, and supplementary information.
    /// </summary>
    public partial class AggregateEvaluationResult
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit account ID of the source account.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Annotation. 
        /// <para>
        /// Supplementary information about how the agrregate evaluation determined the compliance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Annotation { get; set; }

        /// <summary>
        /// Checks to see if the Annotation property is set.
        /// </summary>
        internal bool IsSetAnnotation() => this.Annotation != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The source region from where the data is aggregated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The resource compliance status.
        /// </para>
        ///  
        /// <para>
        /// For the <c>AggregationEvaluationResult</c> data type, Config supports only the <c>COMPLIANT</c>
        /// and <c>NON_COMPLIANT</c>. Config does not support the <c>NOT_APPLICABLE</c> and <c>INSUFFICIENT_DATA</c>
        /// value.
        /// </para>
        /// </summary>
        public ComplianceType ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property ConfigRuleInvokedTime. 
        /// <para>
        /// The time when the Config rule evaluated the Amazon Web Services resource.
        /// </para>
        /// </summary>
        public DateTime? ConfigRuleInvokedTime { get; set; }

        /// <summary>
        /// Checks to see if the ConfigRuleInvokedTime property is set.
        /// </summary>
        internal bool IsSetConfigRuleInvokedTime() => this.ConfigRuleInvokedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationResultIdentifier. 
        /// <para>
        /// Uniquely identifies the evaluation result.
        /// </para>
        /// </summary>
        public EvaluationResultIdentifier EvaluationResultIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationResultIdentifier property is set.
        /// </summary>
        internal bool IsSetEvaluationResultIdentifier() => this.EvaluationResultIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResultRecordedTime. 
        /// <para>
        /// The time when Config recorded the aggregate evaluation result.
        /// </para>
        /// </summary>
        public DateTime? ResultRecordedTime { get; set; }

        /// <summary>
        /// Checks to see if the ResultRecordedTime property is set.
        /// </summary>
        internal bool IsSetResultRecordedTime() => this.ResultRecordedTime.HasValue;
    }
}
