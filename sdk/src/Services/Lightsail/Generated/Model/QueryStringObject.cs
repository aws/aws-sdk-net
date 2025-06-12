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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the query string parameters that an Amazon Lightsail content delivery network
    /// (CDN) distribution to bases caching on.
    /// 
    ///  
    /// <para>
    /// For the query strings that you specify, your distribution caches separate versions
    /// of the specified content based on the query string values in viewer requests.
    /// </para>
    /// </summary>
    public partial class QueryStringObject
    {
        private bool? _option;
        private List<string> _queryStringsAllowList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Option. 
        /// <para>
        /// Indicates whether the distribution forwards and caches based on query strings.
        /// </para>
        /// </summary>
        public bool? Option
        {
            get { return this._option; }
            set { this._option = value; }
        }

        // Check to see if Option property is set
        internal bool IsSetOption()
        {
            return this._option.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryStringsAllowList. 
        /// <para>
        /// The specific query strings that the distribution forwards to the origin.
        /// </para>
        ///  
        /// <para>
        /// Your distribution will cache content based on the specified query strings.
        /// </para>
        ///  
        /// <para>
        /// If the <c>option</c> parameter is true, then your distribution forwards all query
        /// strings, regardless of what you specify using the <c>queryStringsAllowList</c> parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> QueryStringsAllowList
        {
            get { return this._queryStringsAllowList; }
            set { this._queryStringsAllowList = value; }
        }

        // Check to see if QueryStringsAllowList property is set
        internal bool IsSetQueryStringsAllowList()
        {
            return this._queryStringsAllowList != null && (this._queryStringsAllowList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}