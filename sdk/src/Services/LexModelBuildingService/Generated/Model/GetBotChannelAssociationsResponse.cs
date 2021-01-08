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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// This is the response object from the GetBotChannelAssociations operation.
    /// </summary>
    public partial class GetBotChannelAssociationsResponse : AmazonWebServiceResponse
    {
        private List<BotChannelAssociation> _botChannelAssociations = new List<BotChannelAssociation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BotChannelAssociations. 
        /// <para>
        /// An array of objects, one for each association, that provides information about the
        /// Amazon Lex bot and its association with the channel. 
        /// </para>
        /// </summary>
        public List<BotChannelAssociation> BotChannelAssociations
        {
            get { return this._botChannelAssociations; }
            set { this._botChannelAssociations = value; }
        }

        // Check to see if BotChannelAssociations property is set
        internal bool IsSetBotChannelAssociations()
        {
            return this._botChannelAssociations != null && this._botChannelAssociations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that fetches the next page of associations. If the response to
        /// this call is truncated, Amazon Lex returns a pagination token in the response. To
        /// fetch the next page of associations, specify the pagination token in the next request.
        /// 
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

    }
}