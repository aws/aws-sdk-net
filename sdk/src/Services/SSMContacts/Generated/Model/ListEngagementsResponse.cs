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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// This is the response object from the ListEngagements operation.
    /// </summary>
    public partial class ListEngagementsResponse : AmazonWebServiceResponse
    {
        private List<Engagement> _engagements = AWSConfigs.InitializeCollections ? new List<Engagement>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Engagements. 
        /// <para>
        /// A list of each engagement that occurred during the specified time range of an incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Engagement> Engagements
        {
            get { return this._engagements; }
            set { this._engagements = value; }
        }

        // Check to see if Engagements property is set
        internal bool IsSetEngagements()
        {
            return this._engagements != null && (this._engagements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to continue to the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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