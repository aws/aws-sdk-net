/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.RDS.Model;
using Amazon.RDS.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.RDS
{
    /// <summary>
    /// Implementation for accessing AmazonRDS.
    ///  
    /// Amazon Relational Database Service <para> Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier to set up,
    /// operate, and scale a relational database in the cloud. It provides cost-efficient, resizable capacity for an industry-standard relational
    /// database and manages common database administration tasks, freeing up developers to focus on what makes their applications and businesses
    /// unique. </para> <para> Amazon RDS gives you access to the capabilities of a familiar MySQL or Oracle database server. This means the code,
    /// applications, and tools you already use today with your existing MySQL or Oracle databases work with Amazon RDS without modification. Amazon
    /// RDS automatically backs up your database and maintains the database software that powers your DB Instance. Amazon RDS is flexible: you can
    /// scale your database instance's compute resources and storage capacity to meet your application's demand. As with all Amazon Web Services,
    /// there are no up-front investments, and you pay only for the resources you use. </para> <para> This is the <i>Amazon RDS API Reference</i> .
    /// It contains a comprehensive description of all Amazon RDS Query APIs and data types. To get started with Amazon RDS, go to the Amazon RDS
    /// Getting Started Guide. For more information on Amazon RDS concepts and usage scenarios, go to the Amazon RDS User Guide. </para>
    /// </summary>
    public class AmazonRDSClient : AmazonWebServiceClient, AmazonRDS
    {
    
        AbstractAWSSigner signer = new QueryStringSigner();

        #region Constructors

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials defined in the App.config.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRDSClient()
            : base(new EnvironmentAWSCredentials(), new AmazonRDSConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials defined in the App.config.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRDS Configuration Object</param>
        public AmazonRDSClient(AmazonRDSConfig config)
            : base(new EnvironmentAWSCredentials(), config, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRDSClient(AWSCredentials credentials)
            : this(credentials, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials and an
        /// AmazonRDSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(AWSCredentials credentials, AmazonRDSConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRDSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User)
        {
        }
        

        #endregion
   
        #region DeleteDBInstance

        /// <summary>
        /// <para> The DeleteDBInstance API deletes a previously provisioned RDS instance. A successful response from the web service indicates the
        /// request was received correctly. If a final DBSnapshot is requested the status of the RDS instance will be "deleting" until the DBSnapshot is
        /// created. DescribeDBInstance is used to monitor the status of this operation. This cannot be canceled or reverted once submitted. </para>
        /// </summary>
        /// 
        /// <param name="deleteDBInstanceRequest">Container for the necessary parameters to execute the DeleteDBInstance service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="SnapshotQuotaExceededException"/>
        /// <exception cref="DBSnapshotAlreadyExistsException"/>
        public DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest deleteDBInstanceRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBInstance(deleteDBInstanceRequest, null, null, true);
            return EndDeleteDBInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBInstance"/>
        /// </summary>
        /// 
        /// <param name="deleteDBInstanceRequest">Container for the necessary parameters to execute the DeleteDBInstance operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBInstance
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDBInstance(DeleteDBInstanceRequest deleteDBInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBInstance(deleteDBInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBInstance operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBInstance.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public DeleteDBInstanceResponse EndDeleteDBInstance(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBInstance(DeleteDBInstanceRequest deleteDBInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBInstanceRequestMarshaller().Marshall(deleteDBInstanceRequest);
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDBSubnetGroups

        /// <summary>
        /// <para> Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified, the list will contain only the descriptions of the
        /// specified DBSubnetGroup. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        public DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest describeDBSubnetGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBSubnetGroups(describeDBSubnetGroupsRequest, null, null, true);
            return EndDescribeDBSubnetGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="describeDBSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBSubnetGroups operation.</returns>
        public IAsyncResult BeginDescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest describeDBSubnetGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBSubnetGroups(describeDBSubnetGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSubnetGroups.</param>
        /// 
        /// <returns>Returns a DescribeDBSubnetGroupsResult from AmazonRDS.</returns>
        public DescribeDBSubnetGroupsResponse EndDescribeDBSubnetGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBSubnetGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest describeDBSubnetGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBSubnetGroupsRequestMarshaller().Marshall(describeDBSubnetGroupsRequest);
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified, the list will contain only the descriptions of the
        /// specified DBSubnetGroup. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        public DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups()
        {
            return DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest());
        }
        

        #endregion
    
        #region ModifyDBParameterGroup

        /// <summary>
        /// <para> Modifies the parameters of a DBParameterGroup. To modify more than one parameter submit a list of the following: ParameterName,
        /// ParameterValue, and ApplyMethod. A maximum of 20 parameters can be modified in a single request. </para> <para><b>NOTE:</b> The
        /// apply-immediate method can only be used for dynamic parameters; the pending-reboot method can be used for either dynamic or static
        /// parameters. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBParameterGroupRequest">Container for the necessary parameters to execute the ModifyDBParameterGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="InvalidDBParameterGroupStateException"/>
        public ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeModifyDBParameterGroup(modifyDBParameterGroupRequest, null, null, true);
            return EndModifyDBParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyDBParameterGroupRequest">Container for the necessary parameters to execute the ModifyDBParameterGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyDBParameterGroup operation.</returns>
        public IAsyncResult BeginModifyDBParameterGroup(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeModifyDBParameterGroup(modifyDBParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBParameterGroup.</param>
        /// 
        /// <returns>Returns a ModifyDBParameterGroupResult from AmazonRDS.</returns>
        public ModifyDBParameterGroupResponse EndModifyDBParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<ModifyDBParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyDBParameterGroup(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyDBParameterGroupRequestMarshaller().Marshall(modifyDBParameterGroupRequest);
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyDBInstance

        /// <summary>
        /// <para> Modify settings for a DB Instance. You can change one or more database configuration parameters by specifying these parameters and
        /// the new values in the request. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBInstanceRequest">Container for the necessary parameters to execute the ModifyDBInstance service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InvalidDBSecurityGroupStateException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        public ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest modifyDBInstanceRequest)
        {
            IAsyncResult asyncResult = invokeModifyDBInstance(modifyDBInstanceRequest, null, null, true);
            return EndModifyDBInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyDBInstance"/>
        /// </summary>
        /// 
        /// <param name="modifyDBInstanceRequest">Container for the necessary parameters to execute the ModifyDBInstance operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBInstance
        ///         operation.</returns>
        public IAsyncResult BeginModifyDBInstance(ModifyDBInstanceRequest modifyDBInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeModifyDBInstance(modifyDBInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyDBInstance operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyDBInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBInstance.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public ModifyDBInstanceResponse EndModifyDBInstance(IAsyncResult asyncResult)
        {
            return endOperation<ModifyDBInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyDBInstance(ModifyDBInstanceRequest modifyDBInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyDBInstanceRequestMarshaller().Marshall(modifyDBInstanceRequest);
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeReservedDBInstances

        /// <summary>
        /// <para> Returns information about reserved DB Instances for this account, or about a specified reserved DB Instance. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesRequest">Container for the necessary parameters to execute the DescribeReservedDBInstances service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstanceNotFoundException"/>
        public DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedDBInstances(describeReservedDBInstancesRequest, null, null, true);
            return EndDescribeReservedDBInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstances operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeReservedDBInstances"/>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesRequest">Container for the necessary parameters to execute the DescribeReservedDBInstances operation
        ///          on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedDBInstances operation.</returns>
        public IAsyncResult BeginDescribeReservedDBInstances(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedDBInstances(describeReservedDBInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedDBInstances operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeReservedDBInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedDBInstances.</param>
        /// 
        /// <returns>Returns a DescribeReservedDBInstancesResult from AmazonRDS.</returns>
        public DescribeReservedDBInstancesResponse EndDescribeReservedDBInstances(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedDBInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedDBInstances(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedDBInstancesRequestMarshaller().Marshall(describeReservedDBInstancesRequest);
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns information about reserved DB Instances for this account, or about a specified reserved DB Instance. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstanceNotFoundException"/>
        public DescribeReservedDBInstancesResponse DescribeReservedDBInstances()
        {
            return DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest());
        }
        

        #endregion
    
        #region DeleteDBSubnetGroup

        /// <summary>
        /// <para> Deletes a DB subnet group. </para> <para><b>NOTE:</b>The specified database subnet group must not be associated with any DB
        /// instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSubnetGroupRequest">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="InvalidDBSubnetGroupStateException"/>
        /// <exception cref="InvalidDBSubnetStateException"/>
        public DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest deleteDBSubnetGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBSubnetGroup(deleteDBSubnetGroupRequest, null, null, true);
            return EndDeleteDBSubnetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteDBSubnetGroupRequest">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteDBSubnetGroup(DeleteDBSubnetGroupRequest deleteDBSubnetGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBSubnetGroup(deleteDBSubnetGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSubnetGroup.</param>
        public DeleteDBSubnetGroupResponse EndDeleteDBSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBSubnetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBSubnetGroup(DeleteDBSubnetGroupRequest deleteDBSubnetGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBSubnetGroupRequestMarshaller().Marshall(deleteDBSubnetGroupRequest);
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBSubnetGroup

        /// <summary>
        /// <para> Creates a new DB subnet group. DB subnet groups must contain at least one subnet in each AZ in the region. </para>
        /// </summary>
        /// 
        /// <param name="createDBSubnetGroupRequest">Container for the necessary parameters to execute the CreateDBSubnetGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSubnetQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupAlreadyExistsException"/>
        /// <exception cref="DBSubnetGroupQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupListDoesNotCoverAllAzException"/>
        /// <exception cref="InvalidSubnetException"/>
        public CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest createDBSubnetGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBSubnetGroup(createDBSubnetGroupRequest, null, null, true);
            return EndCreateDBSubnetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="createDBSubnetGroupRequest">Container for the necessary parameters to execute the CreateDBSubnetGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDBSubnetGroup operation.</returns>
        public IAsyncResult BeginCreateDBSubnetGroup(CreateDBSubnetGroupRequest createDBSubnetGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBSubnetGroup(createDBSubnetGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a DBSubnetGroup from AmazonRDS.</returns>
        public CreateDBSubnetGroupResponse EndCreateDBSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBSubnetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBSubnetGroup(CreateDBSubnetGroupRequest createDBSubnetGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBSubnetGroupRequestMarshaller().Marshall(createDBSubnetGroupRequest);
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDBSecurityGroups

        /// <summary>
        /// <para> Returns a list of DBSecurityGroup descriptions. If a DBSecurityGroupName is specified, the list will contain only the descriptions of
        /// the specified DBSecurityGroup. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method
        ///          on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBSecurityGroups(describeDBSecurityGroupsRequest, null, null, true);
            return EndDescribeDBSecurityGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="describeDBSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeDBSecurityGroups operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBSecurityGroups operation.</returns>
        public IAsyncResult BeginDescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBSecurityGroups(describeDBSecurityGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSecurityGroups.</param>
        /// 
        /// <returns>Returns a DescribeDBSecurityGroupsResult from AmazonRDS.</returns>
        public DescribeDBSecurityGroupsResponse EndDescribeDBSecurityGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBSecurityGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBSecurityGroupsRequestMarshaller().Marshall(describeDBSecurityGroupsRequest);
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of DBSecurityGroup descriptions. If a DBSecurityGroupName is specified, the list will contain only the descriptions of
        /// the specified DBSecurityGroup. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups()
        {
            return DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest());
        }
        

        #endregion
    
        #region PurchaseReservedDBInstancesOffering

        /// <summary>
        /// <para> Purchases a reserved DB Instance offering. </para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedDBInstancesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedDBInstancesOffering service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the PurchaseReservedDBInstancesOffering service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstancesOfferingNotFoundException"/>
        /// <exception cref="ReservedDBInstanceQuotaExceededException"/>
        /// <exception cref="ReservedDBInstanceAlreadyExistsException"/>
        public PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest purchaseReservedDBInstancesOfferingRequest)
        {
            IAsyncResult asyncResult = invokePurchaseReservedDBInstancesOffering(purchaseReservedDBInstancesOfferingRequest, null, null, true);
            return EndPurchaseReservedDBInstancesOffering(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.PurchaseReservedDBInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="purchaseReservedDBInstancesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedDBInstancesOffering operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPurchaseReservedDBInstancesOffering operation.</returns>
        public IAsyncResult BeginPurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest purchaseReservedDBInstancesOfferingRequest, AsyncCallback callback, object state)
        {
            return invokePurchaseReservedDBInstancesOffering(purchaseReservedDBInstancesOfferingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.PurchaseReservedDBInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedDBInstancesOffering.</param>
        /// 
        /// <returns>Returns a ReservedDBInstance from AmazonRDS.</returns>
        public PurchaseReservedDBInstancesOfferingResponse EndPurchaseReservedDBInstancesOffering(IAsyncResult asyncResult)
        {
            return endOperation<PurchaseReservedDBInstancesOfferingResponse>(asyncResult);
        }
        
        IAsyncResult invokePurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest purchaseReservedDBInstancesOfferingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PurchaseReservedDBInstancesOfferingRequestMarshaller().Marshall(purchaseReservedDBInstancesOfferingRequest);
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDBSecurityGroup

        /// <summary>
        /// <para> Deletes a DB Security Group. </para> <para><b>NOTE:</b>The specified DB Security Group must not be associated with any DB
        /// Instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSecurityGroupRequest">Container for the necessary parameters to execute the DeleteDBSecurityGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InvalidDBSecurityGroupStateException"/>
        public DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest deleteDBSecurityGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBSecurityGroup(deleteDBSecurityGroupRequest, null, null, true);
            return EndDeleteDBSecurityGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteDBSecurityGroupRequest">Container for the necessary parameters to execute the DeleteDBSecurityGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteDBSecurityGroup(DeleteDBSecurityGroupRequest deleteDBSecurityGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBSecurityGroup(deleteDBSecurityGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSecurityGroup.</param>
        public DeleteDBSecurityGroupResponse EndDeleteDBSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBSecurityGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBSecurityGroup(DeleteDBSecurityGroupRequest deleteDBSecurityGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBSecurityGroupRequestMarshaller().Marshall(deleteDBSecurityGroupRequest);
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyDBSubnetGroup

        /// <summary>
        /// <para> Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet in each AZ in the region. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBSubnetGroupRequest">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="DBSubnetQuotaExceededException"/>
        /// <exception cref="SubnetAlreadyInUseException"/>
        /// <exception cref="DBSubnetGroupListDoesNotCoverAllAzException"/>
        /// <exception cref="InvalidSubnetException"/>
        public ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest modifyDBSubnetGroupRequest)
        {
            IAsyncResult asyncResult = invokeModifyDBSubnetGroup(modifyDBSubnetGroupRequest, null, null, true);
            return EndModifyDBSubnetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyDBSubnetGroupRequest">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyDBSubnetGroup operation.</returns>
        public IAsyncResult BeginModifyDBSubnetGroup(ModifyDBSubnetGroupRequest modifyDBSubnetGroupRequest, AsyncCallback callback, object state)
        {
            return invokeModifyDBSubnetGroup(modifyDBSubnetGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a DBSubnetGroup from AmazonRDS.</returns>
        public ModifyDBSubnetGroupResponse EndModifyDBSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation<ModifyDBSubnetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyDBSubnetGroup(ModifyDBSubnetGroupRequest modifyDBSubnetGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyDBSubnetGroupRequestMarshaller().Marshall(modifyDBSubnetGroupRequest);
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBSnapshot

        /// <summary>
        /// <para> Creates a DBSnapshot. The source DBInstance must be in "available" state. </para>
        /// </summary>
        /// 
        /// <param name="createDBSnapshotRequest">Container for the necessary parameters to execute the CreateDBSnapshot service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="SnapshotQuotaExceededException"/>
        /// <exception cref="DBSnapshotAlreadyExistsException"/>
        public CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest createDBSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBSnapshot(createDBSnapshotRequest, null, null, true);
            return EndCreateDBSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="createDBSnapshotRequest">Container for the necessary parameters to execute the CreateDBSnapshot operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCreateDBSnapshot(CreateDBSnapshotRequest createDBSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBSnapshot(createDBSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSnapshot.</param>
        /// 
        /// <returns>Returns a DBSnapshot from AmazonRDS.</returns>
        public CreateDBSnapshotResponse EndCreateDBSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBSnapshot(CreateDBSnapshotRequest createDBSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBSnapshotRequestMarshaller().Marshall(createDBSnapshotRequest);
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDBEngineVersions

        /// <summary>
        /// <para> Returns a list of the available DB engines. </para>
        /// </summary>
        /// 
        /// <param name="describeDBEngineVersionsRequest">Container for the necessary parameters to execute the DescribeDBEngineVersions service method
        ///          on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBEngineVersions(describeDBEngineVersionsRequest, null, null, true);
            return EndDescribeDBEngineVersions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="describeDBEngineVersionsRequest">Container for the necessary parameters to execute the DescribeDBEngineVersions operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBEngineVersions operation.</returns>
        public IAsyncResult BeginDescribeDBEngineVersions(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBEngineVersions(describeDBEngineVersionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBEngineVersions operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBEngineVersions.</param>
        /// 
        /// <returns>Returns a DescribeDBEngineVersionsResult from AmazonRDS.</returns>
        public DescribeDBEngineVersionsResponse EndDescribeDBEngineVersions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBEngineVersionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBEngineVersions(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBEngineVersionsRequestMarshaller().Marshall(describeDBEngineVersionsRequest);
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of the available DB engines. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeDBEngineVersionsResponse DescribeDBEngineVersions()
        {
            return DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest());
        }
        

        #endregion
    
        #region RestoreDBInstanceToPointInTime

        /// <summary>
        /// <para> Restores a DB Instance to an arbitrary point-in-time. Users can restore to any point in time before the latestRestorableTime for up
        /// to backupRetentionPeriod days. The target database is created from the source database with the same configuration as the original database
        /// except that the DB instance is created with the default DB security group. </para>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceToPointInTimeRequest">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime
        ///          service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceToPointInTime service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="PointInTimeRestoreNotEnabledException"/>
        /// <exception cref="InvalidRestoreException"/>
        /// <exception cref="InstanceQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="DBInstanceAlreadyExistsException"/>
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        public RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest)
        {
            IAsyncResult asyncResult = invokeRestoreDBInstanceToPointInTime(restoreDBInstanceToPointInTimeRequest, null, null, true);
            return EndRestoreDBInstanceToPointInTime(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.RestoreDBInstanceToPointInTime"/>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceToPointInTimeRequest">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRestoreDBInstanceToPointInTime operation.</returns>
        public IAsyncResult BeginRestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest, AsyncCallback callback, object state)
        {
            return invokeRestoreDBInstanceToPointInTime(restoreDBInstanceToPointInTimeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.RestoreDBInstanceToPointInTime"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBInstanceToPointInTime.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public RestoreDBInstanceToPointInTimeResponse EndRestoreDBInstanceToPointInTime(IAsyncResult asyncResult)
        {
            return endOperation<RestoreDBInstanceToPointInTimeResponse>(asyncResult);
        }
        
        IAsyncResult invokeRestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RestoreDBInstanceToPointInTimeRequestMarshaller().Marshall(restoreDBInstanceToPointInTimeRequest);
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CopyDBSnapshot

        /// <summary>
        /// <para> Copies the specified DBSnapshot. The source DBSnapshot must be in the "available" state. </para>
        /// </summary>
        /// 
        /// <param name="copyDBSnapshotRequest">Container for the necessary parameters to execute the CopyDBSnapshot service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CopyDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="InvalidDBSnapshotStateException"/>
        /// <exception cref="SnapshotQuotaExceededException"/>
        /// <exception cref="DBSnapshotAlreadyExistsException"/>
        /// <exception cref="DBSnapshotNotFoundException"/>
        public CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest copyDBSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeCopyDBSnapshot(copyDBSnapshotRequest, null, null, true);
            return EndCopyDBSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CopyDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="copyDBSnapshotRequest">Container for the necessary parameters to execute the CopyDBSnapshot operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCopyDBSnapshot(CopyDBSnapshotRequest copyDBSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeCopyDBSnapshot(copyDBSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CopyDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CopyDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDBSnapshot.</param>
        /// 
        /// <returns>Returns a DBSnapshot from AmazonRDS.</returns>
        public CopyDBSnapshotResponse EndCopyDBSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<CopyDBSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeCopyDBSnapshot(CopyDBSnapshotRequest copyDBSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CopyDBSnapshotRequestMarshaller().Marshall(copyDBSnapshotRequest);
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ResetDBParameterGroup

        /// <summary>
        /// <para> Modifies the parameters of a DBParameterGroup to the engine/system default value. To reset specific parameters submit a list of the
        /// following: ParameterName and ApplyMethod. To reset the entire DBParameterGroup specify the DBParameterGroup name and ResetAllParameters
        /// parameters. When resetting the entire group, dynamic parameters are updated immediately and static parameters are set to pending-reboot to
        /// take effect on the next DB instance restart or RebootDBInstance request. </para>
        /// </summary>
        /// 
        /// <param name="resetDBParameterGroupRequest">Container for the necessary parameters to execute the ResetDBParameterGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="InvalidDBParameterGroupStateException"/>
        public ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest resetDBParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeResetDBParameterGroup(resetDBParameterGroupRequest, null, null, true);
            return EndResetDBParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.ResetDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="resetDBParameterGroupRequest">Container for the necessary parameters to execute the ResetDBParameterGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndResetDBParameterGroup operation.</returns>
        public IAsyncResult BeginResetDBParameterGroup(ResetDBParameterGroupRequest resetDBParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeResetDBParameterGroup(resetDBParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResetDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.ResetDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetDBParameterGroup.</param>
        /// 
        /// <returns>Returns a ResetDBParameterGroupResult from AmazonRDS.</returns>
        public ResetDBParameterGroupResponse EndResetDBParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<ResetDBParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeResetDBParameterGroup(ResetDBParameterGroupRequest resetDBParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResetDBParameterGroupRequestMarshaller().Marshall(resetDBParameterGroupRequest);
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeOrderableDBInstanceOptions

        /// <summary>
        /// <para> Returns a list of orderable DB Instance options for the specified engine. </para>
        /// </summary>
        /// 
        /// <param name="describeOrderableDBInstanceOptionsRequest">Container for the necessary parameters to execute the
        ///          DescribeOrderableDBInstanceOptions service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest describeOrderableDBInstanceOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeOrderableDBInstanceOptions(describeOrderableDBInstanceOptionsRequest, null, null, true);
            return EndDescribeOrderableDBInstanceOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeOrderableDBInstanceOptions"/>
        /// </summary>
        /// 
        /// <param name="describeOrderableDBInstanceOptionsRequest">Container for the necessary parameters to execute the
        ///          DescribeOrderableDBInstanceOptions operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeOrderableDBInstanceOptions operation.</returns>
        public IAsyncResult BeginDescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest describeOrderableDBInstanceOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeOrderableDBInstanceOptions(describeOrderableDBInstanceOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeOrderableDBInstanceOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableDBInstanceOptions.</param>
        /// 
        /// <returns>Returns a DescribeOrderableDBInstanceOptionsResult from AmazonRDS.</returns>
        public DescribeOrderableDBInstanceOptionsResponse EndDescribeOrderableDBInstanceOptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeOrderableDBInstanceOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest describeOrderableDBInstanceOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeOrderableDBInstanceOptionsRequestMarshaller().Marshall(describeOrderableDBInstanceOptionsRequest);
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDBSnapshot

        /// <summary>
        /// <para> Deletes a DBSnapshot. </para> <para><b>NOTE:</b>The DBSnapshot must be in the available state to be deleted.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSnapshotRequest">Container for the necessary parameters to execute the DeleteDBSnapshot service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="InvalidDBSnapshotStateException"/>
        /// <exception cref="DBSnapshotNotFoundException"/>
        public DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest deleteDBSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBSnapshot(deleteDBSnapshotRequest, null, null, true);
            return EndDeleteDBSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="deleteDBSnapshotRequest">Container for the necessary parameters to execute the DeleteDBSnapshot operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDBSnapshot(DeleteDBSnapshotRequest deleteDBSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBSnapshot(deleteDBSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSnapshot.</param>
        /// 
        /// <returns>Returns a DBSnapshot from AmazonRDS.</returns>
        public DeleteDBSnapshotResponse EndDeleteDBSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBSnapshot(DeleteDBSnapshotRequest deleteDBSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBSnapshotRequestMarshaller().Marshall(deleteDBSnapshotRequest);
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDBParameters

        /// <summary>
        /// <para> Returns the detailed parameter list for a particular DBParameterGroup. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParametersRequest">Container for the necessary parameters to execute the DescribeDBParameters service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        public DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest describeDBParametersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBParameters(describeDBParametersRequest, null, null, true);
            return EndDescribeDBParameters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBParameters"/>
        /// </summary>
        /// 
        /// <param name="describeDBParametersRequest">Container for the necessary parameters to execute the DescribeDBParameters operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBParameters operation.</returns>
        public IAsyncResult BeginDescribeDBParameters(DescribeDBParametersRequest describeDBParametersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBParameters(describeDBParametersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBParameters operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBParameters.</param>
        /// 
        /// <returns>Returns a DescribeDBParametersResult from AmazonRDS.</returns>
        public DescribeDBParametersResponse EndDescribeDBParameters(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBParametersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBParameters(DescribeDBParametersRequest describeDBParametersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBParametersRequestMarshaller().Marshall(describeDBParametersRequest);
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBInstance

        /// <summary>
        /// <para> Creates a new DB instance. </para>
        /// </summary>
        /// 
        /// <param name="createDBInstanceRequest">Container for the necessary parameters to execute the CreateDBInstance service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="InstanceQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="DBInstanceAlreadyExistsException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        public CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest createDBInstanceRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBInstance(createDBInstanceRequest, null, null, true);
            return EndCreateDBInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBInstance"/>
        /// </summary>
        /// 
        /// <param name="createDBInstanceRequest">Container for the necessary parameters to execute the CreateDBInstance operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBInstance
        ///         operation.</returns>
        public IAsyncResult BeginCreateDBInstance(CreateDBInstanceRequest createDBInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBInstance(createDBInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBInstance operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBInstance.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public CreateDBInstanceResponse EndCreateDBInstance(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBInstance(CreateDBInstanceRequest createDBInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBInstanceRequestMarshaller().Marshall(createDBInstanceRequest);
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDBParameterGroup

        /// <summary>
        /// <para> Deletes a specified DBParameterGroup. The DBParameterGroup cannot be associated with any RDS instances to be deleted. </para>
        /// <para><b>NOTE:</b> The specified DB Parameter Group cannot be associated with any DB Instances. </para>
        /// </summary>
        /// 
        /// <param name="deleteDBParameterGroupRequest">Container for the necessary parameters to execute the DeleteDBParameterGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="InvalidDBParameterGroupStateException"/>
        public DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest deleteDBParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBParameterGroup(deleteDBParameterGroupRequest, null, null, true);
            return EndDeleteDBParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteDBParameterGroupRequest">Container for the necessary parameters to execute the DeleteDBParameterGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteDBParameterGroup(DeleteDBParameterGroupRequest deleteDBParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBParameterGroup(deleteDBParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DeleteDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBParameterGroup.</param>
        public DeleteDBParameterGroupResponse EndDeleteDBParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBParameterGroup(DeleteDBParameterGroupRequest deleteDBParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBParameterGroupRequestMarshaller().Marshall(deleteDBParameterGroupRequest);
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RevokeDBSecurityGroupIngress

        /// <summary>
        /// <para> Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2 or VPC Security Groups. Required parameters for
        /// this API are one of CIDRIP, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
        /// </para>
        /// </summary>
        /// 
        /// <param name="revokeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RevokeDBSecurityGroupIngress service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InvalidDBSecurityGroupStateException"/>
        /// <exception cref="AuthorizationNotFoundException"/>
        public RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest)
        {
            IAsyncResult asyncResult = invokeRevokeDBSecurityGroupIngress(revokeDBSecurityGroupIngressRequest, null, null, true);
            return EndRevokeDBSecurityGroupIngress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.RevokeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="revokeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRevokeDBSecurityGroupIngress operation.</returns>
        public IAsyncResult BeginRevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest, AsyncCallback callback, object state)
        {
            return invokeRevokeDBSecurityGroupIngress(revokeDBSecurityGroupIngressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.RevokeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeDBSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a DBSecurityGroup from AmazonRDS.</returns>
        public RevokeDBSecurityGroupIngressResponse EndRevokeDBSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation<RevokeDBSecurityGroupIngressResponse>(asyncResult);
        }
        
        IAsyncResult invokeRevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RevokeDBSecurityGroupIngressRequestMarshaller().Marshall(revokeDBSecurityGroupIngressRequest);
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBSecurityGroup

        /// <summary>
        /// <para> Creates a new DB Security Group. DB Security Groups control access to a DB Instance. </para>
        /// </summary>
        /// 
        /// <param name="createDBSecurityGroupRequest">Container for the necessary parameters to execute the CreateDBSecurityGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSecurityGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupQuotaExceededException"/>
        /// <exception cref="DBSecurityGroupAlreadyExistsException"/>
        public CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest createDBSecurityGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBSecurityGroup(createDBSecurityGroupRequest, null, null, true);
            return EndCreateDBSecurityGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="createDBSecurityGroupRequest">Container for the necessary parameters to execute the CreateDBSecurityGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDBSecurityGroup operation.</returns>
        public IAsyncResult BeginCreateDBSecurityGroup(CreateDBSecurityGroupRequest createDBSecurityGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBSecurityGroup(createDBSecurityGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSecurityGroup.</param>
        /// 
        /// <returns>Returns a DBSecurityGroup from AmazonRDS.</returns>
        public CreateDBSecurityGroupResponse EndCreateDBSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBSecurityGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBSecurityGroup(CreateDBSecurityGroupRequest createDBSecurityGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBSecurityGroupRequestMarshaller().Marshall(createDBSecurityGroupRequest);
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDBParameterGroups

        /// <summary>
        /// <para> Returns a list of DBParameterGroup descriptions. If a DBParameterGroupName is specified, the list will contain only the description
        /// of the specified DBParameterGroup. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParameterGroupsRequest">Container for the necessary parameters to execute the DescribeDBParameterGroups service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        public DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest describeDBParameterGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBParameterGroups(describeDBParameterGroupsRequest, null, null, true);
            return EndDescribeDBParameterGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="describeDBParameterGroupsRequest">Container for the necessary parameters to execute the DescribeDBParameterGroups operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBParameterGroups operation.</returns>
        public IAsyncResult BeginDescribeDBParameterGroups(DescribeDBParameterGroupsRequest describeDBParameterGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBParameterGroups(describeDBParameterGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBParameterGroups operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBParameterGroups.</param>
        /// 
        /// <returns>Returns a DescribeDBParameterGroupsResult from AmazonRDS.</returns>
        public DescribeDBParameterGroupsResponse EndDescribeDBParameterGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBParameterGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBParameterGroups(DescribeDBParameterGroupsRequest describeDBParameterGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBParameterGroupsRequestMarshaller().Marshall(describeDBParameterGroupsRequest);
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of DBParameterGroup descriptions. If a DBParameterGroupName is specified, the list will contain only the description
        /// of the specified DBParameterGroup. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        public DescribeDBParameterGroupsResponse DescribeDBParameterGroups()
        {
            return DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest());
        }
        

        #endregion
    
        #region DescribeEvents

        /// <summary>
        /// <para> Returns events related to DB Instances, DB Security Groups, DB Snapshots and DB Parameter Groups for the past 14 days. Events
        /// specific to a particular DB Instance, DB Security Group, database snapshot or DB Parameter Group can be obtained by providing the name as a
        /// parameter. By default, the past hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEvents(describeEventsRequest, null, null, true);
            return EndDescribeEvents(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEvents(describeEventsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a DescribeEventsResult from AmazonRDS.</returns>
        public DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEventsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEventsRequestMarshaller().Marshall(describeEventsRequest);
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns events related to DB Instances, DB Security Groups, DB Snapshots and DB Parameter Groups for the past 14 days. Events
        /// specific to a particular DB Instance, DB Security Group, database snapshot or DB Parameter Group can be obtained by providing the name as a
        /// parameter. By default, the past hour of events are returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        

        #endregion
    
        #region DescribeEngineDefaultParameters

        /// <summary>
        /// <para> Returns the default engine and system parameter information for the specified database engine. </para>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        ///          service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEngineDefaultParameters(describeEngineDefaultParametersRequest, null, null, true);
            return EndDescribeEngineDefaultParameters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEngineDefaultParameters operation.</returns>
        public IAsyncResult BeginDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEngineDefaultParameters(describeEngineDefaultParametersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultParameters.</param>
        /// 
        /// <returns>Returns a EngineDefaults from AmazonRDS.</returns>
        public DescribeEngineDefaultParametersResponse EndDescribeEngineDefaultParameters(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEngineDefaultParametersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEngineDefaultParametersRequestMarshaller().Marshall(describeEngineDefaultParametersRequest);
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBParameterGroup

        /// <summary>
        /// <para> Creates a new DB Parameter Group. </para> <para> A DB Parameter Group is initially created with the default parameters for the
        /// database engine used by the DB Instance. To provide custom values for any of the parameters, you must modify the group after creating it
        /// using <i>ModifyDBParameterGroup</i> . Once you've created a DB Parameter Group, you need to associate it with your DB Instance using
        /// <i>ModifyDBInstance</i> . When you associate a new DB Parameter Group with a running DB Instance, you need to reboot the DB Instance for the
        /// new DB Parameter Group and associated settings to take effect. </para>
        /// </summary>
        /// 
        /// <param name="createDBParameterGroupRequest">Container for the necessary parameters to execute the CreateDBParameterGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupQuotaExceededException"/>
        /// <exception cref="DBParameterGroupAlreadyExistsException"/>
        public CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest createDBParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBParameterGroup(createDBParameterGroupRequest, null, null, true);
            return EndCreateDBParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="createDBParameterGroupRequest">Container for the necessary parameters to execute the CreateDBParameterGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDBParameterGroup operation.</returns>
        public IAsyncResult BeginCreateDBParameterGroup(CreateDBParameterGroupRequest createDBParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBParameterGroup(createDBParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBParameterGroup.</param>
        /// 
        /// <returns>Returns a DBParameterGroup from AmazonRDS.</returns>
        public CreateDBParameterGroupResponse EndCreateDBParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBParameterGroup(CreateDBParameterGroupRequest createDBParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBParameterGroupRequestMarshaller().Marshall(createDBParameterGroupRequest);
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeReservedDBInstancesOfferings

        /// <summary>
        /// <para> Lists available reserved DB Instance offerings. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedDBInstancesOfferings service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstancesOfferingNotFoundException"/>
        public DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedDBInstancesOfferings(describeReservedDBInstancesOfferingsRequest, null, null, true);
            return EndDescribeReservedDBInstancesOfferings(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeReservedDBInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedDBInstancesOfferings operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedDBInstancesOfferings operation.</returns>
        public IAsyncResult BeginDescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedDBInstancesOfferings(describeReservedDBInstancesOfferingsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeReservedDBInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedDBInstancesOfferings.</param>
        /// 
        /// <returns>Returns a DescribeReservedDBInstancesOfferingsResult from AmazonRDS.</returns>
        public DescribeReservedDBInstancesOfferingsResponse EndDescribeReservedDBInstancesOfferings(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedDBInstancesOfferingsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedDBInstancesOfferingsRequestMarshaller().Marshall(describeReservedDBInstancesOfferingsRequest);
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Lists available reserved DB Instance offerings. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstancesOfferingNotFoundException"/>
        public DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings()
        {
            return DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest());
        }
        

        #endregion
    
        #region DescribeDBInstances

        /// <summary>
        /// <para> Returns information about provisioned RDS instances. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBInstancesRequest">Container for the necessary parameters to execute the DescribeDBInstances service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        public DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest describeDBInstancesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBInstances(describeDBInstancesRequest, null, null, true);
            return EndDescribeDBInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBInstances"/>
        /// </summary>
        /// 
        /// <param name="describeDBInstancesRequest">Container for the necessary parameters to execute the DescribeDBInstances operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBInstances operation.</returns>
        public IAsyncResult BeginDescribeDBInstances(DescribeDBInstancesRequest describeDBInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBInstances(describeDBInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBInstances operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBInstances.</param>
        /// 
        /// <returns>Returns a DescribeDBInstancesResult from AmazonRDS.</returns>
        public DescribeDBInstancesResponse EndDescribeDBInstances(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBInstances(DescribeDBInstancesRequest describeDBInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBInstancesRequestMarshaller().Marshall(describeDBInstancesRequest);
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns information about provisioned RDS instances. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        public DescribeDBInstancesResponse DescribeDBInstances()
        {
            return DescribeDBInstances(new DescribeDBInstancesRequest());
        }
        

        #endregion
    
        #region RebootDBInstance

        /// <summary>
        /// <para> Reboots a previously provisioned RDS instance. This API results in the application of modified DBParameterGroup parameters with
        /// ApplyStatus of pending-reboot to the RDS instance. This action is taken as soon as possible, and results in a momentary outage to the RDS
        /// instance during which the RDS instance status is set to rebooting. A DBInstance event is created when the reboot is completed. </para>
        /// </summary>
        /// 
        /// <param name="rebootDBInstanceRequest">Container for the necessary parameters to execute the RebootDBInstance service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        public RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest rebootDBInstanceRequest)
        {
            IAsyncResult asyncResult = invokeRebootDBInstance(rebootDBInstanceRequest, null, null, true);
            return EndRebootDBInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.RebootDBInstance"/>
        /// </summary>
        /// 
        /// <param name="rebootDBInstanceRequest">Container for the necessary parameters to execute the RebootDBInstance operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootDBInstance
        ///         operation.</returns>
        public IAsyncResult BeginRebootDBInstance(RebootDBInstanceRequest rebootDBInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeRebootDBInstance(rebootDBInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RebootDBInstance operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.RebootDBInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootDBInstance.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public RebootDBInstanceResponse EndRebootDBInstance(IAsyncResult asyncResult)
        {
            return endOperation<RebootDBInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeRebootDBInstance(RebootDBInstanceRequest rebootDBInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RebootDBInstanceRequestMarshaller().Marshall(rebootDBInstanceRequest);
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RestoreDBInstanceFromDBSnapshot

        /// <summary>
        /// <para> Creates a new DB Instance from a DB snapshot. The target database is created from the source database restore point with the same
        /// configuration as the original source database, except that the new RDS instance is created with the default security group. </para>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceFromDBSnapshotRequest">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot
        ///          service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="InvalidRestoreException"/>
        /// <exception cref="InstanceQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="DBInstanceAlreadyExistsException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InvalidDBSnapshotStateException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        /// <exception cref="DBSnapshotNotFoundException"/>
        public RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeRestoreDBInstanceFromDBSnapshot(restoreDBInstanceFromDBSnapshotRequest, null, null, true);
            return EndRestoreDBInstanceFromDBSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.RestoreDBInstanceFromDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceFromDBSnapshotRequest">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRestoreDBInstanceFromDBSnapshot operation.</returns>
        public IAsyncResult BeginRestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeRestoreDBInstanceFromDBSnapshot(restoreDBInstanceFromDBSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.RestoreDBInstanceFromDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBInstanceFromDBSnapshot.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public RestoreDBInstanceFromDBSnapshotResponse EndRestoreDBInstanceFromDBSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<RestoreDBInstanceFromDBSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeRestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RestoreDBInstanceFromDBSnapshotRequestMarshaller().Marshall(restoreDBInstanceFromDBSnapshotRequest);
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AuthorizeDBSecurityGroupIngress

        /// <summary>
        /// <para> Enables ingress to a DBSecurityGroup using one of two forms of authorization. First, EC2 or VPC Security Groups can be added to the
        /// DBSecurityGroup if the application using the database is running on EC2 or VPC instances. Second, IP ranges are available if the application
        /// accessing your database is running on the Internet. Required parameters for this API are one of CIDR range, EC2SecurityGroupId for VPC, or
        /// (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC). </para> <para><b>NOTE:</b> You cannot authorize
        /// ingress from an EC2 security group in one Region to an Amazon RDS DB Instance in another. You cannot authorize ingress from a VPC security
        /// group in one VPC to an Amazon RDS DB Instance in another. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial.
        /// </para>
        /// </summary>
        /// 
        /// <param name="authorizeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress
        ///          service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the AuthorizeDBSecurityGroupIngress service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InvalidDBSecurityGroupStateException"/>
        /// <exception cref="AuthorizationAlreadyExistsException"/>
        /// <exception cref="AuthorizationQuotaExceededException"/>
        public AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest authorizeDBSecurityGroupIngressRequest)
        {
            IAsyncResult asyncResult = invokeAuthorizeDBSecurityGroupIngress(authorizeDBSecurityGroupIngressRequest, null, null, true);
            return EndAuthorizeDBSecurityGroupIngress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.AuthorizeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="authorizeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAuthorizeDBSecurityGroupIngress operation.</returns>
        public IAsyncResult BeginAuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest authorizeDBSecurityGroupIngressRequest, AsyncCallback callback, object state)
        {
            return invokeAuthorizeDBSecurityGroupIngress(authorizeDBSecurityGroupIngressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.AuthorizeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeDBSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a DBSecurityGroup from AmazonRDS.</returns>
        public AuthorizeDBSecurityGroupIngressResponse EndAuthorizeDBSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation<AuthorizeDBSecurityGroupIngressResponse>(asyncResult);
        }
        
        IAsyncResult invokeAuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest authorizeDBSecurityGroupIngressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AuthorizeDBSecurityGroupIngressRequestMarshaller().Marshall(authorizeDBSecurityGroupIngressRequest);
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBInstanceReadReplica

        /// <summary>
        /// <para> Creates a DB Instance that acts as a Read Replica of a source DB Instance. </para> <para> All Read Replica DB Instances are created
        /// as Single-AZ deployments with backups disabled. All other DB Instance attributes (including DB Security Groups and DB Parameter Groups) are
        /// inherited from the source DB Instance, except as specified below. </para> <para><b>IMPORTANT:</b> The source DB Instance must have backup
        /// retention enabled. </para>
        /// </summary>
        /// 
        /// <param name="createDBInstanceReadReplicaRequest">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="InstanceQuotaExceededException"/>
        /// <exception cref="DBInstanceAlreadyExistsException"/>
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        public CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBInstanceReadReplica(createDBInstanceReadReplicaRequest, null, null, true);
            return EndCreateDBInstanceReadReplica(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBInstanceReadReplica"/>
        /// </summary>
        /// 
        /// <param name="createDBInstanceReadReplicaRequest">Container for the necessary parameters to execute the CreateDBInstanceReadReplica operation
        ///          on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDBInstanceReadReplica operation.</returns>
        public IAsyncResult BeginCreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBInstanceReadReplica(createDBInstanceReadReplicaRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBInstanceReadReplica"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBInstanceReadReplica.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public CreateDBInstanceReadReplicaResponse EndCreateDBInstanceReadReplica(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBInstanceReadReplicaResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBInstanceReadReplicaRequestMarshaller().Marshall(createDBInstanceReadReplicaRequest);
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDBSnapshots

        /// <summary>
        /// <para> Returns information about DBSnapshots. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSnapshotsRequest">Container for the necessary parameters to execute the DescribeDBSnapshots service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSnapshotNotFoundException"/>
        public DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest describeDBSnapshotsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBSnapshots(describeDBSnapshotsRequest, null, null, true);
            return EndDescribeDBSnapshots(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshots operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBSnapshots"/>
        /// </summary>
        /// 
        /// <param name="describeDBSnapshotsRequest">Container for the necessary parameters to execute the DescribeDBSnapshots operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBSnapshots operation.</returns>
        public IAsyncResult BeginDescribeDBSnapshots(DescribeDBSnapshotsRequest describeDBSnapshotsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBSnapshots(describeDBSnapshotsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBSnapshots operation.
        /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBSnapshots"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSnapshots.</param>
        /// 
        /// <returns>Returns a DescribeDBSnapshotsResult from AmazonRDS.</returns>
        public DescribeDBSnapshotsResponse EndDescribeDBSnapshots(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBSnapshotsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBSnapshots(DescribeDBSnapshotsRequest describeDBSnapshotsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBSnapshotsRequestMarshaller().Marshall(describeDBSnapshotsRequest);
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns information about DBSnapshots. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSnapshotNotFoundException"/>
        public DescribeDBSnapshotsResponse DescribeDBSnapshots()
        {
            return DescribeDBSnapshots(new DescribeDBSnapshotsRequest());
        }
        

        #endregion
    
    }
}
    
