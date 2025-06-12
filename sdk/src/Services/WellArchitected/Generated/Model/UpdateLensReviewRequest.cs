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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLensReview operation.
    /// Update lens review for a particular workload.
    /// </summary>
    public partial class UpdateLensReviewRequest : AmazonWellArchitectedRequest
    {
        private JiraSelectedQuestionConfiguration _jiraConfiguration;
        private string _lensAlias;
        private string _lensNotes;
        private Dictionary<string, string> _pillarNotes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _workloadId;

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Configuration of the Jira integration.
        /// </para>
        /// </summary>
        public JiraSelectedQuestionConfiguration JiraConfiguration
        {
            get { return this._jiraConfiguration; }
            set { this._jiraConfiguration = value; }
        }

        // Check to see if JiraConfiguration property is set
        internal bool IsSetJiraConfiguration()
        {
            return this._jiraConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string LensAlias
        {
            get { return this._lensAlias; }
            set { this._lensAlias = value; }
        }

        // Check to see if LensAlias property is set
        internal bool IsSetLensAlias()
        {
            return this._lensAlias != null;
        }

        /// <summary>
        /// Gets and sets the property LensNotes.
        /// </summary>
        [AWSProperty(Max=2084)]
        public string LensNotes
        {
            get { return this._lensNotes; }
            set { this._lensNotes = value; }
        }

        // Check to see if LensNotes property is set
        internal bool IsSetLensNotes()
        {
            return this._lensNotes != null;
        }

        /// <summary>
        /// Gets and sets the property PillarNotes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> PillarNotes
        {
            get { return this._pillarNotes; }
            set { this._pillarNotes = value; }
        }

        // Check to see if PillarNotes property is set
        internal bool IsSetPillarNotes()
        {
            return this._pillarNotes != null && (this._pillarNotes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

    }
}