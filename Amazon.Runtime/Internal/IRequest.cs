/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Represents a request being sent to an Amazon Web Service, including the
    /// parameters being sent as part of the request, the endpoint to which the
    /// request should be sent, etc.
    /// <para>
    /// This class is only intended for internal use inside the AWS client libraries.
    /// Callers shouldn't ever interact directly with objects of this class.
    /// </para>
    /// </summary>
    /// <typeparam name="T">The type of original, user facing request represented by this request.</typeparam>
    public interface IRequest<T>
    {
        /// <summary>
        /// Returns a dictionary of the headers included in this request.
        /// </summary>
        IDictionary<string, string> Headers
        {
            get;
        }

        /// <summary>
        /// Returns a dictionary of the parameters included in this request.
        /// </summary>
        IDictionary<String, String> Parameters
        {
            get;
        }

        /// <summary>
        /// Gets and Sets the endpoint for this request.
        /// </summary>
        Uri Endpoint
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the service to which this request is being sent.
        /// </summary>
        string ServiceName
        {
            get;
        }

        /// <summary>
        /// Returns the original, user facing request object which this internal
        /// request object is representing.
        /// </summary>
        AmazonWebServiceRequest OriginalRequest
        {
            get;
        }
    }
}
