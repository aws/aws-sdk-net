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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when using Veeva as a flow source.
    /// </summary>
    public partial class VeevaSourceProperties
    {
        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The document type specified in the Veeva document extract flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string DocumentType { get; set; }

        /// <summary>
        /// Checks to see if the DocumentType property is set.
        /// </summary>
        internal bool IsSetDocumentType() => this.DocumentType != null;

        /// <summary>
        /// Gets and sets the property IncludeAllVersions. 
        /// <para>
        /// Boolean value to include All Versions of files in Veeva document extract flow.
        /// </para>
        /// </summary>
        public bool? IncludeAllVersions { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAllVersions property is set.
        /// </summary>
        internal bool IsSetIncludeAllVersions() => this.IncludeAllVersions.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeRenditions. 
        /// <para>
        /// Boolean value to include file renditions in Veeva document extract flow.
        /// </para>
        /// </summary>
        public bool? IncludeRenditions { get; set; }

        /// <summary>
        /// Checks to see if the IncludeRenditions property is set.
        /// </summary>
        internal bool IsSetIncludeRenditions() => this.IncludeRenditions.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeSourceFiles. 
        /// <para>
        /// Boolean value to include source files in Veeva document extract flow.
        /// </para>
        /// </summary>
        public bool? IncludeSourceFiles { get; set; }

        /// <summary>
        /// Checks to see if the IncludeSourceFiles property is set.
        /// </summary>
        internal bool IsSetIncludeSourceFiles() => this.IncludeSourceFiles.HasValue;

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        ///  The object specified in the Veeva flow source. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string Object { get; set; }

        /// <summary>
        /// Checks to see if the Object property is set.
        /// </summary>
        internal bool IsSetObject() => this.Object != null;
    }
}
