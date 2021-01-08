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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Returns information about the DryRun response and response metadata.
    /// </summary>
    public class DryRunResponse : Amazon.Runtime.AmazonWebServiceResponse
    {
        private bool? isSuccessfulField;
        private string messageField;
        private Exception errorField;

        /// <summary>
        /// Flag that signals if you have the required permissions to execute the request.
        /// </summary>
        public bool IsSuccessful
        {
            get { return this.isSuccessfulField.GetValueOrDefault(); }
            set { this.isSuccessfulField = value; }
        }

        // Checks if IsSuccessful property is set
        internal bool IsSetIsSuccessful()
        {
            return isSuccessfulField.HasValue;
        }


        /// <summary>
        /// Message associated with the response.
        /// </summary>
        public string Message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
        }

        /// <summary>
        /// Checks if Message property is set
        /// </summary>
        /// <returns></returns>
        public bool IsSetMessage()
        {
            return this.messageField != null;
        }


        /// <summary>
        /// Exception associated with the response, if there was one.
        /// </summary>
        public Exception Error
        {
            get { return this.errorField; }
            set { this.errorField = value; }
        }

        /// <summary>
        /// Checks if Error property is set
        /// </summary>
        /// <returns></returns>
        public bool IsSetError()
        {
            return this.errorField != null;
        }
    }
}
