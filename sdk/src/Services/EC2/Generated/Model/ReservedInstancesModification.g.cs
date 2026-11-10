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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Reserved Instance modification.
    /// </summary>
    public partial class ReservedInstancesModification
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive key supplied by the client to ensure that the request is
        /// idempotent. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The time when the modification request was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The time for the modification to become effective.
        /// </para>
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveDate property is set.
        /// </summary>
        internal bool IsSetEffectiveDate() => this.EffectiveDate.HasValue;

        /// <summary>
        /// Gets and sets the property ModificationResults. 
        /// <para>
        /// Contains target configurations along with their corresponding new Reserved Instance
        /// IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReservedInstancesModificationResult> ModificationResults { get; set; } = AWSConfigs.InitializeCollections ? new List<ReservedInstancesModificationResult>() : null;

        /// <summary>
        /// Checks to see if the ModificationResults property is set.
        /// </summary>
        internal bool IsSetModificationResults() => this.ModificationResults != null && (this.ModificationResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReservedInstancesIds. 
        /// <para>
        /// The IDs of one or more Reserved Instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReservedInstancesId> ReservedInstancesIds { get; set; } = AWSConfigs.InitializeCollections ? new List<ReservedInstancesId>() : null;

        /// <summary>
        /// Checks to see if the ReservedInstancesIds property is set.
        /// </summary>
        internal bool IsSetReservedInstancesIds() => this.ReservedInstancesIds != null && (this.ReservedInstancesIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReservedInstancesModificationId. 
        /// <para>
        /// A unique ID for the Reserved Instance modification.
        /// </para>
        /// </summary>
        public string ReservedInstancesModificationId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedInstancesModificationId property is set.
        /// </summary>
        internal bool IsSetReservedInstancesModificationId() => this.ReservedInstancesModificationId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Reserved Instances modification request.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The reason for the status.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The time when the modification request was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDate property is set.
        /// </summary>
        internal bool IsSetUpdateDate() => this.UpdateDate.HasValue;
    }
}
