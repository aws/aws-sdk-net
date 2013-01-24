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
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> An invalidation batch. </para>
    /// </summary>
    public class InvalidationBatch  
    {
        
        private Paths paths;
        private string callerReference;

        /// <summary>
        /// The path of the object to invalidate. The path is relative to the distribution and must begin with a slash (/). You must enclose each
        /// invalidation object with the Path element tags. If the path includes non-ASCII characters or unsafe characters as defined in RFC 1783
        /// (http://www.ietf.org/rfc/rfc1738.txt), URL encode those characters. Do not URL encode any other characters in the path, or CloudFront will
        /// not invalidate the old version of the updated object.
        ///  
        /// </summary>
        public Paths Paths
        {
            get { return this.paths; }
            set { this.paths = value; }
        }

        /// <summary>
        /// Sets the Paths property
        /// </summary>
        /// <param name="paths">The value to set for the Paths property </param>
        /// <returns>this instance</returns>
        public InvalidationBatch WithPaths(Paths paths)
        {
            this.paths = paths;
            return this;
        }
            

        // Check to see if Paths property is set
        internal bool IsSetPaths()
        {
            return this.paths != null;       
        }

        /// <summary>
        /// A unique name that ensures the request can't be replayed. If the CallerReference is new (no matter the content of the Path object), a new
        /// distribution is created. If the CallerReference is a value you already sent in a previous request to create an invalidation batch, and the
        /// content of each Path element is identical to the original request, the response includes the same information returned to the original
        /// request. If the CallerReference is a value you already sent in a previous request to create a distribution but the content of any Path is
        /// different from the original request, CloudFront returns an InvalidationBatchAlreadyExists error.
        ///  
        /// </summary>
        public string CallerReference
        {
            get { return this.callerReference; }
            set { this.callerReference = value; }
        }

        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">The value to set for the CallerReference property </param>
        /// <returns>this instance</returns>
        public InvalidationBatch WithCallerReference(string callerReference)
        {
            this.callerReference = callerReference;
            return this;
        }
            

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this.callerReference != null;       
        }
    }
}
