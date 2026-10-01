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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The protected query summary for the objects listed by the request.
    /// </summary>
    public partial class ProtectedQuerySummary
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the protected query was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the protected query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IntermediateTableConfiguration. 
        /// <para>
        /// The intermediate table configuration, present when the protected query was triggered
        /// by a populate operation.
        /// </para>
        /// </summary>
        public IntermediateTableOutputConfiguration IntermediateTableConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateTableConfiguration property is set.
        /// </summary>
        internal bool IsSetIntermediateTableConfiguration() => this.IntermediateTableConfiguration != null;

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The unique ARN for the membership that initiated the protected query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string MembershipArn { get; set; }

        /// <summary>
        /// Checks to see if the MembershipArn property is set.
        /// </summary>
        internal bool IsSetMembershipArn() => this.MembershipArn != null;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The unique ID for the membership that initiated the protected query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property QueryComputePayerAccountId. 
        /// <para>
        /// The account ID of the member that pays for the query compute costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string QueryComputePayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the QueryComputePayerAccountId property is set.
        /// </summary>
        internal bool IsSetQueryComputePayerAccountId() => this.QueryComputePayerAccountId != null;

        /// <summary>
        /// Gets and sets the property ReceiverConfigurations. 
        /// <para>
        ///  The receiver configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ReceiverConfiguration> ReceiverConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ReceiverConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ReceiverConfigurations property is set.
        /// </summary>
        internal bool IsSetReceiverConfigurations() => this.ReceiverConfigurations != null && (this.ReceiverConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the protected query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProtectedQueryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
