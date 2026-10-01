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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// A unique identifier for an attribute.
    /// </summary>
    public partial class AttributeKey
    {
        /// <summary>
        /// Gets and sets the property FacetName. 
        /// <para>
        /// The name of the facet that the attribute exists within.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FacetName { get; set; }

        /// <summary>
        /// Checks to see if the FacetName property is set.
        /// </summary>
        internal bool IsSetFacetName() => this.FacetName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 230)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the schema that contains the facet and attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SchemaArn { get; set; }

        /// <summary>
        /// Checks to see if the SchemaArn property is set.
        /// </summary>
        internal bool IsSetSchemaArn() => this.SchemaArn != null;
    }
}
