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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Specifies S3 configuration information for the input data for the data ingestion
    /// job.
    /// </summary>
    public partial class IngestionS3InputConfiguration
    {
        private string _bucket;
        private string _keyPattern;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the S3 bucket used for the input data for the data ingestion. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPattern. 
        /// <para>
        ///  The pattern for matching the Amazon S3 files that will be used for ingestion. If
        /// the schema was created previously without any KeyPattern, then the default KeyPattern
        /// {prefix}/{component_name}/* is used to download files from Amazon S3 according to
        /// the schema. This field is required when ingestion is being done for the first time.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: {prefix}/{component_name}_* | {prefix}/{component_name}/* | {prefix}/{component_name}[DELIMITER]*
        /// (Allowed delimiters : space, dot, underscore, hyphen)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KeyPattern
        {
            get { return this._keyPattern; }
            set { this._keyPattern = value; }
        }

        // Check to see if KeyPattern property is set
        internal bool IsSetKeyPattern()
        {
            return this._keyPattern != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix for the S3 location being used for the input data for the data ingestion.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}