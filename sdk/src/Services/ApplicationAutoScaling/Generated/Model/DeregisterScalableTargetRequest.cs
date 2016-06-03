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
    /// Container for the parameters to the DeregisterScalableTarget operation.
    /// Deregisters a scalable target that was previously registered. If you are no longer
    /// using a scalable target, you can delete it with this operation. When you deregister
    /// a scalable target, all of the scaling policies that are associated with that scalable
    /// target are deleted.
    /// 
    ///  
    /// <para>
    /// To create a new scalable target or update an existing one, see <a>RegisterScalableTarget</a>.
    /// </para>
    /// </summary>
    public partial class DeregisterScalableTargetRequest : AmazonApplicationAutoScalingRequest
    {
        private string _resourceId;
        private ScalableDimension _scalableDimension;
        private ServiceNamespace _serviceNamespace;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique identifier string for the resource associated with the scalable target.
        /// For Amazon ECS services, this value is the resource type, followed by the cluster
        /// name and service name, such as <code>service/default/sample-webapp</code>.
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
        /// The scalable dimension associated with the scalable target. The scalable dimension
        /// contains the service namespace, resource type, and scaling property, such as <code>ecs:service:DesiredCount</code>
        /// for the desired task count of an Amazon ECS service.
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
        /// The namespace for the AWS service that the scalable target is associated with. For
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