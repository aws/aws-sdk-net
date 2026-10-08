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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
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
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// The product attribute values used for filtering the costs by key and value pairs.
    /// Product attributes are supported for Amazon Bedrock only.
    /// </summary>
    public partial class ProductAttributeValues
    {
        private string _key;
        private List<string> _matchOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the product attribute to filter on. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>feature</c> – The feature that was used, such as <c>On-demand Inference</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>inferenceType</c> – The type of inference usage, such as <c>Input tokens</c> or
        /// <c>Output tokens</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>model</c> – The model, such as <c>Claude Sonnet 5</c> or <c>Claude Haiku 4.5</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provider</c> – The model provider, such as <c>Anthropic</c>, <c>Cohere</c>, or
        /// <c>Amazon</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Keys are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property MatchOptions. 
        /// <para>
        /// The match options for the <c>ProductAttributes</c> filter. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ABSENT</c> – Matches costs that have no value for the attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CASE_SENSITIVE</c> – Requires an exact case match.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EQUALS</c> – Matches costs where the attribute equals the specified value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Specify either <c>EQUALS</c> or <c>ABSENT</c>. You can add <c>CASE_SENSITIVE</c> to
        /// <c>EQUALS</c>, but you can't use it by itself or with <c>ABSENT</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchOptions
        {
            get { return this._matchOptions; }
            set { this._matchOptions = value; }
        }

        // Check to see if MatchOptions property is set
        internal bool IsSetMatchOptions()
        {
            return this._matchOptions != null && (this._matchOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The specific values of the product attribute, such as <c>Claude Sonnet 5</c> for the
        /// <c>model</c> key. Values are matched exactly.
        /// </para>
        ///  
        /// <para>
        ///  <c>Values</c> is required unless <c>MatchOptions</c> is <c>ABSENT</c>. To match costs
        /// that have no value for the key, set <c>MatchOptions</c> to <c>ABSENT</c> and omit
        /// <c>Values</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}