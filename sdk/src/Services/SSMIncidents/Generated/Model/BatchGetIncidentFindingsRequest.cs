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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetIncidentFindings operation.
    /// Retrieves details about all specified findings for an incident, including descriptive
    /// details about each finding. A finding represents a recent application environment
    /// change made by an CodeDeploy deployment or an CloudFormation stack creation or update
    /// that can be investigated as a potential cause of the incident.
    /// </summary>
    public partial class BatchGetIncidentFindingsRequest : AmazonSSMIncidentsRequest
    {
        private List<string> _findingIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _incidentRecordArn;

        /// <summary>
        /// Gets and sets the property FindingIds. 
        /// <para>
        /// A list of IDs of findings for which you want to view details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<string> FindingIds
        {
            get { return this._findingIds; }
            set { this._findingIds = value; }
        }

        // Check to see if FindingIds property is set
        internal bool IsSetFindingIds()
        {
            return this._findingIds != null && (this._findingIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncidentRecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident for which you want to view finding
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string IncidentRecordArn
        {
            get { return this._incidentRecordArn; }
            set { this._incidentRecordArn = value; }
        }

        // Check to see if IncidentRecordArn property is set
        internal bool IsSetIncidentRecordArn()
        {
            return this._incidentRecordArn != null;
        }

    }
}