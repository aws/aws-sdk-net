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
    /// An object that represents the methods by which a subject alternative name on a peer
    /// Transport Layer Security (TLS) certificate can be matched.
    /// </summary>
    public partial class SubjectAlternativeNameMatchers
    {
        private List<string> _exact = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Exact. 
        /// <para>
        /// The values sent must match the specified values exactly.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Exact
        {
            get { return this._exact; }
            set { this._exact = value; }
        }

        // Check to see if Exact property is set
        internal bool IsSetExact()
        {
            return this._exact != null && (this._exact.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}