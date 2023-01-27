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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a Hudi data source stored in Amazon S3.
    /// </summary>
    public partial class S3HudiSource
    {
        private Dictionary<string, string> _additionalHudiOptions = new Dictionary<string, string>();
        private S3DirectSourceAdditionalOptions _additionalOptions;
        private string _name;
        private List<GlueSchema> _outputSchemas = new List<GlueSchema>();
        private List<string> _paths = new List<string>();

        /// <summary>
        /// Gets and sets the property AdditionalHudiOptions. 
        /// <para>
        /// Specifies additional connection options.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalHudiOptions
        {
            get { return this._additionalHudiOptions; }
            set { this._additionalHudiOptions = value; }
        }

        // Check to see if AdditionalHudiOptions property is set
        internal bool IsSetAdditionalHudiOptions()
        {
            return this._additionalHudiOptions != null && this._additionalHudiOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalOptions.
        /// </summary>
        public S3DirectSourceAdditionalOptions AdditionalOptions
        {
            get { return this._additionalOptions; }
            set { this._additionalOptions = value; }
        }

        // Check to see if AdditionalOptions property is set
        internal bool IsSetAdditionalOptions()
        {
            return this._additionalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Hudi source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// Specifies the data schema for the Hudi source.
        /// </para>
        /// </summary>
        public List<GlueSchema> OutputSchemas
        {
            get { return this._outputSchemas; }
            set { this._outputSchemas = value; }
        }

        // Check to see if OutputSchemas property is set
        internal bool IsSetOutputSchemas()
        {
            return this._outputSchemas != null && this._outputSchemas.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Paths. 
        /// <para>
        /// A list of the Amazon S3 paths to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Paths
        {
            get { return this._paths; }
            set { this._paths = value; }
        }

        // Check to see if Paths property is set
        internal bool IsSetPaths()
        {
            return this._paths != null && this._paths.Count > 0; 
        }

    }
}