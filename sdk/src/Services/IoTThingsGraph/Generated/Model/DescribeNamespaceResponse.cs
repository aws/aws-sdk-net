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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// This is the response object from the DescribeNamespace operation.
    /// </summary>
    public partial class DescribeNamespaceResponse : AmazonWebServiceResponse
    {
        private string _namespaceArn;
        private string _namespaceName;
        private long? _namespaceVersion;
        private string _trackingNamespaceName;
        private long? _trackingNamespaceVersion;

        /// <summary>
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The ARN of the namespace.
        /// </para>
        /// </summary>
        public string NamespaceArn
        {
            get { return this._namespaceArn; }
            set { this._namespaceArn = value; }
        }

        // Check to see if NamespaceArn property is set
        internal bool IsSetNamespaceArn()
        {
            return this._namespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceVersion. 
        /// <para>
        /// The version of the user's namespace to describe.
        /// </para>
        /// </summary>
        public long NamespaceVersion
        {
            get { return this._namespaceVersion.GetValueOrDefault(); }
            set { this._namespaceVersion = value; }
        }

        // Check to see if NamespaceVersion property is set
        internal bool IsSetNamespaceVersion()
        {
            return this._namespaceVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrackingNamespaceName. 
        /// <para>
        /// The name of the public namespace that the latest namespace version is tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string TrackingNamespaceName
        {
            get { return this._trackingNamespaceName; }
            set { this._trackingNamespaceName = value; }
        }

        // Check to see if TrackingNamespaceName property is set
        internal bool IsSetTrackingNamespaceName()
        {
            return this._trackingNamespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingNamespaceVersion. 
        /// <para>
        /// The version of the public namespace that the latest version is tracking.
        /// </para>
        /// </summary>
        public long TrackingNamespaceVersion
        {
            get { return this._trackingNamespaceVersion.GetValueOrDefault(); }
            set { this._trackingNamespaceVersion = value; }
        }

        // Check to see if TrackingNamespaceVersion property is set
        internal bool IsSetTrackingNamespaceVersion()
        {
            return this._trackingNamespaceVersion.HasValue; 
        }

    }
}