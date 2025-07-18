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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the ListConflictingAliases operation.
    /// <note> 
    /// <para>
    /// The <c>ListConflictingAliases</c> API operation only supports standard distributions.
    /// To list domain conflicts for both standard distributions and distribution tenants,
    /// we recommend that you use the <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDomainConflicts.html">ListDomainConflicts</a>
    /// API operation instead.
    /// 
    ///  </note> 
    /// <para>
    /// Gets a list of aliases that conflict or overlap with the provided alias, and the associated
    /// CloudFront standard distribution and Amazon Web Services accounts for each conflicting
    /// alias. An alias is commonly known as a custom domain or vanity domain. It can also
    /// be called a CNAME or alternate domain name.
    /// </para>
    ///  
    /// <para>
    /// In the returned list, the standard distribution and account IDs are partially hidden,
    /// which allows you to identify the standard distribution and accounts that you own,
    /// and helps to protect the information of ones that you don't own.
    /// </para>
    ///  
    /// <para>
    /// Use this operation to find aliases that are in use in CloudFront that conflict or
    /// overlap with the provided alias. For example, if you provide <c>www.example.com</c>
    /// as input, the returned list can include <c>www.example.com</c> and the overlapping
    /// wildcard alternate domain name (<c><em>.example.com</c>), if they exist. If you provide
    /// <c></em>.example.com</c> as input, the returned list can include <c>*.example.com</c>
    /// and any alternate domain names covered by that wildcard (for example, <c>www.example.com</c>,
    /// <c>test.example.com</c>, <c>dev.example.com</c>, and so on), if they exist.
    /// </para>
    ///  
    /// <para>
    /// To list conflicting aliases, specify the alias to search and the ID of a standard
    /// distribution in your account that has an attached TLS certificate that includes the
    /// provided alias. For more information, including how to set up the standard distribution
    /// and certificate, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
    /// an alternate domain name to a different standard distribution or distribution tenant</a>
    /// in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can optionally specify the maximum number of items to receive in the response.
    /// If the total number of items in the list exceeds the maximum that you specify, or
    /// the default maximum, the response is paginated. To get the next page of items, send
    /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
    /// as the <c>Marker</c> value in the subsequent request.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class ListConflictingAliasesRequest : AmazonCloudFrontRequest
    {
        private string _alias;
        private string _distributionId;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias (also called a CNAME) to search for conflicting aliases.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=253)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionId. 
        /// <para>
        /// The ID of a standard distribution in your account that has an attached TLS certificate
        /// that includes the provided alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public string DistributionId
        {
            get { return this._distributionId; }
            set { this._distributionId = value; }
        }

        // Check to see if DistributionId property is set
        internal bool IsSetDistributionId()
        {
            return this._distributionId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this field when paginating results to indicate where to begin in the list of conflicting
        /// aliases. The response includes conflicting aliases in the list that occur after the
        /// marker. To get the next page of the list, set this field's value to the value of <c>NextMarker</c>
        /// from the current page's response.
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
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of conflicting aliases that you want in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}