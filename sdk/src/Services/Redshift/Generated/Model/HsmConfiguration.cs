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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private string _description;
        private string _hsmConfigurationIdentifier;
        private string _hsmIpAddress;
        private string _hsmPartitionName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A text description of the HSM configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property HsmConfigurationIdentifier. 
        /// <para>
        /// The name of the Amazon Redshift HSM configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string HsmConfigurationIdentifier
        {
            get { return this._hsmConfigurationIdentifier; }
            set { this._hsmConfigurationIdentifier = value; }
        }

        // Check to see if HsmConfigurationIdentifier property is set
        internal bool IsSetHsmConfigurationIdentifier()
        {
            return this._hsmConfigurationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property HsmIpAddress. 
        /// <para>
        /// The IP address that the Amazon Redshift cluster must use to access the HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string HsmIpAddress
        {
            get { return this._hsmIpAddress; }
            set { this._hsmIpAddress = value; }
        }

        // Check to see if HsmIpAddress property is set
        internal bool IsSetHsmIpAddress()
        {
            return this._hsmIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property HsmPartitionName. 
        /// <para>
        /// The name of the partition in the HSM where the Amazon Redshift clusters will store
        /// their database encryption keys.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string HsmPartitionName
        {
            get { return this._hsmPartitionName; }
            set { this._hsmPartitionName = value; }
        }

        // Check to see if HsmPartitionName property is set
        internal bool IsSetHsmPartitionName()
        {
            return this._hsmPartitionName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the HSM configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}