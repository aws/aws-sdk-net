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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about the topic rule destination.
    /// </summary>
    public partial class TopicRuleDestinationSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The topic rule destination ARN.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the topic rule destination was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property HttpUrlSummary. 
        /// <para>
        /// Information about the HTTP URL.
        /// </para>
        /// </summary>
        public HttpUrlDestinationSummary HttpUrlSummary { get; set; }

        /// <summary>
        /// Checks to see if the HttpUrlSummary property is set.
        /// </summary>
        internal bool IsSetHttpUrlSummary() => this.HttpUrlSummary != null;

        /// <summary>
        /// Gets and sets the property InfluxDBSummary. 
        /// <para>
        /// A summary of an InfluxDB topic rule destination, as returned by <c>ListTopicRuleDestinations</c>.
        /// </para>
        /// </summary>
        public InfluxDBDestinationSummary InfluxDBSummary { get; set; }

        /// <summary>
        /// Checks to see if the InfluxDBSummary property is set.
        /// </summary>
        internal bool IsSetInfluxDBSummary() => this.InfluxDBSummary != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when the topic rule destination was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the topic rule destination. Valid values are:
        /// </para>
        ///  <dl> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// A topic rule destination was created but has not been confirmed. You can set <c>status</c>
        /// to <c>IN_PROGRESS</c> by calling <c>UpdateTopicRuleDestination</c>. Calling <c>UpdateTopicRuleDestination</c>
        /// causes a new confirmation challenge to be sent to your confirmation endpoint.
        /// </para>
        ///  </dd> <dt>ENABLED</dt> <dd> 
        /// <para>
        /// Confirmation was completed, and traffic to this destination is allowed. You can set
        /// <c>status</c> to <c>DISABLED</c> by calling <c>UpdateTopicRuleDestination</c>.
        /// </para>
        ///  </dd> <dt>DISABLED</dt> <dd> 
        /// <para>
        /// Confirmation was completed, and traffic to this destination is not allowed. You can
        /// set <c>status</c> to <c>ENABLED</c> by calling <c>UpdateTopicRuleDestination</c>.
        /// </para>
        ///  </dd> <dt>ERROR</dt> <dd> 
        /// <para>
        /// Confirmation could not be completed, for example if the confirmation timed out. You
        /// can call <c>GetTopicRuleDestination</c> for details about the error. You can set <c>status</c>
        /// to <c>IN_PROGRESS</c> by calling <c>UpdateTopicRuleDestination</c>. Calling <c>UpdateTopicRuleDestination</c>
        /// causes a new confirmation challenge to be sent to your confirmation endpoint.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public TopicRuleDestinationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason the topic rule destination is in the current status.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property VpcDestinationSummary. 
        /// <para>
        /// Information about the virtual private cloud (VPC) connection.
        /// </para>
        /// </summary>
        public VpcDestinationSummary VpcDestinationSummary { get; set; }

        /// <summary>
        /// Checks to see if the VpcDestinationSummary property is set.
        /// </summary>
        internal bool IsSetVpcDestinationSummary() => this.VpcDestinationSummary != null;
    }
}
