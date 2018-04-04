/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// A list that contains detailed configurations of a specified resource.
    /// </summary>
    public partial class ConfigurationItem
    {
        private string _accountId;
        private string _arn;
        private string _availabilityZone;
        private string _awsRegion;
        private string _configuration;
        private DateTime? _configurationItemCaptureTime;
        private string _configurationItemMD5Hash;
        private ConfigurationItemStatus _configurationItemStatus;
        private string _configurationStateId;
        private List<string> _relatedEvents = new List<string>();
        private List<Relationship> _relationships = new List<Relationship>();
        private DateTime? _resourceCreationTime;
        private string _resourceId;
        private string _resourceName;
        private ResourceType _resourceType;
        private Dictionary<string, string> _supplementaryConfiguration = new Dictionary<string, string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _version;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit AWS account ID associated with the resource.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
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
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone associated with the resource.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The region where the resource resides.
        /// </para>
        /// </summary>
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The description of the resource configuration.
        /// </para>
        /// </summary>
        public string Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationItemCaptureTime. 
        /// <para>
        /// The time when the configuration recording was initiated.
        /// </para>
        /// </summary>
        public DateTime ConfigurationItemCaptureTime
        {
            get { return this._configurationItemCaptureTime.GetValueOrDefault(); }
            set { this._configurationItemCaptureTime = value; }
        }

        // Check to see if ConfigurationItemCaptureTime property is set
        internal bool IsSetConfigurationItemCaptureTime()
        {
            return this._configurationItemCaptureTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationItemMD5Hash. 
        /// <para>
        /// Unique MD5 hash that represents the configuration item's state.
        /// </para>
        ///  
        /// <para>
        /// You can use MD5 hash to compare the states of two or more configuration items that
        /// are associated with the same resource.
        /// </para>
        /// </summary>
        public string ConfigurationItemMD5Hash
        {
            get { return this._configurationItemMD5Hash; }
            set { this._configurationItemMD5Hash = value; }
        }

        // Check to see if ConfigurationItemMD5Hash property is set
        internal bool IsSetConfigurationItemMD5Hash()
        {
            return this._configurationItemMD5Hash != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationItemStatus. 
        /// <para>
        /// The configuration item status.
        /// </para>
        /// </summary>
        public ConfigurationItemStatus ConfigurationItemStatus
        {
            get { return this._configurationItemStatus; }
            set { this._configurationItemStatus = value; }
        }

        // Check to see if ConfigurationItemStatus property is set
        internal bool IsSetConfigurationItemStatus()
        {
            return this._configurationItemStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationStateId. 
        /// <para>
        /// An identifier that indicates the ordering of the configuration items of a resource.
        /// </para>
        /// </summary>
        public string ConfigurationStateId
        {
            get { return this._configurationStateId; }
            set { this._configurationStateId = value; }
        }

        // Check to see if ConfigurationStateId property is set
        internal bool IsSetConfigurationStateId()
        {
            return this._configurationStateId != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedEvents. 
        /// <para>
        /// A list of CloudTrail event IDs.
        /// </para>
        ///  
        /// <para>
        /// A populated field indicates that the current configuration was initiated by the events
        /// recorded in the CloudTrail log. For more information about CloudTrail, see <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">What
        /// Is AWS CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        /// An empty field indicates that the current configuration was not initiated by any event.
        /// </para>
        /// </summary>
        public List<string> RelatedEvents
        {
            get { return this._relatedEvents; }
            set { this._relatedEvents = value; }
        }

        // Check to see if RelatedEvents property is set
        internal bool IsSetRelatedEvents()
        {
            return this._relatedEvents != null && this._relatedEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Relationships. 
        /// <para>
        /// A list of related AWS resources.
        /// </para>
        /// </summary>
        public List<Relationship> Relationships
        {
            get { return this._relationships; }
            set { this._relationships = value; }
        }

        // Check to see if Relationships property is set
        internal bool IsSetRelationships()
        {
            return this._relationships != null && this._relationships.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceCreationTime. 
        /// <para>
        /// The time stamp when the resource was created.
        /// </para>
        /// </summary>
        public DateTime ResourceCreationTime
        {
            get { return this._resourceCreationTime.GetValueOrDefault(); }
            set { this._resourceCreationTime = value; }
        }

        // Check to see if ResourceCreationTime property is set
        internal bool IsSetResourceCreationTime()
        {
            return this._resourceCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource (for example, <code>sg-xxxxxx</code>).
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The custom name of the resource, if available.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of AWS resource.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SupplementaryConfiguration. 
        /// <para>
        /// Configuration attributes that AWS Config returns for certain resource types to supplement
        /// the information returned for the <code>configuration</code> parameter.
        /// </para>
        /// </summary>
        public Dictionary<string, string> SupplementaryConfiguration
        {
            get { return this._supplementaryConfiguration; }
            set { this._supplementaryConfiguration = value; }
        }

        // Check to see if SupplementaryConfiguration property is set
        internal bool IsSetSupplementaryConfiguration()
        {
            return this._supplementaryConfiguration != null && this._supplementaryConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A mapping of key value tags associated with the resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the resource configuration.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}