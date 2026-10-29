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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the AttachThingPrincipal operation. Attaches the specified
    /// principal to the specified thing. A principal can be X.509 certificates, Amazon Cognito
    /// identities or federated identities. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AttachThingPrincipal</a>
    /// action. </para>
    /// </summary>
    public partial class AttachThingPrincipalRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal, which can be a certificate ARN (as returned from the CreateCertificate
        /// operation) or an Amazon Cognito ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;

        /// <summary>
        /// Gets and sets the property ThingPrincipalType. 
        /// <para>
        /// The type of the relation you want to specify when you attach a principal to a thing.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EXCLUSIVE_THING</c> - Attaches the specified principal to the specified thing,
        /// exclusively. The thing will be the only thing that’s attached to the principal.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>NON_EXCLUSIVE_THING</c> - Attaches the specified principal to the specified thing.
        /// Multiple things can be attached to the principal.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ThingPrincipalType ThingPrincipalType { get; set; }

        /// <summary>
        /// Checks to see if the ThingPrincipalType property is set.
        /// </summary>
        internal bool IsSetThingPrincipalType() => this.ThingPrincipalType != null;
    }
}
