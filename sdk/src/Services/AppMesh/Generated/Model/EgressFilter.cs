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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the egress filter rules for a service mesh.
    /// </summary>
    public partial class EgressFilter
    {
        private EgressFilterType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The egress filter type. By default, the type is <c>DROP_ALL</c>, which allows egress
        /// only from virtual nodes to other defined resources in the service mesh (and any traffic
        /// to <c>*.amazonaws.com</c> for Amazon Web Services API calls). You can set the egress
        /// filter type to <c>ALLOW_ALL</c> to allow egress to any endpoint inside or outside
        /// of the service mesh.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EgressFilterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}