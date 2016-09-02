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
    /// Container for the parameters to the DeleteScalingPolicy operation.
    /// Deletes an Application Auto Scaling scaling policy that was previously created. If
    /// you are no longer using a scaling policy, you can delete it with this operation.
    /// 
    ///  
    /// <para>
    /// Deleting a policy deletes the underlying alarm action, but does not delete the CloudWatch
    /// alarm associated with the scaling policy, even if it no longer has an associated action.
    /// </para>
    ///  
    /// <para>
    /// To create a new scaling policy or update an existing one, see <a>PutScalingPolicy</a>.
    /// </para>
    /// </summary>
    public partial class DeleteScalingPolicyRequest : AmazonApplicationAutoScalingRequest
    {
        private string _policyName;
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ServiceNamespace _serviceNamespace;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the scaling policy to delete.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource type and unique identifier string for the resource associated with the
        /// scaling policy. For Amazon ECS services, the resource type is <code>services</code>,
        /// and the identifier is the cluster name and service name; for example, <code>service/default/sample-webapp</code>.
        /// For Amazon EC2 Spot fleet requests, the resource type is <code>spot-fleet-request</code>,
        /// and the identifier is the Spot fleet request ID; for example, <code>spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE</code>.
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
        /// The scalable dimension associated with the scaling policy. The scalable dimension
        /// contains the service namespace, resource type, and scaling property, such as <code>ecs:service:DesiredCount</code>
        /// for the desired task count of an Amazon ECS service, or <code>ec2:spot-fleet-request:TargetCapacity</code>
        /// for the target capacity of an Amazon EC2 Spot fleet request.
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
        /// The namespace for the AWS service that the scaling policy is associated with. For
        /// more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">AWS
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

    }
}