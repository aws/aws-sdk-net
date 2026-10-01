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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataGrant operation. This operation creates
    /// a data grant.
    /// </summary>
    public partial class CreateDataGrantRequest : AmazonDataExchangeRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data grant.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndsAt. 
        /// <para>
        /// The timestamp of when access to the associated data set ends.
        /// </para>
        /// </summary>
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// Checks to see if the EndsAt property is set.
        /// </summary>
        internal bool IsSetEndsAt() => this.EndsAt.HasValue;

        /// <summary>
        /// Gets and sets the property GrantDistributionScope. 
        /// <para>
        /// The distribution scope of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GrantDistributionScope GrantDistributionScope { get; set; }

        /// <summary>
        /// Checks to see if the GrantDistributionScope property is set.
        /// </summary>
        internal bool IsSetGrantDistributionScope() => this.GrantDistributionScope != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReceiverPrincipal. 
        /// <para>
        /// The Amazon Web Services account ID of the data grant receiver.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReceiverPrincipal { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverPrincipal property is set.
        /// </summary>
        internal bool IsSetReceiverPrincipal() => this.ReceiverPrincipal != null;

        /// <summary>
        /// Gets and sets the property SourceDataSetId. 
        /// <para>
        /// The ID of the data set used to create the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceDataSetId { get; set; }

        /// <summary>
        /// Checks to see if the SourceDataSetId property is set.
        /// </summary>
        internal bool IsSetSourceDataSetId() => this.SourceDataSetId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the data grant. A tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
