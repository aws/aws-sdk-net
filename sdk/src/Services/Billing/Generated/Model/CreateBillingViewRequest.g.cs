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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBillingView operation. Creates a billing
    /// view with the specified billing view attributes.
    /// </summary>
    public partial class CreateBillingViewRequest : AmazonBillingRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you specify to ensure idempotency of the request.
        /// Idempotency ensures that an API request completes no more than one time. If the original
        /// request completes successfully, any subsequent retries complete successfully without
        /// performing any further actions with an idempotent request. 
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataFilterExpression. 
        /// <para>
        ///  See <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_billing_Expression.html">Expression</a>.
        /// Billing view only supports <c>LINKED_ACCOUNT</c>, <c>Tags</c>, and <c>CostCategories</c>.
        /// 
        /// </para>
        /// </summary>
        public Expression DataFilterExpression { get; set; }

        /// <summary>
        /// Checks to see if the DataFilterExpression property is set.
        /// </summary>
        internal bool IsSetDataFilterExpression() => this.DataFilterExpression != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the billing view. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the billing view. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// A list of key value map specifying tags associated to the billing view being created.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceViews. 
        /// <para>
        /// A list of billing views used as the data source for the custom billing view.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> SourceViews { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceViews property is set.
        /// </summary>
        internal bool IsSetSourceViews() => this.SourceViews != null && (this.SourceViews.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
