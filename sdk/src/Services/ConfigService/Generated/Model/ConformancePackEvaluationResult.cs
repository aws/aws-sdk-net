/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The details of a conformance pack evaluation. Provides AWS Config rule and AWS resource
    /// type that was evaluated, the compliance of the conformance pack, related time stamps,
    /// and supplementary information.
    /// </summary>
    public partial class ConformancePackEvaluationResult
    {
        private string _annotation;
        private ConformancePackComplianceType _complianceType;
        private DateTime? _configRuleInvokedTime;
        private EvaluationResultIdentifier _evaluationResultIdentifier;
        private DateTime? _resultRecordedTime;

        /// <summary>
        /// Gets and sets the property Annotation. 
        /// <para>
        /// Supplementary information about how the evaluation determined the compliance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The compliance type. The allowed values are <code>COMPLIANT</code> and <code>NON_COMPLIANT</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConformancePackComplianceType ComplianceType
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
        /// The time when AWS Config rule evaluated AWS resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ConfigRuleInvokedTime
        {
            get { return this._configRuleInvokedTime.GetValueOrDefault(); }
            set { this._configRuleInvokedTime = value; }
        }

        // Check to see if ConfigRuleInvokedTime property is set
        internal bool IsSetConfigRuleInvokedTime()
        {
            return this._configRuleInvokedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationResultIdentifier.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The time when AWS Config recorded the evaluation result. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ResultRecordedTime
        {
            get { return this._resultRecordedTime.GetValueOrDefault(); }
            set { this._resultRecordedTime = value; }
        }

        // Check to see if ResultRecordedTime property is set
        internal bool IsSetResultRecordedTime()
        {
            return this._resultRecordedTime.HasValue; 
        }

    }
}