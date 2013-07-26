/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains the output of the PutPipelineDefinition action.</para>
    /// </summary>
    public partial class PutPipelineDefinitionResult : AmazonWebServiceResponse
    {
        
        private List<ValidationError> validationErrors = new List<ValidationError>();
        private List<ValidationWarning> validationWarnings = new List<ValidationWarning>();
        private bool? errored;

        /// <summary>
        /// A list of the validation errors that are associated with the objects defined in <c>pipelineObjects</c>.
        ///  
        /// </summary>
        public List<ValidationError> ValidationErrors
        {
            get { return this.validationErrors; }
            set { this.validationErrors = value; }
        }

        // Check to see if ValidationErrors property is set
        internal bool IsSetValidationErrors()
        {
            return this.validationErrors.Count > 0;
        }

        /// <summary>
        /// A list of the validation warnings that are associated with the objects defined in <c>pipelineObjects</c>.
        ///  
        /// </summary>
        public List<ValidationWarning> ValidationWarnings
        {
            get { return this.validationWarnings; }
            set { this.validationWarnings = value; }
        }

        // Check to see if ValidationWarnings property is set
        internal bool IsSetValidationWarnings()
        {
            return this.validationWarnings.Count > 0;
        }

        /// <summary>
        /// If <c>True</c>, there were validation errors. If errored is <c>True</c>, the pipeline definition is stored but cannot be activated until you
        /// correct the pipeline and call <a>PutPipelineDefinition</a> to commit the corrected pipeline.
        ///  
        /// </summary>
        public bool Errored
        {
            get { return this.errored ?? default(bool); }
            set { this.errored = value; }
        }

        // Check to see if Errored property is set
        internal bool IsSetErrored()
        {
            return this.errored.HasValue;
        }
    }
}
