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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// This is the response object from the BatchGetStreamKey operation.
    /// </summary>
    public partial class BatchGetStreamKeyResponse : AmazonWebServiceResponse
    {
        private List<BatchError> _errors = new List<BatchError>();
        private List<StreamKey> _streamKeys = new List<StreamKey>();

        /// <summary>
        /// Gets and sets the property Errors.
        /// </summary>
        public List<BatchError> Errors
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
        /// Gets and sets the property StreamKeys.
        /// </summary>
        public List<StreamKey> StreamKeys
        {
            get { return this._streamKeys; }
            set { this._streamKeys = value; }
        }

        // Check to see if StreamKeys property is set
        internal bool IsSetStreamKeys()
        {
            return this._streamKeys != null && this._streamKeys.Count > 0; 
        }

    }
}