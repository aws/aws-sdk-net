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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Defines a validation error returned by PutPipelineDefinition or ValidatePipelineDefinition. Validation errors prevent pipeline
    /// activation. The set of validation errors that can be returned are defined by AWS Data Pipeline.</para>
    /// </summary>
    public class ValidationError
    {
        
        private string id;
        private List<string> errors = new List<string>();

        /// <summary>
        /// The identifier of the object that contains the validation error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        public ValidationError WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// A description of the validation error.
        ///  
        /// </summary>
        public List<string> Errors
        {
            get { return this.errors; }
            set { this.errors = value; }
        }
        /// <summary>
        /// Adds elements to the Errors collection
        /// </summary>
        /// <param name="errors">The values to add to the Errors collection </param>
        /// <returns>this instance</returns>
        public ValidationError WithErrors(params string[] errors)
        {
            foreach (string element in errors)
            {
                this.errors.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Errors collection
        /// </summary>
        /// <param name="errors">The values to add to the Errors collection </param>
        /// <returns>this instance</returns>
        public ValidationError WithErrors(IEnumerable<string> errors)
        {
            foreach (string element in errors)
            {
                this.errors.Add(element);
            }

            return this;
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this.errors.Count > 0;
        }
    }
}
