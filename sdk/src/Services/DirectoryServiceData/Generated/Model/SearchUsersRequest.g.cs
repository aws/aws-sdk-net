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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// Container for the parameters to the SearchUsers operation. Searches the specified
    /// directory for a user. You can find users that match the <c>SearchString</c> parameter
    /// with the value of their attributes included in the <c>SearchString</c> parameter.
    /// <para> This operation supports pagination with the use of the <c>NextToken</c> request
    /// and response parameters. If more results are available, the <c>SearchUsers.NextToken</c>
    /// member contains a token that you pass in the next call to <c>SearchUsers</c>. This
    /// retrieves the next set of items. </para> <para> You can also specify a maximum number
    /// of return results with the <c>MaxResults</c> parameter. </para>
    /// </summary>
    public partial class SearchUsersRequest : AmazonDirectoryServiceDataRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        ///  The identifier (ID) of the directory that's associated with the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to be returned per request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An encoded paging token for paginated calls that can be passed back to retrieve the
        /// next page. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 6144)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Realm. 
        /// <para>
        ///  The domain name that's associated with the user. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This parameter is optional, so you can return users outside of your Managed Microsoft
        /// AD domain. When no value is defined, only your Managed Microsoft AD users are returned.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This value is case insensitive. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Realm { get; set; }

        /// <summary>
        /// Checks to see if the Realm property is set.
        /// </summary>
        internal bool IsSetRealm() => this.Realm != null;

        /// <summary>
        /// Gets and sets the property SearchAttributes. 
        /// <para>
        ///  One or more data attributes that are used to search for a user. For a list of supported
        /// attributes, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ad_data_attributes.html">Directory
        /// Service Data Attributes</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public List<string> SearchAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SearchAttributes property is set.
        /// </summary>
        internal bool IsSetSearchAttributes() => this.SearchAttributes != null && (this.SearchAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SearchString. 
        /// <para>
        ///  The attribute value that you want to search for. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Wildcard <c>(*)</c> searches aren't supported. For a list of supported attributes,
        /// see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ad_data_attributes.html">Directory
        /// Service Data Attributes</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string SearchString { get; set; }

        /// <summary>
        /// Checks to see if the SearchString property is set.
        /// </summary>
        internal bool IsSetSearchString() => this.SearchString != null;
    }
}
