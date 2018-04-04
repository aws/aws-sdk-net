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
    /// Identifies an AWS resource and indicates whether it complies with the AWS Config rule
    /// that it was evaluated against.
    /// </summary>
    public partial class Evaluation
    {
        private string _annotation;
        private string _complianceResourceId;
        private string _complianceResourceType;
        private ComplianceType _complianceType;
        private DateTime? _orderingTimestamp;

        /// <summary>
        /// Gets and sets the property Annotation. 
        /// <para>
        /// Supplementary information about how the evaluation determined the compliance.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ComplianceResourceId. 
        /// <para>
        /// The ID of the AWS resource that was evaluated.
        /// </para>
        /// </summary>
        public string ComplianceResourceId
        {
            get { return this._complianceResourceId; }
            set { this._complianceResourceId = value; }
        }

        // Check to see if ComplianceResourceId property is set
        internal bool IsSetComplianceResourceId()
        {
            return this._complianceResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceResourceType. 
        /// <para>
        /// The type of AWS resource that was evaluated.
        /// </para>
        /// </summary>
        public string ComplianceResourceType
        {
            get { return this._complianceResourceType; }
            set { this._complianceResourceType = value; }
        }

        // Check to see if ComplianceResourceType property is set
        internal bool IsSetComplianceResourceType()
        {
            return this._complianceResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// Indicates whether the AWS resource complies with the AWS Config rule that it was evaluated
        /// against.
        /// </para>
        ///  
        /// <para>
        /// For the <code>Evaluation</code> data type, AWS Config supports only the <code>COMPLIANT</code>,
        /// <code>NON_COMPLIANT</code>, and <code>NOT_APPLICABLE</code> values. AWS Config does
        /// not support the <code>INSUFFICIENT_DATA</code> value for this data type.
        /// </para>
        ///  
        /// <para>
        /// Similarly, AWS Config does not accept <code>INSUFFICIENT_DATA</code> as the value
        /// for <code>ComplianceType</code> from a <code>PutEvaluations</code> request. For example,
        /// an AWS Lambda function for a custom AWS Config rule cannot pass an <code>INSUFFICIENT_DATA</code>
        /// value to AWS Config.
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
        /// Gets and sets the property OrderingTimestamp. 
        /// <para>
        /// The time of the event in AWS Config that triggered the evaluation. For event-based
        /// evaluations, the time indicates when AWS Config created the configuration item that
        /// triggered the evaluation. For periodic evaluations, the time indicates when AWS Config
        /// triggered the evaluation at the frequency that you specified (for example, every 24
        /// hours).
        /// </para>
        /// </summary>
        public DateTime OrderingTimestamp
        {
            get { return this._orderingTimestamp.GetValueOrDefault(); }
            set { this._orderingTimestamp = value; }
        }

        // Check to see if OrderingTimestamp property is set
        internal bool IsSetOrderingTimestamp()
        {
            return this._orderingTimestamp.HasValue; 
        }

    }
}