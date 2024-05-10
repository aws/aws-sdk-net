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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the ValidatePolicy operation.
    /// Requests the validation of a policy and returns a list of findings. The findings help
    /// you identify issues and provide actionable recommendations to resolve the issue and
    /// enable you to author functional policies that meet security best practices.
    /// </summary>
    public partial class ValidatePolicyRequest : AmazonAccessAnalyzerRequest
    {
        private Locale _locale;
        private int? _maxResults;
        private string _nextToken;
        private string _policyDocument;
        private PolicyType _policyType;
        private ValidatePolicyResourceType _validatePolicyResourceType;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale to use for localizing the findings.
        /// </para>
        /// </summary>
        public Locale Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used for pagination of results returned.
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
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON policy document to use as the content for the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy to validate. Identity policies grant permissions to IAM principals.
        /// Identity policies include managed and inline policies for IAM roles, users, and groups.
        /// </para>
        ///  
        /// <para>
        /// Resource policies grant permissions on Amazon Web Services resources. Resource policies
        /// include trust policies for IAM roles and bucket policies for Amazon S3 buckets. You
        /// can provide a generic input such as identity policy or resource policy or a specific
        /// input such as managed policy or Amazon S3 bucket policy. 
        /// </para>
        ///  
        /// <para>
        /// Service control policies (SCPs) are a type of organization policy attached to an Amazon
        /// Web Services organization, organizational unit (OU), or an account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property ValidatePolicyResourceType. 
        /// <para>
        /// The type of resource to attach to your resource policy. Specify a value for the policy
        /// validation resource type only if the policy type is <c>RESOURCE_POLICY</c>. For example,
        /// to validate a resource policy to attach to an Amazon S3 bucket, you can choose <c>AWS::S3::Bucket</c>
        /// for the policy validation resource type.
        /// </para>
        ///  
        /// <para>
        /// For resource types not supported as valid values, IAM Access Analyzer runs policy
        /// checks that apply to all resource policies. For example, to validate a resource policy
        /// to attach to a KMS key, do not specify a value for the policy validation resource
        /// type and IAM Access Analyzer will run policy checks that apply to all resource policies.
        /// </para>
        /// </summary>
        public ValidatePolicyResourceType ValidatePolicyResourceType
        {
            get { return this._validatePolicyResourceType; }
            set { this._validatePolicyResourceType = value; }
        }

        // Check to see if ValidatePolicyResourceType property is set
        internal bool IsSetValidatePolicyResourceType()
        {
            return this._validatePolicyResourceType != null;
        }

    }
}