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
    /// Creates a new changeset in a FinSpace dataset.
    /// </summary>
    public partial class CreateChangesetRequest : AmazonFinSpaceDataRequest
    {
        private ChangeType _changeType;
        private string _datasetId;
        private Dictionary<string, string> _formatParams = new Dictionary<string, string>();
        private FormatType _formatType;
        private Dictionary<string, string> _sourceParams = new Dictionary<string, string>();
        private SourceType _sourceType;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// Option to indicate how a changeset will be applied to a dataset.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLACE</code> - Changeset will be considered as a replacement to all prior
        /// loaded changesets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>APPEND</code> - Changeset will be considered as an addition to the end of all
        /// prior loaded changesets.
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
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier for the FinSpace dataset in which the changeset will be created.
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
        /// Options that define the structure of the source file(s).
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FormatType. 
        /// <para>
        /// Format type of the input files being loaded into the changeset.
        /// </para>
        /// </summary>
        public FormatType FormatType
        {
            get { return this._formatType; }
            set { this._formatType = value; }
        }

        // Check to see if FormatType property is set
        internal bool IsSetFormatType()
        {
            return this._formatType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceParams. 
        /// <para>
        /// Source path from which the files to create the changeset will be sourced.
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

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Type of the data source from which the files to create the changeset will be sourced.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>S3</code> - Amazon S3.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags to apply to this changeset.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}