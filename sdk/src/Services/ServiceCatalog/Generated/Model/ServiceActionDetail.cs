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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// An object containing detailed information about the self-service action.
    /// </summary>
    public partial class ServiceActionDetail
    {
        private Dictionary<string, string> _definition = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ServiceActionSummary _serviceActionSummary;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// A map that defines the self-service action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public Dictionary<string, string> Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null && (this._definition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceActionSummary. 
        /// <para>
        /// Summary information about the self-service action.
        /// </para>
        /// </summary>
        public ServiceActionSummary ServiceActionSummary
        {
            get { return this._serviceActionSummary; }
            set { this._serviceActionSummary = value; }
        }

        // Check to see if ServiceActionSummary property is set
        internal bool IsSetServiceActionSummary()
        {
            return this._serviceActionSummary != null;
        }

    }
}