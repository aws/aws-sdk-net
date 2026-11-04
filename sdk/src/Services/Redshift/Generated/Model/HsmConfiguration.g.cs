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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns information about an HSM configuration, which is an object that describes
    /// to Amazon Redshift clusters the information they require to connect to an HSM where
    /// they can store database encryption keys.
    /// </summary>
    public partial class HsmConfiguration
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A text description of the HSM configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HsmConfigurationIdentifier. 
        /// <para>
        /// The name of the Amazon Redshift HSM configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string HsmConfigurationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the HsmConfigurationIdentifier property is set.
        /// </summary>
        internal bool IsSetHsmConfigurationIdentifier() => this.HsmConfigurationIdentifier != null;

        /// <summary>
        /// Gets and sets the property HsmIpAddress. 
        /// <para>
        /// The IP address that the Amazon Redshift cluster must use to access the HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string HsmIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the HsmIpAddress property is set.
        /// </summary>
        internal bool IsSetHsmIpAddress() => this.HsmIpAddress != null;

        /// <summary>
        /// Gets and sets the property HsmPartitionName. 
        /// <para>
        /// The name of the partition in the HSM where the Amazon Redshift clusters will store
        /// their database encryption keys.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string HsmPartitionName { get; set; }

        /// <summary>
        /// Checks to see if the HsmPartitionName property is set.
        /// </summary>
        internal bool IsSetHsmPartitionName() => this.HsmPartitionName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the HSM configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
