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
using System.Collections.Generic;
using System.Text;

namespace Amazon.Runtime
{
    /// <summary>
    /// This exception is thrown when there is a parse error on the response back from AWS.
    /// </summary>
    public class AmazonUnmarshallingException : AmazonServiceException
    {
        private string lastKnownLocation;

        public AmazonUnmarshallingException(string requestId, string lastKnownLocation, Exception innerException)
            : base("Error unmarshalling response back from AWS.", innerException)
        {
            this.RequestId = requestId;
            this.LastKnownLocation = lastKnownLocation;
        }

        public string LastKnownLocation
        {
            get { return this.lastKnownLocation; }
            private set { this.lastKnownLocation = value; }
        }

        public override string Message
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (!string.IsNullOrEmpty(this.RequestId))
                    sb.AppendFormat("Request ID: {0}", this.RequestId);
                if (!string.IsNullOrEmpty(this.LastKnownLocation))
                    sb.AppendFormat(", Last Parsed Path: {0}", this.LastKnownLocation);

                return base.Message + " " + sb.ToString();
            }
        }
    }
}
