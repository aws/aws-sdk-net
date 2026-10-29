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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The detailed configurations of a specified resource.
    /// </summary>
    public partial class BaseConfigurationItem
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account ID associated with the resource.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone associated with the resource.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The region where the resource resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A JSON-encoded string that contains the contents for the resource configuration. This
        /// string needs to be deserialized using <c>json.loads()</c> before you can access the
        /// contents. 
        /// </para>
        /// </summary>
        public string Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ConfigurationItemCaptureTime. 
        /// <para>
        /// The time when the recording of configuration changes was initiated for the resource.
        /// </para>
        /// </summary>
        public DateTime? ConfigurationItemCaptureTime { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationItemCaptureTime property is set.
        /// </summary>
        internal bool IsSetConfigurationItemCaptureTime() => this.ConfigurationItemCaptureTime.HasValue;

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
        public DateTime? ConfigurationItemDeliveryTime { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationItemDeliveryTime property is set.
        /// </summary>
        internal bool IsSetConfigurationItemDeliveryTime() => this.ConfigurationItemDeliveryTime.HasValue;

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
        public ConfigurationItemStatus ConfigurationItemStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationItemStatus property is set.
        /// </summary>
        internal bool IsSetConfigurationItemStatus() => this.ConfigurationItemStatus != null;

        /// <summary>
        /// Gets and sets the property ConfigurationStateId. 
        /// <para>
        /// An identifier that indicates the ordering of the configuration items of a resource.
        /// </para>
        /// </summary>
        public string ConfigurationStateId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationStateId property is set.
        /// </summary>
        internal bool IsSetConfigurationStateId() => this.ConfigurationStateId != null;

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
        public RecordingFrequency RecordingFrequency { get; set; }

        /// <summary>
        /// Checks to see if the RecordingFrequency property is set.
        /// </summary>
        internal bool IsSetRecordingFrequency() => this.RecordingFrequency != null;

        /// <summary>
        /// Gets and sets the property ResourceCreationTime. 
        /// <para>
        /// The time stamp when the resource was created.
        /// </para>
        /// </summary>
        public DateTime? ResourceCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCreationTime property is set.
        /// </summary>
        internal bool IsSetResourceCreationTime() => this.ResourceCreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource (for example., sg-xxxxxx).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 768)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The custom name of the resource, if available.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SupplementaryConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SupplementaryConfiguration property is set.
        /// </summary>
        internal bool IsSetSupplementaryConfiguration() => this.SupplementaryConfiguration != null && (this.SupplementaryConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the resource configuration.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
