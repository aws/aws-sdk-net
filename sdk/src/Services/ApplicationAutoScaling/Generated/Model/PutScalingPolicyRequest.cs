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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutScalingPolicy operation.
    /// Creates or updates a policy for an existing Application Auto Scaling scalable target.
    /// Each scalable target is identified by service namespace, a resource ID, and a scalable
    /// dimension, and a scaling policy applies to a scalable target that is identified by
    /// those three attributes. You cannot create a scaling policy without first registering
    /// a scalable target with <a>RegisterScalableTarget</a>.
    /// 
    ///  
    /// <para>
    /// To update an existing policy, use the existing policy name and set the parameters
    /// you want to change. Any existing parameter not changed in an update to an existing
    /// policy is not changed in this update request.
    /// </para>
    ///  
    /// <para>
    /// You can view the existing scaling policies for a service namespace with <a>DescribeScalingPolicies</a>.
    /// If you are no longer using a scaling policy, you can delete it with <a>DeleteScalingPolicy</a>.
    /// </para>
    /// </summary>
    public partial class PutScalingPolicyRequest : AmazonApplicationAutoScalingRequest
    {
        private string _policyName;
        private PolicyType _policyType;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ServiceNamespace _serviceNamespace;
        private StepScalingPolicyConfiguration _stepScalingPolicyConfiguration;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the scaling policy.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The policy type. This parameter is required if you are creating a new policy.
        /// </para>
        /// </summary>
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique resource identifier string for the scalable target that this scaling policy
        /// applies to. For Amazon ECS services, this value is the resource type, followed by
        /// the cluster name and service name, such as <code>service/default/sample-webapp</code>.
        /// </para>
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
        /// <para>
        /// The scalable dimension of the scalable target that this scaling policy applies to.
        /// The scalable dimension contains the service namespace, resource type, and scaling
        /// property, such as <code>ecs:service:DesiredCount</code> for the desired task count
        /// of an Amazon ECS service.
        /// </para>
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
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The AWS service namespace of the scalable target that this scaling policy applies
        /// to. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">AWS
        /// Service Namespaces</a> in the Amazon Web Services General Reference.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property StepScalingPolicyConfiguration. 
        /// <para>
        /// The configuration for the step scaling policy. This parameter is required if you are
        /// creating a new policy. For more information, see <a>StepScalingPolicyConfiguration</a>
        /// and <a>StepAdjustment</a>.
        /// </para>
        /// </summary>
        public StepScalingPolicyConfiguration StepScalingPolicyConfiguration
        {
            get { return this._stepScalingPolicyConfiguration; }
            set { this._stepScalingPolicyConfiguration = value; }
        }

        // Check to see if StepScalingPolicyConfiguration property is set
        internal bool IsSetStepScalingPolicyConfiguration()
        {
            return this._stepScalingPolicyConfiguration != null;
        }

    }
}