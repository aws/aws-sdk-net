/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Describes the data specification of a <code>DataSource</code>.
    /// </summary>
    public partial class S3DataSpec
    {
        private string _dataLocationS3;
        private string _dataRearrangement;
        private string _dataSchema;
        private string _dataSchemaLocationS3;

        /// <summary>
        /// Gets and sets the property DataLocationS3. 
        /// <para>
        /// The location of the data file(s) used by a <code>DataSource</code>. The URI specifies
        /// a data file or an Amazon Simple Storage Service (Amazon S3) directory or bucket containing
        /// data files.
        /// </para>
        /// </summary>
        public string DataLocationS3
        {
            get { return this._dataLocationS3; }
            set { this._dataLocationS3 = value; }
        }

        // Check to see if DataLocationS3 property is set
        internal bool IsSetDataLocationS3()
        {
            return this._dataLocationS3 != null;
        }

        /// <summary>
        /// Gets and sets the property DataRearrangement. 
        /// <para>
        ///  Describes the splitting requirement of a <code>Datasource</code>.
        /// </para>
        /// </summary>
        public string DataRearrangement
        {
            get { return this._dataRearrangement; }
            set { this._dataRearrangement = value; }
        }

        // Check to see if DataRearrangement property is set
        internal bool IsSetDataRearrangement()
        {
            return this._dataRearrangement != null;
        }

        /// <summary>
        /// Gets and sets the property DataSchema. 
        /// <para>
        ///  A JSON string that represents the schema for an Amazon S3 <code>DataSource</code>.
        /// The <code>DataSchema</code> defines the structure of the observation data in the data
        /// file(s) referenced in the <code>DataSource</code>.
        /// </para>
        ///  
        /// <para>
        /// Define your <code>DataSchema</code> as a series of key-value pairs. <code>attributes</code>
        /// and <code>excludedVariableNames</code> have an array of key-value pairs for their
        /// value. Use the following format to define your <code>DataSchema</code>.
        /// </para>
        ///  
        /// <para>
        /// { "version": "1.0",
        /// </para>
        ///  
        /// <para>
        ///  "recordAnnotationFieldName": "F1",
        /// </para>
        ///  
        /// <para>
        ///  "recordWeightFieldName": "F2",
        /// </para>
        ///  
        /// <para>
        ///  "targetFieldName": "F3",
        /// </para>
        ///  
        /// <para>
        ///  "dataFormat": "CSV",
        /// </para>
        ///  
        /// <para>
        ///  "dataFileContainsHeader": true,
        /// </para>
        ///  
        /// <para>
        ///  "attributes": [
        /// </para>
        ///  
        /// <para>
        ///  { "fieldName": "F1", "fieldType": "TEXT" }, { "fieldName": "F2", "fieldType": "NUMERIC"
        /// }, { "fieldName": "F3", "fieldType": "CATEGORICAL" }, { "fieldName": "F4", "fieldType":
        /// "NUMERIC" }, { "fieldName": "F5", "fieldType": "CATEGORICAL" }, { "fieldName": "F6",
        /// "fieldType": "TEXT" }, { "fieldName": "F7", "fieldType": "WEIGHTED_INT_SEQUENCE" },
        /// { "fieldName": "F8", "fieldType": "WEIGHTED_STRING_SEQUENCE" } ],
        /// </para>
        ///  
        /// <para>
        ///  "excludedVariableNames": [ "F6" ] } 
        /// </para>
        /// </summary>
        public string DataSchema
        {
            get { return this._dataSchema; }
            set { this._dataSchema = value; }
        }

        // Check to see if DataSchema property is set
        internal bool IsSetDataSchema()
        {
            return this._dataSchema != null;
        }

        /// <summary>
        /// Gets and sets the property DataSchemaLocationS3. 
        /// <para>
        /// Describes the schema Location in Amazon S3.
        /// </para>
        /// </summary>
        public string DataSchemaLocationS3
        {
            get { return this._dataSchemaLocationS3; }
            set { this._dataSchemaLocationS3 = value; }
        }

        // Check to see if DataSchemaLocationS3 property is set
        internal bool IsSetDataSchemaLocationS3()
        {
            return this._dataSchemaLocationS3 != null;
        }

    }
}