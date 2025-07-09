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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// This is the response object from the GetIdentitySource operation.
    /// </summary>
    public partial class GetIdentitySourceResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _identitySourceArn;
        private IdentitySourceParametersForGet _identitySourceParameters;
        private IdentitySourceType _identitySourceType;
        private IdentitySourceStatus _status;
        private IdentitySourceStatusCode _statusCode;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Timestamp when the identity source was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentitySourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string IdentitySourceArn
        {
            get { return this._identitySourceArn; }
            set { this._identitySourceArn = value; }
        }

        // Check to see if IdentitySourceArn property is set
        internal bool IsSetIdentitySourceArn()
        {
            return this._identitySourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentitySourceParameters. 
        /// <para>
        /// A <c> IdentitySourceParameters</c> object. Contains details for the resource that
        /// provides identities to the identity source. For example, an IAM Identity Center instance.
        /// </para>
        /// </summary>
        public IdentitySourceParametersForGet IdentitySourceParameters
        {
            get { return this._identitySourceParameters; }
            set { this._identitySourceParameters = value; }
        }

        // Check to see if IdentitySourceParameters property is set
        internal bool IsSetIdentitySourceParameters()
        {
            return this._identitySourceParameters != null;
        }

        /// <summary>
        /// Gets and sets the property IdentitySourceType. 
        /// <para>
        /// The type of resource that provided identities to the identity source. For example,
        /// an IAM Identity Center instance.
        /// </para>
        /// </summary>
        public IdentitySourceType IdentitySourceType
        {
            get { return this._identitySourceType; }
            set { this._identitySourceType = value; }
        }

        // Check to see if IdentitySourceType property is set
        internal bool IsSetIdentitySourceType()
        {
            return this._identitySourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status for the identity source. For example, if the identity source is <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        public IdentitySourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Status code of the identity source.
        /// </para>
        /// </summary>
        public IdentitySourceStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Message describing the status for the identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}