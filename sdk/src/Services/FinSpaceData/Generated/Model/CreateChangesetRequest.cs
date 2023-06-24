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

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChangeset operation.
    /// Creates a new Changeset in a FinSpace Dataset.
    /// </summary>
    public partial class CreateChangesetRequest : AmazonFinSpaceDataRequest
    {
        private ChangeType _changeType;
        private string _clientToken;
        private string _datasetId;
        private Dictionary<string, string> _formatParams = new Dictionary<string, string>();
        private Dictionary<string, string> _sourceParams = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// The option to indicate how a Changeset will be applied to a Dataset.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLACE</code> – Changeset will be considered as a replacement to all prior
        /// loaded Changesets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>APPEND</code> – Changeset will be considered as an addition to the end of all
        /// prior loaded Changesets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MODIFY</code> – Changeset is considered as a replacement to a specific prior
        /// ingested Changeset.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeType ChangeType
        {
            get { return this._changeType; }
            set { this._changeType = value; }
        }

        // Check to see if ChangeType property is set
        internal bool IsSetChangeType()
        {
            return this._changeType != null;
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
        /// The unique identifier for the FinSpace Dataset where the Changeset will be created.
        /// 
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
        /// (<code>formatType</code>), header row (<code>withHeader</code>), data separation character
        /// (<code>separator</code>) and the type of compression (<code>compression</code>). 
        /// </para>
        ///  
        /// <para>
        ///  <code>formatType</code> is a required attribute and can have the following values:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PARQUET</code> – Parquet source file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CSV</code> – CSV source file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JSON</code> – JSON source file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>XML</code> – XML source file format.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Here is an example of how you could specify the <code>formatParams</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code> "formatParams": { "formatType": "CSV", "withHeader": "true", "separator":
        /// ",", "compression":"None" } </code> 
        /// </para>
        ///  
        /// <para>
        /// Note that if you only provide <code>formatType</code> as <code>CSV</code>, the rest
        /// of the attributes will automatically default to CSV values as following:
        /// </para>
        ///  
        /// <para>
        ///  <code> { "withHeader": "true", "separator": "," } </code> 
        /// </para>
        ///  
        /// <para>
        ///  For more information about supported file formats, see <a href="https://docs.aws.amazon.com/finspace/latest/userguide/supported-data-types.html">Supported
        /// Data Types and File Formats</a> in the FinSpace User Guide.
        /// </para>
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
            return this._formatParams != null && this._formatParams.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceParams. 
        /// <para>
        /// Options that define the location of the data being ingested (<code>s3SourcePath</code>)
        /// and the source of the changeset (<code>sourceType</code>).
        /// </para>
        ///  
        /// <para>
        /// Both <code>s3SourcePath</code> and <code>sourceType</code> are required attributes.
        /// </para>
        ///  
        /// <para>
        /// Here is an example of how you could specify the <code>sourceParams</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code> "sourceParams": { "s3SourcePath": "s3://finspace-landing-us-east-2-bk7gcfvitndqa6ebnvys4d/scratch/wr5hh8pwkpqqkxa4sxrmcw/ingestion/equity.csv",
        /// "sourceType": "S3" } </code> 
        /// </para>
        ///  
        /// <para>
        /// The S3 path that you specify must allow the FinSpace role access. To do that, you
        /// first need to configure the IAM policy on S3 bucket. For more information, see <a
        /// href="https://docs.aws.amazon.com/finspace/latest/data-api/fs-using-the-finspace-api.html#access-s3-buckets">Loading
        /// data from an Amazon S3 Bucket using the FinSpace API</a> section.
        /// </para>
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
            return this._sourceParams != null && this._sourceParams.Count > 0; 
        }

    }
}