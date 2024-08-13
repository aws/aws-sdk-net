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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Error information for an OpenSearch Serverless request.
    /// </summary>
    public partial class EffectiveLifecyclePolicyDetail
    {
        private bool? _noMinRetentionPeriod;
        private string _policyName;
        private string _resource;
        private ResourceType _resourceType;
        private string _retentionPeriod;
        private LifecyclePolicyType _type;

        /// <summary>
        /// Gets and sets the property NoMinRetentionPeriod. 
        /// <para>
        /// The minimum number of index retention days set. That is an optional param that will
        /// return as <c>true</c> if the minimum number of days or hours is not set to a index
        /// resource.
        /// </para>
        /// </summary>
        public bool? NoMinRetentionPeriod
        {
            get { return this._noMinRetentionPeriod; }
            set { this._noMinRetentionPeriod = value; }
        }

        // Check to see if NoMinRetentionPeriod property is set
        internal bool IsSetNoMinRetentionPeriod()
        {
            return this._noMinRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=32)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The name of the OpenSearch Serverless index resource.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of OpenSearch Serverless resource. Currently, the only supported resource
        /// is <c>index</c>.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
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
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The minimum number of index retention in days or hours. This is an optional parameter
        /// that will return only if it’s set.
        /// </para>
        /// </summary>
        public string RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of lifecycle policy.
        /// </para>
        /// </summary>
        public LifecyclePolicyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}