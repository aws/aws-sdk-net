/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The result of the DryRun operation. </para>
    /// </summary>
    public class DryRunResult : AmazonWebServiceResponse
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

        // Checks if Message property is set
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

        // Checks if Error property is set
        public bool IsSetError()
        {
            return this.errorField != null;
        }
    }
}
