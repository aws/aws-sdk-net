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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// A list of <code>OutputAttribute</code> objects, each of which have the fields <code>Name</code>
    /// and <code>Hashed</code>. Each of these objects selects a column to be included in
    /// the output table, and whether the values of the column should be hashed.
    /// </summary>
    public partial class OutputSource
    {
        private bool? _applyNormalization;
        private string _kmsArn;
        private List<OutputAttribute> _output = new List<OutputAttribute>();
        private string _outputs3Path;

        /// <summary>
        /// Gets and sets the property ApplyNormalization. 
        /// <para>
        /// Normalizes the attributes defined in the schema in the input data. For example, if
        /// an attribute has an <code>AttributeType</code> of <code>PHONE_NUMBER</code>, and the
        /// data in the input table is in a format of 1234567890, Entity Resolution will normalize
        /// this field in the output to (123)-456-7890.
        /// </para>
        /// </summary>
        public bool ApplyNormalization
        {
            get { return this._applyNormalization.GetValueOrDefault(); }
            set { this._applyNormalization = value; }
        }

        // Check to see if ApplyNormalization property is set
        internal bool IsSetApplyNormalization()
        {
            return this._applyNormalization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSArn. 
        /// <para>
        /// Customer KMS ARN for encryption at rest. If not provided, system will use an Entity
        /// Resolution managed KMS key.
        /// </para>
        /// </summary>
        public string KMSArn
        {
            get { return this._kmsArn; }
            set { this._kmsArn = value; }
        }

        // Check to see if KMSArn property is set
        internal bool IsSetKMSArn()
        {
            return this._kmsArn != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// A list of <code>OutputAttribute</code> objects, each of which have the fields <code>Name</code>
        /// and <code>Hashed</code>. Each of these objects selects a column to be included in
        /// the output table, and whether the values of the column should be hashed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=750)]
        public List<OutputAttribute> Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null && this._output.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputS3Path. 
        /// <para>
        /// The S3 path to which Entity Resolution will write the output table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputS3Path
        {
            get { return this._outputs3Path; }
            set { this._outputs3Path = value; }
        }

        // Check to see if OutputS3Path property is set
        internal bool IsSetOutputS3Path()
        {
            return this._outputs3Path != null;
        }

    }
}