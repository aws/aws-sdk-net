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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains the output of PutPipelineDefinition.
    /// </summary>
    public partial class PutPipelineDefinitionResponse : AmazonWebServiceResponse
    {
        private bool? _errored;
        private List<ValidationError> _validationErrors = AWSConfigs.InitializeCollections ? new List<ValidationError>() : null;
        private List<ValidationWarning> _validationWarnings = AWSConfigs.InitializeCollections ? new List<ValidationWarning>() : null;

        /// <summary>
        /// Gets and sets the property Errored. 
        /// <para>
        /// Indicates whether there were validation errors, and the pipeline definition is stored
        /// but cannot be activated until you correct the pipeline and call <c>PutPipelineDefinition</c>
        /// to commit the corrected pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Errored
        {
            get { return this._errored; }
            set { this._errored = value; }
        }

        // Check to see if Errored property is set
        internal bool IsSetErrored()
        {
            return this._errored.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationErrors. 
        /// <para>
        /// The validation errors that are associated with the objects defined in <c>pipelineObjects</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ValidationError> ValidationErrors
        {
            get { return this._validationErrors; }
            set { this._validationErrors = value; }
        }

        // Check to see if ValidationErrors property is set
        internal bool IsSetValidationErrors()
        {
            return this._validationErrors != null && (this._validationErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidationWarnings. 
        /// <para>
        /// The validation warnings that are associated with the objects defined in <c>pipelineObjects</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ValidationWarning> ValidationWarnings
        {
            get { return this._validationWarnings; }
            set { this._validationWarnings = value; }
        }

        // Check to see if ValidationWarnings property is set
        internal bool IsSetValidationWarnings()
        {
            return this._validationWarnings != null && (this._validationWarnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}