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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataset operation.
    /// Creates an empty dataset and adds it to the specified dataset group. Use <a>CreateDatasetImportJob</a>
    /// to import your training data to a dataset.
    /// 
    ///  
    /// <para>
    /// There are three types of datasets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Interactions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Items
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Users
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each dataset type has an associated schema with required field types. Only the <code>Interactions</code>
    /// dataset is required in order to train a model (also referred to as creating a solution).
    /// </para>
    ///  
    /// <para>
    /// A dataset can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DELETE PENDING &gt; DELETE IN_PROGRESS
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the status of the dataset, call <a>DescribeDataset</a>.
    /// </para>
    ///  <p class="title"> <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateDatasetGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListDatasets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeDataset</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteDataset</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDatasetRequest : AmazonPersonalizeRequest
    {
        private string _datasetGroupArn;
        private string _datasetType;
        private string _name;
        private string _schemaArn;

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset group to add the dataset to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The type of dataset.
        /// </para>
        ///  
        /// <para>
        /// One of the following (case insensitive) values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Interactions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Items
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Users
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DatasetType
        {
            get { return this._datasetType; }
            set { this._datasetType = value; }
        }

        // Check to see if DatasetType property is set
        internal bool IsSetDatasetType()
        {
            return this._datasetType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The ARN of the schema to associate with the dataset. The schema defines the dataset
        /// fields.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string SchemaArn
        {
            get { return this._schemaArn; }
            set { this._schemaArn = value; }
        }

        // Check to see if SchemaArn property is set
        internal bool IsSetSchemaArn()
        {
            return this._schemaArn != null;
        }

    }
}