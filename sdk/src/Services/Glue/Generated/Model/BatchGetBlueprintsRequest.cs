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
    /// Container for the parameters to the BatchGetBlueprints operation.
    /// Retrieves information about a list of blueprints.
    /// </summary>
    public partial class BatchGetBlueprintsRequest : AmazonGlueRequest
    {
        private bool? _includeBlueprint;
        private bool? _includeParameterSpec;
        private List<string> _names = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IncludeBlueprint. 
        /// <para>
        /// Specifies whether or not to include the blueprint in the response.
        /// </para>
        /// </summary>
        public bool? IncludeBlueprint
        {
            get { return this._includeBlueprint; }
            set { this._includeBlueprint = value; }
        }

        // Check to see if IncludeBlueprint property is set
        internal bool IsSetIncludeBlueprint()
        {
            return this._includeBlueprint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeParameterSpec. 
        /// <para>
        /// Specifies whether or not to include the parameters, as a JSON string, for the blueprint
        /// in the response.
        /// </para>
        /// </summary>
        public bool? IncludeParameterSpec
        {
            get { return this._includeParameterSpec; }
            set { this._includeParameterSpec = value; }
        }

        // Check to see if IncludeParameterSpec property is set
        internal bool IsSetIncludeParameterSpec()
        {
            return this._includeParameterSpec.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// A list of blueprint names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && (this._names.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}