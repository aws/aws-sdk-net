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
using System.Collections.ObjectModel;
using System.Text;

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime
{
    public abstract partial class AmazonWebServiceRequest : IAmazonWebServiceRequest
    {
        /// <summary>
        /// This flag specifies if SigV4 will be used for the current request.
        /// </summary>
        [Obsolete("UseSigV4 is deprecated. Use SignatureVersion directly instead.")]
        bool IAmazonWebServiceRequest.UseSigV4
        {
            get { return UseSigV4; }
            set { UseSigV4 = value; }
        }

        /// <summary>
        /// This flag specifies if SigV4 will be used for the current request.
        /// Returns true if the request will use SigV4.
        /// Setting it to false will use SigV2.
        /// </summary>
        [Obsolete("UseSigV4 is deprecated. Use SignatureVersion directly instead.")]
        protected bool UseSigV4
        {
            get { return ((IAmazonWebServiceRequest)this).SignatureVersion == SignatureVersion.SigV4; }
            set { ((IAmazonWebServiceRequest)this).SignatureVersion = value ? SignatureVersion.SigV4 : SignatureVersion.SigV2; }
        }

        /// <summary>
        /// Specifies which signature version will be used for the current request.
        /// </summary>
        SignatureVersion IAmazonWebServiceRequest.SignatureVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets a value indicating if "Expect: 100-continue" HTTP header will be 
        /// sent by the client for this request. The default value is false.
        /// </summary>
        protected virtual bool Expect100Continue
        {
            get { return false; }
        }

        internal bool GetExpect100Continue()
        {
            return this.Expect100Continue;
        }

        protected virtual bool IncludeSHA256Header
        {
            get { return true; }
        }

        internal bool GetIncludeSHA256Header()
        {
            return this.IncludeSHA256Header;
        }

        /// <summary>
        /// Gets the signer to use for this request.
        /// A null return value indicates to use the configured
        /// signer for the service that this request is part of.
        /// </summary>
        /// <returns>A signer for this request, or null.</returns>
        protected virtual AbstractAWSSigner CreateSigner()
        {
            return null;
        }

        internal AbstractAWSSigner GetSigner()
        {
            return CreateSigner();
        }

        /// <summary>
        /// Checksum validation behavior for validating the integrity of this request's response
        /// </summary>
        protected internal virtual CoreChecksumResponseBehavior CoreChecksumMode => CoreChecksumResponseBehavior.DISABLED;

        /// <summary>
        /// Checksum algorithms that are supported for validating the integrity of this request's response
        /// </summary>
        protected internal virtual ReadOnlyCollection<CoreChecksumAlgorithm> ChecksumResponseAlgorithms => new List<CoreChecksumAlgorithm>(0).AsReadOnly();
    }
}
