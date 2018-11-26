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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Result structure for an Amplify App list request.
    /// </summary>
    public partial class ListAppsResponse : AmazonWebServiceResponse
    {
        private List<App> _apps = new List<App>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Apps. 
        /// <para>
        ///  List of Amplify Apps. 
        /// </para>
        /// </summary>
        public List<App> Apps
        {
            get { return this._apps; }
            set { this._apps = value; }
        }

        // Check to see if Apps property is set
        internal bool IsSetApps()
        {
            return this._apps != null && this._apps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Pagination token. Set to null to start listing Apps from start. If non-null pagination
        /// token is returned in a result, then pass its value in here to list more projects.
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