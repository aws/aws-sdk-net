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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The scope configuration for an Azure connector, defining the tenant or subscription
    /// scope.
    /// </summary>
    public partial class AzureScopeConfiguration
    {
        private ScopeType _scopeType;
        private List<string> _scopeValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ScopeType. 
        /// <para>
        /// The type of scope. Valid values are <c>tenant</c> and <c>subscription</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScopeType ScopeType
        {
            get { return this._scopeType; }
            set { this._scopeType = value; }
        }

        // Check to see if ScopeType property is set
        internal bool IsSetScopeType()
        {
            return this._scopeType != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeValues. 
        /// <para>
        /// The list of scope values, such as subscription IDs, when the scope type is <c>subscription</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ScopeValues
        {
            get { return this._scopeValues; }
            set { this._scopeValues = value; }
        }

        // Check to see if ScopeValues property is set
        internal bool IsSetScopeValues()
        {
            return this._scopeValues != null && (this._scopeValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}