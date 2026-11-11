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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A CloudFront origin access control.
    /// </summary>
    public partial class OriginAccessControlSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the origin access control.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the origin access control.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name that identifies the origin access control.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OriginAccessControlOriginType. 
        /// <para>
        /// The type of origin that this origin access control is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OriginAccessControlOriginTypes OriginAccessControlOriginType { get; set; }

        /// <summary>
        /// Checks to see if the OriginAccessControlOriginType property is set.
        /// </summary>
        internal bool IsSetOriginAccessControlOriginType() => this.OriginAccessControlOriginType != null;

        /// <summary>
        /// Gets and sets the property SigningBehavior. 
        /// <para>
        /// A value that specifies which requests CloudFront signs (adds authentication information
        /// to). This field can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>never</c> – CloudFront doesn't sign any origin requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>always</c> – CloudFront signs all origin requests, overwriting the <c>Authorization</c>
        /// header from the viewer request if necessary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>no-override</c> – If the viewer request doesn't contain the <c>Authorization</c>
        /// header, CloudFront signs the origin request. If the viewer request contains the <c>Authorization</c>
        /// header, CloudFront doesn't sign the origin request, but instead passes along the <c>Authorization</c>
        /// header that it received in the viewer request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>always-amz-auth</c> – CloudFront signs all origin requests with Amazon authentication
        /// headers, and forwards the viewer's <c>Authorization</c> header to the origin if one
        /// is present. This value is only valid with Lambda-Web origins.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public OriginAccessControlSigningBehaviors SigningBehavior { get; set; }

        /// <summary>
        /// Checks to see if the SigningBehavior property is set.
        /// </summary>
        internal bool IsSetSigningBehavior() => this.SigningBehavior != null;

        /// <summary>
        /// Gets and sets the property SigningProtocol. 
        /// <para>
        /// The signing protocol of the origin access control. The signing protocol determines
        /// how CloudFront signs (authenticates) requests. The only valid values are <c>sigv4</c>
        /// and <c>sigv4a</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OriginAccessControlSigningProtocols SigningProtocol { get; set; }

        /// <summary>
        /// Checks to see if the SigningProtocol property is set.
        /// </summary>
        internal bool IsSetSigningProtocol() => this.SigningProtocol != null;
    }
}
