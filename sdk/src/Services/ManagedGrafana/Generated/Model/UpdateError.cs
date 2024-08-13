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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
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
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// A structure containing information about one error encountered while performing an
    /// <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdatePermissions.html">UpdatePermissions</a>
    /// operation.
    /// </summary>
    public partial class UpdateError
    {
        private UpdateInstruction _causedBy;
        private int? _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property CausedBy. 
        /// <para>
        /// Specifies which permission update caused the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateInstruction CausedBy
        {
            get { return this._causedBy; }
            set { this._causedBy = value; }
        }

        // Check to see if CausedBy property is set
        internal bool IsSetCausedBy()
        {
            return this._causedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=100, Max=999)]
        public int? Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message for this error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}