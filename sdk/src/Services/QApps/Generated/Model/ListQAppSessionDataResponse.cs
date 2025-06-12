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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// This is the response object from the ListQAppSessionData operation.
    /// </summary>
    public partial class ListQAppSessionDataResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private string _sessionArn;
        private List<QAppSessionData> _sessionData = AWSConfigs.InitializeCollections ? new List<QAppSessionData>() : null;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token that indicates the next set of results to retrieve.
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

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Q App data collection session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionArn
        {
            get { return this._sessionArn; }
            set { this._sessionArn = value; }
        }

        // Check to see if SessionArn property is set
        internal bool IsSetSessionArn()
        {
            return this._sessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionData. 
        /// <para>
        /// The collected responses of a Q App session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QAppSessionData> SessionData
        {
            get { return this._sessionData; }
            set { this._sessionData = value; }
        }

        // Check to see if SessionData property is set
        internal bool IsSetSessionData()
        {
            return this._sessionData != null && (this._sessionData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the Q App data collection session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}