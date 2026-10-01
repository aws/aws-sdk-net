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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Provides summary information about an ML input channel in a collaboration.
    /// </summary>
    public partial class CollaborationMLInputChannelSummary
    {
        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The collaboration ID of the collaboration that contains the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationIdentifier property is set.
        /// </summary>
        internal bool IsSetCollaborationIdentifier() => this.CollaborationIdentifier != null;

        /// <summary>
        /// Gets and sets the property ConfiguredModelAlgorithmAssociations. 
        /// <para>
        /// The associated configured model algorithms used to create the ML input channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> ConfiguredModelAlgorithmAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConfiguredModelAlgorithmAssociations property is set.
        /// </summary>
        internal bool IsSetConfiguredModelAlgorithmAssociations() => this.ConfiguredModelAlgorithmAssociations != null && (this.ConfiguredModelAlgorithmAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the ML input channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The account ID of the member who created the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string CreatorAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorAccountId property is set.
        /// </summary>
        internal bool IsSetCreatorAccountId() => this.CreatorAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the membership that contains the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property MlInputChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string MlInputChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the MlInputChannelArn property is set.
        /// </summary>
        internal bool IsSetMlInputChannelArn() => this.MlInputChannelArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PayerConfiguration. 
        /// <para>
        /// The payer configuration for the ML input channel.
        /// </para>
        /// </summary>
        public PayerConfiguration PayerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PayerConfiguration property is set.
        /// </summary>
        internal bool IsSetPayerConfiguration() => this.PayerConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MLInputChannelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the ML input channel was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
