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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetBlueprint operation. Retrieves the details
    /// of a blueprint.
    /// </summary>
    public partial class GetBlueprintRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeBlueprint. 
        /// <para>
        /// Specifies whether or not to include the blueprint in the response.
        /// </para>
        /// </summary>
        public bool? IncludeBlueprint { get; set; }

        /// <summary>
        /// Checks to see if the IncludeBlueprint property is set.
        /// </summary>
        internal bool IsSetIncludeBlueprint() => this.IncludeBlueprint.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeParameterSpec. 
        /// <para>
        /// Specifies whether or not to include the parameter specification.
        /// </para>
        /// </summary>
        public bool? IncludeParameterSpec { get; set; }

        /// <summary>
        /// Checks to see if the IncludeParameterSpec property is set.
        /// </summary>
        internal bool IsSetIncludeParameterSpec() => this.IncludeParameterSpec.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
