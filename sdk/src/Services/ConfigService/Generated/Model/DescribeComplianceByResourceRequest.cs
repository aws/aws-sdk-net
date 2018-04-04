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
    /// Container for the parameters to the DescribeComplianceByResource operation.
    /// Indicates whether the specified AWS resources are compliant. If a resource is noncompliant,
    /// this action returns the number of AWS Config rules that the resource does not comply
    /// with.
    /// 
    ///  
    /// <para>
    /// A resource is compliant if it complies with all the AWS Config rules that evaluate
    /// it. It is noncompliant if it does not comply with one or more of these rules.
    /// </para>
    ///  
    /// <para>
    /// If AWS Config has no current evaluation results for the resource, it returns <code>INSUFFICIENT_DATA</code>.
    /// This result might indicate one of the following conditions about the rules that evaluate
    /// the resource:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// AWS Config has never invoked an evaluation for the rule. To check whether it has,
    /// use the <code>DescribeConfigRuleEvaluationStatus</code> action to get the <code>LastSuccessfulInvocationTime</code>
    /// and <code>LastFailedInvocationTime</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The rule's AWS Lambda function is failing to send evaluation results to AWS Config.
    /// Verify that the role that you assigned to your configuration recorder includes the
    /// <code>config:PutEvaluations</code> permission. If the rule is a custom rule, verify
    /// that the AWS Lambda execution role includes the <code>config:PutEvaluations</code>
    /// permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The rule's AWS Lambda function has returned <code>NOT_APPLICABLE</code> for all evaluation
    /// results. This can occur if the resources were deleted or removed from the rule's scope.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeComplianceByResourceRequest : AmazonConfigServiceRequest
    {
        private List<string> _complianceTypes = new List<string>();
        private int? _limit;
        private string _nextToken;
        private string _resourceId;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ComplianceTypes. 
        /// <para>
        /// Filters the results by compliance.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are <code>COMPLIANT</code> and <code>NON_COMPLIANT</code>.
        /// </para>
        /// </summary>
        public List<string> ComplianceTypes
        {
            get { return this._complianceTypes; }
            set { this._complianceTypes = value; }
        }

        // Check to see if ComplianceTypes property is set
        internal bool IsSetComplianceTypes()
        {
            return this._complianceTypes != null && this._complianceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of evaluation results returned on each page. The default is 10.
        /// You cannot specify a number greater than 100. If you specify 0, AWS Config uses the
        /// default.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned on a previous page that you use to get
        /// the next page of results in a paginated response.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the AWS resource for which you want compliance information. You can specify
        /// only one resource ID. If you specify a resource ID, you must also specify a type for
        /// <code>ResourceType</code>.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The types of AWS resources for which you want compliance information (for example,
        /// <code>AWS::EC2::Instance</code>). For this action, you can specify that the resource
        /// type is an AWS account by specifying <code>AWS::::Account</code>.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}