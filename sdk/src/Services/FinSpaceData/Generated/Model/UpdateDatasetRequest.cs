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
    /// Container for the parameters to the UpdateDataset operation.
    /// Updates a FinSpace Dataset.
    /// </summary>
    public partial class UpdateDatasetRequest : AmazonFinSpaceDataRequest
    {
        private string _alias;
        private string _clientToken;
        private string _datasetDescription;
        private string _datasetId;
        private string _datasetTitle;
        private DatasetKind _kind;
        private SchemaUnion _schemaDefinition;

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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetDescription. 
        /// <para>
        /// A description for the Dataset.
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
        /// The unique identifier for the Dataset to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
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
        /// A display title for the Dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The format in which the Dataset data is structured.
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
        [AWSProperty(Required=true)]
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

    }
}