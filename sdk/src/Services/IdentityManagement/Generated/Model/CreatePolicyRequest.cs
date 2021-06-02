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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePolicy operation.
    /// Creates a new managed policy for your AWS account.
    /// 
    ///  
    /// <para>
    /// This operation creates a policy version with a version identifier of <code>v1</code>
    /// and sets v1 as the policy's default version. For more information about policy versions,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
    /// for managed policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// As a best practice, you can validate your IAM policies. To learn more, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_policy-validator.html">Validating
    /// IAM policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policies in general, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// policies and inline policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreatePolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _description;
        private string _path;
        private string _policyDocument;
        private string _policyName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A friendly description of the policy.
        /// </para>
        ///  
        /// <para>
        /// Typically used to store information about the permissions defined in the policy. For
        /// example, "Grants access to production DynamoDB tables."
        /// </para>
        ///  
        /// <para>
        /// The policy description is immutable. After a value is assigned, it cannot be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path for the policy.
        /// </para>
        ///  
        /// <para>
        /// For more information about paths, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/).
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of either a forward slash (/) by itself
        /// or a string that must begin and end with forward slashes. In addition, it can contain
        /// any ASCII character from the ! (<code>\u0021</code>) through the DEL character (<code>\u007F</code>),
        /// including most punctuation characters, digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON policy document that you want to use as the content for the new policy.
        /// </para>
        ///  
        /// <para>
        /// You must provide policies in JSON format in IAM. However, for AWS CloudFormation templates
        /// formatted in YAML, you can provide the policy in JSON or YAML format. AWS CloudFormation
        /// always converts a YAML policy to JSON format before submitting it to IAM.
        /// </para>
        ///  
        /// <para>
        /// To learn more about JSON policy grammar, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_grammar.html">Grammar
        /// of the IAM JSON policy language</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<code>\u0020</code>)
        /// through the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <code>\u00FF</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>),
        /// and carriage return (<code>\u000D</code>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=131072)]
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
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The friendly name of the policy.
        /// </para>
        ///  
        /// <para>
        /// IAM user, group, role, and policy names must be unique within the account. Names are
        /// not distinguished by case. For example, you cannot create resources named both "MyResource"
        /// and "myresource".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that you want to attach to the new IAM customer managed policy. Each
        /// tag consists of a key name and an associated value. For more information about tagging,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}