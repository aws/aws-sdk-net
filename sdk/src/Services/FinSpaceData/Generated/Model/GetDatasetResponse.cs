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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Response for the GetDataset operation
    /// </summary>
    public partial class GetDatasetResponse : AmazonWebServiceResponse
    {
        private string _alias;
        private long? _createTime;
        private string _datasetArn;
        private string _datasetDescription;
        private string _datasetId;
        private string _datasetTitle;
        private DatasetKind _kind;
        private long? _lastModifiedTime;
        private SchemaUnion _schemaDefinition;
        private DatasetStatus _status;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The unique resource identifier for a Dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp at which the Dataset was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public long? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The ARN identifier of the Dataset.
        /// </para>
        /// </summary>
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetDescription. 
        /// <para>
        /// A description of the Dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string DatasetDescription
        {
            get { return this._datasetDescription; }
            set { this._datasetDescription = value; }
        }

        // Check to see if DatasetDescription property is set
        internal bool IsSetDatasetDescription()
        {
            return this._datasetDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier for a Dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetTitle. 
        /// <para>
        /// Display title for a Dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DatasetTitle
        {
            get { return this._datasetTitle; }
            set { this._datasetTitle = value; }
        }

        // Check to see if DatasetTitle property is set
        internal bool IsSetDatasetTitle()
        {
            return this._datasetTitle != null;
        }

        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// The format in which Dataset data is structured.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TABULAR</c> – Data is structured in a tabular format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_TABULAR</c> – Data is structured in a non-tabular format.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DatasetKind Kind
        {
            get { return this._kind; }
            set { this._kind = value; }
        }

        // Check to see if Kind property is set
        internal bool IsSetKind()
        {
            return this._kind != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the Dataset was modified. The value is determined as epoch time
        /// in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00 PM UTC
        /// is specified as 1635768000000.
        /// </para>
        /// </summary>
        public long? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchemaDefinition. 
        /// <para>
        /// Definition for a schema on a tabular Dataset.
        /// </para>
        /// </summary>
        public SchemaUnion SchemaDefinition
        {
            get { return this._schemaDefinition; }
            set { this._schemaDefinition = value; }
        }

        // Check to see if SchemaDefinition property is set
        internal bool IsSetSchemaDefinition()
        {
            return this._schemaDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the Dataset creation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – Dataset is pending creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – Dataset creation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – Dataset creation has succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> – Dataset creation is running.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DatasetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}