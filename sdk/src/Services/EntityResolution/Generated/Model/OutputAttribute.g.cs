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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// A list of <c>OutputAttribute</c> objects, each of which have the fields <c>Name</c>
    /// and <c>Hashed</c>. Each of these objects selects a column to be included in the output
    /// table, and whether the values of the column should be hashed.
    /// </summary>
    public partial class OutputAttribute
    {
        /// <summary>
        /// Gets and sets the property Hashed. 
        /// <para>
        /// Enables the ability to hash the column values in the output.
        /// </para>
        /// </summary>
        public bool? Hashed { get; set; }

        /// <summary>
        /// Checks to see if the Hashed property is set.
        /// </summary>
        internal bool IsSetHashed() => this.Hashed.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name of a column to be written to the output. This must be an <c>InputField</c>
        /// name in the schema mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
