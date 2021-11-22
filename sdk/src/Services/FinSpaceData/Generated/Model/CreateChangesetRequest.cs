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
        /// Option to indicate how a Changeset will be applied to a Dataset.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLACE</code> - Changeset will be considered as a replacement to all prior
        /// loaded Changesets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>APPEND</code> - Changeset will be considered as an addition to the end of all
        /// prior loaded Changesets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MODIFY</code> - Changeset is considered as a replacement to a specific prior
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
        /// A token used to ensure idempotency.
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
        ///  <code>PARQUET</code> - Parquet source file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CSV</code> - CSV source file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JSON</code> - JSON source file format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>XML</code> - XML source file format.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, you could specify the following for <code>formatParams</code>:
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
        /// Options that define the location of the data being ingested.
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