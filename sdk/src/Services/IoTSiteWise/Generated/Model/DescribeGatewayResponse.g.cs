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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeGateway operation.
    /// </summary>
    public partial class DescribeGatewayResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the gateway was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the gateway, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:gateway/${GatewayId}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property GatewayCapabilitySummaries. 
        /// <para>
        /// A list of gateway capability summaries that each contain a namespace and status. Each
        /// gateway capability defines data sources for the gateway. To retrieve a capability
        /// configuration's definition, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeGatewayCapabilityConfiguration.html">DescribeGatewayCapabilityConfiguration</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<GatewayCapabilitySummary> GatewayCapabilitySummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<GatewayCapabilitySummary>() : null;

        /// <summary>
        /// Checks to see if the GatewayCapabilitySummaries property is set.
        /// </summary>
        internal bool IsSetGatewayCapabilitySummaries() => this.GatewayCapabilitySummaries != null && (this.GatewayCapabilitySummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of the gateway device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property GatewayName. 
        /// <para>
        /// The name of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string GatewayName { get; set; }

        /// <summary>
        /// Checks to see if the GatewayName property is set.
        /// </summary>
        internal bool IsSetGatewayName() => this.GatewayName != null;

        /// <summary>
        /// Gets and sets the property GatewayPlatform. 
        /// <para>
        /// The gateway's platform.
        /// </para>
        /// </summary>
        public GatewayPlatform GatewayPlatform { get; set; }

        /// <summary>
        /// Checks to see if the GatewayPlatform property is set.
        /// </summary>
        internal bool IsSetGatewayPlatform() => this.GatewayPlatform != null;

        /// <summary>
        /// Gets and sets the property GatewayVersion. 
        /// <para>
        /// The version of the gateway. A value of <c>3</c> indicates an MQTT-enabled, V3 gateway,
        /// while <c>2</c> indicates a Classic streams, V2 gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GatewayVersion { get; set; }

        /// <summary>
        /// Checks to see if the GatewayVersion property is set.
        /// </summary>
        internal bool IsSetGatewayVersion() => this.GatewayVersion != null;

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date the gateway was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateDate property is set.
        /// </summary>
        internal bool IsSetLastUpdateDate() => this.LastUpdateDate.HasValue;
    }
}
