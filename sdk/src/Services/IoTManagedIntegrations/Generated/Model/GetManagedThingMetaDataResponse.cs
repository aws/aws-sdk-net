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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// This is the response object from the GetManagedThingMetaData operation.
    /// </summary>
    public partial class GetManagedThingMetaDataResponse : AmazonWebServiceResponse
    {
        private string _managedThingId;
        private Dictionary<string, string> _metaData = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ManagedThingId. 
        /// <para>
        /// The managed thing id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ManagedThingId
        {
            get { return this._managedThingId; }
            set { this._managedThingId = value; }
        }

        // Check to see if ManagedThingId property is set
        internal bool IsSetManagedThingId()
        {
            return this._managedThingId != null;
        }

        /// <summary>
        /// Gets and sets the property MetaData. 
        /// <para>
        /// The metadata for the managed thing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> MetaData
        {
            get { return this._metaData; }
            set { this._metaData = value; }
        }

        // Check to see if MetaData property is set
        internal bool IsSetMetaData()
        {
            return this._metaData != null && (this._metaData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}