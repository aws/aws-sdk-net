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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Limits for given InstanceType and for each of it's role. <br/> Limits contains following
    /// <c> <a>StorageTypes,</a> </c> <c> <a>InstanceLimits</a> </c> and <c> <a>AdditionalLimits</a>
    /// </c>
    /// </summary>
    public partial class Limits
    {
        private List<AdditionalLimit> _additionalLimits = AWSConfigs.InitializeCollections ? new List<AdditionalLimit>() : null;
        private InstanceLimits _instanceLimits;
        private List<StorageType> _storageTypes = AWSConfigs.InitializeCollections ? new List<StorageType>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalLimits. 
        /// <para>
        ///  List of additional limits that are specific to a given InstanceType and for each
        /// of it's <c> <a>InstanceRole</a> </c> . 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalLimit> AdditionalLimits
        {
            get { return this._additionalLimits; }
            set { this._additionalLimits = value; }
        }

        // Check to see if AdditionalLimits property is set
        internal bool IsSetAdditionalLimits()
        {
            return this._additionalLimits != null && (this._additionalLimits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceLimits.
        /// </summary>
        public InstanceLimits InstanceLimits
        {
            get { return this._instanceLimits; }
            set { this._instanceLimits = value; }
        }

        // Check to see if InstanceLimits property is set
        internal bool IsSetInstanceLimits()
        {
            return this._instanceLimits != null;
        }

        /// <summary>
        /// Gets and sets the property StorageTypes. 
        /// <para>
        /// StorageType represents the list of storage related types and attributes that are available
        /// for given InstanceType. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StorageType> StorageTypes
        {
            get { return this._storageTypes; }
            set { this._storageTypes = value; }
        }

        // Check to see if StorageTypes property is set
        internal bool IsSetStorageTypes()
        {
            return this._storageTypes != null && (this._storageTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}