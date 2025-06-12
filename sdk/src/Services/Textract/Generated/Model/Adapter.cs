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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// An adapter selected for use when analyzing documents. Contains an adapter ID and a
    /// version number. Contains information on pages selected for analysis when analyzing
    /// documents asychronously.
    /// </summary>
    public partial class Adapter
    {
        private string _adapterId;
        private List<string> _pages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _version;

        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A unique identifier for the adapter resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=1011)]
        public string AdapterId
        {
            get { return this._adapterId; }
            set { this._adapterId = value; }
        }

        // Check to see if AdapterId property is set
        internal bool IsSetAdapterId()
        {
            return this._adapterId != null;
        }

        /// <summary>
        /// Gets and sets the property Pages. 
        /// <para>
        /// Pages is a parameter that the user inputs to specify which pages to apply an adapter
        /// to. The following is a list of rules for using this parameter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a page is not specified, it is set to <c>["1"]</c> by default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The following characters are allowed in the parameter's string: <c>0 1 2 3 4 5 6 7
        /// 8 9 - *</c>. No whitespace is allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When using * to indicate all pages, it must be the only element in the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can use page intervals, such as <c>["1-3", "1-1", "4-*"]</c>. Where <c>*</c> indicates
        /// last page of document.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified pages must be greater than 0 and less than or equal to the number of pages
        /// in the document.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Pages
        {
            get { return this._pages; }
            set { this._pages = value; }
        }

        // Check to see if Pages property is set
        internal bool IsSetPages()
        {
            return this._pages != null && (this._pages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A string that identifies the version of the adapter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}