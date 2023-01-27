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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Information about the progress of a pre-upgrade dry run analysis.
    /// </summary>
    public partial class DryRunProgressStatus
    {
        private string _creationDate;
        private string _dryRunId;
        private string _dryRunStatus;
        private string _updateDate;
        private List<ValidationFailure> _validationFailures = new List<ValidationFailure>();

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The timestamp when the dry run was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property DryRunId. 
        /// <para>
        /// The unique identifier of the dry run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string DryRunId
        {
            get { return this._dryRunId; }
            set { this._dryRunId = value; }
        }

        // Check to see if DryRunId property is set
        internal bool IsSetDryRunId()
        {
            return this._dryRunId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRunStatus. 
        /// <para>
        /// The current status of the dry run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DryRunStatus
        {
            get { return this._dryRunStatus; }
            set { this._dryRunStatus = value; }
        }

        // Check to see if DryRunStatus property is set
        internal bool IsSetDryRunStatus()
        {
            return this._dryRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The timestamp when the dry run was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UpdateDate
        {
            get { return this._updateDate; }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationFailures. 
        /// <para>
        /// Any validation failures that occurred as a result of the dry run.
        /// </para>
        /// </summary>
        public List<ValidationFailure> ValidationFailures
        {
            get { return this._validationFailures; }
            set { this._validationFailures = value; }
        }

        // Check to see if ValidationFailures property is set
        internal bool IsSetValidationFailures()
        {
            return this._validationFailures != null && this._validationFailures.Count > 0; 
        }

    }
}