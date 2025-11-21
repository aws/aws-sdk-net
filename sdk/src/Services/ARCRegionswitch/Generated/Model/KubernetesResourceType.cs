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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Defines the type of Kubernetes resource to scale in an Amazon EKS cluster.
    /// </summary>
    public partial class KubernetesResourceType
    {
        private string _apiVersion;
        private string _kind;

        /// <summary>
        /// Gets and sets the property ApiVersion. 
        /// <para>
        /// The API version type for the Kubernetes resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiVersion
        {
            get { return this._apiVersion; }
            set { this._apiVersion = value; }
        }

        // Check to see if ApiVersion property is set
        internal bool IsSetApiVersion()
        {
            return this._apiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// The kind for the Kubernetes resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Kind
        {
            get { return this._kind; }
            set { this._kind = value; }
        }

        // Check to see if Kind property is set
        internal bool IsSetKind()
        {
            return this._kind != null;
        }

    }
}