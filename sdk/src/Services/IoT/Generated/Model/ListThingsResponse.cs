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
    /// The output from the ListThings operation.
    /// </summary>
    public partial class ListThingsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<ThingAttribute> _things = AWSConfigs.InitializeCollections ? new List<ThingAttribute>() : null;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// The token to use to get the next set of results. Will not be returned if operation
        /// has returned all results.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property Things. 
        /// <para>
        /// The things.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThingAttribute> Things
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