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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// A structure that defines filtering criteria for control implementations. You can use
    /// this filter to find controls that are implemented by specific Amazon Web Services
    /// services or with specific service identifiers.
    /// </summary>
    public partial class ImplementationFilter
    {
        private List<string> _identifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _types = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Identifiers. 
        /// <para>
        /// A list of service-specific identifiers that can serve as filters. For example, you
        /// can filter for controls with specific Amazon Web Services Config Rule IDs or Security
        /// Hub Control IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Identifiers
        {
            get { return this._identifiers; }
            set { this._identifiers = value; }
        }

        // Check to see if Identifiers property is set
        internal bool IsSetIdentifiers()
        {
            return this._identifiers != null && (this._identifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// A list of implementation types that can serve as filters. For example, you can filter
        /// for controls implemented as Amazon Web Services Config Rules by specifying AWS::Config::ConfigRule
        /// as a type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && (this._types.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}