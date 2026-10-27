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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the Kubernetes API for which you check if you have permission to
    /// call.
    /// </summary>
    public partial class KubernetesPermissionCheckedDetails
    {
        /// <summary>
        /// Gets and sets the property Allowed. 
        /// <para>
        /// Information whether the user has the permission to call the Kubernetes API.
        /// </para>
        /// </summary>
        public bool? Allowed { get; set; }

        /// <summary>
        /// Checks to see if the Allowed property is set.
        /// </summary>
        internal bool IsSetAllowed() => this.Allowed.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace where the Kubernetes API action will take place.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The Kubernetes resource with which your Kubernetes API call will interact.
        /// </para>
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property Verb. 
        /// <para>
        /// The verb component of the Kubernetes API call. For example, when you check whether
        /// or not you have the permission to call the <c>CreatePod</c> API, the verb component
        /// will be <c>Create</c>.
        /// </para>
        /// </summary>
        public string Verb { get; set; }

        /// <summary>
        /// Checks to see if the Verb property is set.
        /// </summary>
        internal bool IsSetVerb() => this.Verb != null;
    }
}
