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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the BatchDeleteFeaturedResultsSet operation.
    /// </summary>
    public partial class BatchDeleteFeaturedResultsSetResponse : AmazonWebServiceResponse
    {
        private List<BatchDeleteFeaturedResultsSetError> _errors = new List<BatchDeleteFeaturedResultsSetError>();

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// The list of errors for the featured results set IDs, explaining why they couldn't
        /// be removed from the index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchDeleteFeaturedResultsSetError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

    }
}