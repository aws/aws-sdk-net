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
    /// This is the response object from the BatchDescribeMergeConflicts operation.
    /// </summary>
    public partial class BatchDescribeMergeConflictsResponse : AmazonWebServiceResponse
    {
        private string _baseCommitId;
        private List<Conflict> _conflicts = AWSConfigs.InitializeCollections ? new List<Conflict>() : null;
        private string _destinationCommitId;
        private List<BatchDescribeMergeConflictsError> _errors = AWSConfigs.InitializeCollections ? new List<BatchDescribeMergeConflictsError>() : null;
        private string _nextToken;
        private string _sourceCommitId;

        /// <summary>
        /// Gets and sets the property BaseCommitId. 
        /// <para>
        /// The commit ID of the merge base.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Conflicts. 
        /// <para>
        /// A list of conflicts for each file, including the conflict metadata and the hunks of
        /// the differences between the files.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Conflict> Conflicts
        {
            get { return this._conflicts; }
            set { this._conflicts = value; }
        }

        // Check to see if Conflicts property is set
        internal bool IsSetConflicts()
        {
            return this._conflicts != null && (this._conflicts.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of any errors returned while describing the merge conflicts for each file.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchDescribeMergeConflictsError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that can be used in a request to return the next batch of the
        /// results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
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