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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the RestoreObject response metadata.
    /// The RestoreObject operation has a void result type.
    /// </summary>
    public partial class RestoreObjectResponse : AmazonWebServiceResponse
    {
        private RequestCharged requestCharged;
        private string restoreOutputPath;

        /// <summary>
        /// If present, indicates that the requester was successfully charged for the request.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this.requestCharged; }
            set { this.requestCharged = value; }
        }

        /// <summary>
        /// Checks to see if RequestCharged is set.
        /// </summary>
        /// <returns>true, if RequestCharged property is set.</returns>
        internal bool IsSetRequestCharged()
        {
            return requestCharged != null;
        }

        /// <summary>
        /// Indicates the path in the provided S3 output location where Select results will be restored to.
        /// </summary>
        public string RestoreOutputPath
        {
            get { return this.restoreOutputPath; }
            set { this.restoreOutputPath = value; }
        }

        internal bool IsSetRestoreOutputPath()
        {
            return this.RestoreOutputPath != null;
        }
    }
}
    
