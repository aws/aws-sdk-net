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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The Output data type.
    /// </summary>
    public partial class Output
    {
        private string _description;
        private string _exportName;
        private string _outputKey;
        private string _outputValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// User defined description associated with the output.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExportName. 
        /// <para>
        /// The name of the export associated with the output.
        /// </para>
        /// </summary>
        public string ExportName
        {
            get { return this._exportName; }
            set { this._exportName = value; }
        }

        // Check to see if ExportName property is set
        internal bool IsSetExportName()
        {
            return this._exportName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputKey. 
        /// <para>
        /// The key associated with the output.
        /// </para>
        /// </summary>
        public string OutputKey
        {
            get { return this._outputKey; }
            set { this._outputKey = value; }
        }

        // Check to see if OutputKey property is set
        internal bool IsSetOutputKey()
        {
            return this._outputKey != null;
        }

        /// <summary>
        /// Gets and sets the property OutputValue. 
        /// <para>
        /// The value associated with the output.
        /// </para>
        /// </summary>
        public string OutputValue
        {
            get { return this._outputValue; }
            set { this._outputValue = value; }
        }

        // Check to see if OutputValue property is set
        internal bool IsSetOutputValue()
        {
            return this._outputValue != null;
        }

    }
}