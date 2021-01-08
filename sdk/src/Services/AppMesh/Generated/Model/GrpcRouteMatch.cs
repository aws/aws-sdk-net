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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the criteria for determining a request match.
    /// </summary>
    public partial class GrpcRouteMatch
    {
        private List<GrpcRouteMetadata> _metadata = new List<GrpcRouteMetadata>();
        private string _methodName;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// An object that represents the data to match from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<GrpcRouteMetadata> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && this._metadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MethodName. 
        /// <para>
        /// The method name to match from the request. If you specify a name, you must also specify
        /// a <code>serviceName</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string MethodName
        {
            get { return this._methodName; }
            set { this._methodName = value; }
        }

        // Check to see if MethodName property is set
        internal bool IsSetMethodName()
        {
            return this._methodName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The fully qualified domain name for the service to match from the request.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}