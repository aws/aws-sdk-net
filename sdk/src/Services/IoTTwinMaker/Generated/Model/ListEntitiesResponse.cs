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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is the response object from the ListEntities operation.
    /// </summary>
    public partial class ListEntitiesResponse : AmazonWebServiceResponse
    {
        private List<EntitySummary> _entitySummaries = AWSConfigs.InitializeCollections ? new List<EntitySummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EntitySummaries. 
        /// <para>
        /// A list of objects that contain information about the entities.
        /// </para>
        /// </summary>
        public List<EntitySummary> EntitySummaries
        {
            get { return this._entitySummaries; }
            set { this._entitySummaries = value; }
        }

        // Check to see if EntitySummaries property is set
        internal bool IsSetEntitySummaries()
        {
            return this._entitySummaries != null && (this._entitySummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that specifies the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=17880)]
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