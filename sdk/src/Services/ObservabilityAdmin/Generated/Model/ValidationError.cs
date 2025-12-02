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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Represents a detailed validation error with message, reason, and field mapping for
    /// comprehensive error reporting.
    /// </summary>
    public partial class ValidationError
    {
        private Dictionary<string, string> _fieldMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _message;
        private string _reason;

        /// <summary>
        /// Gets and sets the property FieldMap. 
        /// <para>
        /// A mapping of field names to specific validation issues within the configuration.
        /// </para>
        /// </summary>
        public Dictionary<string, string> FieldMap
        {
            get { return this._fieldMap; }
            set { this._fieldMap = value; }
        }

        // Check to see if FieldMap property is set
        internal bool IsSetFieldMap()
        {
            return this._fieldMap != null && (this._fieldMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error message describing the validation issue.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason code or category for the validation error.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}