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
using System;
using System.Threading;

using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.CloudFormation
{
    /// <summary>
    /// Implementation for accessing AmazonCloudFormation.
    ///  
    /// AWS CloudFormation <para>AWS CloudFormation enables you to create and manage AWS infrastructure deployments predictably and repeatedly. AWS
    /// CloudFormation helps you leverage AWS products such as Amazon EC2, EBS, Amazon SNS, ELB, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost effective applications without worrying about creating and configuring the underlying AWS infrastructure.</para> <para>With
    /// AWS CloudFormation, you declare all of your resources and dependencies in a template file. The template defines a collection of resources as
    /// a single unit called a stack. AWS CloudFormation creates and deletes all member resources of the stack together and manages all dependencies
    /// between the resources for you.</para> <para>For more information about this product, go to the <a
    /// href="http://aws.amazon.com/cloudformation/" >CloudFormation Product Page</a> .</para> <para>Amazon CloudFormation makes use of other AWS
    /// products. If you need additional technical information about a specific AWS product, you can find the product's technical documentation at
    /// <a href="http://aws.amazon.com/documentation/" >http://aws.amazon.com/documentation/</a> .</para>
    /// </summary>
    public partial class AmazonCloudFormationClient : AmazonWebServiceClient, AmazonCloudFormation
    {
        protected override void ProcessRequestHandlers(IRequest request)
        {
            base.ProcessRequestHandlers(request);

            var originalRequest = request.OriginalRequest;
            var updateStackRequest = originalRequest as UpdateStackRequest;
            if (updateStackRequest != null)
            {
                var arns = updateStackRequest.NotificationARNs;
                bool arnsAutoConstructed = arns is AutoConstructedList<string>;

                // if there are no NotificationARNs and the list was created by user (type is NOT AutoConstructed)
                // only then pass empty param
                if (arns.Count == 0 && !arnsAutoConstructed)
                {
                    request.Parameters.Add("NotificationARNs", "");
                }
            }
        }
    }
}
    
