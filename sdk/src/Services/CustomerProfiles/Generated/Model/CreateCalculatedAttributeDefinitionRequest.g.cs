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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCalculatedAttributeDefinition operation.
    /// Creates a new calculated attribute definition. After creation, new object data ingested
    /// into Customer Profiles will be included in the calculated attribute, which can be
    /// retrieved for a profile using the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetCalculatedAttributeForProfile.html">GetCalculatedAttributeForProfile</a>
    /// API. Defining a calculated attribute makes it available for all profiles within a
    /// domain. Each calculated attribute can only reference one <c>ObjectType</c> and at
    /// most, two fields from that <c>ObjectType</c>.
    /// </summary>
    public partial class CreateCalculatedAttributeDefinitionRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeDetails. 
        /// <para>
        /// Mathematical expression and a list of attribute items specified in that expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public AttributeDetails AttributeDetails { get; set; }

        /// <summary>
        /// Checks to see if the AttributeDetails property is set.
        /// </summary>
        internal bool IsSetAttributeDetails() => this.AttributeDetails != null;

        /// <summary>
        /// Gets and sets the property CalculatedAttributeName. 
        /// <para>
        /// The unique name of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CalculatedAttributeName { get; set; }

        /// <summary>
        /// Checks to see if the CalculatedAttributeName property is set.
        /// </summary>
        internal bool IsSetCalculatedAttributeName() => this.CalculatedAttributeName != null;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// The conditions including range, object count, and threshold for the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Conditions Conditions { get; set; }

        /// <summary>
        /// Checks to see if the Conditions property is set.
        /// </summary>
        internal bool IsSetConditions() => this.Conditions != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Defines how to filter incoming objects to include part of the Calculated Attribute.
        /// </para>
        /// </summary>
        public Filter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The aggregation operation to perform for the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Statistic Statistic { get; set; }

        /// <summary>
        /// Checks to see if the Statistic property is set.
        /// </summary>
        internal bool IsSetStatistic() => this.Statistic != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseHistoricalData. 
        /// <para>
        /// Whether historical data ingested before the Calculated Attribute was created should
        /// be included in calculations.
        /// </para>
        /// </summary>
        public bool? UseHistoricalData { get; set; }

        /// <summary>
        /// Checks to see if the UseHistoricalData property is set.
        /// </summary>
        internal bool IsSetUseHistoricalData() => this.UseHistoricalData.HasValue;
    }
}
