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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
        private string _documentType;
        private bool? _includeAllVersions;
        private bool? _includeRenditions;
        private bool? _includeSourceFiles;
        private string _object;

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The document type specified in the Veeva document extract flow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string DocumentType
        {
            get { return this._documentType; }
            set { this._documentType = value; }
        }

        // Check to see if DocumentType property is set
        internal bool IsSetDocumentType()
        {
            return this._documentType != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeAllVersions. 
        /// <para>
        /// Boolean value to include All Versions of files in Veeva document extract flow.
        /// </para>
        /// </summary>
        public bool? IncludeAllVersions
        {
            get { return this._includeAllVersions; }
            set { this._includeAllVersions = value; }
        }

        // Check to see if IncludeAllVersions property is set
        internal bool IsSetIncludeAllVersions()
        {
            return this._includeAllVersions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeRenditions. 
        /// <para>
        /// Boolean value to include file renditions in Veeva document extract flow.
        /// </para>
        /// </summary>
        public bool? IncludeRenditions
        {
            get { return this._includeRenditions; }
            set { this._includeRenditions = value; }
        }

        // Check to see if IncludeRenditions property is set
        internal bool IsSetIncludeRenditions()
        {
            return this._includeRenditions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeSourceFiles. 
        /// <para>
        /// Boolean value to include source files in Veeva document extract flow.
        /// </para>
        /// </summary>
        public bool? IncludeSourceFiles
        {
            get { return this._includeSourceFiles; }
            set { this._includeSourceFiles = value; }
        }

        // Check to see if IncludeSourceFiles property is set
        internal bool IsSetIncludeSourceFiles()
        {
            return this._includeSourceFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        ///  The object specified in the Veeva flow source. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Object
        {
            get { return this._object; }
            set { this._object = value; }
        }

        // Check to see if Object property is set
        internal bool IsSetObject()
        {
            return this._object != null;
        }

    }
}