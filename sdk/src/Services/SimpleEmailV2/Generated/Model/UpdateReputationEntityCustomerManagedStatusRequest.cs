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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateReputationEntityCustomerManagedStatus operation.
    /// Update the customer-managed sending status for a reputation entity. This allows you
    /// to enable, disable, or reinstate sending for the entity.
    /// 
    ///  
    /// <para>
    /// The customer-managed status works in conjunction with the Amazon Web Services Amazon
    /// SES-managed status to determine the overall sending capability. When you update the
    /// customer-managed status, the Amazon Web Services Amazon SES-managed status remains
    /// unchanged. If Amazon Web Services Amazon SES has disabled the entity, it will not
    /// be allowed to send regardless of the customer-managed status setting. When you reinstate
    /// an entity through the customer-managed status, it can continue sending only if the
    /// Amazon Web Services Amazon SES-managed status also permits sending, even if there
    /// are active reputation findings, until the findings are resolved or new violations
    /// occur.
    /// </para>
    /// </summary>
    public partial class UpdateReputationEntityCustomerManagedStatusRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _reputationEntityReference;
        private ReputationEntityType _reputationEntityType;
        private SendingStatus _sendingStatus;

        /// <summary>
        /// Gets and sets the property ReputationEntityReference. 
        /// <para>
        /// The unique identifier for the reputation entity. For resource-type entities, this
        /// is the Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ReputationEntityReference
        {
            get { return this._reputationEntityReference; }
            set { this._reputationEntityReference = value; }
        }

        // Check to see if ReputationEntityReference property is set
        internal bool IsSetReputationEntityReference()
        {
            return this._reputationEntityReference != null;
        }

        /// <summary>
        /// Gets and sets the property ReputationEntityType. 
        /// <para>
        /// The type of reputation entity. Currently, only <c>RESOURCE</c> type entities are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReputationEntityType ReputationEntityType
        {
            get { return this._reputationEntityType; }
            set { this._reputationEntityType = value; }
        }

        // Check to see if ReputationEntityType property is set
        internal bool IsSetReputationEntityType()
        {
            return this._reputationEntityType != null;
        }

        /// <summary>
        /// Gets and sets the property SendingStatus. 
        /// <para>
        /// The new customer-managed sending status for the reputation entity. This can be one
        /// of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – Allow sending for this entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Prevent sending for this entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REINSTATED</c> – Allow sending even if there are active reputation findings.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SendingStatus SendingStatus
        {
            get { return this._sendingStatus; }
            set { this._sendingStatus = value; }
        }

        // Check to see if SendingStatus property is set
        internal bool IsSetSendingStatus()
        {
            return this._sendingStatus != null;
        }

    }
}