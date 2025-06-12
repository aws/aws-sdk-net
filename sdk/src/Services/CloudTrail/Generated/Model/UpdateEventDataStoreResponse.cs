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
    /// This is the response object from the UpdateEventDataStore operation.
    /// </summary>
    public partial class UpdateEventDataStoreResponse : AmazonWebServiceResponse
    {
        private List<AdvancedEventSelector> _advancedEventSelectors = AWSConfigs.InitializeCollections ? new List<AdvancedEventSelector>() : null;
        private BillingMode _billingMode;
        private DateTime? _createdTimestamp;
        private string _eventDataStoreArn;
        private string _federationRoleArn;
        private FederationStatus _federationStatus;
        private string _kmsKeyId;
        private bool? _multiRegionEnabled;
        private string _name;
        private bool? _organizationEnabled;
        private int? _retentionPeriod;
        private EventDataStoreStatus _status;
        private bool? _terminationProtectionEnabled;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        /// The advanced event selectors that are applied to the event data store.
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
        /// The billing mode for the event data store.
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp that shows when an event data store was first created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        /// The ARN of the event data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string EventDataStoreArn
        {
            get { return this._eventDataStoreArn; }
            set { this._eventDataStoreArn = value; }
        }

        // Check to see if EventDataStoreArn property is set
        internal bool IsSetEventDataStoreArn()
        {
            return this._eventDataStoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property FederationRoleArn. 
        /// <para>
        ///  If Lake query federation is enabled, provides the ARN of the federation role used
        /// to access the resources for the federated event data store. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=125)]
        public string FederationRoleArn
        {
            get { return this._federationRoleArn; }
            set { this._federationRoleArn = value; }
        }

        // Check to see if FederationRoleArn property is set
        internal bool IsSetFederationRoleArn()
        {
            return this._federationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property FederationStatus. 
        /// <para>
        ///  Indicates the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation.html">Lake
        /// query federation</a> status. The status is <c>ENABLED</c> if Lake query federation
        /// is enabled, or <c>DISABLED</c> if Lake query federation is disabled. You cannot delete
        /// an event data store if the <c>FederationStatus</c> is <c>ENABLED</c>. 
        /// </para>
        /// </summary>
        public FederationStatus FederationStatus
        {
            get { return this._federationStatus; }
            set { this._federationStatus = value; }
        }

        // Check to see if FederationStatus property is set
        internal bool IsSetFederationStatus()
        {
            return this._federationStatus != null;
        }

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
        /// Indicates whether the event data store includes events from all Regions, or only from
        /// the Region in which it was created.
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
        [AWSProperty(Min=3, Max=128)]
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
        /// Indicates whether an event data store is collecting logged events for an organization
        /// in Organizations.
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
        /// The retention period, in days.
        /// </para>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of an event data store.
        /// </para>
        /// </summary>
        public EventDataStoreStatus Status
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
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// Indicates whether termination protection is enabled for the event data store.
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

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The timestamp that shows when the event data store was last updated. <c>UpdatedTimestamp</c>
        /// is always either the same or newer than the time shown in <c>CreatedTimestamp</c>.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp
        {
            get { return this._updatedTimestamp; }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}