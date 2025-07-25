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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The detailed configurations of a specified resource.
    /// </summary>
    public partial class BaseConfigurationItem
    {
        private string _accountId;
        private string _arn;
        private string _availabilityZone;
        private string _awsRegion;
        private string _configuration;
        private DateTime? _configurationItemCaptureTime;
        private DateTime? _configurationItemDeliveryTime;
        private ConfigurationItemStatus _configurationItemStatus;
        private string _configurationStateId;
        private RecordingFrequency _recordingFrequency;
        private DateTime? _resourceCreationTime;
        private string _resourceId;
        private string _resourceName;
        private ResourceType _resourceType;
        private Dictionary<string, string> _supplementaryConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _version;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account ID associated with the resource.
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
        [AWSProperty(Min=1, Max=64)]
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
        /// A JSON-encoded string that contains the contents for the resource configuration. This
        /// string needs to be deserialized using <c>json.loads()</c> before you can access the
        /// contents. 
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
        /// The time when the recording of configuration changes was initiated for the resource.
        /// </para>
        /// </summary>
        public DateTime? ConfigurationItemCaptureTime
        {
            get { return this._configurationItemCaptureTime; }
            set { this._configurationItemCaptureTime = value; }
        }

        // Check to see if ConfigurationItemCaptureTime property is set
        internal bool IsSetConfigurationItemCaptureTime()
        {
            return this._configurationItemCaptureTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationItemDeliveryTime. 
        /// <para>
        /// The time when configuration changes for the resource were delivered.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional and is not guaranteed to be present in a configuration item
        /// (CI). If you are using daily recording, this field will be populated. However, if
        /// you are using continuous recording, this field will be omitted since the delivery
        /// time is instantaneous as the CI is available right away. For more information on daily
        /// recording and continuous recording, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/select-resources.html#select-resources-recording-frequency">Recording
        /// Frequency</a> in the <i>Config Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? ConfigurationItemDeliveryTime
        {
            get { return this._configurationItemDeliveryTime; }
            set { this._configurationItemDeliveryTime = value; }
        }

        // Check to see if ConfigurationItemDeliveryTime property is set
        internal bool IsSetConfigurationItemDeliveryTime()
        {
            return this._configurationItemDeliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationItemStatus. 
        /// <para>
        /// The configuration item status. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// OK – The resource configuration has been updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ResourceDiscovered – The resource was newly discovered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ResourceNotRecorded – The resource was discovered, but its configuration was not recorded
        /// since the recorder doesn't record resources of this type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ResourceDeleted – The resource was deleted
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ResourceDeletedNotRecorded – The resource was deleted, but its configuration was not
        /// recorded since the recorder doesn't record resources of this type.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property RecordingFrequency. 
        /// <para>
        /// The recording frequency that Config uses to record configuration changes for the resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field only appears in the API response when <c>DAILY</c> recording is enabled
        /// for a resource type. If this field is not present, <c>CONTINUOUS</c> recording is
        /// enabled for that resource type. For more information on daily recording and continuous
        /// recording, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/select-resources.html#select-resources-recording-frequency">Recording
        /// Frequency</a> in the <i>Config Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public RecordingFrequency RecordingFrequency
        {
            get { return this._recordingFrequency; }
            set { this._recordingFrequency = value; }
        }

        // Check to see if RecordingFrequency property is set
        internal bool IsSetRecordingFrequency()
        {
            return this._recordingFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCreationTime. 
        /// <para>
        /// The time stamp when the resource was created.
        /// </para>
        /// </summary>
        public DateTime? ResourceCreationTime
        {
            get { return this._resourceCreationTime; }
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
        /// The ID of the resource (for example., sg-xxxxxx).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=768)]
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
        /// The type of Amazon Web Services resource.
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
        /// A string to string map that contains additional contents for the resource configuration.Config
        /// returns this field for certain resource types to supplement the information returned
        /// for the <c>configuration</c> field.
        /// </para>
        ///  
        /// <para>
        /// This string needs to be deserialized using <c>json.loads()</c> before you can access
        /// the contents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SupplementaryConfiguration
        {
            get { return this._supplementaryConfiguration; }
            set { this._supplementaryConfiguration = value; }
        }

        // Check to see if SupplementaryConfiguration property is set
        internal bool IsSetSupplementaryConfiguration()
        {
            return this._supplementaryConfiguration != null && (this._supplementaryConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
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