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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAdapter operation. Creates an adapter, which
    /// can be fine-tuned for enhanced performance on user provided documents. Takes an AdapterName
    /// and FeatureType. Currently the only supported feature type is <c>QUERIES</c>. You
    /// can also provide a Description, Tags, and a ClientRequestToken. You can choose whether
    /// or not the adapter should be AutoUpdated with the AutoUpdate argument. By default,
    /// AutoUpdate is set to DISABLED.
    /// </summary>
    public partial class CreateAdapterRequest : AmazonTextractRequest
    {
        /// <summary>
        /// Gets and sets the property AdapterName. 
        /// <para>
        /// The name to be assigned to the adapter being created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AdapterName { get; set; }

        /// <summary>
        /// Checks to see if the AdapterName property is set.
        /// </summary>
        internal bool IsSetAdapterName() => this.AdapterName != null;

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// Controls whether or not the adapter should automatically update.
        /// </para>
        /// </summary>
        public AutoUpdate AutoUpdate { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpdate property is set.
        /// </summary>
        internal bool IsSetAutoUpdate() => this.AutoUpdate != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token is used to recognize the request. If the same token is used with
        /// multiple CreateAdapter requests, the same session is returned. This token is employed
        /// to avoid unintentionally creating the same session multiple times.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to be assigned to the adapter being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// The type of feature that the adapter is being trained on. Currrenly, supported feature
        /// types are: <c>QUERIES</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> FeatureTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FeatureTypes property is set.
        /// </summary>
        internal bool IsSetFeatureTypes() => this.FeatureTypes != null && (this.FeatureTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to the adapter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
