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
    /// Container for the parameters to the UpdateIndex operation. Updates an Amazon Q Business
    /// index.
    /// </summary>
    public partial class UpdateIndexRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application connected to the index.
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
        /// The storage capacity units you want to provision for your Amazon Q Business index.
        /// You can add and remove capacity to fit your usage needs.
        /// </para>
        /// </summary>
        public IndexCapacityConfiguration CapacityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CapacityConfiguration property is set.
        /// </summary>
        internal bool IsSetCapacityConfiguration() => this.CapacityConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Amazon Q Business index.
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
        /// The name of the Amazon Q Business index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DocumentAttributeConfigurations. 
        /// <para>
        /// Configuration information for document metadata or fields. Document metadata are fields
        /// or attributes associated with your documents. For example, the company department
        /// name associated with each document. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/doc-attributes-types.html#doc-attributes">Understanding
        /// document attributes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<DocumentAttributeConfiguration> DocumentAttributeConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentAttributeConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DocumentAttributeConfigurations property is set.
        /// </summary>
        internal bool IsSetDocumentAttributeConfigurations() => this.DocumentAttributeConfigurations != null && (this.DocumentAttributeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the Amazon Q Business index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string IndexId { get; set; }

        /// <summary>
        /// Checks to see if the IndexId property is set.
        /// </summary>
        internal bool IsSetIndexId() => this.IndexId != null;
    }
}
