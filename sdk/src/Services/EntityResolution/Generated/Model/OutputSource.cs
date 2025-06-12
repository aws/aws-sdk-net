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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// A list of <c>OutputAttribute</c> objects, each of which have the fields <c>Name</c>
    /// and <c>Hashed</c>. Each of these objects selects a column to be included in the output
    /// table, and whether the values of the column should be hashed.
    /// </summary>
    public partial class OutputSource
    {
        private bool? _applyNormalization;
        private string _kmsArn;
        private List<OutputAttribute> _output = AWSConfigs.InitializeCollections ? new List<OutputAttribute>() : null;
        private string _outputs3Path;

        /// <summary>
        /// Gets and sets the property ApplyNormalization. 
        /// <para>
        /// Normalizes the attributes defined in the schema in the input data. For example, if
        /// an attribute has an <c>AttributeType</c> of <c>PHONE_NUMBER</c>, and the data in the
        /// input table is in a format of 1234567890, Entity Resolution will normalize this field
        /// in the output to (123)-456-7890.
        /// </para>
        /// </summary>
        public bool? ApplyNormalization
        {
            get { return this._applyNormalization; }
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
        /// A list of <c>OutputAttribute</c> objects, each of which have the fields <c>Name</c>
        /// and <c>Hashed</c>. Each of these objects selects a column to be included in the output
        /// table, and whether the values of the column should be hashed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._output != null && (this._output.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputS3Path. 
        /// <para>
        /// The S3 path to which Entity Resolution will write the output table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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