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
    /// This is the response object from the UpdateTableMetadataLocation operation.
    /// </summary>
    public partial class UpdateTableMetadataLocationResponse : AmazonWebServiceResponse
    {
        private string _metadataLocation;
        private string _name;
        private List<string> _awsNamespace = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tablearn;
        private string _versionToken;

        /// <summary>
        /// Gets and sets the property MetadataLocation. 
        /// <para>
        /// The metadata location of the table.
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
        /// The namespace the table is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null && (this._awsNamespace.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TableARN
        {
            get { return this._tablearn; }
            set { this._tablearn = value; }
        }

        // Check to see if TableARN property is set
        internal bool IsSetTableARN()
        {
            return this._tablearn != null;
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