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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information on boosting supported Amazon Q Business document attribute types.
    /// When an end user chat query matches document attributes that have been boosted, Amazon
    /// Q Business prioritizes generating responses from content that matches the boosted
    /// document attributes.
    /// 
    ///  
    /// <para>
    /// In version 2, boosting uses numeric values (ONE, TWO) to indicate priority tiers that
    /// establish clear hierarchical relationships between boosted attributes. This allows
    /// for more precise control over how different attributes influence search results.
    /// </para>
    ///  <note> 
    /// <para>
    /// For <c>STRING</c> and <c>STRING_LIST</c> type document attributes to be used for boosting
    /// on the console and the API, they must be enabled for search using the <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_DocumentAttributeConfiguration.html">DocumentAttributeConfiguration</a>
    /// object of the <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_UpdateIndex.html">UpdateIndex</a>
    /// API. If you haven't enabled searching on these attributes, you can't boost attributes
    /// of these data types on either the console or the API.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information on how boosting document attributes work in Amazon Q Business,
    /// see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/metadata-boosting.html">Boosting
    /// using document attributes</a>.
    /// </para>
    /// </summary>
    public partial class DocumentAttributeBoostingConfiguration
    {
        private DateAttributeBoostingConfiguration _dateConfiguration;
        private NumberAttributeBoostingConfiguration _numberConfiguration;
        private StringAttributeBoostingConfiguration _stringConfiguration;
        private StringListAttributeBoostingConfiguration _stringListConfiguration;

        /// <summary>
        /// Gets and sets the property DateConfiguration. 
        /// <para>
        /// Provides information on boosting <c>DATE</c> type document attributes.
        /// </para>
        ///  
        /// <para>
        /// Version 2 assigns priority tiers to <c>DATE</c> attributes, establishing clear hierarchical
        /// relationships with other boosted attributes.
        /// </para>
        /// </summary>
        public DateAttributeBoostingConfiguration DateConfiguration
        {
            get { return this._dateConfiguration; }
            set { this._dateConfiguration = value; }
        }

        // Check to see if DateConfiguration property is set
        internal bool IsSetDateConfiguration()
        {
            return this._dateConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NumberConfiguration. 
        /// <para>
        /// Provides information on boosting <c>NUMBER</c> type document attributes.
        /// </para>
        ///  
        /// <para>
        ///  <c>NUMBER</c> attributes are not supported when using <c>NativeIndexConfiguration</c>
        /// version 2, which focuses on <c>DATE</c> attributes for recency and <c>STRING</c> attributes
        /// for source prioritization.
        /// </para>
        /// </summary>
        public NumberAttributeBoostingConfiguration NumberConfiguration
        {
            get { return this._numberConfiguration; }
            set { this._numberConfiguration = value; }
        }

        // Check to see if NumberConfiguration property is set
        internal bool IsSetNumberConfiguration()
        {
            return this._numberConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StringConfiguration. 
        /// <para>
        /// Provides information on boosting <c>STRING</c> type document attributes.
        /// </para>
        ///  
        /// <para>
        /// Version 2 assigns priority tiers to <c>STRING</c> attributes, establishing clear hierarchical
        /// relationships with other boosted attributes.
        /// </para>
        /// </summary>
        public StringAttributeBoostingConfiguration StringConfiguration
        {
            get { return this._stringConfiguration; }
            set { this._stringConfiguration = value; }
        }

        // Check to see if StringConfiguration property is set
        internal bool IsSetStringConfiguration()
        {
            return this._stringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StringListConfiguration. 
        /// <para>
        /// Provides information on boosting <c>STRING_LIST</c> type document attributes.
        /// </para>
        ///  
        /// <para>
        ///  <c>STRING_LIST</c> attributes are not supported when using <c>NativeIndexConfiguration</c>
        /// version 2, which focuses on <c>DATE</c> attributes for recency and <c>STRING</c> attributes
        /// for source prioritization.
        /// </para>
        /// </summary>
        public StringListAttributeBoostingConfiguration StringListConfiguration
        {
            get { return this._stringListConfiguration; }
            set { this._stringListConfiguration = value; }
        }

        // Check to see if StringListConfiguration property is set
        internal bool IsSetStringListConfiguration()
        {
            return this._stringListConfiguration != null;
        }

    }
}