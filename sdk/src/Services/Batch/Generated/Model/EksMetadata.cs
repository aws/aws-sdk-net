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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Describes and uniquely identifies Kubernetes resources. For example, the compute environment
    /// that a pod runs in or the <c>jobID</c> for a job running in the pod. For more information,
    /// see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/kubernetes-objects/">Understanding
    /// Kubernetes Objects</a> in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksMetadata
    {
        private Dictionary<string, string> _labels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Key-value pairs used to identify, sort, and organize cube resources. Can contain up
        /// to 63 uppercase letters, lowercase letters, numbers, hyphens (-), and underscores
        /// (_). Labels can be added or modified at any time. Each resource can have multiple
        /// labels, but each key must be unique for a given object.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}