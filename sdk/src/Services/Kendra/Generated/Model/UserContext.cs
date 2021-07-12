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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about the user context for a Amazon Kendra index.
    /// 
    ///  
    /// <para>
    /// This is used for filtering search results for different users based on their access
    /// to documents.
    /// </para>
    ///  
    /// <para>
    /// You provide one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// User token
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// User ID, the groups the user belongs to, and the data sources the groups can access
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you provide both, an exception is thrown.
    /// </para>
    /// </summary>
    public partial class UserContext
    {
        private List<DataSourceGroup> _dataSourceGroups = new List<DataSourceGroup>();
        private List<string> _groups = new List<string>();
        private string _token;
        private string _userId;

        /// <summary>
        /// Gets and sets the property DataSourceGroups. 
        /// <para>
        /// The list of data source groups you want to filter search results based on groups'
        /// access to documents in that data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public List<DataSourceGroup> DataSourceGroups
        {
            get { return this._dataSourceGroups; }
            set { this._dataSourceGroups = value; }
        }

        // Check to see if DataSourceGroups property is set
        internal bool IsSetDataSourceGroups()
        {
            return this._dataSourceGroups != null && this._dataSourceGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The list of groups you want to filter search results based on the groups' access to
        /// documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public List<string> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The user context token for filtering search results for a user. It must be a JWT or
        /// a JSON token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user you want to filter search results based on their access
        /// to documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}