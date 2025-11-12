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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeMetadataModel operation.
    /// </summary>
    public partial class DescribeMetadataModelResponse : AmazonWebServiceResponse
    {
        private string _definition;
        private string _metadataModelName;
        private string _metadataModelType;
        private List<MetadataModelReference> _targetMetadataModels = AWSConfigs.InitializeCollections ? new List<MetadataModelReference>() : null;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The SQL text of the metadata model. This field might not be populated for some metadata
        /// models.
        /// </para>
        /// </summary>
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataModelName. 
        /// <para>
        /// The name of the metadata model.
        /// </para>
        /// </summary>
        public string MetadataModelName
        {
            get { return this._metadataModelName; }
            set { this._metadataModelName = value; }
        }

        // Check to see if MetadataModelName property is set
        internal bool IsSetMetadataModelName()
        {
            return this._metadataModelName != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataModelType. 
        /// <para>
        /// The type of the metadata model.
        /// </para>
        /// </summary>
        public string MetadataModelType
        {
            get { return this._metadataModelType; }
            set { this._metadataModelType = value; }
        }

        // Check to see if MetadataModelType property is set
        internal bool IsSetMetadataModelType()
        {
            return this._metadataModelType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetMetadataModels. 
        /// <para>
        /// A list of counterpart metadata models in the target. This field is populated only
        /// when Origin is SOURCE and after the object has been converted by DMS Schema Conversion.
        /// </para>
        /// </summary>
        public List<MetadataModelReference> TargetMetadataModels
        {
            get { return this._targetMetadataModels; }
            set { this._targetMetadataModels = value; }
        }

        // Check to see if TargetMetadataModels property is set
        internal bool IsSetTargetMetadataModels()
        {
            return this._targetMetadataModels != null && (this._targetMetadataModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}