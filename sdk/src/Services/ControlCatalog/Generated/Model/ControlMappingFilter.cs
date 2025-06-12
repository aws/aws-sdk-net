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
    /// A structure that defines filtering criteria for the ListControlMappings operation.
    /// You can use this filter to narrow down the list of control mappings based on control
    /// ARNs, common control ARNs, or mapping types.
    /// </summary>
    public partial class ControlMappingFilter
    {
        private List<string> _commonControlArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _controlArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _mappingTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CommonControlArns. 
        /// <para>
        /// A list of common control ARNs to filter the mappings. When specified, only mappings
        /// associated with these common controls are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> CommonControlArns
        {
            get { return this._commonControlArns; }
            set { this._commonControlArns = value; }
        }

        // Check to see if CommonControlArns property is set
        internal bool IsSetCommonControlArns()
        {
            return this._commonControlArns != null && (this._commonControlArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ControlArns. 
        /// <para>
        /// A list of control ARNs to filter the mappings. When specified, only mappings associated
        /// with these controls are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ControlArns
        {
            get { return this._controlArns; }
            set { this._controlArns = value; }
        }

        // Check to see if ControlArns property is set
        internal bool IsSetControlArns()
        {
            return this._controlArns != null && (this._controlArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MappingTypes. 
        /// <para>
        /// A list of mapping types to filter the mappings. When specified, only mappings of these
        /// types are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> MappingTypes
        {
            get { return this._mappingTypes; }
            set { this._mappingTypes = value; }
        }

        // Check to see if MappingTypes property is set
        internal bool IsSetMappingTypes()
        {
            return this._mappingTypes != null && (this._mappingTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}