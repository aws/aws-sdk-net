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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the ValidateSecurityProfileBehaviors operation.
    /// </summary>
    public partial class ValidateSecurityProfileBehaviorsResponse : AmazonWebServiceResponse
    {
        private bool? _valid;
        private List<ValidationError> _validationErrors = new List<ValidationError>();

        /// <summary>
        /// Gets and sets the property Valid. 
        /// <para>
        /// True if the behaviors were valid.
        /// </para>
        /// </summary>
        public bool Valid
        {
            get { return this._valid.GetValueOrDefault(); }
            set { this._valid = value; }
        }

        // Check to see if Valid property is set
        internal bool IsSetValid()
        {
            return this._valid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationErrors. 
        /// <para>
        /// The list of any errors found in the behaviors.
        /// </para>
        /// </summary>
        public List<ValidationError> ValidationErrors
        {
            get { return this._validationErrors; }
            set { this._validationErrors = value; }
        }

        // Check to see if ValidationErrors property is set
        internal bool IsSetValidationErrors()
        {
            return this._validationErrors != null && this._validationErrors.Count > 0; 
        }

    }
}