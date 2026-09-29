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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents the JSON-specific options that define how input is to be interpreted by
    /// Glue DataBrew.
    /// </summary>
    public partial class JsonOptions
    {
        /// <summary>
        /// Gets and sets the property MultiLine. 
        /// <para>
        /// A value that specifies whether JSON input contains embedded new line characters.
        /// </para>
        /// </summary>
        public bool? MultiLine { get; set; }

        /// <summary>
        /// Checks to see if the MultiLine property is set.
        /// </summary>
        internal bool IsSetMultiLine() => this.MultiLine.HasValue;
    }
}
