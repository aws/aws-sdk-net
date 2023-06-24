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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the GetPlace operation.
    /// Finds a place by its unique ID. A <code>PlaceId</code> is returned by other search
    /// operations.
    /// 
    ///  <note> 
    /// <para>
    /// A PlaceId is valid only if all of the following are the same in the original search
    /// request and the call to <code>GetPlace</code>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Customer Amazon Web Services account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Web Services Region
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data provider specified in the place index resource
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class GetPlaceRequest : AmazonLocationServiceRequest
    {
        private string _indexName;
        private string _language;
        private string _placeId;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the place index resource that you want to use for the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The preferred language used to return results. The value must be a valid <a href="https://tools.ietf.org/search/bcp47">BCP
        /// 47</a> language tag, for example, <code>en</code> for English.
        /// </para>
        ///  
        /// <para>
        /// This setting affects the languages used in the results, but not the results themselves.
        /// If no language is specified, or not supported for a particular result, the partner
        /// automatically chooses a language for the result.
        /// </para>
        ///  
        /// <para>
        /// For an example, we'll use the Greek language. You search for a location around Athens,
        /// Greece, with the <code>language</code> parameter set to <code>en</code>. The <code>city</code>
        /// in the results will most likely be returned as <code>Athens</code>.
        /// </para>
        ///  
        /// <para>
        /// If you set the <code>language</code> parameter to <code>el</code>, for Greek, then
        /// the <code>city</code> in the results will more likely be returned as <code>Αθήνα</code>.
        /// </para>
        ///  
        /// <para>
        /// If the data provider does not have a value for Greek, the result will be in a language
        /// that the provider does support.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=35)]
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The identifier of the place to find.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlaceId
        {
            get { return this._placeId; }
            set { this._placeId = value; }
        }

        // Check to see if PlaceId property is set
        internal bool IsSetPlaceId()
        {
            return this._placeId != null;
        }

    }
}