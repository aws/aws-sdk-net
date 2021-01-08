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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeGateway operation.
    /// </summary>
    public partial class DescribeGatewayResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDate;
        private string _gatewayArn;
        private List<GatewayCapabilitySummary> _gatewayCapabilitySummaries = new List<GatewayCapabilitySummary>();
        private string _gatewayId;
        private string _gatewayName;
        private GatewayPlatform _gatewayPlatform;
        private DateTime? _lastUpdateDate;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the gateway was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the gateway, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:${Partition}:iotsitewise:${Region}:${Account}:gateway/${GatewayId}</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayCapabilitySummaries. 
        /// <para>
        /// A list of gateway capability summaries that each contain a namespace and status. Each
        /// gateway capability defines data sources for the gateway. To retrieve a capability
        /// configuration's definition, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeGatewayCapabilityConfiguration.html">DescribeGatewayCapabilityConfiguration</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GatewayCapabilitySummary> GatewayCapabilitySummaries
        {
            get { return this._gatewayCapabilitySummaries; }
            set { this._gatewayCapabilitySummaries = value; }
        }

        // Check to see if GatewayCapabilitySummaries property is set
        internal bool IsSetGatewayCapabilitySummaries()
        {
            return this._gatewayCapabilitySummaries != null && this._gatewayCapabilitySummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of the gateway device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayName. 
        /// <para>
        /// The name of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string GatewayName
        {
            get { return this._gatewayName; }
            set { this._gatewayName = value; }
        }

        // Check to see if GatewayName property is set
        internal bool IsSetGatewayName()
        {
            return this._gatewayName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayPlatform. 
        /// <para>
        /// The gateway's platform.
        /// </para>
        /// </summary>
        public GatewayPlatform GatewayPlatform
        {
            get { return this._gatewayPlatform; }
            set { this._gatewayPlatform = value; }
        }

        // Check to see if GatewayPlatform property is set
        internal bool IsSetGatewayPlatform()
        {
            return this._gatewayPlatform != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date the gateway was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdateDate
        {
            get { return this._lastUpdateDate.GetValueOrDefault(); }
            set { this._lastUpdateDate = value; }
        }

        // Check to see if LastUpdateDate property is set
        internal bool IsSetLastUpdateDate()
        {
            return this._lastUpdateDate.HasValue; 
        }

    }
}