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
    /// Selector of a column from a dataset for profile job configuration. One selector includes
    /// either a column name or a regular expression.
    /// </summary>
    public partial class ColumnSelector
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a column from a dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// A regular expression for selecting a column from a dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Regex { get; set; }

        /// <summary>
        /// Checks to see if the Regex property is set.
        /// </summary>
        internal bool IsSetRegex() => this.Regex != null;
    }
}
