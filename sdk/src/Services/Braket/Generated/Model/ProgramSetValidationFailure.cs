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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Contains information about validation failures that occurred during the processing
    /// of a program set in a quantum task.
    /// </summary>
    public partial class ProgramSetValidationFailure
    {
        private List<string> _errors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _inputsIndex;
        private long? _programIndex;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of error messages describing the validation failures that occurred.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputsIndex. 
        /// <para>
        /// The index of the input within the program set that failed validation.
        /// </para>
        /// </summary>
        public long? InputsIndex
        {
            get { return this._inputsIndex; }
            set { this._inputsIndex = value; }
        }

        // Check to see if InputsIndex property is set
        internal bool IsSetInputsIndex()
        {
            return this._inputsIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgramIndex. 
        /// <para>
        /// The index of the program within the program set that failed validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ProgramIndex
        {
            get { return this._programIndex; }
            set { this._programIndex = value; }
        }

        // Check to see if ProgramIndex property is set
        internal bool IsSetProgramIndex()
        {
            return this._programIndex.HasValue; 
        }

    }
}