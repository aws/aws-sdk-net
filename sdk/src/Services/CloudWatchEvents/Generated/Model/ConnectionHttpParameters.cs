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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
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
namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Contains additional parameters for the connection.
    /// </summary>
    public partial class ConnectionHttpParameters
    {
        private List<ConnectionBodyParameter> _bodyParameters = AWSConfigs.InitializeCollections ? new List<ConnectionBodyParameter>() : null;
        private List<ConnectionHeaderParameter> _headerParameters = AWSConfigs.InitializeCollections ? new List<ConnectionHeaderParameter>() : null;
        private List<ConnectionQueryStringParameter> _queryStringParameters = AWSConfigs.InitializeCollections ? new List<ConnectionQueryStringParameter>() : null;

        /// <summary>
        /// Gets and sets the property BodyParameters. 
        /// <para>
        /// Contains additional body string parameters for the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConnectionBodyParameter> BodyParameters
        {
            get { return this._bodyParameters; }
            set { this._bodyParameters = value; }
        }

        // Check to see if BodyParameters property is set
        internal bool IsSetBodyParameters()
        {
            return this._bodyParameters != null && (this._bodyParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HeaderParameters. 
        /// <para>
        /// Contains additional header parameters for the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConnectionHeaderParameter> HeaderParameters
        {
            get { return this._headerParameters; }
            set { this._headerParameters = value; }
        }

        // Check to see if HeaderParameters property is set
        internal bool IsSetHeaderParameters()
        {
            return this._headerParameters != null && (this._headerParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryStringParameters. 
        /// <para>
        /// Contains additional query string parameters for the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ConnectionQueryStringParameter> QueryStringParameters
        {
            get { return this._queryStringParameters; }
            set { this._queryStringParameters = value; }
        }

        // Check to see if QueryStringParameters property is set
        internal bool IsSetQueryStringParameters()
        {
            return this._queryStringParameters != null && (this._queryStringParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}