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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about the user context for an Amazon Kendra index.
    /// 
    ///  
    /// <para>
    /// User context filtering is a kind of personalized search with the benefit of controlling
    /// access to documents. For example, not all teams that search the company portal for
    /// information should access top-secret company documents, nor are these documents relevant
    /// to all users. Only specific users or groups of teams given access to top-secret documents
    /// should see these documents in their search results.
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
    /// User ID, the groups the user belongs to, and any data sources the groups can access.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you provide both, an exception is thrown.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you're using an Amazon Kendra Gen AI Enterprise Edition index, you can use <c>UserId</c>,
    /// <c>Groups</c>, and <c>DataSourceGroups</c> to filter content. If you set the <c>UserId</c>
    /// to a particular user ID, it also includes all public documents.
    /// </para>
    ///  
    /// <para>
    /// Amazon Kendra Gen AI Enterprise Edition indices don't support token based document
    /// filtering. If you're using an Amazon Kendra Gen AI Enterprise Edition index, Amazon
    /// Kendra returns a <c>ValidationException</c> error if the <c>Token</c> field has a
    /// non-null value.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UserContext
    {
        private List<DataSourceGroup> _dataSourceGroups = AWSConfigs.InitializeCollections ? new List<DataSourceGroup>() : null;
        private List<string> _groups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _token;
        private string _userId;

        /// <summary>
        /// Gets and sets the property DataSourceGroups. 
        /// <para>
        /// The list of data source groups you want to filter search results based on groups'
        /// access to documents in that data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._dataSourceGroups != null && (this._dataSourceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The list of groups you want to filter search results based on the groups' access to
        /// documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
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