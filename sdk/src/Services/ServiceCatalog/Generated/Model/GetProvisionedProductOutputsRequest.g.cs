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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the GetProvisionedProductOutputs operation. This API
    /// takes either a <c>ProvisonedProductId</c> or a <c>ProvisionedProductName</c>, along
    /// with a list of one or more output keys, and responds with the key/value pairs of those
    /// outputs.
    /// </summary>
    public partial class GetProvisionedProductOutputsRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AcceptLanguage property is set.
        /// </summary>
        internal bool IsSetAcceptLanguage() => this.AcceptLanguage != null;

        /// <summary>
        /// Gets and sets the property OutputKeys. 
        /// <para>
        /// The list of keys that the API should return with their values. If none are provided,
        /// the API will return all outputs of the provisioned product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public List<string> OutputKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OutputKeys property is set.
        /// </summary>
        internal bool IsSetOutputKeys() => this.OutputKeys != null && (this.OutputKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of items to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The page token for the next set of results. To retrieve the first set of results,
        /// use null.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2024)]
        public string PageToken { get; set; }

        /// <summary>
        /// Checks to see if the PageToken property is set.
        /// </summary>
        internal bool IsSetPageToken() => this.PageToken != null;

        /// <summary>
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The identifier of the provisioned product that you want the outputs from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProvisionedProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedProductId property is set.
        /// </summary>
        internal bool IsSetProvisionedProductId() => this.ProvisionedProductId != null;

        /// <summary>
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// The name of the provisioned product that you want the outputs from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProvisionedProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedProductName property is set.
        /// </summary>
        internal bool IsSetProvisionedProductName() => this.ProvisionedProductName != null;
    }
}
