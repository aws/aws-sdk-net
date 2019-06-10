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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes the data source that contains the data to upload to a dataset.
    /// </summary>
    public partial class DataSource
    {
        private string _dataLocation;

        /// <summary>
        /// Gets and sets the property DataLocation. 
        /// <para>
        /// The path to the Amazon S3 bucket where the data that you want to upload to your dataset
        /// is stored. For example: 
        /// </para>
        ///  
        /// <para>
        ///  <code>s3://bucket-name/training-data.csv</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DataLocation
        {
            get { return this._dataLocation; }
            set { this._dataLocation = value; }
        }

        // Check to see if DataLocation property is set
        internal bool IsSetDataLocation()
        {
            return this._dataLocation != null;
        }

    }
}