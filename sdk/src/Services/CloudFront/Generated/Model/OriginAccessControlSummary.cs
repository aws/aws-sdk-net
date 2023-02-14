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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A CloudFront origin access control.
    /// </summary>
    public partial class OriginAccessControlSummary
    {
        private string _description;
        private string _id;
        private string _name;
        private OriginAccessControlOriginTypes _originAccessControlOriginType;
        private OriginAccessControlSigningBehaviors _signingBehavior;
        private OriginAccessControlSigningProtocols _signingProtocol;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the origin access control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the origin access control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name that identifies the origin access control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OriginAccessControlOriginType. 
        /// <para>
        /// The type of origin that this origin access control is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginAccessControlOriginTypes OriginAccessControlOriginType
        {
            get { return this._originAccessControlOriginType; }
            set { this._originAccessControlOriginType = value; }
        }

        // Check to see if OriginAccessControlOriginType property is set
        internal bool IsSetOriginAccessControlOriginType()
        {
            return this._originAccessControlOriginType != null;
        }

        /// <summary>
        /// Gets and sets the property SigningBehavior. 
        /// <para>
        /// A value that specifies which requests CloudFront signs (adds authentication information
        /// to). This field can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>never</code> – CloudFront doesn't sign any origin requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>always</code> – CloudFront signs all origin requests, overwriting the <code>Authorization</code>
        /// header from the viewer request if necessary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>no-override</code> – If the viewer request doesn't contain the <code>Authorization</code>
        /// header, CloudFront signs the origin request. If the viewer request contains the <code>Authorization</code>
        /// header, CloudFront doesn't sign the origin request, but instead passes along the <code>Authorization</code>
        /// header that it received in the viewer request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginAccessControlSigningBehaviors SigningBehavior
        {
            get { return this._signingBehavior; }
            set { this._signingBehavior = value; }
        }

        // Check to see if SigningBehavior property is set
        internal bool IsSetSigningBehavior()
        {
            return this._signingBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property SigningProtocol. 
        /// <para>
        /// The signing protocol of the origin access control. The signing protocol determines
        /// how CloudFront signs (authenticates) requests. The only valid value is <code>sigv4</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginAccessControlSigningProtocols SigningProtocol
        {
            get { return this._signingProtocol; }
            set { this._signingProtocol = value; }
        }

        // Check to see if SigningProtocol property is set
        internal bool IsSetSigningProtocol()
        {
            return this._signingProtocol != null;
        }

    }
}