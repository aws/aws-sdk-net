/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFindings operation.
    /// Updates the AWS Security Hub-aggregated findings specified by the filter attributes.
    /// </summary>
    public partial class UpdateFindingsRequest : AmazonSecurityHubRequest
    {
        private AwsSecurityFindingFilters _filters;
        private NoteUpdate _note;
        private RecordState _recordState;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A collection of attributes that specify what findings you want to update.
        /// </para>
        /// </summary>
        public AwsSecurityFindingFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// The updated note for the finding.
        /// </para>
        /// </summary>
        public NoteUpdate Note
        {
            get { return this._note; }
            set { this._note = value; }
        }

        // Check to see if Note property is set
        internal bool IsSetNote()
        {
            return this._note != null;
        }

        /// <summary>
        /// Gets and sets the property RecordState. 
        /// <para>
        /// The updated record state for the finding.
        /// </para>
        /// </summary>
        public RecordState RecordState
        {
            get { return this._recordState; }
            set { this._recordState = value; }
        }

        // Check to see if RecordState property is set
        internal bool IsSetRecordState()
        {
            return this._recordState != null;
        }

    }
}