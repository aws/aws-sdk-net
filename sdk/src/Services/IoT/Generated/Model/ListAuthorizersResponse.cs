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
    /// This is the response object from the ListAuthorizers operation.
    /// </summary>
    public partial class ListAuthorizersResponse : AmazonWebServiceResponse
    {
        private List<AuthorizerSummary> _authorizers = new List<AuthorizerSummary>();
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property Authorizers. 
        /// <para>
        /// The authorizers.
        /// </para>
        /// </summary>
        public List<AuthorizerSummary> Authorizers
        {
            get { return this._authorizers; }
            set { this._authorizers = value; }
        }

        // Check to see if Authorizers property is set
        internal bool IsSetAuthorizers()
        {
            return this._authorizers != null && this._authorizers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// A marker used to get the next set of results.
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

    }
}