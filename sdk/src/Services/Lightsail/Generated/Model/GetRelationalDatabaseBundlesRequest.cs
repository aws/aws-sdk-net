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
    /// Container for the parameters to the GetRelationalDatabaseBundles operation.
    /// Returns the list of bundles that are available in Amazon Lightsail. A bundle describes
    /// the performance specifications for a database.
    /// 
    ///  
    /// <para>
    /// You can use a bundle ID to create a new database with explicit performance specifications.
    /// </para>
    /// </summary>
    public partial class GetRelationalDatabaseBundlesRequest : AmazonLightsailRequest
    {
        private bool? _includeInactive;
        private string _pageToken;

        /// <summary>
        /// Gets and sets the property IncludeInactive. 
        /// <para>
        /// A Boolean value that indicates whether to include inactive (unavailable) bundles in
        /// the response of your request.
        /// </para>
        /// </summary>
        public bool? IncludeInactive
        {
            get { return this._includeInactive; }
            set { this._includeInactive = value; }
        }

        // Check to see if IncludeInactive property is set
        internal bool IsSetIncludeInactive()
        {
            return this._includeInactive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <c>GetRelationalDatabaseBundles</c> request.
        /// If your results are paginated, the response will return a next page token that you
        /// can specify as the page token in a subsequent request.
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

    }
}