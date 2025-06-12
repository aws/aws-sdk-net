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
    /// Container for the parameters to the UpdateChangeset operation.
    /// Updates a FinSpace Changeset.
    /// </summary>
    public partial class UpdateChangesetRequest : AmazonFinSpaceDataRequest
    {
        private string _changesetId;
        private string _clientToken;
        private string _datasetId;
        private Dictionary<string, string> _formatParams = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _sourceParams = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ChangesetId. 
        /// <para>
        /// The unique identifier for the Changeset to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
        public string ChangesetId
        {
            get { return this._changesetId; }
            set { this._changesetId = value; }
        }

        // Check to see if ChangesetId property is set
        internal bool IsSetChangesetId()
        {
            return this._changesetId != null;
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
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier for the FinSpace Dataset in which the Changeset is created.
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
        /// Gets and sets the property FormatParams. 
        /// <para>
        /// Options that define the structure of the source file(s) including the format type
        /// (<c>formatType</c>), header row (<c>withHeader</c>), data separation character (<c>separator</c>)
        /// and the type of compression (<c>compression</c>). 
        /// </para>
        ///  
        /// <para>
        ///  <c>formatType</c> is a required attribute and can have the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PARQUET</c> – Parquet source file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CSV</c> – CSV source file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JSON</c> – JSON source file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XML</c> – XML source file format.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Here is an example of how you could specify the <c>formatParams</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c> "formatParams": { "formatType": "CSV", "withHeader": "true", "separator": ",",
        /// "compression":"None" } </c> 
        /// </para>
        ///  
        /// <para>
        /// Note that if you only provide <c>formatType</c> as <c>CSV</c>, the rest of the attributes
        /// will automatically default to CSV values as following:
        /// </para>
        ///  
        /// <para>
        ///  <c> { "withHeader": "true", "separator": "," } </c> 
        /// </para>
        ///  
        /// <para>
        ///  For more information about supported file formats, see <a href="https://docs.aws.amazon.com/finspace/latest/userguide/supported-data-types.html">Supported
        /// Data Types and File Formats</a> in the FinSpace User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> FormatParams
        {
            get { return this._formatParams; }
            set { this._formatParams = value; }
        }

        // Check to see if FormatParams property is set
        internal bool IsSetFormatParams()
        {
            return this._formatParams != null && (this._formatParams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceParams. 
        /// <para>
        /// Options that define the location of the data being ingested (<c>s3SourcePath</c>)
        /// and the source of the changeset (<c>sourceType</c>).
        /// </para>
        ///  
        /// <para>
        /// Both <c>s3SourcePath</c> and <c>sourceType</c> are required attributes.
        /// </para>
        ///  
        /// <para>
        /// Here is an example of how you could specify the <c>sourceParams</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c> "sourceParams": { "s3SourcePath": "s3://finspace-landing-us-east-2-bk7gcfvitndqa6ebnvys4d/scratch/wr5hh8pwkpqqkxa4sxrmcw/ingestion/equity.csv",
        /// "sourceType": "S3" } </c> 
        /// </para>
        ///  
        /// <para>
        /// The S3 path that you specify must allow the FinSpace role access. To do that, you
        /// first need to configure the IAM policy on S3 bucket. For more information, see <a
        /// href="https://docs.aws.amazon.com/finspace/latest/data-api/fs-using-the-finspace-api.html#access-s3-buckets">Loading
        /// data from an Amazon S3 Bucket using the FinSpace API</a>section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> SourceParams
        {
            get { return this._sourceParams; }
            set { this._sourceParams = value; }
        }

        // Check to see if SourceParams property is set
        internal bool IsSetSourceParams()
        {
            return this._sourceParams != null && (this._sourceParams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}