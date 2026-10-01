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
    /// This is the response object from the GetMLInputChannel operation.
    /// </summary>
    public partial class GetMLInputChannelResponse : AmazonWebServiceResponse
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
        /// The configured model algorithm associations that were used to create the ML input
        /// channel.
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
        /// Gets and sets the property InputChannel. 
        /// <para>
        /// The input channel that was used to create the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputChannel InputChannel { get; set; }

        /// <summary>
        /// Checks to see if the InputChannel property is set.
        /// </summary>
        internal bool IsSetInputChannel() => this.InputChannel != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key that was used to create the ML input
        /// channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

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
        /// Gets and sets the property NumberOfFiles. 
        /// <para>
        /// The number of files in the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public double? NumberOfFiles { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfFiles property is set.
        /// </summary>
        internal bool IsSetNumberOfFiles() => this.NumberOfFiles.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfRecords. 
        /// <para>
        /// The number of records in the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100000000000)]
        public long? NumberOfRecords { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfRecords property is set.
        /// </summary>
        internal bool IsSetNumberOfRecords() => this.NumberOfRecords.HasValue;

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
        /// Gets and sets the property PrivacyBudgets. 
        /// <para>
        /// Returns the privacy budgets that control access to this Clean Rooms ML input channel.
        /// Use these budgets to monitor and limit resource consumption over specified time periods.
        /// </para>
        /// </summary>
        public PrivacyBudgets PrivacyBudgets { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyBudgets property is set.
        /// </summary>
        internal bool IsSetPrivacyBudgets() => this.PrivacyBudgets != null;

        /// <summary>
        /// Gets and sets the property ProtectedQueryIdentifier. 
        /// <para>
        /// The ID of the protected query that was used to create the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ProtectedQueryIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProtectedQueryIdentifier property is set.
        /// </summary>
        internal bool IsSetProtectedQueryIdentifier() => this.ProtectedQueryIdentifier != null;

        /// <summary>
        /// Gets and sets the property RetentionInDays. 
        /// <para>
        /// The number of days to keep the data in the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionInDays property is set.
        /// </summary>
        internal bool IsSetRetentionInDays() => this.RetentionInDays.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size, in GB, of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public double? SizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the SizeInGb property is set.
        /// </summary>
        internal bool IsSetSizeInGb() => this.SizeInGb.HasValue;

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
        /// Gets and sets the property StatusDetails.
        /// </summary>
        public StatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property SyntheticDataConfiguration. 
        /// <para>
        /// The synthetic data configuration for this ML input channel, including parameters for
        /// generating privacy-preserving synthetic data and evaluation scores for measuring the
        /// privacy of the generated data.
        /// </para>
        /// </summary>
        public SyntheticDataConfiguration SyntheticDataConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SyntheticDataConfiguration property is set.
        /// </summary>
        internal bool IsSetSyntheticDataConfiguration() => this.SyntheticDataConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you applied to the resource to help you categorize and
        /// organize them. Each tag consists of a key and an optional value, both of which you
        /// define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use aws:, AWS:, or any upper or lowercase combination of such as a prefix for
        /// keys as it is reserved for AWS use. You cannot edit or delete tag keys with this prefix.
        /// Values can have this prefix. If a tag value has aws as its prefix but the key does
        /// not, then Clean Rooms ML considers it to be a user tag and will count against the
        /// limit of 50 tags. Tags with only the key prefix of aws do not count against your tags
        /// per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
