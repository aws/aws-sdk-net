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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when the custom connector is being used as a source.
    /// </summary>
    public partial class CustomConnectorSourceProperties
    {
        private Dictionary<string, string> _customProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DataTransferApi _dataTransferApi;
        private string _entityName;

        /// <summary>
        /// Gets and sets the property CustomProperties. 
        /// <para>
        /// Custom properties that are required to use the custom connector as a source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> CustomProperties
        {
            get { return this._customProperties; }
            set { this._customProperties = value; }
        }

        // Check to see if CustomProperties property is set
        internal bool IsSetCustomProperties()
        {
            return this._customProperties != null && (this._customProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataTransferApi. 
        /// <para>
        /// The API of the connector application that Amazon AppFlow uses to transfer your data.
        /// </para>
        /// </summary>
        public DataTransferApi DataTransferApi
        {
            get { return this._dataTransferApi; }
            set { this._dataTransferApi = value; }
        }

        // Check to see if DataTransferApi property is set
        internal bool IsSetDataTransferApi()
        {
            return this._dataTransferApi != null;
        }

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// The entity specified in the custom connector as a source in the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string EntityName
        {
            get { return this._entityName; }
            set { this._entityName = value; }
        }

        // Check to see if EntityName property is set
        internal bool IsSetEntityName()
        {
            return this._entityName != null;
        }

    }
}