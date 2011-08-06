/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Transform;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.CloudFormation
{
    /// <summary>
    /// Implemenation for accessing AmazonCloudFormation.
    ///  
    /// AWS CloudFormation <para>This is the AWS CloudFormation API Reference. The major sections of this guide are described in the following
    /// table.</para>
    /// <ul>
    /// <li> Actions: Alphabetical list of CloudFormation actions</li>
    /// <li> Data Types: Alphabetical list of CloudFormation data types</li>
    /// <li> Common Parameters: Parameters that all Query actions can use</li>
    /// <li> Common Errors: Client and server errors that all actions can return</li>
    /// 
    /// </ul>
    /// <para>This guide is for programmers who need detailed information about the CloudFormation APIs. You use AWS CloudFormation to create and
    /// manage AWS infrastructure deployments predictably and repeatedly. CloudFormation helps you leverage AWS products such as Amazon EC2, EBS,
    /// Amazon SNS, ELB, and Auto Scaling to build highly-reliable, highly scalable, cost effective applications without worrying about creating and
    /// configuring the underlying the AWS infrastructure.</para> <para>Through the use of a template file you write, and a few AWS CloudFormation
    /// commands or API actions, AWS CloudFormation enables you to manage a collection of resources together as a single unit called a stack. AWS
    /// CloudFormation creates and deletes all member resources of the stack together and manages all dependencies between the resources for
    /// you.</para> <para>For more information about this product, go to the CloudFormation Product Page.</para> <para>Amazon CloudFormation makes
    /// use of other AWS products. If you need additional technical information about a specific AWS product, you can find the product's technical
    /// documentation at http://aws.amazon.com/documentation/.</para>
    /// </summary>
    public class AmazonCloudFormationClient : AmazonWebServiceClient, AmazonCloudFormation
    {
    
    
        AbstractAWSSigner signer = new QueryStringSigner();

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }
        
   

         /// <summary>
         /// <para> Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
         /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
         /// is returned (including existing stacks and stacks that have been deleted). </para>
         /// </summary>
         /// 
         /// <param name="listStacksRequest">Container for the necessary parameters to execute the ListStacks service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the ListStacks service method, as returned by AmazonCloudFormation.</returns>
         /// 
        public ListStacksResponse ListStacks(ListStacksRequest listStacksRequest) 
        {           
            IRequest<ListStacksRequest> request = new ListStacksRequestMarshaller().Marshall(listStacksRequest);
            ListStacksResponse response = Invoke<ListStacksRequest, ListStacksResponse> (request, this.signer, ListStacksResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Creates a stack as specified in the template. After the call completes successfully, the stack creation starts. You can check the
         /// status of the stack via the DescribeStacks API. </para> <para><b>NOTE:</b> Currently, the limit for stacks is 20 stacks per account per
         /// region. </para>
         /// </summary>
         /// 
         /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the CreateStack service method, as returned by AmazonCloudFormation.</returns>
         /// 
         /// <exception cref="AlreadyExistsException"/>
         /// <exception cref="LimitExceededException"/>
        public CreateStackResponse CreateStack(CreateStackRequest createStackRequest) 
        {           
            IRequest<CreateStackRequest> request = new CreateStackRequestMarshaller().Marshall(createStackRequest);
            CreateStackResponse response = Invoke<CreateStackRequest, CreateStackResponse> (request, this.signer, CreateStackResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Validates a specified template. </para>
         /// </summary>
         /// 
         /// <param name="validateTemplateRequest">Container for the necessary parameters to execute the ValidateTemplate service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the ValidateTemplate service method, as returned by AmazonCloudFormation.</returns>
         /// 
        public ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest validateTemplateRequest) 
        {           
            IRequest<ValidateTemplateRequest> request = new ValidateTemplateRequestMarshaller().Marshall(validateTemplateRequest);
            ValidateTemplateResponse response = Invoke<ValidateTemplateRequest, ValidateTemplateResponse> (request, this.signer, ValidateTemplateResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns the description for the specified stack; if no stack name was specified, then it returns the description for all the stacks
         /// created. </para>
         /// </summary>
         /// 
         /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the DescribeStacks service method, as returned by AmazonCloudFormation.</returns>
         /// 
        public DescribeStacksResponse DescribeStacks(DescribeStacksRequest describeStacksRequest) 
        {           
            IRequest<DescribeStacksRequest> request = new DescribeStacksRequestMarshaller().Marshall(describeStacksRequest);
            DescribeStacksResponse response = Invoke<DescribeStacksRequest, DescribeStacksResponse> (request, this.signer, DescribeStacksResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns all the stack related events for the AWS account. If <c>StackName</c> is specified, returns events related to all the stacks
         /// with the given name. If <c>StackName</c> is not specified, returns all the events for the account. For more information about a stack's
         /// event history, go to the AWS CloudFormation User Guide. </para> <para><b>NOTE:</b>Events are returned, even if the stack never existed or
         /// has been successfully deleted.</para>
         /// </summary>
         /// 
         /// <param name="describeStackEventsRequest">Container for the necessary parameters to execute the DescribeStackEvents service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the DescribeStackEvents service method, as returned by AmazonCloudFormation.</returns>
         /// 
        public DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest describeStackEventsRequest) 
        {           
            IRequest<DescribeStackEventsRequest> request = new DescribeStackEventsRequestMarshaller().Marshall(describeStackEventsRequest);
            DescribeStackEventsResponse response = Invoke<DescribeStackEventsRequest, DescribeStackEventsResponse> (request, this.signer, DescribeStackEventsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns the template body for a specified stack name. You can get the template for running or deleted stacks.</para> <para>For deleted
         /// stacks, GetTemplate returns the template for up to 90 days after the stack has been deleted. </para> <para><b>NOTE:</b> If the template does
         /// not exist, a ValidationError is returned. </para>
         /// </summary>
         /// 
         /// <param name="getTemplateRequest">Container for the necessary parameters to execute the GetTemplate service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the GetTemplate service method, as returned by AmazonCloudFormation.</returns>
         /// 
        public GetTemplateResponse GetTemplate(GetTemplateRequest getTemplateRequest) 
        {           
            IRequest<GetTemplateRequest> request = new GetTemplateRequestMarshaller().Marshall(getTemplateRequest);
            GetTemplateResponse response = Invoke<GetTemplateRequest, GetTemplateResponse> (request, this.signer, GetTemplateResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns the description for the specified resource in the specified stack. </para> <para>For deleted stacks, DescribeStackResource
         /// returns resource information for up to 90 days after the stack has been deleted. </para> <para> You must specify <c>StackName</c> and
         /// <c>LogicalResourceId</c> .
         /// </para>
         /// </summary>
         /// 
         /// <param name="describeStackResourceRequest">Container for the necessary parameters to execute the DescribeStackResource service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the DescribeStackResource service method, as returned by AmazonCloudFormation.</returns>
         /// 
        public DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest describeStackResourceRequest) 
        {           
            IRequest<DescribeStackResourceRequest> request = new DescribeStackResourceRequestMarshaller().Marshall(describeStackResourceRequest);
            DescribeStackResourceResponse response = Invoke<DescribeStackResourceRequest, DescribeStackResourceResponse> (request, this.signer, DescribeStackResourceResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Deletes a specified stack. Once the call completes successfully, stack deletion starts. Deleted stacks do not show up in the
         /// DescribeStacks API if the deletion has been completed successfully. </para>
         /// </summary>
         /// 
         /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack service method on
         ///           AmazonCloudFormation.</param>
         /// 
        public DeleteStackResponse DeleteStack(DeleteStackRequest deleteStackRequest) 
        {           
            IRequest<DeleteStackRequest> request = new DeleteStackRequestMarshaller().Marshall(deleteStackRequest);
            DeleteStackResponse response = Invoke<DeleteStackRequest, DeleteStackResponse> (request, this.signer, DeleteStackResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns descriptions for all resources of the specified stack. </para> <para>For deleted stacks, ListStackResources returns resource
         /// information for up to 90 days after the stack has been deleted. </para>
         /// </summary>
         /// 
         /// <param name="listStackResourcesRequest">Container for the necessary parameters to execute the ListStackResources service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the ListStackResources service method, as returned by AmazonCloudFormation.</returns>
         /// 
        public ListStackResourcesResponse ListStackResources(ListStackResourcesRequest listStackResourcesRequest) 
        {           
            IRequest<ListStackResourcesRequest> request = new ListStackResourcesRequestMarshaller().Marshall(listStackResourcesRequest);
            ListStackResourcesResponse response = Invoke<ListStackResourcesRequest, ListStackResourcesResponse> (request, this.signer, ListStackResourcesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns AWS resource descriptions for running and deleted stacks. If <c>StackName</c> is specified, all the associated resources that
         /// are part of the stack are returned. If <c>PhysicalResourceId</c> is specified, all the associated resources of the stack the resource
         /// belongs to are returned. </para> <para>For deleted stacks, DescribeStackResources returns resource information for up to 90 days after the
         /// stack has been deleted. </para> <para> You must specify <c>StackName</c> or <c>PhysicalResourceId.</c> In addition, you can specify
         /// <c>LogicalResourceId</c> to filter the returned result. For more information about resources, the <c>LogicalResourceId</c> and
         /// <c>PhysicalResourceId</c> , go to the AWS CloudFormation User Guide. </para> <para><b>NOTE:</b> A ValidationError is returned if you specify
         /// both StackName and PhysicalResourceId in the same request. </para>
         /// </summary>
         /// 
         /// <param name="describeStackResourcesRequest">Container for the necessary parameters to execute the DescribeStackResources service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the DescribeStackResources service method, as returned by AmazonCloudFormation.</returns>
         /// 
        public DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest describeStackResourcesRequest) 
        {           
            IRequest<DescribeStackResourcesRequest> request = new DescribeStackResourcesRequestMarshaller().Marshall(describeStackResourcesRequest);
            DescribeStackResourcesResponse response = Invoke<DescribeStackResourcesRequest, DescribeStackResourcesResponse> (request, this.signer, DescribeStackResourcesResponseUnmarshaller.GetInstance());
            return response;
        }
    
    }
}   
    
