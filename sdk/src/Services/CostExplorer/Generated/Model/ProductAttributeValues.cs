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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The product attribute values that you can use to filter the costs of supported services.
    /// Currently, Amazon Bedrock is the only supported service.
    /// 
    ///  
    /// <para>
    /// The following product attribute keys are available for each supported service:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Bedrock
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>provider</c> - The model provider, such as <c>Anthropic</c>, <c>Cohere</c>, or
    /// <c>OpenAI</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>model</c> - The model, such as <c>Claude Sonnet 5</c> or <c>Claude Haiku 4.5</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>inferenceType</c> - The type of inference usage, such as <c>Input tokens</c> or
    /// <c>Output tokens</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>feature</c> - The feature that was used, such as <c>On-demand Inference</c> or
    /// <c>Reranker</c>.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// The following operations support product attributes: <c>GetCostAndUsage</c>, <c>GetCostAndUsageWithResources</c>,
    /// <c>GetDimensionValues</c> (in the <c>COST_AND_USAGE</c> context), <c>GetTags</c>,
    /// and <c>GetCostCategories</c>.
    /// </para>
    ///  
    /// <para>
    /// Product attribute data is available for time periods that start on or after September
    /// 1, 2026. Requests for earlier time periods that use product attributes fail with a
    /// <c>DataUnavailableException</c>.
    /// </para>
    ///  
    /// <para>
    /// The <c>SERVICE</c> filter rules for product attributes depend on the operation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>GetCostAndUsage</c> and <c>GetCostAndUsageWithResources</c> - Optional.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetDimensionValues</c> - Required when the filter includes <c>ProductAttributes</c>,
    /// for any <c>Dimension</c>. Otherwise, optional.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetTags</c> and <c>GetCostCategories</c> - Required when the filter includes <c>ProductAttributes</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A <c>SERVICE</c> filter must contain only supported services, or the request fails
    /// with a <c>ValidationException</c>. Service names are matched exactly. To list them,
    /// use <c>GetDimensionValues</c> with <c>Dimension</c> set to <c>SERVICE</c> and the
    /// same <c>TimePeriod</c>, for example with <c>SearchString</c> set to <c>Bedrock</c>.
    /// </para>
    ///  
    /// <para>
    /// The costs of a supported service can appear under multiple service names. When the
    /// <c>SERVICE</c> filter is optional, omit it so that your results include all of those
    /// costs.
    /// </para>
    ///  
    /// <para>
    /// For example, the following <c>Expression</c> filters for the costs of one model: <c>{
    /// "ProductAttributes": { "Key": "model", "Values": [ "Claude Sonnet 5" ], "MatchOptions":
    /// [ "EQUALS" ] } }</c> 
    /// </para>
    /// </summary>
    public partial class ProductAttributeValues
    {
        private string _key;
        private List<string> _matchOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the product attribute, such as <c>model</c>. The keys that are available
        /// depend on the service. For the keys of each supported service, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_ProductAttributeValues.html">
        /// <c>ProductAttributeValues</c> </a>.
        /// </para>
        ///  
        /// <para>
        /// Keys are case-sensitive. A key that doesn't exist doesn't return an error: <c>EQUALS</c>
        /// matches no costs, and <c>ABSENT</c> matches all costs of supported services.
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
        /// The match options that you can use to filter your results. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EQUALS</c> - Matches the values that you specify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ABSENT</c> - Matches costs that have no value for the key. Omit <c>Values</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CASE_SENSITIVE</c> - Use only with <c>EQUALS</c>. Values are always matched case-sensitively.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default values are <c>EQUALS</c> and <c>CASE_SENSITIVE</c>.
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
        /// <c>model</c> key. Values are matched exactly, including case. To list the values of
        /// a key, use <c>GetDimensionValues</c> with <c>Dimension</c> set to <c>PRODUCT_ATTRIBUTE</c>
        /// and <c>DimensionKey</c> set to the key.
        /// </para>
        ///  
        /// <para>
        /// To match costs that have no value for the key, set <c>MatchOptions</c> to <c>ABSENT</c>
        /// and omit <c>Values</c>. Otherwise, <c>Values</c> is required.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=6000)]
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