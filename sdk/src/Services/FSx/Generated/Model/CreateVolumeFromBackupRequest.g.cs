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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVolumeFromBackup operation. Creates a new
    /// Amazon FSx for NetApp ONTAP volume from an existing Amazon FSx volume backup.
    /// </summary>
    public partial class CreateVolumeFromBackupRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property BackupId.
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 128)]
        public string BackupId { get; set; }

        /// <summary>
        /// Checks to see if the BackupId property is set.
        /// </summary>
        internal bool IsSetBackupId() => this.BackupId != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new volume you're creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 203)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OntapConfiguration. 
        /// <para>
        /// Specifies the configuration of the ONTAP volume that you are creating.
        /// </para>
        /// </summary>
        public CreateOntapVolumeConfiguration OntapConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OntapConfiguration property is set.
        /// </summary>
        internal bool IsSetOntapConfiguration() => this.OntapConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
