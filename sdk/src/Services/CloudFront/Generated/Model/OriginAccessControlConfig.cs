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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A CloudFront origin access control configuration.
    /// </summary>
    public partial class OriginAccessControlConfig
    {
        private string _description;
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A name to identify the origin access control. You can specify up to 64 characters.
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
        /// Specifies which requests CloudFront signs (adds authentication information to). Specify
        /// <c>always</c> for the most common use case. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-restricting-access-to-s3.html#oac-advanced-settings">origin
        /// access control advanced settings</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This field can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>always</c> – CloudFront signs all origin requests, overwriting the <c>Authorization</c>
        /// header from the viewer request if one exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>never</c> – CloudFront doesn't sign any origin requests. This value turns off
        /// origin access control for all origins in all distributions that use this origin access
        /// control.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>no-override</c> – If the viewer request doesn't contain the <c>Authorization</c>
        /// header, then CloudFront signs the origin request. If the viewer request contains the
        /// <c>Authorization</c> header, then CloudFront doesn't sign the origin request and instead
        /// passes along the <c>Authorization</c> header from the viewer request. <b>WARNING:
        /// To pass along the <c>Authorization</c> header from the viewer request, you <i>must</i>
        /// add the <c>Authorization</c> header to a <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html">cache
        /// policy</a> for all cache behaviors that use origins associated with this origin access
        /// control.</b> 
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
        /// The signing protocol of the origin access control, which determines how CloudFront
        /// signs (authenticates) requests. The only valid value is <c>sigv4</c>.
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