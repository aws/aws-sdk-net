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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Returns information about the resource being evaluated.
    /// </summary>
    public partial class InsightResourceDetail
    {
        private string _arn;
        private InsightStatus _insightStatus;
        private string _kubernetesResourceUri;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) if applicable.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property InsightStatus. 
        /// <para>
        /// An object containing more detail on the status of the insight resource.
        /// </para>
        /// </summary>
        public InsightStatus InsightStatus
        {
            get { return this._insightStatus; }
            set { this._insightStatus = value; }
        }

        // Check to see if InsightStatus property is set
        internal bool IsSetInsightStatus()
        {
            return this._insightStatus != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesResourceUri. 
        /// <para>
        /// The Kubernetes resource URI if applicable.
        /// </para>
        /// </summary>
        public string KubernetesResourceUri
        {
            get { return this._kubernetesResourceUri; }
            set { this._kubernetesResourceUri = value; }
        }

        // Check to see if KubernetesResourceUri property is set
        internal bool IsSetKubernetesResourceUri()
        {
            return this._kubernetesResourceUri != null;
        }

    }
}