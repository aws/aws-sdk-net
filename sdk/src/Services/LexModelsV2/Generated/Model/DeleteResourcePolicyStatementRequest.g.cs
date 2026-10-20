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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourcePolicyStatement operation. Deletes
    /// a policy statement from a resource policy. If you delete the last statement from a
    /// policy, the policy is deleted. If you specify a statement ID that doesn't exist in
    /// the policy, or if the bot or bot alias doesn't have a policy attached, Amazon Lex
    /// returns an exception. <para> You need to add the <c>DeleteResourcePolicy</c> or <c>UpdateResourcePolicy</c>
    /// action to the bot role in order to call the API. </para>
    /// </summary>
    public partial class DeleteResourcePolicyStatementRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. 
        /// <para>
        /// The identifier of the revision of the policy to delete the statement from. If this
        /// revision ID doesn't match the current revision ID, Amazon Lex throws an exception.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a revision, Amazon Lex removes the current contents of the statement.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string ExpectedRevisionId { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedRevisionId property is set.
        /// </summary>
        internal bool IsSetExpectedRevisionId() => this.ExpectedRevisionId != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bot or bot alias that the resource policy is
        /// attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// The name of the statement (SID) to delete from the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string StatementId { get; set; }

        /// <summary>
        /// Checks to see if the StatementId property is set.
        /// </summary>
        internal bool IsSetStatementId() => this.StatementId != null;
    }
}
