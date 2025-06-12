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
    /// Specifies the supported authentication types returned by the <c>DescribeConnectionType</c>
    /// API.
    /// </summary>
    public partial class Capabilities
    {
        private List<string> _supportedAuthenticationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedComputeEnvironments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedDataOperations = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SupportedAuthenticationTypes. 
        /// <para>
        /// A list of supported authentication types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedAuthenticationTypes
        {
            get { return this._supportedAuthenticationTypes; }
            set { this._supportedAuthenticationTypes = value; }
        }

        // Check to see if SupportedAuthenticationTypes property is set
        internal bool IsSetSupportedAuthenticationTypes()
        {
            return this._supportedAuthenticationTypes != null && (this._supportedAuthenticationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedComputeEnvironments. 
        /// <para>
        /// A list of supported compute environments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedComputeEnvironments
        {
            get { return this._supportedComputeEnvironments; }
            set { this._supportedComputeEnvironments = value; }
        }

        // Check to see if SupportedComputeEnvironments property is set
        internal bool IsSetSupportedComputeEnvironments()
        {
            return this._supportedComputeEnvironments != null && (this._supportedComputeEnvironments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedDataOperations. 
        /// <para>
        /// A list of supported data operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedDataOperations
        {
            get { return this._supportedDataOperations; }
            set { this._supportedDataOperations = value; }
        }

        // Check to see if SupportedDataOperations property is set
        internal bool IsSetSupportedDataOperations()
        {
            return this._supportedDataOperations != null && (this._supportedDataOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}