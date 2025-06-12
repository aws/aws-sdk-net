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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a data source.
    /// </summary>
    public partial class DataSource
    {
        private string _destination;
        private string _name;
        private string _s3Bucket;
        private List<S3KeyOutput> _s3Keys = AWSConfigs.InitializeCollections ? new List<S3KeyOutput>() : null;
        private DataSourceType _type;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The location where your files are mounted in the container image.
        /// </para>
        ///  
        /// <para>
        /// If you've specified the <c>type</c> of the data source as an <c>Archive</c>, you must
        /// provide an Amazon S3 object key to your archive. The object key must point to either
        /// a <c>.zip</c> or <c>.tar.gz</c> file.
        /// </para>
        ///  
        /// <para>
        /// If you've specified the <c>type</c> of the data source as a <c>Prefix</c>, you provide
        /// the Amazon S3 prefix that points to the files that you are using for your data source.
        /// </para>
        ///  
        /// <para>
        /// If you've specified the <c>type</c> of the data source as a <c>File</c>, you provide
        /// the Amazon S3 path to the file that you're using as your data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3KeyOutput> S3Keys
        {
            get { return this._s3Keys; }
            set { this._s3Keys = value; }
        }

        // Check to see if S3Keys property is set
        internal bool IsSetS3Keys()
        {
            return this._s3Keys != null && (this._s3Keys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type for the data source that you're using for your container image or simulation
        /// job. You can use this field to specify whether your data source is an Archive, an
        /// Amazon S3 prefix, or a file.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a field, the default value is <c>File</c>.
        /// </para>
        /// </summary>
        public DataSourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}