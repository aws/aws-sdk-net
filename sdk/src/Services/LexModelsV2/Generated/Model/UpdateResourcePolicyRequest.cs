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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourcePolicy operation.
    /// Replaces the existing resource policy for a bot or bot alias with a new one. If the
    /// policy doesn't exist, Amazon Lex returns an exception.
    /// </summary>
    public partial class UpdateResourcePolicyRequest : AmazonLexModelsV2Request
    {
        private string _expectedRevisionId;
        private string _policy;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. 
        /// <para>
        /// The identifier of the revision of the policy to update. If this revision ID doesn't
        /// match the current revision ID, Amazon Lex throws an exception.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a revision, Amazon Lex overwrites the contents of the policy
        /// with the new values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string ExpectedRevisionId
        {
            get { return this._expectedRevisionId; }
            set { this._expectedRevisionId = value; }
        }

        // Check to see if ExpectedRevisionId property is set
        internal bool IsSetExpectedRevisionId()
        {
            return this._expectedRevisionId != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A resource policy to add to the resource. The policy is a JSON structure that contains
        /// one or more statements that define the policy. The policy must follow the IAM syntax.
        /// For more information about the contents of a JSON policy document, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">
        /// IAM JSON policy reference </a>. 
        /// </para>
        ///  
        /// <para>
        /// If the policy isn't valid, Amazon Lex returns a validation exception.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bot or bot alias that the resource policy is
        /// attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}