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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// The identifier for a serverless namespace.
    /// </summary>
    public partial class ServerlessIdentifier
    {
        private string _namespaceIdentifier;
        private string _workgroupIdentifier;

        /// <summary>
        /// Gets and sets the property NamespaceIdentifier. 
        /// <para>
        /// The unique identifier for the serverless namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string NamespaceIdentifier
        {
            get { return this._namespaceIdentifier; }
            set { this._namespaceIdentifier = value; }
        }

        // Check to see if NamespaceIdentifier property is set
        internal bool IsSetNamespaceIdentifier()
        {
            return this._namespaceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property WorkgroupIdentifier. 
        /// <para>
        /// The unique identifier for the workgroup associated with the serverless namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string WorkgroupIdentifier
        {
            get { return this._workgroupIdentifier; }
            set { this._workgroupIdentifier = value; }
        }

        // Check to see if WorkgroupIdentifier property is set
        internal bool IsSetWorkgroupIdentifier()
        {
            return this._workgroupIdentifier != null;
        }

    }
}