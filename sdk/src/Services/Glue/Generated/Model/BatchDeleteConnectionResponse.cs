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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the BatchDeleteConnection operation.
    /// </summary>
    public partial class BatchDeleteConnectionResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, ErrorDetail> _errors = new Dictionary<string, ErrorDetail>();
        private List<string> _succeeded = new List<string>();

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A map of the names of connections that were not successfully deleted to error details.
        /// </para>
        /// </summary>
        public Dictionary<string, ErrorDetail> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Succeeded. 
        /// <para>
        /// A list of names of the connection definitions that were successfully deleted.
        /// </para>
        /// </summary>
        public List<string> Succeeded
        {
            get { return this._succeeded; }
            set { this._succeeded = value; }
        }

        // Check to see if Succeeded property is set
        internal bool IsSetSucceeded()
        {
            return this._succeeded != null && this._succeeded.Count > 0; 
        }

    }
}