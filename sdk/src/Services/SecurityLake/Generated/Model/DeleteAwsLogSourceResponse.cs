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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// This is the response object from the DeleteAwsLogSource operation.
    /// </summary>
    public partial class DeleteAwsLogSourceResponse : AmazonWebServiceResponse
    {
        private List<string> _failed = new List<string>();
        private List<string> _processing = new List<string>();

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// Deletion of the Amazon Web Services sources failed as the account is not a part of
        /// the organization.
        /// </para>
        /// </summary>
        public List<string> Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed != null && this._failed.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Processing. 
        /// <para>
        /// Deletion of the Amazon Web Services sources is in progress.
        /// </para>
        /// </summary>
        public List<string> Processing
        {
            get { return this._processing; }
            set { this._processing = value; }
        }

        // Check to see if Processing property is set
        internal bool IsSetProcessing()
        {
            return this._processing != null && this._processing.Count > 0; 
        }

    }
}