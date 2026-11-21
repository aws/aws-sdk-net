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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInboundConnector operation. Creates an inbound
    /// connector in a Quick Sight account. An inbound connector is the endpoint that an external
    /// client, such as the Quick Sight desktop application, uses to reach Quick Sight in
    /// your account. <para> Your users authenticate through the access control applications
    /// that are associated with the connector. To manage these associations, use <c>UpdateInboundConnectorApplicationAssociations</c>.
    /// </para> <para> An account can have one <c>QUICK_DESKTOP</c> inbound connector in each
    /// Region. </para>
    /// </summary>
    public partial class CreateInboundConnectorRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the Quick Sight account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the inbound connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InboundConnectorConfiguration. 
        /// <para>
        /// The configuration of the inbound connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InboundConnectorConfig InboundConnectorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InboundConnectorConfiguration property is set.
        /// </summary>
        internal bool IsSetInboundConnectorConfiguration() => this.InboundConnectorConfiguration != null;

        /// <summary>
        /// Gets and sets the property InboundConnectorId. 
        /// <para>
        /// The ID for the inbound connector. This ID is unique per Amazon Web Services Region
        /// for each Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// For a <c>QUICK_DESKTOP</c> inbound connector, the ID must be <c>ibc-desktop-</c> followed
        /// by your Amazon Web Services account ID and the Region that you call, separated by
        /// a hyphen. For example, <c>ibc-desktop-111122223333-us-east-1</c>. Quick Sight reserves
        /// IDs that start with <c>ibc-desktop-</c> for <c>QUICK_DESKTOP</c> inbound connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string InboundConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the InboundConnectorId property is set.
        /// </summary>
        internal bool IsSetInboundConnectorId() => this.InboundConnectorId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the inbound connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the inbound connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
