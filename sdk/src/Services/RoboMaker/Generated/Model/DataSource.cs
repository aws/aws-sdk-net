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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a data source.
    /// </summary>
    public partial class DataSource
    {
        private string _name;
        private string _s3Bucket;
        private List<S3KeyOutput> _s3Keys = new List<S3KeyOutput>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The S3 bucket where the data files are located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Keys. 
        /// <para>
        /// The list of S3 keys identifying the data source files.
        /// </para>
        /// </summary>
        public List<S3KeyOutput> S3Keys
        {
            get { return this._s3Keys; }
            set { this._s3Keys = value; }
        }

        // Check to see if S3Keys property is set
        internal bool IsSetS3Keys()
        {
            return this._s3Keys != null && this._s3Keys.Count > 0; 
        }

    }
}