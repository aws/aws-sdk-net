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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes the data source that contains the data to upload to a dataset, or the list
    /// of records to delete from Amazon Personalize.
    /// </summary>
    public partial class DataSource
    {
        private string _dataLocation;

        /// <summary>
        /// Gets and sets the property DataLocation. 
        /// <para>
        /// For dataset import jobs, the path to the Amazon S3 bucket where the data that you
        /// want to upload to your dataset is stored. For data deletion jobs, the path to the
        /// Amazon S3 bucket that stores the list of records to delete. 
        /// </para>
        ///  
        /// <para>
        ///  For example: 
        /// </para>
        ///  
        /// <para>
        ///  <c>s3://bucket-name/folder-name/fileName.csv</c> 
        /// </para>
        ///  
        /// <para>
        /// If your CSV files are in a folder in your Amazon S3 bucket and you want your import
        /// job or data deletion job to consider multiple files, you can specify the path to the
        /// folder. With a data deletion job, Amazon Personalize uses all files in the folder
        /// and any sub folder. Use the following syntax with a <c>/</c> after the folder name:
        /// </para>
        ///  
        /// <para>
        ///  <c>s3://bucket-name/folder-name/</c> 
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