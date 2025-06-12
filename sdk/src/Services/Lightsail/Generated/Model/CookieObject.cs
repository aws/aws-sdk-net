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
    /// Describes whether an Amazon Lightsail content delivery network (CDN) distribution
    /// forwards cookies to the origin and, if so, which ones.
    /// 
    ///  
    /// <para>
    /// For the cookies that you specify, your distribution caches separate versions of the
    /// specified content based on the cookie values in viewer requests.
    /// </para>
    /// </summary>
    public partial class CookieObject
    {
        private List<string> _cookiesAllowList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ForwardValues _option;

        /// <summary>
        /// Gets and sets the property CookiesAllowList. 
        /// <para>
        /// The specific cookies to forward to your distribution's origin.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CookiesAllowList
        {
            get { return this._cookiesAllowList; }
            set { this._cookiesAllowList = value; }
        }

        // Check to see if CookiesAllowList property is set
        internal bool IsSetCookiesAllowList()
        {
            return this._cookiesAllowList != null && (this._cookiesAllowList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Option. 
        /// <para>
        /// Specifies which cookies to forward to the distribution's origin for a cache behavior:
        /// <c>all</c>, <c>none</c>, or <c>allow-list</c> to forward only the cookies specified
        /// in the <c>cookiesAllowList</c> parameter.
        /// </para>
        /// </summary>
        public ForwardValues Option
        {
            get { return this._option; }
            set { this._option = value; }
        }

        // Check to see if Option property is set
        internal bool IsSetOption()
        {
            return this._option != null;
        }

    }
}