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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ModifyVerifiedAccessGroupPolicy operation.
    /// </summary>
    public partial class ModifyVerifiedAccessGroupPolicyResponse : AmazonWebServiceResponse
    {
        private string _policyDocument;
        private bool? _policyEnabled;
        private VerifiedAccessSseSpecificationResponse _sseSpecification;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The Verified Access policy document.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyEnabled. 
        /// <para>
        /// The status of the Verified Access policy.
        /// </para>
        /// </summary>
        public bool? PolicyEnabled
        {
            get { return this._policyEnabled; }
            set { this._policyEnabled = value; }
        }

        // Check to see if PolicyEnabled property is set
        internal bool IsSetPolicyEnabled()
        {
            return this._policyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SseSpecification. 
        /// <para>
        /// The options in use for server side encryption.
        /// </para>
        /// </summary>
        public VerifiedAccessSseSpecificationResponse SseSpecification
        {
            get { return this._sseSpecification; }
            set { this._sseSpecification = value; }
        }

        // Check to see if SseSpecification property is set
        internal bool IsSetSseSpecification()
        {
            return this._sseSpecification != null;
        }

    }
}