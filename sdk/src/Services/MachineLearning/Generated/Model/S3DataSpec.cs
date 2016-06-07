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
        /// A JSON string that represents the splitting and rearrangement processing to be applied
        /// to a <code>DataSource</code>. If the <code>DataRearrangement</code> parameter is not
        /// provided, all of the input data is used to create the <code>Datasource</code>.
        /// </para>
        ///  
        /// <para>
        /// There are multiple parameters that control what data is used to create a datasource:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <b><code>percentBegin</code></b>
        /// </para>
        ///  
        /// <para>
        /// Use <code>percentBegin</code> to indicate the beginning of the range of the data used
        /// to create the Datasource. If you do not include <code>percentBegin</code> and <code>percentEnd</code>,
        /// Amazon ML includes all of the data when creating the datasource.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <b><code>percentEnd</code></b>
        /// </para>
        ///  
        /// <para>
        /// Use <code>percentEnd</code> to indicate the end of the range of the data used to create
        /// the Datasource. If you do not include <code>percentBegin</code> and <code>percentEnd</code>,
        /// Amazon ML includes all of the data when creating the datasource.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <b><code>complement</code></b>
        /// </para>
        ///  
        /// <para>
        /// The <code>complement</code> parameter instructs Amazon ML to use the data that is
        /// not included in the range of <code>percentBegin</code> to <code>percentEnd</code>
        /// to create a datasource. The <code>complement</code> parameter is useful if you need
        /// to create complementary datasources for training and evaluation. To create a complementary
        /// datasource, use the same values for <code>percentBegin</code> and <code>percentEnd</code>,
        /// along with the <code>complement</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// For example, the following two datasources do not share any data, and can be used
        /// to train and evaluate a model. The first datasource has 25 percent of the data, and
        /// the second one has 75 percent of the data.
        /// </para>
        ///  
        /// <para>
        /// Datasource for evaluation: <code>{"splitting":{"percentBegin":0, "percentEnd":25}}</code>
        /// </para>
        ///  
        /// <para>
        /// Datasource for training: <code>{"splitting":{"percentBegin":0, "percentEnd":25, "complement":"true"}}</code>
        /// </para>
        ///  </li> <li>
        /// <para>
        /// <b><code>strategy</code></b>
        /// </para>
        ///  
        /// <para>
        /// To change how Amazon ML splits the data for a datasource, use the <code>strategy</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// The default value for the <code>strategy</code> parameter is <code>sequential</code>,
        /// meaning that Amazon ML takes all of the data records between the <code>percentBegin</code>
        /// and <code>percentEnd</code> parameters for the datasource, in the order that the records
        /// appear in the input data.
        /// </para>
        ///  
        /// <para>
        /// The following two <code>DataRearrangement</code> lines are examples of sequentially
        /// ordered training and evaluation datasources:
        /// </para>
        ///  
        /// <para>
        /// Datasource for evaluation: <code>{"splitting":{"percentBegin":70, "percentEnd":100,
        /// "strategy":"sequential"}}</code>
        /// </para>
        ///  
        /// <para>
        /// Datasource for training: <code>{"splitting":{"percentBegin":70, "percentEnd":100,
        /// "strategy":"sequential", "complement":"true"}}</code>
        /// </para>
        ///  
        /// <para>
        /// To randomly split the input data into the proportions indicated by the percentBegin
        /// and percentEnd parameters, set the <code>strategy</code> parameter to <code>random</code>
        /// and provide a string that is used as the seed value for the random data splitting
        /// (for example, you can use the S3 path to your data as the random seed string). If
        /// you choose the random split strategy, Amazon ML assigns each row of data a pseudo-random
        /// number between 0 and 100, and then selects the rows that have an assigned number between
        /// <code>percentBegin</code> and <code>percentEnd</code>. Pseudo-random numbers are assigned
        /// using both the input seed string value and the byte offset as a seed, so changing
        /// the data results in a different split. Any existing ordering is preserved. The random
        /// splitting strategy ensures that variables in the training and evaluation data are
        /// distributed similarly. It is useful in the cases where the input data may have an
        /// implicit sort order, which would otherwise result in training and evaluation datasources
        /// containing non-similar data records.
        /// </para>
        ///  
        /// <para>
        /// The following two <code>DataRearrangement</code> lines are examples of non-sequentially
        /// ordered training and evaluation datasources:
        /// </para>
        ///  
        /// <para>
        /// Datasource for evaluation: <code>{"splitting":{"percentBegin":70, "percentEnd":100,
        /// "strategy":"random", "randomSeed"="s3://my_s3_path/bucket/file.csv"}}</code>
        /// </para>
        ///  
        /// <para>
        /// Datasource for training: <code>{"splitting":{"percentBegin":70, "percentEnd":100,
        /// "strategy":"random", "randomSeed"="s3://my_s3_path/bucket/file.csv", "complement":"true"}}</code>
        /// </para>
        ///  </li> </ul>
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
        /// You must provide either the <code>DataSchema</code> or the <code>DataSchemaLocationS3</code>.
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
        /// Describes the schema location in Amazon S3. You must provide either the <code>DataSchema</code>
        /// or the <code>DataSchemaLocationS3</code>.
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