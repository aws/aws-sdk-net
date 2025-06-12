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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetCollaborationAnalysisTemplate operation.
    /// Retrieves multiple analysis templates within a collaboration by their Amazon Resource
    /// Names (ARNs).
    /// </summary>
    public partial class BatchGetCollaborationAnalysisTemplateRequest : AmazonCleanRoomsRequest
    {
        private List<string> _analysisTemplateArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _collaborationIdentifier;

        /// <summary>
        /// Gets and sets the property AnalysisTemplateArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the analysis template within a collaboration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> AnalysisTemplateArns
        {
            get { return this._analysisTemplateArns; }
            set { this._analysisTemplateArns = value; }
        }

        // Check to see if AnalysisTemplateArns property is set
        internal bool IsSetAnalysisTemplateArns()
        {
            return this._analysisTemplateArns != null && (this._analysisTemplateArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// A unique identifier for the collaboration that the analysis templates belong to. Currently
        /// accepts collaboration ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationIdentifier
        {
            get { return this._collaborationIdentifier; }
            set { this._collaborationIdentifier = value; }
        }

        // Check to see if CollaborationIdentifier property is set
        internal bool IsSetCollaborationIdentifier()
        {
            return this._collaborationIdentifier != null;
        }

    }
}