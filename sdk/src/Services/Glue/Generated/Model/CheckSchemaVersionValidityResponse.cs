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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the CheckSchemaVersionValidity operation.
    /// </summary>
    public partial class CheckSchemaVersionValidityResponse : AmazonWebServiceResponse
    {
        private string _error;
        private bool? _valid;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// A validation failure error message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Valid. 
        /// <para>
        /// Return true, if the schema is valid and false otherwise.
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

    }
}