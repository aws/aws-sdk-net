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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the CreateEventDataStore operation.
    /// </summary>
    public partial class CreateEventDataStoreResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        /// The advanced event selectors that were used to select the events for the data store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdvancedEventSelector> AdvancedEventSelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<AdvancedEventSelector>() : null;

        /// <summary>
        /// Checks to see if the AdvancedEventSelectors property is set.
        /// </summary>
        internal bool IsSetAdvancedEventSelectors() => this.AdvancedEventSelectors != null && (this.AdvancedEventSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// The billing mode for the event data store.
        /// </para>
        /// </summary>
        public BillingMode BillingMode { get; set; }

        /// <summary>
        /// Checks to see if the BillingMode property is set.
        /// </summary>
        internal bool IsSetBillingMode() => this.BillingMode != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp that shows when the event data store was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        /// The ARN of the event data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string EventDataStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStoreArn property is set.
        /// </summary>
        internal bool IsSetEventDataStoreArn() => this.EventDataStoreArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specifies the KMS key ID that encrypts the events delivered by CloudTrail. The value
        /// is a fully specified ARN to a KMS key in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 350)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MultiRegionEnabled. 
        /// <para>
        /// Indicates whether the event data store collects events from all Regions, or only from
        /// the Region in which it was created.
        /// </para>
        /// </summary>
        public bool? MultiRegionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionEnabled property is set.
        /// </summary>
        internal bool IsSetMultiRegionEnabled() => this.MultiRegionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OrganizationEnabled. 
        /// <para>
        /// Indicates whether an event data store is collecting logged events for an organization
        /// in Organizations.
        /// </para>
        /// </summary>
        public bool? OrganizationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationEnabled property is set.
        /// </summary>
        internal bool IsSetOrganizationEnabled() => this.OrganizationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The retention period of an event data store, in days.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 3653)]
        public int? RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of event data store creation.
        /// </para>
        /// </summary>
        public EventDataStoreStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TagsList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> TagsList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagsList property is set.
        /// </summary>
        internal bool IsSetTagsList() => this.TagsList != null && (this.TagsList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// Indicates whether termination protection is enabled for the event data store.
        /// </para>
        /// </summary>
        public bool? TerminationProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TerminationProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetTerminationProtectionEnabled() => this.TerminationProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The timestamp that shows when an event data store was updated, if applicable. <c>UpdatedTimestamp</c>
        /// is always either the same or newer than the time shown in <c>CreatedTimestamp</c>.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
