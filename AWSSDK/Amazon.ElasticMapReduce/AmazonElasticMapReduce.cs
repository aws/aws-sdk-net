/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElasticMapReduce;
using Amazon.ElasticMapReduce.Model;

namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// Interface for accessing AmazonElasticMapReduce.
    ///  
    ///  <para> This is the <i>Amazon Elastic MapReduce API Reference</i> . This guide provides descriptions and samples of the Amazon Elastic
    /// MapReduce APIs.</para> <para>Amazon Elastic MapReduce is a web service that makes it easy to process large amounts of data efficiently.
    /// Elastic MapReduce uses Hadoop processing combined with several AWS products to do tasks such as web indexing, data mining, log file
    /// analysis, machine learning, scientific simulation, and data warehousing.</para>
    /// </summary>
    public interface AmazonElasticMapReduce : IDisposable
    {
        

        #region SetVisibleToAllUsers

        /// <summary>
        /// <para>Sets whether all AWS Identity and Access Management (IAM) users under your account can access the specifed job flows. This action
        /// works on running job flows. You can also set the visibility of a job flow when you launch it using the <c>VisibleToAllUsers</c> parameter of
        /// RunJobFlow. The SetVisibleToAllUsers action can be called only by an IAM user who created the job flow or the AWS account that owns the job
        /// flow.</para>
        /// </summary>
        /// 
        /// <param name="setVisibleToAllUsersRequest">Container for the necessary parameters to execute the SetVisibleToAllUsers service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest setVisibleToAllUsersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetVisibleToAllUsers operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.SetVisibleToAllUsers"/>
        /// </summary>
        /// 
        /// <param name="setVisibleToAllUsersRequest">Container for the necessary parameters to execute the SetVisibleToAllUsers operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetVisibleToAllUsers(SetVisibleToAllUsersRequest setVisibleToAllUsersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetVisibleToAllUsers operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.SetVisibleToAllUsers"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetVisibleToAllUsers.</param>
        SetVisibleToAllUsersResponse EndSetVisibleToAllUsers(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AddInstanceGroups

        /// <summary>
        /// <para>AddInstanceGroups adds an instance group to a running cluster.</para>
        /// </summary>
        /// 
        /// <param name="addInstanceGroupsRequest">Container for the necessary parameters to execute the AddInstanceGroups service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest addInstanceGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AddInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.AddInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="addInstanceGroupsRequest">Container for the necessary parameters to execute the AddInstanceGroups operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddInstanceGroups
        ///         operation.</returns>
        IAsyncResult BeginAddInstanceGroups(AddInstanceGroupsRequest addInstanceGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AddInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.AddInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddInstanceGroups.</param>
        /// 
        /// <returns>Returns a AddInstanceGroupsResult from AmazonElasticMapReduce.</returns>
        AddInstanceGroupsResponse EndAddInstanceGroups(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AddJobFlowSteps

        /// <summary>
        /// <para> AddJobFlowSteps adds new steps to a running job flow. A maximum of 256 steps are allowed in each job flow. </para> <para>If your job
        /// flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data. You can bypass
        /// the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries directly to the
        /// software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to Add More than 256 Steps to a Job
        /// Flow in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para> A step specifies the location of a JAR file stored either on
        /// the master node of the job flow or in Amazon S3. Each step is performed by the main function of the main class of the JAR file. The main
        /// class can be specified either in the manifest of the JAR or by using the MainFunction parameter of the step. </para> <para> Elastic
        /// MapReduce executes each step in the order listed. For a step to be considered complete, the main function must exit with a zero exit code
        /// and all Hadoop jobs started while the step was running must have completed and run successfully. </para> <para> You can only add steps to a
        /// job flow that is in one of the following states: STARTING, BOOTSTRAPPING, RUNNING, or WAITING.</para>
        /// </summary>
        /// 
        /// <param name="addJobFlowStepsRequest">Container for the necessary parameters to execute the AddJobFlowSteps service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest addJobFlowStepsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AddJobFlowSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.AddJobFlowSteps"/>
        /// </summary>
        /// 
        /// <param name="addJobFlowStepsRequest">Container for the necessary parameters to execute the AddJobFlowSteps operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAddJobFlowSteps(AddJobFlowStepsRequest addJobFlowStepsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AddJobFlowSteps operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.AddJobFlowSteps"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddJobFlowSteps.</param>
        AddJobFlowStepsResponse EndAddJobFlowSteps(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region TerminateJobFlows

        /// <summary>
        /// <para> TerminateJobFlows shuts a list of job flows down. When a job flow is shut down, any step not yet completed is canceled and the EC2
        /// instances on which the job flow is running are stopped. Any log files not already saved are uploaded to Amazon S3 if a LogUri was specified
        /// when the job flow was created. </para> <para> The call to TerminateJobFlows is asynchronous. Depending on the configuration of the job flow,
        /// it may take up to 5-20 minutes for the job flow to completely terminate and release allocated resources, such as Amazon EC2 instances.
        /// </para>
        /// </summary>
        /// 
        /// <param name="terminateJobFlowsRequest">Container for the necessary parameters to execute the TerminateJobFlows service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest terminateJobFlowsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.TerminateJobFlows"/>
        /// </summary>
        /// 
        /// <param name="terminateJobFlowsRequest">Container for the necessary parameters to execute the TerminateJobFlows operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginTerminateJobFlows(TerminateJobFlowsRequest terminateJobFlowsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the TerminateJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.TerminateJobFlows"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateJobFlows.</param>
        TerminateJobFlowsResponse EndTerminateJobFlows(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeJobFlows

        /// <summary>
        /// <para> DescribeJobFlows returns a list of job flows that match all of the supplied parameters. The parameters can include a list of job flow
        /// IDs, job flow states, and restrictions on job flow creation date and time.</para> <para> Regardless of supplied parameters, only job flows
        /// created within the last two months are returned.</para> <para> If no parameters are supplied, then job flows matching either of the
        /// following criteria are returned:</para>
        /// <ul>
        /// <li>Job flows created and completed in the last two weeks</li>
        /// <li> Job flows created within the last two months that are in one of the following states: <c>RUNNING</c> ,
        /// <c>WAITING</c> ,
        /// <c>SHUTTING_DOWN</c> ,
        /// 
        /// <c>STARTING</c> </li>
        /// 
        /// </ul>
        /// <para> Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. </para>
        /// </summary>
        /// 
        /// <param name="describeJobFlowsRequest">Container for the necessary parameters to execute the DescribeJobFlows service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest describeJobFlowsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.DescribeJobFlows"/>
        /// </summary>
        /// 
        /// <param name="describeJobFlowsRequest">Container for the necessary parameters to execute the DescribeJobFlows operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobFlows
        ///         operation.</returns>
        IAsyncResult BeginDescribeJobFlows(DescribeJobFlowsRequest describeJobFlowsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeJobFlows operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.DescribeJobFlows"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobFlows.</param>
        /// 
        /// <returns>Returns a DescribeJobFlowsResult from AmazonElasticMapReduce.</returns>
        DescribeJobFlowsResponse EndDescribeJobFlows(IAsyncResult asyncResult);

        /// <summary>
        /// <para> DescribeJobFlows returns a list of job flows that match all of the supplied parameters. The parameters can include a list of job flow
        /// IDs, job flow states, and restrictions on job flow creation date and time.</para> <para> Regardless of supplied parameters, only job flows
        /// created within the last two months are returned.</para> <para> If no parameters are supplied, then job flows matching either of the
        /// following criteria are returned:</para>
        /// <ul>
        /// <li>Job flows created and completed in the last two weeks</li>
        /// <li> Job flows created within the last two months that are in one of the following states: <c>RUNNING</c> ,
        /// <c>WAITING</c> ,
        /// <c>SHUTTING_DOWN</c> ,
        /// 
        /// <c>STARTING</c> </li>
        /// 
        /// </ul>
        /// <para> Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        DescribeJobFlowsResponse DescribeJobFlows();
        
        #endregion
        
    

        #region SetTerminationProtection

        /// <summary>
        /// <para> SetTerminationProtection locks a job flow so the Amazon EC2 instances in the cluster cannot be terminated by user intervention, an
        /// API call, or in the event of a job-flow error. The cluster still terminates upon successful completion of the job flow. Calling
        /// SetTerminationProtection on a job flow is analogous to calling the Amazon EC2 DisableAPITermination API on all of the EC2 instances in a
        /// cluster.</para> <para> SetTerminationProtection is used to prevent accidental termination of a job flow and to ensure that in the event of
        /// an error, the instances will persist so you can recover any data stored in their ephemeral instance storage.</para> <para> To terminate a
        /// job flow that has been locked by setting SetTerminationProtection to <c>true</c> ,
        /// you must first unlock the job flow by a subsequent call to SetTerminationProtection in which you set the value to <c>false</c> .
        /// </para> <para> For more information, go to Protecting a Job Flow from Termination in the <i>Amazon Elastic MapReduce Developer's Guide.</i>
        /// </para>
        /// </summary>
        /// 
        /// <param name="setTerminationProtectionRequest">Container for the necessary parameters to execute the SetTerminationProtection service method
        ///          on AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest setTerminationProtectionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTerminationProtection operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.SetTerminationProtection"/>
        /// </summary>
        /// 
        /// <param name="setTerminationProtectionRequest">Container for the necessary parameters to execute the SetTerminationProtection operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetTerminationProtection(SetTerminationProtectionRequest setTerminationProtectionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetTerminationProtection operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.SetTerminationProtection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTerminationProtection.</param>
        SetTerminationProtectionResponse EndSetTerminationProtection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RunJobFlow

        /// <summary>
        /// <para> RunJobFlow creates and starts running a new job flow. The job flow will run the steps specified. Once the job flow completes, the
        /// cluster is stopped and the HDFS partition is lost. To prevent loss of data, configure the last step of the job flow to store results in
        /// Amazon S3. If the JobFlowInstancesConfig <c>KeepJobFlowAliveWhenNoSteps</c> parameter is set to <c>TRUE</c> , the job flow will transition
        /// to the WAITING state rather than shutting down once the steps have completed. </para> <para>For additional protection, you can set the
        /// JobFlowInstancesConfig <c>TerminationProtected</c> parameter to <c>TRUE</c> to lock the job flow and prevent it from being terminated by API
        /// call, user intervention, or in the event of a job flow error.</para> <para>A maximum of 256 steps are allowed in each job flow.</para>
        /// <para>If your job flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data.
        /// You can bypass the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries
        /// directly to the software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to Add More than
        /// 256 Steps to a Job Flow in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para>For long running job flows, we recommend
        /// that you periodically store your results.</para>
        /// </summary>
        /// 
        /// <param name="runJobFlowRequest">Container for the necessary parameters to execute the RunJobFlow service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <returns>The response from the RunJobFlow service method, as returned by AmazonElasticMapReduce.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        RunJobFlowResponse RunJobFlow(RunJobFlowRequest runJobFlowRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RunJobFlow operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.RunJobFlow"/>
        /// </summary>
        /// 
        /// <param name="runJobFlowRequest">Container for the necessary parameters to execute the RunJobFlow operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunJobFlow
        ///         operation.</returns>
        IAsyncResult BeginRunJobFlow(RunJobFlowRequest runJobFlowRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RunJobFlow operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.RunJobFlow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunJobFlow.</param>
        /// 
        /// <returns>Returns a RunJobFlowResult from AmazonElasticMapReduce.</returns>
        RunJobFlowResponse EndRunJobFlow(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyInstanceGroups

        /// <summary>
        /// <para>ModifyInstanceGroups modifies the number of nodes and configuration settings of an instance group. The input parameters include the
        /// new target instance count for the group and the instance group ID. The call will either succeed or fail atomically.</para>
        /// </summary>
        /// 
        /// <param name="modifyInstanceGroupsRequest">Container for the necessary parameters to execute the ModifyInstanceGroups service method on
        ///          AmazonElasticMapReduce.</param>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest modifyInstanceGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.ModifyInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="modifyInstanceGroupsRequest">Container for the necessary parameters to execute the ModifyInstanceGroups operation on
        ///          AmazonElasticMapReduce.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginModifyInstanceGroups(ModifyInstanceGroupsRequest modifyInstanceGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyInstanceGroups operation.
        /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.ModifyInstanceGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceGroups.</param>
        ModifyInstanceGroupsResponse EndModifyInstanceGroups(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
