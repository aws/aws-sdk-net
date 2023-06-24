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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DataModelConfiguration
    {
        private DataModel _dataModel;
        private DataModelS3Configuration _dataModelS3Configuration;

        /// <summary>
        /// Gets and sets the property DataModel.
        /// </summary>
        public DataModel DataModel
        {
            get { return this._dataModel; }
            set { this._dataModel = value; }
        }

        // Check to see if DataModel property is set
        internal bool IsSetDataModel()
        {
            return this._dataModel != null;
        }

        /// <summary>
        /// Gets and sets the property DataModelS3Configuration.
        /// </summary>
        public DataModelS3Configuration DataModelS3Configuration
        {
            get { return this._dataModelS3Configuration; }
            set { this._dataModelS3Configuration = value; }
        }

        // Check to see if DataModelS3Configuration property is set
        internal bool IsSetDataModelS3Configuration()
        {
            return this._dataModelS3Configuration != null;
        }

    }
}