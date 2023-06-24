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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the ListPoolOriginationIdentities operation.
    /// </summary>
    public partial class ListPoolOriginationIdentitiesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<OriginationIdentityMetadata> _originationIdentities = new List<OriginationIdentityMetadata>();
        private string _poolArn;
        private string _poolId;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results. If this field is empty
        /// then there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property OriginationIdentities. 
        /// <para>
        /// An array of any OriginationIdentityMetadata objects.
        /// </para>
        /// </summary>
        public List<OriginationIdentityMetadata> OriginationIdentities
        {
            get { return this._originationIdentities; }
            set { this._originationIdentities = value; }
        }

        // Check to see if OriginationIdentities property is set
        internal bool IsSetOriginationIdentities()
        {
            return this._originationIdentities != null && this._originationIdentities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PoolArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the pool.
        /// </para>
        /// </summary>
        public string PoolArn
        {
            get { return this._poolArn; }
            set { this._poolArn = value; }
        }

        // Check to see if PoolArn property is set
        internal bool IsSetPoolArn()
        {
            return this._poolArn != null;
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The unique PoolId of the pool.
        /// </para>
        /// </summary>
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

    }
}