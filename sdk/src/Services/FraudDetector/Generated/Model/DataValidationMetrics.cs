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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The model training validation messages.
    /// </summary>
    public partial class DataValidationMetrics
    {
        private List<FieldValidationMessage> _fieldLevelMessages = new List<FieldValidationMessage>();
        private List<FileValidationMessage> _fileLevelMessages = new List<FileValidationMessage>();

        /// <summary>
        /// Gets and sets the property FieldLevelMessages. 
        /// <para>
        /// The field-specific model training validation messages.
        /// </para>
        /// </summary>
        public List<FieldValidationMessage> FieldLevelMessages
        {
            get { return this._fieldLevelMessages; }
            set { this._fieldLevelMessages = value; }
        }

        // Check to see if FieldLevelMessages property is set
        internal bool IsSetFieldLevelMessages()
        {
            return this._fieldLevelMessages != null && this._fieldLevelMessages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FileLevelMessages. 
        /// <para>
        /// The file-specific model training validation messages.
        /// </para>
        /// </summary>
        public List<FileValidationMessage> FileLevelMessages
        {
            get { return this._fileLevelMessages; }
            set { this._fileLevelMessages = value; }
        }

        // Check to see if FileLevelMessages property is set
        internal bool IsSetFileLevelMessages()
        {
            return this._fileLevelMessages != null && this._fileLevelMessages.Count > 0; 
        }

    }
}