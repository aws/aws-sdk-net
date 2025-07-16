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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutDeliverySource operation.
    /// Creates or updates a logical <i>delivery source</i>. A delivery source represents
    /// an Amazon Web Services resource that sends logs to an logs delivery destination. The
    /// destination can be CloudWatch Logs, Amazon S3, Firehose or X-Ray for sending traces.
    /// 
    ///  
    /// <para>
    /// To configure logs delivery between a delivery destination and an Amazon Web Services
    /// service that is supported as a delivery source, you must do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use <c>PutDeliverySource</c> to create a delivery source, which is a logical object
    /// that represents the resource that is actually sending the logs. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>PutDeliveryDestination</c> to create a <i>delivery destination</i>, which is
    /// a logical object that represents the actual delivery destination. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">PutDeliveryDestination</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are delivering logs cross-account, you must use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>
    /// in the destination account to assign an IAM policy to the destination. This policy
    /// allows delivery to that destination. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>CreateDelivery</c> to create a <i>delivery</i> by pairing exactly one delivery
    /// source and one delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can configure a single delivery source to send logs to multiple destinations by
    /// creating multiple deliveries. You can also create multiple deliveries to configure
    /// multiple delivery sources to send logs to the same delivery destination.
    /// </para>
    ///  
    /// <para>
    /// Only some Amazon Web Services services support being configured as a delivery source.
    /// These services are listed as <b>Supported [V2 Permissions]</b> in the table at <a
    /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
    /// logging from Amazon Web Services services.</a> 
    /// </para>
    ///  
    /// <para>
    /// If you use this operation to update an existing delivery source, all the current delivery
    /// source parameters are overwritten with the new parameter values that you specify.
    /// </para>
    /// </summary>
    public partial class PutDeliverySourceRequest : AmazonCloudWatchLogsRequest
    {
        private string _logType;
        private string _name;
        private string _resourceArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// Defines the type of log that the source is sending.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Amazon Bedrock, the valid value is <c>APPLICATION_LOGS</c> and <c>TRACES</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For CloudFront, the valid value is <c>ACCESS_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon CodeWhisperer, the valid value is <c>EVENT_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Elemental MediaPackage, the valid values are <c>EGRESS_ACCESS_LOGS</c> and <c>INGRESS_ACCESS_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Elemental MediaTailor, the valid values are <c>AD_DECISION_SERVER_LOGS</c>, <c>MANIFEST_SERVICE_LOGS</c>,
        /// and <c>TRANSCODE_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Entity Resolution, the valid value is <c>WORKFLOW_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For IAM Identity Center, the valid value is <c>ERROR_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PCS, the valid values are <c>PCS_SCHEDULER_LOGS</c> and <c>PCS_JOBCOMP_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Q, the valid value is <c>EVENT_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon SES mail manager, the valid values are <c>APPLICATION_LOG</c> and <c>TRAFFIC_POLICY_DEBUG_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon WorkMail, the valid values are <c>ACCESS_CONTROL_LOGS</c>, <c>AUTHENTICATION_LOGS</c>,
        /// <c>WORKMAIL_AVAILABILITY_PROVIDER_LOGS</c>, <c>WORKMAIL_MAILBOX_ACCESS_LOGS</c>, and
        /// <c>WORKMAIL_PERSONAL_ACCESS_TOKEN_LOGS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon VPC Route Server, the valid value is <c>EVENT_LOGS</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string LogType
        {
            get { return this._logType; }
            set { this._logType = value; }
        }

        // Check to see if LogType property is set
        internal bool IsSetLogType()
        {
            return this._logType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for this delivery source. This name must be unique for all delivery sources
        /// in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the Amazon Web Services resource that is generating and sending logs. For
        /// example, <c>arn:aws:workmail:us-east-1:123456789012:organization/m-1234EXAMPLEabcd1234abcd1234abcd1234</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of key-value pairs to associate with the resource.
        /// </para>
        ///  
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}