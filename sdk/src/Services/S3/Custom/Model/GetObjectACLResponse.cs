﻿/*
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
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the GetObjectAcl operation.
    /// </summary>
    public partial class GetObjectAclResponse : AmazonWebServiceResponse
    {
        private List<S3Grant> _grants = AWSConfigs.InitializeCollections ? new List<S3Grant>() : null;
        private Owner _owner;
        private RequestCharged _requestCharged;

        /// <summary>
        /// Gets and sets the property Grants. 
        /// <para>
        /// A list of grants.
        /// </para>
        /// </summary>
        public List<S3Grant> Grants
        {
            get { return this._grants; }
            set { this._grants = value; }
        }

        // Check to see if Grants property is set
        internal bool IsSetGrants()
        {
            return this._grants != null && (this._grants.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        ///  Container for the bucket owner's display name and ID.
        /// </para>
        /// </summary>
        public Owner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return !string.IsNullOrEmpty(this._requestCharged);
        }

    }
}