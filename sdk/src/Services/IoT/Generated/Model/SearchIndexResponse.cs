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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the SearchIndex operation.
    /// </summary>
    public partial class SearchIndexResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ThingGroupDocument> _thingGroups = AWSConfigs.InitializeCollections ? new List<ThingGroupDocument>() : null;
        private List<ThingDocument> _things = AWSConfigs.InitializeCollections ? new List<ThingDocument>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to get the next set of results, or <c>null</c> if there are no additional
        /// results.
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
        /// Gets and sets the property ThingGroups. 
        /// <para>
        /// The thing groups that match the search query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThingGroupDocument> ThingGroups
        {
            get { return this._thingGroups; }
            set { this._thingGroups = value; }
        }

        // Check to see if ThingGroups property is set
        internal bool IsSetThingGroups()
        {
            return this._thingGroups != null && (this._thingGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Things. 
        /// <para>
        /// The things that match the search query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThingDocument> Things
        {
            get { return this._things; }
            set { this._things = value; }
        }

        // Check to see if Things property is set
        internal bool IsSetThings()
        {
            return this._things != null && (this._things.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}