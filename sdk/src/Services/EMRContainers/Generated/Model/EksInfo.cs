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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// The information about the Amazon EKS cluster.
    /// </summary>
    public partial class EksInfo
    {
        private string _awsNamespace;
        private string _nodeLabel;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespaces of the Amazon EKS cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NodeLabel. 
        /// <para>
        /// The nodeLabel of the nodes where the resources of this virtual cluster can get scheduled.
        /// It requires relevant scaling and policy engine addons.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string NodeLabel
        {
            get { return this._nodeLabel; }
            set { this._nodeLabel = value; }
        }

        // Check to see if NodeLabel property is set
        internal bool IsSetNodeLabel()
        {
            return this._nodeLabel != null;
        }

    }
}