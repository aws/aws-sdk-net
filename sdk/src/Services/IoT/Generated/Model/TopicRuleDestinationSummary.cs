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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private string _arn;
        private DateTime? _createdAt;
        private HttpUrlDestinationSummary _httpUrlSummary;
        private DateTime? _lastUpdatedAt;
        private TopicRuleDestinationStatus _status;
        private string _statusReason;
        private VpcDestinationSummary _vpcDestinationSummary;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The topic rule destination ARN.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the topic rule destination was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpUrlSummary. 
        /// <para>
        /// Information about the HTTP URL.
        /// </para>
        /// </summary>
        public HttpUrlDestinationSummary HttpUrlSummary
        {
            get { return this._httpUrlSummary; }
            set { this._httpUrlSummary = value; }
        }

        // Check to see if HttpUrlSummary property is set
        internal bool IsSetHttpUrlSummary()
        {
            return this._httpUrlSummary != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when the topic rule destination was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

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
        public TopicRuleDestinationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason the topic rule destination is in the current status.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property VpcDestinationSummary. 
        /// <para>
        /// Information about the virtual private cloud (VPC) connection.
        /// </para>
        /// </summary>
        public VpcDestinationSummary VpcDestinationSummary
        {
            get { return this._vpcDestinationSummary; }
            set { this._vpcDestinationSummary = value; }
        }

        // Check to see if VpcDestinationSummary property is set
        internal bool IsSetVpcDestinationSummary()
        {
            return this._vpcDestinationSummary != null;
        }

    }
}