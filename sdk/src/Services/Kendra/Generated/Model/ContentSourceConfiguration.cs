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
    /// Provides the configuration information for your content sources, such as data sources,
    /// FAQs, and content indexed directly via <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">BatchPutDocument</a>.
    /// </summary>
    public partial class ContentSourceConfiguration
    {
        private List<string> _dataSourceIds = new List<string>();
        private bool? _directPutContent;
        private List<string> _faqIds = new List<string>();

        /// <summary>
        /// Gets and sets the property DataSourceIds. 
        /// <para>
        /// The identifier of the data sources you want to use for your Amazon Kendra experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> DataSourceIds
        {
            get { return this._dataSourceIds; }
            set { this._dataSourceIds = value; }
        }

        // Check to see if DataSourceIds property is set
        internal bool IsSetDataSourceIds()
        {
            return this._dataSourceIds != null && this._dataSourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DirectPutContent. 
        /// <para>
        ///  <code>TRUE</code> to use documents you indexed directly using the <code>BatchPutDocument</code>
        /// API.
        /// </para>
        /// </summary>
        public bool DirectPutContent
        {
            get { return this._directPutContent.GetValueOrDefault(); }
            set { this._directPutContent = value; }
        }

        // Check to see if DirectPutContent property is set
        internal bool IsSetDirectPutContent()
        {
            return this._directPutContent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FaqIds. 
        /// <para>
        /// The identifier of the FAQs that you want to use for your Amazon Kendra experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> FaqIds
        {
            get { return this._faqIds; }
            set { this._faqIds = value; }
        }

        // Check to see if FaqIds property is set
        internal bool IsSetFaqIds()
        {
            return this._faqIds != null && this._faqIds.Count > 0; 
        }

    }
}