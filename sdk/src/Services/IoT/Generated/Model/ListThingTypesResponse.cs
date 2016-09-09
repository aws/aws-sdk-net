/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The output for the ListThingTypes operation.
    /// </summary>
    public partial class ListThingTypesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ThingTypeDefinition> _thingTypes = new List<ThingTypeDefinition>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or <b>null</b> if there are no additional results.
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
        /// Gets and sets the property ThingTypes. 
        /// <para>
        /// The thing types.
        /// </para>
        /// </summary>
        public List<ThingTypeDefinition> ThingTypes
        {
            get { return this._thingTypes; }
            set { this._thingTypes = value; }
        }

        // Check to see if ThingTypes property is set
        internal bool IsSetThingTypes()
        {
            return this._thingTypes != null && this._thingTypes.Count > 0; 
        }

    }
}