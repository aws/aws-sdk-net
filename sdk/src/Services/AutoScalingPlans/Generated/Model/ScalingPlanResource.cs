/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ScalingPlanResource
    {
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private string _scalingPlanName;
        private long? _scalingPlanVersion;
        private List<ScalingPolicy> _scalingPolicies = new List<ScalingPolicy>();
        private ScalingStatusCode _scalingStatusCode;
        private string _scalingStatusMessage;
        private ServiceNamespace _serviceNamespace;

        /// <summary>
        /// Gets and sets the property ResourceId.
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ScalableDimension.
        /// </summary>
        public ScalableDimension ScalableDimension
        {
            get { return this._scalableDimension; }
            set { this._scalableDimension = value; }
        }

        // Check to see if ScalableDimension property is set
        internal bool IsSetScalableDimension()
        {
            return this._scalableDimension != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingPlanName.
        /// </summary>
        public string ScalingPlanName
        {
            get { return this._scalingPlanName; }
            set { this._scalingPlanName = value; }
        }

        // Check to see if ScalingPlanName property is set
        internal bool IsSetScalingPlanName()
        {
            return this._scalingPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingPlanVersion.
        /// </summary>
        public long ScalingPlanVersion
        {
            get { return this._scalingPlanVersion.GetValueOrDefault(); }
            set { this._scalingPlanVersion = value; }
        }

        // Check to see if ScalingPlanVersion property is set
        internal bool IsSetScalingPlanVersion()
        {
            return this._scalingPlanVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalingPolicies.
        /// </summary>
        public List<ScalingPolicy> ScalingPolicies
        {
            get { return this._scalingPolicies; }
            set { this._scalingPolicies = value; }
        }

        // Check to see if ScalingPolicies property is set
        internal bool IsSetScalingPolicies()
        {
            return this._scalingPolicies != null && this._scalingPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScalingStatusCode.
        /// </summary>
        public ScalingStatusCode ScalingStatusCode
        {
            get { return this._scalingStatusCode; }
            set { this._scalingStatusCode = value; }
        }

        // Check to see if ScalingStatusCode property is set
        internal bool IsSetScalingStatusCode()
        {
            return this._scalingStatusCode != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingStatusMessage.
        /// </summary>
        public string ScalingStatusMessage
        {
            get { return this._scalingStatusMessage; }
            set { this._scalingStatusMessage = value; }
        }

        // Check to see if ScalingStatusMessage property is set
        internal bool IsSetScalingStatusMessage()
        {
            return this._scalingStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace.
        /// </summary>
        public ServiceNamespace ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

    }
}