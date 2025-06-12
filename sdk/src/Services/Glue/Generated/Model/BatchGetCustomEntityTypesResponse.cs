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
    /// This is the response object from the BatchGetCustomEntityTypes operation.
    /// </summary>
    public partial class BatchGetCustomEntityTypesResponse : AmazonWebServiceResponse
    {
        private List<CustomEntityType> _customEntityTypes = AWSConfigs.InitializeCollections ? new List<CustomEntityType>() : null;
        private List<string> _customEntityTypesNotFound = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CustomEntityTypes. 
        /// <para>
        /// A list of <c>CustomEntityType</c> objects representing the custom patterns that have
        /// been created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomEntityType> CustomEntityTypes
        {
            get { return this._customEntityTypes; }
            set { this._customEntityTypes = value; }
        }

        // Check to see if CustomEntityTypes property is set
        internal bool IsSetCustomEntityTypes()
        {
            return this._customEntityTypes != null && (this._customEntityTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomEntityTypesNotFound. 
        /// <para>
        /// A list of the names of custom patterns that were not found.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> CustomEntityTypesNotFound
        {
            get { return this._customEntityTypesNotFound; }
            set { this._customEntityTypesNotFound = value; }
        }

        // Check to see if CustomEntityTypesNotFound property is set
        internal bool IsSetCustomEntityTypesNotFound()
        {
            return this._customEntityTypesNotFound != null && (this._customEntityTypesNotFound.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}