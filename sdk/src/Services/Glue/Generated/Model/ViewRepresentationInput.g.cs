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
    /// A structure containing details of a representation to update or create a Lake Formation
    /// view.
    /// </summary>
    public partial class ViewRepresentationInput
    {
        /// <summary>
        /// Gets and sets the property Dialect. 
        /// <para>
        /// A parameter that specifies the engine type of a specific representation.
        /// </para>
        /// </summary>
        public ViewDialect Dialect { get; set; }

        /// <summary>
        /// Checks to see if the Dialect property is set.
        /// </summary>
        internal bool IsSetDialect() => this.Dialect != null;

        /// <summary>
        /// Gets and sets the property DialectVersion. 
        /// <para>
        /// A parameter that specifies the version of the engine of a specific representation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DialectVersion { get; set; }

        /// <summary>
        /// Checks to see if the DialectVersion property is set.
        /// </summary>
        internal bool IsSetDialectVersion() => this.DialectVersion != null;

        /// <summary>
        /// Gets and sets the property ValidationConnection. 
        /// <para>
        /// The name of the connection to be used to validate the specific representation of the
        /// view.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ValidationConnection { get; set; }

        /// <summary>
        /// Checks to see if the ValidationConnection property is set.
        /// </summary>
        internal bool IsSetValidationConnection() => this.ValidationConnection != null;

        /// <summary>
        /// Gets and sets the property ViewExpandedText. 
        /// <para>
        /// A string that represents the SQL query that describes the view with expanded resource
        /// ARNs
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 409600)]
        public string ViewExpandedText { get; set; }

        /// <summary>
        /// Checks to see if the ViewExpandedText property is set.
        /// </summary>
        internal bool IsSetViewExpandedText() => this.ViewExpandedText != null;

        /// <summary>
        /// Gets and sets the property ViewOriginalText. 
        /// <para>
        /// A string that represents the original SQL query that describes the view.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 409600)]
        public string ViewOriginalText { get; set; }

        /// <summary>
        /// Checks to see if the ViewOriginalText property is set.
        /// </summary>
        internal bool IsSetViewOriginalText() => this.ViewOriginalText != null;
    }
}
