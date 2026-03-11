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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
    /// Container for the parameters to the Retrieve operation.
    /// Retrieves content from knowledge sources based on a query.
    /// </summary>
    public partial class RetrieveRequest : AmazonQConnectRequest
    {
        private string _assistantId;
        private RetrievalConfiguration _retrievalConfiguration;
        private string _retrievalQuery;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant for content retrieval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantId
        {
            get { return this._assistantId; }
            set { this._assistantId = value; }
        }

        // Check to see if AssistantId property is set
        internal bool IsSetAssistantId()
        {
            return this._assistantId != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalConfiguration. 
        /// <para>
        /// The configuration for the content retrieval operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetrievalConfiguration RetrievalConfiguration
        {
            get { return this._retrievalConfiguration; }
            set { this._retrievalConfiguration = value; }
        }

        // Check to see if RetrievalConfiguration property is set
        internal bool IsSetRetrievalConfiguration()
        {
            return this._retrievalConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalQuery. 
        /// <para>
        /// The query for content retrieval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
        public string RetrievalQuery
        {
            get { return this._retrievalQuery; }
            set { this._retrievalQuery = value; }
        }

        // Check to see if RetrievalQuery property is set
        internal bool IsSetRetrievalQuery()
        {
            return this._retrievalQuery != null;
        }

    }
}