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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteContentAssociation operation. Deletes the
    /// content association. <para> For more information about content associations--what
    /// they are and when they are used--see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
    /// Amazon Q in Connect with step-by-step guides</a> in the <i>Connect Customer Administrator
    /// Guide</i>. </para>
    /// </summary>
    public partial class DeleteContentAssociationRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ContentAssociationId. 
        /// <para>
        /// The identifier of the content association. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ContentAssociationId property is set.
        /// </summary>
        internal bool IsSetContentAssociationId() => this.ContentAssociationId != null;

        /// <summary>
        /// Gets and sets the property ContentId. 
        /// <para>
        /// The identifier of the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentId { get; set; }

        /// <summary>
        /// Checks to see if the ContentId property is set.
        /// </summary>
        internal bool IsSetContentId() => this.ContentId != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;
    }
}
