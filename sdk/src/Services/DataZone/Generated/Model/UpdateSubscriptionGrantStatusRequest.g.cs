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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscriptionGrantStatus operation. Updates
    /// the status of the specified subscription grant status in Amazon DataZone.
    /// </summary>
    public partial class UpdateSubscriptionGrantStatusRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AssetIdentifier. 
        /// <para>
        /// The identifier of the asset the subscription grant status of which is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AssetIdentifier property is set.
        /// </summary>
        internal bool IsSetAssetIdentifier() => this.AssetIdentifier != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which a subscription grant status
        /// is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property FailureCause. 
        /// <para>
        /// Specifies the error message that is returned if the operation cannot be successfully
        /// completed.
        /// </para>
        /// </summary>
        public FailureCause FailureCause { get; set; }

        /// <summary>
        /// Checks to see if the FailureCause property is set.
        /// </summary>
        internal bool IsSetFailureCause() => this.FailureCause != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the subscription grant the status of which is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status to be updated as part of the <c>UpdateSubscriptionGrantStatus</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionGrantStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The target name to be updated as part of the <c>UpdateSubscriptionGrantStatus</c>
        /// action.
        /// </para>
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// Checks to see if the TargetName property is set.
        /// </summary>
        internal bool IsSetTargetName() => this.TargetName != null;
    }
}
