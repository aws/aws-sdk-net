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
    /// This is the response object from the BatchGetCollaborationAnalysisTemplate operation.
    /// </summary>
    public partial class BatchGetCollaborationAnalysisTemplateResponse : AmazonWebServiceResponse
    {
        private List<CollaborationAnalysisTemplate> _collaborationAnalysisTemplates = AWSConfigs.InitializeCollections ? new List<CollaborationAnalysisTemplate>() : null;
        private List<BatchGetCollaborationAnalysisTemplateError> _errors = AWSConfigs.InitializeCollections ? new List<BatchGetCollaborationAnalysisTemplateError>() : null;

        /// <summary>
        /// Gets and sets the property CollaborationAnalysisTemplates. 
        /// <para>
        /// The retrieved list of analysis templates within a collaboration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<CollaborationAnalysisTemplate> CollaborationAnalysisTemplates
        {
            get { return this._collaborationAnalysisTemplates; }
            set { this._collaborationAnalysisTemplates = value; }
        }

        // Check to see if CollaborationAnalysisTemplates property is set
        internal bool IsSetCollaborationAnalysisTemplates()
        {
            return this._collaborationAnalysisTemplates != null && (this._collaborationAnalysisTemplates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Error reasons for collaboration analysis templates that could not be retrieved. One
        /// error is returned for every collaboration analysis template that could not be retrieved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<BatchGetCollaborationAnalysisTemplateError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}