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
    /// Container for the parameters to the CheckNoNewAccess operation.
    /// Checks whether new access is allowed for an updated policy when compared to the existing
    /// policy.
    /// 
    ///  
    /// <para>
    /// You can find examples for reference policies and learn how to set up and run a custom
    /// policy check for new access in the <a href="https://github.com/aws-samples/iam-access-analyzer-custom-policy-check-samples">IAM
    /// Access Analyzer custom policy checks samples</a> repository on GitHub. The reference
    /// policies in this repository are meant to be passed to the <c>existingPolicyDocument</c>
    /// request parameter.
    /// </para>
    /// </summary>
    public partial class CheckNoNewAccessRequest : AmazonAccessAnalyzerRequest
    {
        private string _existingPolicyDocument;
        private string _newPolicyDocument;
        private AccessCheckPolicyType _policyType;

        /// <summary>
        /// Gets and sets the property ExistingPolicyDocument. 
        /// <para>
        /// The JSON policy document to use as the content for the existing policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string ExistingPolicyDocument
        {
            get { return this._existingPolicyDocument; }
            set { this._existingPolicyDocument = value; }
        }

        // Check to see if ExistingPolicyDocument property is set
        internal bool IsSetExistingPolicyDocument()
        {
            return this._existingPolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property NewPolicyDocument. 
        /// <para>
        /// The JSON policy document to use as the content for the updated policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string NewPolicyDocument
        {
            get { return this._newPolicyDocument; }
            set { this._newPolicyDocument = value; }
        }

        // Check to see if NewPolicyDocument property is set
        internal bool IsSetNewPolicyDocument()
        {
            return this._newPolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy to compare. Identity policies grant permissions to IAM principals.
        /// Identity policies include managed and inline policies for IAM roles, users, and groups.
        /// </para>
        ///  
        /// <para>
        /// Resource policies grant permissions on Amazon Web Services resources. Resource policies
        /// include trust policies for IAM roles and bucket policies for Amazon S3 buckets. You
        /// can provide a generic input such as identity policy or resource policy or a specific
        /// input such as managed policy or Amazon S3 bucket policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessCheckPolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}