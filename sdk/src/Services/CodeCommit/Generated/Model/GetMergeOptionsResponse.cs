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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the GetMergeOptions operation.
    /// </summary>
    public partial class GetMergeOptionsResponse : AmazonWebServiceResponse
    {
        private string _baseCommitId;
        private string _destinationCommitId;
        private List<string> _mergeOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sourceCommitId;

        /// <summary>
        /// Gets and sets the property BaseCommitId. 
        /// <para>
        /// The commit ID of the merge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BaseCommitId
        {
            get { return this._baseCommitId; }
            set { this._baseCommitId = value; }
        }

        // Check to see if BaseCommitId property is set
        internal bool IsSetBaseCommitId()
        {
            return this._baseCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationCommitId. 
        /// <para>
        /// The commit ID of the destination commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationCommitId
        {
            get { return this._destinationCommitId; }
            set { this._destinationCommitId = value; }
        }

        // Check to see if DestinationCommitId property is set
        internal bool IsSetDestinationCommitId()
        {
            return this._destinationCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property MergeOptions. 
        /// <para>
        /// The merge option or strategy used to merge the code.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> MergeOptions
        {
            get { return this._mergeOptions; }
            set { this._mergeOptions = value; }
        }

        // Check to see if MergeOptions property is set
        internal bool IsSetMergeOptions()
        {
            return this._mergeOptions != null && (this._mergeOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceCommitId. 
        /// <para>
        /// The commit ID of the source commit specifier that was used in the merge evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceCommitId
        {
            get { return this._sourceCommitId; }
            set { this._sourceCommitId = value; }
        }

        // Check to see if SourceCommitId property is set
        internal bool IsSetSourceCommitId()
        {
            return this._sourceCommitId != null;
        }

    }
}