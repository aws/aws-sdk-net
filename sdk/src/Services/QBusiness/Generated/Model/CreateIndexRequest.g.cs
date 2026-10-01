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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIndex operation. Creates an Amazon Q Business
    /// index. <para> To determine if index creation has completed, check the <c>Status</c>
    /// field returned from a call to <c>DescribeIndex</c>. The <c>Status</c> field is set
    /// to <c>ACTIVE</c> when the index is ready to use. </para> <para> Once the index is
    /// active, you can index your documents using the <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_BatchPutDocument.html">
    /// <c>BatchPutDocument</c> </a> API or the <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_CreateDataSource.html">
    /// <c>CreateDataSource</c> </a> API. </para>
    /// </summary>
    public partial class CreateIndexRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application using the index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property CapacityConfiguration. 
        /// <para>
        /// The capacity units you want to provision for your index. You can add and remove capacity
        /// to fit your usage needs.
        /// </para>
        /// </summary>
        public IndexCapacityConfiguration CapacityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CapacityConfiguration property is set.
        /// </summary>
        internal bool IsSetCapacityConfiguration() => this.CapacityConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create an index. Multiple calls
        /// to the <c>CreateIndex</c> API with the same client token will create only one index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Q Business index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A name for the Amazon Q Business index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify or categorize the index. You can also use
        /// tags to help control access to the index. Tag keys and values can consist of Unicode
        /// letters, digits, white space, and any of the following symbols: _ . : / = + - @.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The index type that's suitable for your needs. For more information on what's included
        /// in each type of index, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/tiers.html#index-tiers">Amazon
        /// Q Business tiers</a>.
        /// </para>
        /// </summary>
        public IndexType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
