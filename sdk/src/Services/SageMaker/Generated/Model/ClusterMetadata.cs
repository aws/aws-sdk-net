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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Metadata information about a HyperPod cluster showing information about the cluster
    /// level operations, such as creating, updating, and deleting.
    /// </summary>
    public partial class ClusterMetadata
    {
        private List<string> _eksRoleAccessEntries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _failureMessage;
        private string _slrAccessEntry;

        /// <summary>
        /// Gets and sets the property EksRoleAccessEntries. 
        /// <para>
        /// A list of Amazon EKS IAM role ARNs associated with the cluster. This is created by
        /// HyperPod on your behalf and only applies for EKS orchestrated clusters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EksRoleAccessEntries
        {
            get { return this._eksRoleAccessEntries; }
            set { this._eksRoleAccessEntries = value; }
        }

        // Check to see if EksRoleAccessEntries property is set
        internal bool IsSetEksRoleAccessEntries()
        {
            return this._eksRoleAccessEntries != null && (this._eksRoleAccessEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// An error message describing why the cluster level operation (such as creating, updating,
        /// or deleting) failed.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SlrAccessEntry. 
        /// <para>
        /// The Service-Linked Role (SLR) associated with the cluster. This is created by HyperPod
        /// on your behalf and only applies for EKS orchestrated clusters.
        /// </para>
        /// </summary>
        public string SlrAccessEntry
        {
            get { return this._slrAccessEntry; }
            set { this._slrAccessEntry = value; }
        }

        // Check to see if SlrAccessEntry property is set
        internal bool IsSetSlrAccessEntry()
        {
            return this._slrAccessEntry != null;
        }

    }
}