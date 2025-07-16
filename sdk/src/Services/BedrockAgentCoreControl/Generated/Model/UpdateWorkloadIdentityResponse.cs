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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the UpdateWorkloadIdentity operation.
    /// </summary>
    public partial class UpdateWorkloadIdentityResponse : AmazonWebServiceResponse
    {
        private List<string> _allowedResourceOauth2ReturnUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdTime;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _workloadIdentityArn;

        /// <summary>
        /// Gets and sets the property AllowedResourceOauth2ReturnUrls. 
        /// <para>
        /// The list of allowed OAuth2 return URLs for resources associated with this workload
        /// identity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedResourceOauth2ReturnUrls
        {
            get { return this._allowedResourceOauth2ReturnUrls; }
            set { this._allowedResourceOauth2ReturnUrls = value; }
        }

        // Check to see if AllowedResourceOauth2ReturnUrls property is set
        internal bool IsSetAllowedResourceOauth2ReturnUrls()
        {
            return this._allowedResourceOauth2ReturnUrls != null && (this._allowedResourceOauth2ReturnUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the workload identity was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the workload identity was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workload identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadIdentityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workload identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string WorkloadIdentityArn
        {
            get { return this._workloadIdentityArn; }
            set { this._workloadIdentityArn = value; }
        }

        // Check to see if WorkloadIdentityArn property is set
        internal bool IsSetWorkloadIdentityArn()
        {
            return this._workloadIdentityArn != null;
        }

    }
}