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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the ListStudioSessionMappings operation.
    /// </summary>
    public partial class ListStudioSessionMappingsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<SessionMappingSummary> _sessionMappings = new List<SessionMappingSummary>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property SessionMappings. 
        /// <para>
        /// A list of session mapping summary objects. Each object includes session mapping details
        /// such as creation time, identity type (user or group), and Studio ID.
        /// </para>
        /// </summary>
        public List<SessionMappingSummary> SessionMappings
        {
            get { return this._sessionMappings; }
            set { this._sessionMappings = value; }
        }

        // Check to see if SessionMappings property is set
        internal bool IsSetSessionMappings()
        {
            return this._sessionMappings != null && this._sessionMappings.Count > 0; 
        }

    }
}