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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
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
namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// The data that is output as a result of the assistant association.
    /// </summary>
    public partial class AssistantAssociationOutputData
    {
        private KnowledgeBaseAssociationData _knowledgeBaseAssociation;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseAssociation. 
        /// <para>
        /// The knowledge base where output data is sent.
        /// </para>
        /// </summary>
        public KnowledgeBaseAssociationData KnowledgeBaseAssociation
        {
            get { return this._knowledgeBaseAssociation; }
            set { this._knowledgeBaseAssociation = value; }
        }

        // Check to see if KnowledgeBaseAssociation property is set
        internal bool IsSetKnowledgeBaseAssociation()
        {
            return this._knowledgeBaseAssociation != null;
        }

    }
}