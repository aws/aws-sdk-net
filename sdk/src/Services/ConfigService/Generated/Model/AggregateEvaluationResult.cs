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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
        private string _accountId;
        private string _annotation;
        private string _awsRegion;
        private ComplianceType _complianceType;
        private DateTime? _configRuleInvokedTime;
        private EvaluationResultIdentifier _evaluationResultIdentifier;
        private DateTime? _resultRecordedTime;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit account ID of the source account.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Annotation. 
        /// <para>
        /// Supplementary information about how the agrregate evaluation determined the compliance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Annotation
        {
            get { return this._annotation; }
            set { this._annotation = value; }
        }

        // Check to see if Annotation property is set
        internal bool IsSetAnnotation()
        {
            return this._annotation != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The source region from where the data is aggregated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

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
        public ComplianceType ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleInvokedTime. 
        /// <para>
        /// The time when the Config rule evaluated the Amazon Web Services resource.
        /// </para>
        /// </summary>
        public DateTime? ConfigRuleInvokedTime
        {
            get { return this._configRuleInvokedTime; }
            set { this._configRuleInvokedTime = value; }
        }

        // Check to see if ConfigRuleInvokedTime property is set
        internal bool IsSetConfigRuleInvokedTime()
        {
            return this._configRuleInvokedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationResultIdentifier. 
        /// <para>
        /// Uniquely identifies the evaluation result.
        /// </para>
        /// </summary>
        public EvaluationResultIdentifier EvaluationResultIdentifier
        {
            get { return this._evaluationResultIdentifier; }
            set { this._evaluationResultIdentifier = value; }
        }

        // Check to see if EvaluationResultIdentifier property is set
        internal bool IsSetEvaluationResultIdentifier()
        {
            return this._evaluationResultIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResultRecordedTime. 
        /// <para>
        /// The time when Config recorded the aggregate evaluation result.
        /// </para>
        /// </summary>
        public DateTime? ResultRecordedTime
        {
            get { return this._resultRecordedTime; }
            set { this._resultRecordedTime = value; }
        }

        // Check to see if ResultRecordedTime property is set
        internal bool IsSetResultRecordedTime()
        {
            return this._resultRecordedTime.HasValue; 
        }

    }
}