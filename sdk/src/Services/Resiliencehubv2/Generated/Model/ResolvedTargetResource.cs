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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// A single AWS resource that AWS Fault Injection Service (AWS FIS) resolved as a target
    /// during a test run.
    /// </summary>
    public partial class ResolvedTargetResource
    {
        private string _resourceType;
        private Dictionary<string, string> _targetInformation = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _targetName;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The AWS FIS resource type the target belongs to, such as aws:ec2:instance, aws:ecs:task,
        /// or aws:eks:pod.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetInformation. 
        /// <para>
        /// The raw target information map as returned by AWS FIS.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public Dictionary<string, string> TargetInformation
        {
            get { return this._targetInformation; }
            set { this._targetInformation = value; }
        }

        // Check to see if TargetInformation property is set
        internal bool IsSetTargetInformation()
        {
            return this._targetInformation != null && (this._targetInformation.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The name of the target in the AWS FIS experiment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TargetName
        {
            get { return this._targetName; }
            set { this._targetName = value; }
        }

        // Check to see if TargetName property is set
        internal bool IsSetTargetName()
        {
            return this._targetName != null;
        }

    }
}