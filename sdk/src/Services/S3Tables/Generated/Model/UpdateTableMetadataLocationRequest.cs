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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTableMetadataLocation operation.
    /// Updates the metadata location for a table. The metadata location of a table must be
    /// an S3 URI that begins with the table's warehouse location. The metadata location for
    /// an Apache Iceberg table must end with <c>.metadata.json</c>, or if the metadata file
    /// is Gzip-compressed, <c>.metadata.json.gz</c>.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3tables:UpdateTableMetadataLocation</c> permission to use this
    /// operation. 
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class UpdateTableMetadataLocationRequest : AmazonS3TablesRequest
    {
        private string _metadataLocation;
        private string _name;
        private string _awsNamespace;
        private string _tableBucketARN;
        private string _versionToken;

        /// <summary>
        /// Gets and sets the property MetadataLocation. 
        /// <para>
        /// The new metadata location for the table. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string MetadataLocation
        {
            get { return this._metadataLocation; }
            set { this._metadataLocation = value; }
        }

        // Check to see if MetadataLocation property is set
        internal bool IsSetMetadataLocation()
        {
            return this._metadataLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableBucketARN
        {
            get { return this._tableBucketARN; }
            set { this._tableBucketARN = value; }
        }

        // Check to see if TableBucketARN property is set
        internal bool IsSetTableBucketARN()
        {
            return this._tableBucketARN != null;
        }

        /// <summary>
        /// Gets and sets the property VersionToken. 
        /// <para>
        /// The version token of the table. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string VersionToken
        {
            get { return this._versionToken; }
            set { this._versionToken = value; }
        }

        // Check to see if VersionToken property is set
        internal bool IsSetVersionToken()
        {
            return this._versionToken != null;
        }

    }
}