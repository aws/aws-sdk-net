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
    /// Container for the parameters to the UpdateInboundConnector operation. Updates an inbound
    /// connector. You can change its name, description, status, and configuration. You can't
    /// change the connector type after the connector is created.
    /// </summary>
    public partial class UpdateInboundConnectorRequest : AmazonQuickSightRequest
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
        /// The new description of the inbound connector.
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
        /// The new configuration of the inbound connector. You can't change the <c>InboundConnectorType</c>.
        /// </para>
        /// </summary>
        public InboundConnectorConfig InboundConnectorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InboundConnectorConfiguration property is set.
        /// </summary>
        internal bool IsSetInboundConnectorConfiguration() => this.InboundConnectorConfiguration != null;

        /// <summary>
        /// Gets and sets the property InboundConnectorId. 
        /// <para>
        /// The ID of the inbound connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string InboundConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the InboundConnectorId property is set.
        /// </summary>
        internal bool IsSetInboundConnectorId() => this.InboundConnectorId != null;

        /// <summary>
        /// Gets and sets the property InboundConnectorStatus. 
        /// <para>
        /// The new status of the inbound connector.
        /// </para>
        /// </summary>
        public InboundConnectorStatus InboundConnectorStatus { get; set; }

        /// <summary>
        /// Checks to see if the InboundConnectorStatus property is set.
        /// </summary>
        internal bool IsSetInboundConnectorStatus() => this.InboundConnectorStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name of the inbound connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
