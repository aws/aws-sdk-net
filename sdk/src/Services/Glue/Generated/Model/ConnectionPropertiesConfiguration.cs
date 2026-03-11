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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Configuration that defines the base URL and additional request parameters needed during
    /// connection creation.
    /// </summary>
    public partial class ConnectionPropertiesConfiguration
    {
        private List<ConnectorProperty> _additionalRequestParameters = AWSConfigs.InitializeCollections ? new List<ConnectorProperty>() : null;
        private ConnectorProperty _url;

        /// <summary>
        /// Gets and sets the property AdditionalRequestParameters. 
        /// <para>
        /// Key-value pairs of additional request parameters that may be needed during connection
        /// creation, such as API versions or service-specific configuration options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorProperty> AdditionalRequestParameters
        {
            get { return this._additionalRequestParameters; }
            set { this._additionalRequestParameters = value; }
        }

        // Check to see if AdditionalRequestParameters property is set
        internal bool IsSetAdditionalRequestParameters()
        {
            return this._additionalRequestParameters != null && (this._additionalRequestParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The base instance URL for the endpoint that this connection type will connect to.
        /// </para>
        /// </summary>
        public ConnectorProperty Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}