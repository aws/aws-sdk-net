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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// This is the response object from the ListAttachmentRoutingPolicyAssociations operation.
    /// </summary>
    public partial class ListAttachmentRoutingPolicyAssociationsResponse : AmazonWebServiceResponse
    {
        private List<AttachmentRoutingPolicyAssociationSummary> _attachmentRoutingPolicyAssociations = AWSConfigs.InitializeCollections ? new List<AttachmentRoutingPolicyAssociationSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AttachmentRoutingPolicyAssociations. 
        /// <para>
        /// The list of attachment routing policy associations.
        /// </para>
        /// </summary>
        public List<AttachmentRoutingPolicyAssociationSummary> AttachmentRoutingPolicyAssociations
        {
            get { return this._attachmentRoutingPolicyAssociations; }
            set { this._attachmentRoutingPolicyAssociations = value; }
        }

        // Check to see if AttachmentRoutingPolicyAssociations property is set
        internal bool IsSetAttachmentRoutingPolicyAssociations()
        {
            return this._attachmentRoutingPolicyAssociations != null && (this._attachmentRoutingPolicyAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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

    }
}