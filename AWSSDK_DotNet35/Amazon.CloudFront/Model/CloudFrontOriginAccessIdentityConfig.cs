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
    /// <para> Origin access identity configuration. </para>
    /// </summary>
    public class CloudFrontOriginAccessIdentityConfig
    {
        
        private string callerReference;
        private string comment;


        /// <summary>
        /// A unique number that ensures the request can't be replayed. If the CallerReference is new (no matter the content of the
        /// CloudFrontOriginAccessIdentityConfig object), a new origin access identity is created. If the CallerReference is a value you already sent in
        /// a previous request to create an identity, and the content of the CloudFrontOriginAccessIdentityConfig is identical to the original request
        /// (ignoring white space), the response includes the same information returned to the original request. If the CallerReference is a value you
        /// already sent in a previous request to create an identity but the content of the CloudFrontOriginAccessIdentityConfig is different from the
        /// original request, CloudFront returns a CloudFrontOriginAccessIdentityAlreadyExists error.
        ///  
        /// </summary>
        public string CallerReference
        {
            get { return this.callerReference; }
            set { this.callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this.callerReference != null;
        }

        /// <summary>
        /// Any comments you want to include about the origin access identity.
        ///  
        /// </summary>
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this.comment != null;
        }
    }
}
