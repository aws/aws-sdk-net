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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
    /// Container for the parameters to the CreateEventDataStore operation.
    /// Creates a new event data store.
    /// </summary>
    public partial class CreateEventDataStoreRequest : AmazonCloudTrailRequest
    {
        private List<AdvancedEventSelector> _advancedEventSelectors = AWSConfigs.InitializeCollections ? new List<AdvancedEventSelector>() : null;
        private BillingMode _billingMode;
        private string _kmsKeyId;
        private bool? _multiRegionEnabled;
        private string _name;
        private bool? _organizationEnabled;
        private int? _retentionPeriod;
        private bool? _startIngestion;
        private List<Tag> _tagsList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _terminationProtectionEnabled;

        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        /// The advanced event selectors to use to select the events for the data store. You can
        /// configure up to five advanced event selectors for each event data store.
        /// </para>
        ///  
        /// <para>
        ///  For more information about how to use advanced event selectors to log CloudTrail
        /// events, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html#creating-data-event-selectors-advanced">Log
        /// events by using advanced event selectors</a> in the CloudTrail User Guide.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use advanced event selectors to include Config configuration
        /// items in your event data store, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-eds-cli.html#lake-cli-create-eds-config">Create
        /// an event data store for Config configuration items</a> in the CloudTrail User Guide.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use advanced event selectors to include events outside
        /// of Amazon Web Services events in your event data store, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-integrations-cli.html#lake-cli-create-integration">Create
        /// an integration to log events from outside Amazon Web Services</a> in the CloudTrail
        /// User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdvancedEventSelector> AdvancedEventSelectors
        {
            get { return this._advancedEventSelectors; }
            set { this._advancedEventSelectors = value; }
        }

        // Check to see if AdvancedEventSelectors property is set
        internal bool IsSetAdvancedEventSelectors()
        {
            return this._advancedEventSelectors != null && (this._advancedEventSelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// The billing mode for the event data store determines the cost for ingesting events
        /// and the default and maximum retention period for the event data store.
        /// </para>
        ///  
        /// <para>
        /// The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EXTENDABLE_RETENTION_PRICING</c> - This billing mode is generally recommended
        /// if you want a flexible retention period of up to 3653 days (about 10 years). The default
        /// retention period for this billing mode is 366 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FIXED_RETENTION_PRICING</c> - This billing mode is recommended if you expect to
        /// ingest more than 25 TB of event data per month and need a retention period of up to
        /// 2557 days (about 7 years). The default retention period for this billing mode is 2557
        /// days.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default value is <c>EXTENDABLE_RETENTION_PRICING</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about CloudTrail pricing, see <a href="http://aws.amazon.com/cloudtrail/pricing/">CloudTrail
        /// Pricing</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-manage-costs.html">Managing
        /// CloudTrail Lake costs</a>.
        /// </para>
        /// </summary>
        public BillingMode BillingMode
        {
            get { return this._billingMode; }
            set { this._billingMode = value; }
        }

        // Check to see if BillingMode property is set
        internal bool IsSetBillingMode()
        {
            return this._billingMode != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specifies the KMS key ID to use to encrypt the events delivered by CloudTrail. The
        /// value can be an alias name prefixed by <c>alias/</c>, a fully specified ARN to an
        /// alias, a fully specified ARN to a key, or a globally unique identifier.
        /// </para>
        ///  <important> 
        /// <para>
        /// Disabling or deleting the KMS key, or removing CloudTrail permissions on the key,
        /// prevents CloudTrail from logging events to the event data store, and prevents users
        /// from querying the data in the event data store that was encrypted with the key. After
        /// you associate an event data store with a KMS key, the KMS key cannot be removed or
        /// changed. Before you disable or delete a KMS key that you are using with an event data
        /// store, delete or back up your event data store.
        /// </para>
        ///  </important> 
        /// <para>
        /// CloudTrail also supports KMS multi-Region keys. For more information about multi-Region
        /// keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>alias/MyAliasName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:kms:us-east-2:123456789012:alias/MyAliasName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>12345678-1234-1234-1234-123456789012</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=350)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionEnabled. 
        /// <para>
        /// Specifies whether the event data store includes events from all Regions, or only from
        /// the Region in which the event data store is created.
        /// </para>
        /// </summary>
        public bool? MultiRegionEnabled
        {
            get { return this._multiRegionEnabled; }
            set { this._multiRegionEnabled = value; }
        }

        // Check to see if MultiRegionEnabled property is set
        internal bool IsSetMultiRegionEnabled()
        {
            return this._multiRegionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
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
        /// Gets and sets the property OrganizationEnabled. 
        /// <para>
        /// Specifies whether an event data store collects events logged for an organization in
        /// Organizations.
        /// </para>
        /// </summary>
        public bool? OrganizationEnabled
        {
            get { return this._organizationEnabled; }
            set { this._organizationEnabled = value; }
        }

        // Check to see if OrganizationEnabled property is set
        internal bool IsSetOrganizationEnabled()
        {
            return this._organizationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The retention period of the event data store, in days. If <c>BillingMode</c> is set
        /// to <c>EXTENDABLE_RETENTION_PRICING</c>, you can set a retention period of up to 3653
        /// days, the equivalent of 10 years. If <c>BillingMode</c> is set to <c>FIXED_RETENTION_PRICING</c>,
        /// you can set a retention period of up to 2557 days, the equivalent of seven years.
        /// </para>
        ///  
        /// <para>
        /// CloudTrail Lake determines whether to retain an event by checking if the <c>eventTime</c>
        /// of the event is within the specified retention period. For example, if you set a retention
        /// period of 90 days, CloudTrail will remove events when the <c>eventTime</c> is older
        /// than 90 days.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you plan to copy trail events to this event data store, we recommend that you consider
        /// both the age of the events that you want to copy as well as how long you want to keep
        /// the copied events in your event data store. For example, if you copy trail events
        /// that are 5 years old and specify a retention period of 7 years, the event data store
        /// will retain those events for two years.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=7, Max=3653)]
        public int? RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartIngestion. 
        /// <para>
        /// Specifies whether the event data store should start ingesting live events. The default
        /// is true.
        /// </para>
        /// </summary>
        public bool? StartIngestion
        {
            get { return this._startIngestion; }
            set { this._startIngestion = value; }
        }

        // Check to see if StartIngestion property is set
        internal bool IsSetStartIngestion()
        {
            return this._startIngestion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagsList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<Tag> TagsList
        {
            get { return this._tagsList; }
            set { this._tagsList = value; }
        }

        // Check to see if TagsList property is set
        internal bool IsSetTagsList()
        {
            return this._tagsList != null && (this._tagsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// Specifies whether termination protection is enabled for the event data store. If termination
        /// protection is enabled, you cannot delete the event data store until termination protection
        /// is disabled.
        /// </para>
        /// </summary>
        public bool? TerminationProtectionEnabled
        {
            get { return this._terminationProtectionEnabled; }
            set { this._terminationProtectionEnabled = value; }
        }

        // Check to see if TerminationProtectionEnabled property is set
        internal bool IsSetTerminationProtectionEnabled()
        {
            return this._terminationProtectionEnabled.HasValue; 
        }

    }
}