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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.S3Control.Model;

#pragma warning disable CS1570
namespace Amazon.S3Control
{
    /// <summary>
    /// <para>Interface for accessing S3Control</para>
    ///
    /// Amazon Web Services S3 Control provides access to Amazon S3 control plane actions.
    /// </summary>
    public partial interface IAmazonS3Control : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IS3ControlPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateAccessGrantsIdentityCenter


        /// <summary>
        /// Associate your S3 Access Grants instance with an Amazon Web Services IAM Identity
        /// Center instance. Use this action if you want to create access grants for users or
        /// groups from your corporate identity directory. First, you must add your corporate
        /// identity directory to Amazon Web Services IAM Identity Center. Then, you can associate
        /// this IAM Identity Center instance with your S3 Access Grants instance.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:AssociateAccessGrantsIdentityCenter</c> permission to use
        /// this operation. 
        /// </para>
        ///  </dd> <dt>Additional Permissions</dt> <dd> 
        /// <para>
        /// You must also have the following permissions: <c>sso:CreateApplication</c>, <c>sso:PutApplicationGrant</c>,
        /// and <c>sso:PutApplicationAuthenticationMethod</c>. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccessGrantsIdentityCenter service method.</param>
        /// 
        /// <returns>The response from the AssociateAccessGrantsIdentityCenter service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/AssociateAccessGrantsIdentityCenter">REST API Reference for AssociateAccessGrantsIdentityCenter Operation</seealso>
        AssociateAccessGrantsIdentityCenterResponse AssociateAccessGrantsIdentityCenter(AssociateAccessGrantsIdentityCenterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAccessGrantsIdentityCenter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccessGrantsIdentityCenter operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAccessGrantsIdentityCenter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/AssociateAccessGrantsIdentityCenter">REST API Reference for AssociateAccessGrantsIdentityCenter Operation</seealso>
        IAsyncResult BeginAssociateAccessGrantsIdentityCenter(AssociateAccessGrantsIdentityCenterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAccessGrantsIdentityCenter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAccessGrantsIdentityCenter.</param>
        /// 
        /// <returns>Returns a  AssociateAccessGrantsIdentityCenterResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/AssociateAccessGrantsIdentityCenter">REST API Reference for AssociateAccessGrantsIdentityCenter Operation</seealso>
        AssociateAccessGrantsIdentityCenterResponse EndAssociateAccessGrantsIdentityCenter(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccessGrant


        /// <summary>
        /// Creates an access grant that gives a grantee access to your S3 data. The grantee can
        /// be an IAM user or role or a directory user, or group. Before you can create a grant,
        /// you must have an S3 Access Grants instance in the same Region as the S3 data. You
        /// can create an S3 Access Grants instance using the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessGrantsInstance.html">CreateAccessGrantsInstance</a>.
        /// You must also have registered at least one S3 data location in your S3 Access Grants
        /// instance using <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessGrantsLocation.html">CreateAccessGrantsLocation</a>.
        /// 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:CreateAccessGrant</c> permission to use this operation. 
        /// </para>
        ///  </dd> <dt>Additional Permissions</dt> <dd> 
        /// <para>
        /// For any directory identity - <c>sso:DescribeInstance</c> and <c>sso:DescribeApplication</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For directory users - <c>identitystore:DescribeUser</c> 
        /// </para>
        ///  
        /// <para>
        /// For directory groups - <c>identitystore:DescribeGroup</c> 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessGrant service method.</param>
        /// 
        /// <returns>The response from the CreateAccessGrant service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrant">REST API Reference for CreateAccessGrant Operation</seealso>
        CreateAccessGrantResponse CreateAccessGrant(CreateAccessGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessGrant operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrant">REST API Reference for CreateAccessGrant Operation</seealso>
        IAsyncResult BeginCreateAccessGrant(CreateAccessGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessGrant.</param>
        /// 
        /// <returns>Returns a  CreateAccessGrantResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrant">REST API Reference for CreateAccessGrant Operation</seealso>
        CreateAccessGrantResponse EndCreateAccessGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccessGrantsInstance


        /// <summary>
        /// Creates an S3 Access Grants instance, which serves as a logical grouping for access
        /// grants. You can create one S3 Access Grants instance per Region per account. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:CreateAccessGrantsInstance</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> <dt>Additional Permissions</dt> <dd> 
        /// <para>
        /// To associate an IAM Identity Center instance with your S3 Access Grants instance,
        /// you must also have the <c>sso:DescribeInstance</c>, <c>sso:CreateApplication</c>,
        /// <c>sso:PutApplicationGrant</c>, and <c>sso:PutApplicationAuthenticationMethod</c>
        /// permissions. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessGrantsInstance service method.</param>
        /// 
        /// <returns>The response from the CreateAccessGrantsInstance service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrantsInstance">REST API Reference for CreateAccessGrantsInstance Operation</seealso>
        CreateAccessGrantsInstanceResponse CreateAccessGrantsInstance(CreateAccessGrantsInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessGrantsInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessGrantsInstance operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessGrantsInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrantsInstance">REST API Reference for CreateAccessGrantsInstance Operation</seealso>
        IAsyncResult BeginCreateAccessGrantsInstance(CreateAccessGrantsInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessGrantsInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessGrantsInstance.</param>
        /// 
        /// <returns>Returns a  CreateAccessGrantsInstanceResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrantsInstance">REST API Reference for CreateAccessGrantsInstance Operation</seealso>
        CreateAccessGrantsInstanceResponse EndCreateAccessGrantsInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccessGrantsLocation


        /// <summary>
        /// The S3 data location that you would like to register in your S3 Access Grants instance.
        /// Your S3 data must be in the same Region as your S3 Access Grants instance. The location
        /// can be one of the following: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The default S3 location <c>s3://</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A bucket - <c>S3://&lt;bucket-name&gt;</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A bucket and prefix - <c>S3://&lt;bucket-name&gt;/&lt;prefix&gt;</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you register a location, you must include the IAM role that has permission to
        /// manage the S3 location that you are registering. Give S3 Access Grants permission
        /// to assume this role <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-grants-location.html">using
        /// a policy</a>. S3 Access Grants assumes this role to manage access to the location
        /// and to vend temporary credentials to grantees or client applications. 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:CreateAccessGrantsLocation</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> <dt>Additional Permissions</dt> <dd> 
        /// <para>
        /// You must also have the following permission for the specified IAM role: <c>iam:PassRole</c>
        /// 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessGrantsLocation service method.</param>
        /// 
        /// <returns>The response from the CreateAccessGrantsLocation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrantsLocation">REST API Reference for CreateAccessGrantsLocation Operation</seealso>
        CreateAccessGrantsLocationResponse CreateAccessGrantsLocation(CreateAccessGrantsLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessGrantsLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessGrantsLocation operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessGrantsLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrantsLocation">REST API Reference for CreateAccessGrantsLocation Operation</seealso>
        IAsyncResult BeginCreateAccessGrantsLocation(CreateAccessGrantsLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessGrantsLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessGrantsLocation.</param>
        /// 
        /// <returns>Returns a  CreateAccessGrantsLocationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrantsLocation">REST API Reference for CreateAccessGrantsLocation Operation</seealso>
        CreateAccessGrantsLocationResponse EndCreateAccessGrantsLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccessPoint


        /// <summary>
        /// Creates an access point and associates it to a specified bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points.html">Managing
        /// access to shared datasets with access points</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-directory-buckets.html">Managing
        /// access to shared datasets in directory buckets with access points</a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To create an access point and attach it to a volume on an Amazon FSx file system,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_CreateAndAttachS3AccessPoint.html">CreateAndAttachS3AccessPoint</a>
        /// in the <i>Amazon FSx API Reference</i>.
        /// </para>
        ///   <note> 
        /// <para>
        /// S3 on Outposts only supports VPC-style access points. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">
        /// Accessing Amazon S3 on Outposts using virtual private cloud (VPC) only access points</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html#API_control_CreateAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///   
        /// <para>
        /// The following actions are related to <c>CreateAccessPoint</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForDirectoryBuckets.html">ListAccessPointsForDirectoryBuckets</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        CreateAccessPointResponse CreateAccessPoint(CreateAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        IAsyncResult BeginCreateAccessPoint(CreateAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessPoint.</param>
        /// 
        /// <returns>Returns a  CreateAccessPointResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        CreateAccessPointResponse EndCreateAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccessPointForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an Object Lambda Access Point. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/transforming-objects.html">Transforming
        /// objects with Object Lambda Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>CreateAccessPointForObjectLambda</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointForObjectLambda.html">DeleteAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointForObjectLambda.html">GetAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForObjectLambda.html">ListAccessPointsForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPointForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPointForObjectLambda">REST API Reference for CreateAccessPointForObjectLambda Operation</seealso>
        CreateAccessPointForObjectLambdaResponse CreateAccessPointForObjectLambda(CreateAccessPointForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessPointForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPointForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessPointForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPointForObjectLambda">REST API Reference for CreateAccessPointForObjectLambda Operation</seealso>
        IAsyncResult BeginCreateAccessPointForObjectLambda(CreateAccessPointForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessPointForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessPointForObjectLambda.</param>
        /// 
        /// <returns>Returns a  CreateAccessPointForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPointForObjectLambda">REST API Reference for CreateAccessPointForObjectLambda Operation</seealso>
        CreateAccessPointForObjectLambdaResponse EndCreateAccessPointForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBucket


        /// <summary>
        /// <note> 
        /// <para>
        /// This action creates an Amazon S3 on Outposts bucket. To create an S3 bucket, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">Create
        /// Bucket</a> in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a new Outposts bucket. By creating the bucket, you become the bucket owner.
        /// To create an Outposts bucket, you must have S3 on Outposts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Not every string is an acceptable bucket name. For information on bucket naming restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/BucketRestrictions.html#bucketnamingrules">Working
        /// with Amazon S3 Buckets</a>.
        /// </para>
        ///  
        /// <para>
        /// S3 on Outposts buckets support:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LifecycleConfigurations for deleting expired objects
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a complete list of restrictions and Amazon S3 feature limitations on S3 on Outposts,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OnOutpostsRestrictionsLimitations.html">
        /// Amazon S3 on Outposts Restrictions and Limitations</a>.
        /// </para>
        ///  
        /// <para>
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and <c>x-amz-outpost-id</c> in your API request,
        /// see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html#API_control_CreateBucket_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>CreateBucket</c> for Amazon S3 on Outposts:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html">GetBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html">DeleteBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBucket service method.</param>
        /// 
        /// <returns>The response from the CreateBucket service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BucketAlreadyExistsException">
        /// The requested Outposts bucket name is not available. The bucket namespace is shared
        /// by all users of the Outposts in this Region. Select a different name and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.BucketAlreadyOwnedByYouException">
        /// The Outposts bucket you tried to create already exists, and you own it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateBucket">REST API Reference for CreateBucket Operation</seealso>
        CreateBucketResponse CreateBucket(CreateBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBucket operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateBucket">REST API Reference for CreateBucket Operation</seealso>
        IAsyncResult BeginCreateBucket(CreateBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBucket.</param>
        /// 
        /// <returns>Returns a  CreateBucketResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateBucket">REST API Reference for CreateBucket Operation</seealso>
        CreateBucketResponse EndCreateBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// This operation creates an S3 Batch Operations job.
        /// 
        ///  
        /// <para>
        /// You can use S3 Batch Operations to perform large-scale batch actions on Amazon S3
        /// objects. Batch Operations can run a single action on lists of Amazon S3 objects that
        /// you specify. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/batch-ops.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For information about permissions required to use the Batch Operations, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/batch-ops-iam-role-policies.html">Granting
        /// permissions for S3 Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </dd> </dl>  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_JobOperation.html">JobOperation</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.IdempotencyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse CreateJob(CreateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateJob">REST API Reference for CreateJob Operation</seealso>
        IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse EndCreateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMultiRegionAccessPoint


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a Multi-Region Access Point and associates it with the specified buckets.
        /// For more information about creating Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CreatingMultiRegionAccessPoints.html">Creating
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around working with Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/MultiRegionAccessPointRestrictions.html">Multi-Region
        /// Access Point restrictions and limitations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This request is asynchronous, meaning that you might receive a response before the
        /// command has completed. When this request provides a response, it provides a token
        /// that you can use to monitor the status of the request with <c>DescribeMultiRegionAccessPointOperation</c>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>CreateMultiRegionAccessPoint</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionAccessPoint service method.</param>
        /// 
        /// <returns>The response from the CreateMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateMultiRegionAccessPoint">REST API Reference for CreateMultiRegionAccessPoint Operation</seealso>
        CreateMultiRegionAccessPointResponse CreateMultiRegionAccessPoint(CreateMultiRegionAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMultiRegionAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionAccessPoint operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMultiRegionAccessPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateMultiRegionAccessPoint">REST API Reference for CreateMultiRegionAccessPoint Operation</seealso>
        IAsyncResult BeginCreateMultiRegionAccessPoint(CreateMultiRegionAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMultiRegionAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMultiRegionAccessPoint.</param>
        /// 
        /// <returns>Returns a  CreateMultiRegionAccessPointResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateMultiRegionAccessPoint">REST API Reference for CreateMultiRegionAccessPoint Operation</seealso>
        CreateMultiRegionAccessPointResponse EndCreateMultiRegionAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStorageLensGroup


        /// <summary>
        /// Creates a new S3 Storage Lens group and associates it with the specified Amazon Web
        /// Services account ID. An S3 Storage Lens group is a custom grouping of objects based
        /// on prefix, suffix, object tags, object size, object age, or a combination of these
        /// filters. For each Storage Lens group that you’ve created, you can also optionally
        /// add Amazon Web Services resource tags. For more information about S3 Storage Lens
        /// groups, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-lens-groups-overview.html">Working
        /// with S3 Storage Lens groups</a>.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the permission to perform the <c>s3:CreateStorageLensGroup</c>
        /// action. If you’re trying to create a Storage Lens group with Amazon Web Services resource
        /// tags, you must also have permission to perform the <c>s3:TagResource</c> action. For
        /// more information about the required Storage Lens Groups permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
        /// account permissions to use S3 Storage Lens groups</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about Storage Lens groups errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3LensErrorCodeList">List
        /// of Amazon S3 Storage Lens error codes</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLensGroup service method.</param>
        /// 
        /// <returns>The response from the CreateStorageLensGroup service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateStorageLensGroup">REST API Reference for CreateStorageLensGroup Operation</seealso>
        CreateStorageLensGroupResponse CreateStorageLensGroup(CreateStorageLensGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLensGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLensGroup operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorageLensGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateStorageLensGroup">REST API Reference for CreateStorageLensGroup Operation</seealso>
        IAsyncResult BeginCreateStorageLensGroup(CreateStorageLensGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorageLensGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageLensGroup.</param>
        /// 
        /// <returns>Returns a  CreateStorageLensGroupResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateStorageLensGroup">REST API Reference for CreateStorageLensGroup Operation</seealso>
        CreateStorageLensGroupResponse EndCreateStorageLensGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessGrant


        /// <summary>
        /// Deletes the access grant from the S3 Access Grants instance. You cannot undo an access
        /// grant deletion and the grantee will no longer have access to the S3 data.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:DeleteAccessGrant</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessGrant service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrant">REST API Reference for DeleteAccessGrant Operation</seealso>
        DeleteAccessGrantResponse DeleteAccessGrant(DeleteAccessGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrant operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrant">REST API Reference for DeleteAccessGrant Operation</seealso>
        IAsyncResult BeginDeleteAccessGrant(DeleteAccessGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessGrant.</param>
        /// 
        /// <returns>Returns a  DeleteAccessGrantResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrant">REST API Reference for DeleteAccessGrant Operation</seealso>
        DeleteAccessGrantResponse EndDeleteAccessGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessGrantsInstance


        /// <summary>
        /// Deletes your S3 Access Grants instance. You must first delete the access grants and
        /// locations before S3 Access Grants can delete the instance. See <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessGrant.html">DeleteAccessGrant</a>
        /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessGrantsLocation.html">DeleteAccessGrantsLocation</a>.
        /// If you have associated an IAM Identity Center instance with your S3 Access Grants
        /// instance, you must first dissassociate the Identity Center instance from the S3 Access
        /// Grants instance before you can delete the S3 Access Grants instance. See <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_AssociateAccessGrantsIdentityCenter.html">AssociateAccessGrantsIdentityCenter</a>
        /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DissociateAccessGrantsIdentityCenter.html">DissociateAccessGrantsIdentityCenter</a>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:DeleteAccessGrantsInstance</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrantsInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessGrantsInstance service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsInstance">REST API Reference for DeleteAccessGrantsInstance Operation</seealso>
        DeleteAccessGrantsInstanceResponse DeleteAccessGrantsInstance(DeleteAccessGrantsInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessGrantsInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrantsInstance operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessGrantsInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsInstance">REST API Reference for DeleteAccessGrantsInstance Operation</seealso>
        IAsyncResult BeginDeleteAccessGrantsInstance(DeleteAccessGrantsInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessGrantsInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessGrantsInstance.</param>
        /// 
        /// <returns>Returns a  DeleteAccessGrantsInstanceResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsInstance">REST API Reference for DeleteAccessGrantsInstance Operation</seealso>
        DeleteAccessGrantsInstanceResponse EndDeleteAccessGrantsInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessGrantsInstanceResourcePolicy


        /// <summary>
        /// Deletes the resource policy of the S3 Access Grants instance. The resource policy
        /// is used to manage cross-account access to your S3 Access Grants instance. By deleting
        /// the resource policy, you delete any cross-account permissions to your S3 Access Grants
        /// instance. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:DeleteAccessGrantsInstanceResourcePolicy</c> permission to
        /// use this operation. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrantsInstanceResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessGrantsInstanceResourcePolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsInstanceResourcePolicy">REST API Reference for DeleteAccessGrantsInstanceResourcePolicy Operation</seealso>
        DeleteAccessGrantsInstanceResourcePolicyResponse DeleteAccessGrantsInstanceResourcePolicy(DeleteAccessGrantsInstanceResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessGrantsInstanceResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrantsInstanceResourcePolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessGrantsInstanceResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsInstanceResourcePolicy">REST API Reference for DeleteAccessGrantsInstanceResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteAccessGrantsInstanceResourcePolicy(DeleteAccessGrantsInstanceResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessGrantsInstanceResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessGrantsInstanceResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccessGrantsInstanceResourcePolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsInstanceResourcePolicy">REST API Reference for DeleteAccessGrantsInstanceResourcePolicy Operation</seealso>
        DeleteAccessGrantsInstanceResourcePolicyResponse EndDeleteAccessGrantsInstanceResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessGrantsLocation


        /// <summary>
        /// Deregisters a location from your S3 Access Grants instance. You can only delete a
        /// location registration from an S3 Access Grants instance if there are no grants associated
        /// with this location. See <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessGrant.html">Delete
        /// a grant</a> for information on how to delete grants. You need to have at least one
        /// registered location in your S3 Access Grants instance in order to create access grants.
        /// 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:DeleteAccessGrantsLocation</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrantsLocation service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessGrantsLocation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsLocation">REST API Reference for DeleteAccessGrantsLocation Operation</seealso>
        DeleteAccessGrantsLocationResponse DeleteAccessGrantsLocation(DeleteAccessGrantsLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessGrantsLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessGrantsLocation operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessGrantsLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsLocation">REST API Reference for DeleteAccessGrantsLocation Operation</seealso>
        IAsyncResult BeginDeleteAccessGrantsLocation(DeleteAccessGrantsLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessGrantsLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessGrantsLocation.</param>
        /// 
        /// <returns>Returns a  DeleteAccessGrantsLocationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsLocation">REST API Reference for DeleteAccessGrantsLocation Operation</seealso>
        DeleteAccessGrantsLocationResponse EndDeleteAccessGrantsLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessPoint


        /// <summary>
        /// Deletes the specified access point.
        /// 
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html#API_control_DeleteAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>DeleteAccessPoint</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        DeleteAccessPointResponse DeleteAccessPoint(DeleteAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        IAsyncResult BeginDeleteAccessPoint(DeleteAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessPoint.</param>
        /// 
        /// <returns>Returns a  DeleteAccessPointResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        DeleteAccessPointResponse EndDeleteAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessPointForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified Object Lambda Access Point.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>DeleteAccessPointForObjectLambda</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPointForObjectLambda.html">CreateAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointForObjectLambda.html">GetAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForObjectLambda.html">ListAccessPointsForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointForObjectLambda">REST API Reference for DeleteAccessPointForObjectLambda Operation</seealso>
        DeleteAccessPointForObjectLambdaResponse DeleteAccessPointForObjectLambda(DeleteAccessPointForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessPointForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessPointForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointForObjectLambda">REST API Reference for DeleteAccessPointForObjectLambda Operation</seealso>
        IAsyncResult BeginDeleteAccessPointForObjectLambda(DeleteAccessPointForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessPointForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessPointForObjectLambda.</param>
        /// 
        /// <returns>Returns a  DeleteAccessPointForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointForObjectLambda">REST API Reference for DeleteAccessPointForObjectLambda Operation</seealso>
        DeleteAccessPointForObjectLambdaResponse EndDeleteAccessPointForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessPointPolicy


        /// <summary>
        /// Deletes the access point policy for the specified access point.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicy.html#API_control_DeleteAccessPointPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>DeleteAccessPointPolicy</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicy.html">GetAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicy">REST API Reference for DeleteAccessPointPolicy Operation</seealso>
        DeleteAccessPointPolicyResponse DeleteAccessPointPolicy(DeleteAccessPointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessPointPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicy">REST API Reference for DeleteAccessPointPolicy Operation</seealso>
        IAsyncResult BeginDeleteAccessPointPolicy(DeleteAccessPointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessPointPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccessPointPolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicy">REST API Reference for DeleteAccessPointPolicy Operation</seealso>
        DeleteAccessPointPolicyResponse EndDeleteAccessPointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessPointPolicyForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Removes the resource policy for an Object Lambda Access Point.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>DeleteAccessPointPolicyForObjectLambda</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicyForObjectLambda.html">GetAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicyForObjectLambda.html">PutAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicyForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicyForObjectLambda">REST API Reference for DeleteAccessPointPolicyForObjectLambda Operation</seealso>
        DeleteAccessPointPolicyForObjectLambdaResponse DeleteAccessPointPolicyForObjectLambda(DeleteAccessPointPolicyForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessPointPolicyForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicyForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessPointPolicyForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicyForObjectLambda">REST API Reference for DeleteAccessPointPolicyForObjectLambda Operation</seealso>
        IAsyncResult BeginDeleteAccessPointPolicyForObjectLambda(DeleteAccessPointPolicyForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessPointPolicyForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessPointPolicyForObjectLambda.</param>
        /// 
        /// <returns>Returns a  DeleteAccessPointPolicyForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicyForObjectLambda">REST API Reference for DeleteAccessPointPolicyForObjectLambda Operation</seealso>
        DeleteAccessPointPolicyForObjectLambdaResponse EndDeleteAccessPointPolicyForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessPointScope


        /// <summary>
        /// Deletes an existing access point scope for a directory bucket.
        /// 
        ///  <note> 
        /// <para>
        /// When you delete the scope of an access point, all prefixes and permissions are deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have the permission to perform the <c>s3express:DeleteAccessPointScope</c>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For information about REST API errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#RESTErrorResponses">REST
        /// error responses</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointScope service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPointScope service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointScope">REST API Reference for DeleteAccessPointScope Operation</seealso>
        DeleteAccessPointScopeResponse DeleteAccessPointScope(DeleteAccessPointScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessPointScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointScope operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessPointScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointScope">REST API Reference for DeleteAccessPointScope Operation</seealso>
        IAsyncResult BeginDeleteAccessPointScope(DeleteAccessPointScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessPointScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessPointScope.</param>
        /// 
        /// <returns>Returns a  DeleteAccessPointScopeResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointScope">REST API Reference for DeleteAccessPointScope Operation</seealso>
        DeleteAccessPointScopeResponse EndDeleteAccessPointScope(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBucket


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket. To delete an S3 bucket, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the Amazon S3 on Outposts bucket. All objects (including all object versions
        /// and delete markers) in the bucket must be deleted before the bucket itself can be
        /// deleted. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html#API_control_DeleteBucket_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html">CreateBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html">GetBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket service method.</param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        DeleteBucketResponse DeleteBucket(DeleteBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        IAsyncResult BeginDeleteBucket(DeleteBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucket.</param>
        /// 
        /// <returns>Returns a  DeleteBucketResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        DeleteBucketResponse EndDeleteBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBucketLifecycleConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket's lifecycle configuration. To
        /// delete an S3 bucket's lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketLifecycle.html">DeleteBucketLifecycle</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the lifecycle configuration from the specified Outposts bucket. Amazon S3
        /// on Outposts removes all the lifecycle configuration rules in the lifecycle subresource
        /// associated with the bucket. Your objects never expire, and Amazon S3 on Outposts no
        /// longer automatically deletes any objects on the basis of rules contained in the deleted
        /// lifecycle configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <c>s3-outposts:PutLifecycleConfiguration</c>
        /// action. By default, the bucket owner has this permission and the Outposts bucket owner
        /// can grant this permission to others.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketLifecycleConfiguration.html#API_control_DeleteBucketLifecycleConfiguration_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// For more information about object expiration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html#intro-lifecycle-rules-actions">Elements
        /// to Describe Lifecycle Actions</a>.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketLifecycleConfiguration">REST API Reference for DeleteBucketLifecycleConfiguration Operation</seealso>
        DeleteBucketLifecycleConfigurationResponse DeleteBucketLifecycleConfiguration(DeleteBucketLifecycleConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketLifecycleConfiguration operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketLifecycleConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketLifecycleConfiguration">REST API Reference for DeleteBucketLifecycleConfiguration Operation</seealso>
        IAsyncResult BeginDeleteBucketLifecycleConfiguration(DeleteBucketLifecycleConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteBucketLifecycleConfigurationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketLifecycleConfiguration">REST API Reference for DeleteBucketLifecycleConfiguration Operation</seealso>
        DeleteBucketLifecycleConfigurationResponse EndDeleteBucketLifecycleConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBucketPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket policy. To delete an S3 bucket
        /// policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// This implementation of the DELETE action uses the policy subresource to delete the
        /// policy of a specified Amazon S3 on Outposts bucket. If you are using an identity other
        /// than the root user of the Amazon Web Services account that owns the bucket, the calling
        /// identity must have the <c>s3-outposts:DeleteBucketPolicy</c> permissions on the specified
        /// Outposts bucket and belong to the bucket owner's account to use this action. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't have <c>DeleteBucketPolicy</c> permissions, Amazon S3 returns a <c>403
        /// Access Denied</c> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <c>405
        /// Method Not Allowed</c> error. 
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the Amazon Web Services account that owns
        /// a bucket can always use this action, even if the policy explicitly denies the root
        /// user the ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html#API_control_DeleteBucketPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>DeleteBucketPolicy</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html">GetBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html">PutBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketPolicy">REST API Reference for DeleteBucketPolicy Operation</seealso>
        DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketPolicy">REST API Reference for DeleteBucketPolicy Operation</seealso>
        IAsyncResult BeginDeleteBucketPolicy(DeleteBucketPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteBucketPolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketPolicy">REST API Reference for DeleteBucketPolicy Operation</seealso>
        DeleteBucketPolicyResponse EndDeleteBucketPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBucketReplication


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation deletes an Amazon S3 on Outposts bucket's replication configuration.
        /// To delete an S3 bucket's replication configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketReplication.html">DeleteBucketReplication</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the replication configuration from the specified S3 on Outposts bucket.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <c>s3-outposts:PutReplicationConfiguration</c>
        /// action. The Outposts bucket owner has this permission by default and can grant it
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsIAM.html">Setting
        /// up IAM with S3 on Outposts</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsBucketPolicy.html">Managing
        /// access to S3 on Outposts buckets</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// It can take a while to propagate <c>PUT</c> or <c>DELETE</c> requests for a replication
        /// configuration to all S3 on Outposts systems. Therefore, the replication configuration
        /// that's returned by a <c>GET</c> request soon after a <c>PUT</c> or <c>DELETE</c> request
        /// might return a more recent result than what's on the Outpost. If an Outpost is offline,
        /// the delay in updating the replication configuration on that Outpost can be significant.
        /// </para>
        ///  </note> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketReplication.html#API_control_DeleteBucketReplication_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// For information about S3 replication on Outposts configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsReplication.html">Replicating
        /// objects for S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>DeleteBucketReplication</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketReplication.html">PutBucketReplication</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketReplication.html">GetBucketReplication</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketReplication service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketReplication">REST API Reference for DeleteBucketReplication Operation</seealso>
        DeleteBucketReplicationResponse DeleteBucketReplication(DeleteBucketReplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketReplication">REST API Reference for DeleteBucketReplication Operation</seealso>
        IAsyncResult BeginDeleteBucketReplication(DeleteBucketReplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketReplication.</param>
        /// 
        /// <returns>Returns a  DeleteBucketReplicationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketReplication">REST API Reference for DeleteBucketReplication Operation</seealso>
        DeleteBucketReplicationResponse EndDeleteBucketReplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBucketTagging


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket's tags. To delete an S3 bucket
        /// tags, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketTagging.html">DeleteBucketTagging</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the tags from the Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <c>PutBucketTagging</c>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others. 
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html#API_control_DeleteBucketTagging_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>DeleteBucketTagging</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html">GetBucketTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html">PutBucketTagging</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketTagging">REST API Reference for DeleteBucketTagging Operation</seealso>
        DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketTagging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketTagging">REST API Reference for DeleteBucketTagging Operation</seealso>
        IAsyncResult BeginDeleteBucketTagging(DeleteBucketTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketTagging.</param>
        /// 
        /// <returns>Returns a  DeleteBucketTaggingResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketTagging">REST API Reference for DeleteBucketTagging Operation</seealso>
        DeleteBucketTaggingResponse EndDeleteBucketTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteJobTagging


        /// <summary>
        /// Removes the entire tag set from the specified S3 Batch Operations job.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// To use the <c>DeleteJobTagging</c> operation, you must have permission to perform
        /// the <c>s3:DeleteJobTagging</c> action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
        /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutJobTagging.html">PutJobTagging</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteJobTagging">REST API Reference for DeleteJobTagging Operation</seealso>
        DeleteJobTaggingResponse DeleteJobTagging(DeleteJobTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJobTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJobTagging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteJobTagging">REST API Reference for DeleteJobTagging Operation</seealso>
        IAsyncResult BeginDeleteJobTagging(DeleteJobTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJobTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJobTagging.</param>
        /// 
        /// <returns>Returns a  DeleteJobTaggingResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteJobTagging">REST API Reference for DeleteJobTagging Operation</seealso>
        DeleteJobTaggingResponse EndDeleteJobTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMultiRegionAccessPoint


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes a Multi-Region Access Point. This action does not delete the buckets associated
        /// with the Multi-Region Access Point, only the Multi-Region Access Point itself.
        /// </para>
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around working with Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/MultiRegionAccessPointRestrictions.html">Multi-Region
        /// Access Point restrictions and limitations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This request is asynchronous, meaning that you might receive a response before the
        /// command has completed. When this request provides a response, it provides a token
        /// that you can use to monitor the status of the request with <c>DescribeMultiRegionAccessPointOperation</c>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>DeleteMultiRegionAccessPoint</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionAccessPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteMultiRegionAccessPoint">REST API Reference for DeleteMultiRegionAccessPoint Operation</seealso>
        DeleteMultiRegionAccessPointResponse DeleteMultiRegionAccessPoint(DeleteMultiRegionAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMultiRegionAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionAccessPoint operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMultiRegionAccessPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteMultiRegionAccessPoint">REST API Reference for DeleteMultiRegionAccessPoint Operation</seealso>
        IAsyncResult BeginDeleteMultiRegionAccessPoint(DeleteMultiRegionAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMultiRegionAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMultiRegionAccessPoint.</param>
        /// 
        /// <returns>Returns a  DeleteMultiRegionAccessPointResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteMultiRegionAccessPoint">REST API Reference for DeleteMultiRegionAccessPoint Operation</seealso>
        DeleteMultiRegionAccessPointResponse EndDeleteMultiRegionAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePublicAccessBlock


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Removes the <c>PublicAccessBlock</c> configuration for an Amazon Web Services account.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
        /// Using Amazon S3 block public access</a>.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetPublicAccessBlock.html">GetPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutPublicAccessBlock.html">PutPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the DeletePublicAccessBlock service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeletePublicAccessBlock">REST API Reference for DeletePublicAccessBlock Operation</seealso>
        DeletePublicAccessBlockResponse DeletePublicAccessBlock(DeletePublicAccessBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePublicAccessBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeletePublicAccessBlock">REST API Reference for DeletePublicAccessBlock Operation</seealso>
        IAsyncResult BeginDeletePublicAccessBlock(DeletePublicAccessBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePublicAccessBlock.</param>
        /// 
        /// <returns>Returns a  DeletePublicAccessBlockResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeletePublicAccessBlock">REST API Reference for DeletePublicAccessBlock Operation</seealso>
        DeletePublicAccessBlockResponse EndDeletePublicAccessBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStorageLensConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the Amazon S3 Storage Lens configuration. For more information about S3 Storage
        /// Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <c>s3:DeleteStorageLensConfiguration</c>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfiguration">REST API Reference for DeleteStorageLensConfiguration Operation</seealso>
        DeleteStorageLensConfigurationResponse DeleteStorageLensConfiguration(DeleteStorageLensConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStorageLensConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensConfiguration operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStorageLensConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfiguration">REST API Reference for DeleteStorageLensConfiguration Operation</seealso>
        IAsyncResult BeginDeleteStorageLensConfiguration(DeleteStorageLensConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStorageLensConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStorageLensConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteStorageLensConfigurationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfiguration">REST API Reference for DeleteStorageLensConfiguration Operation</seealso>
        DeleteStorageLensConfigurationResponse EndDeleteStorageLensConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStorageLensConfigurationTagging


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the Amazon S3 Storage Lens configuration tags. For more information about
        /// S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <c>s3:DeleteStorageLensConfigurationTagging</c>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensConfigurationTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfigurationTagging">REST API Reference for DeleteStorageLensConfigurationTagging Operation</seealso>
        DeleteStorageLensConfigurationTaggingResponse DeleteStorageLensConfigurationTagging(DeleteStorageLensConfigurationTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStorageLensConfigurationTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensConfigurationTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStorageLensConfigurationTagging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfigurationTagging">REST API Reference for DeleteStorageLensConfigurationTagging Operation</seealso>
        IAsyncResult BeginDeleteStorageLensConfigurationTagging(DeleteStorageLensConfigurationTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStorageLensConfigurationTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStorageLensConfigurationTagging.</param>
        /// 
        /// <returns>Returns a  DeleteStorageLensConfigurationTaggingResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfigurationTagging">REST API Reference for DeleteStorageLensConfigurationTagging Operation</seealso>
        DeleteStorageLensConfigurationTaggingResponse EndDeleteStorageLensConfigurationTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStorageLensGroup


        /// <summary>
        /// Deletes an existing S3 Storage Lens group.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the permission to perform the <c>s3:DeleteStorageLensGroup</c>
        /// action. For more information about the required Storage Lens Groups permissions, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
        /// account permissions to use S3 Storage Lens groups</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about Storage Lens groups errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3LensErrorCodeList">List
        /// of Amazon S3 Storage Lens error codes</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteStorageLensGroup service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensGroup">REST API Reference for DeleteStorageLensGroup Operation</seealso>
        DeleteStorageLensGroupResponse DeleteStorageLensGroup(DeleteStorageLensGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStorageLensGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensGroup operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStorageLensGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensGroup">REST API Reference for DeleteStorageLensGroup Operation</seealso>
        IAsyncResult BeginDeleteStorageLensGroup(DeleteStorageLensGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStorageLensGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStorageLensGroup.</param>
        /// 
        /// <returns>Returns a  DeleteStorageLensGroupResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensGroup">REST API Reference for DeleteStorageLensGroup Operation</seealso>
        DeleteStorageLensGroupResponse EndDeleteStorageLensGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// Retrieves the configuration parameters and status for a Batch Operations job. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/batch-ops.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// To use the <c>DescribeJob</c> operation, you must have permission to perform the <c>s3:DescribeJob</c>
        /// action.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        DescribeJobResponse DescribeJob(DescribeJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        IAsyncResult BeginDescribeJob(DescribeJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJob.</param>
        /// 
        /// <returns>Returns a  DescribeJobResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        DescribeJobResponse EndDescribeJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMultiRegionAccessPointOperation


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the status of an asynchronous request to manage a Multi-Region Access Point.
        /// For more information about managing Multi-Region Access Points and how asynchronous
        /// requests work, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/MrapOperations.html">Using
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetMultiRegionAccessPoint</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiRegionAccessPointOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeMultiRegionAccessPointOperation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeMultiRegionAccessPointOperation">REST API Reference for DescribeMultiRegionAccessPointOperation Operation</seealso>
        DescribeMultiRegionAccessPointOperationResponse DescribeMultiRegionAccessPointOperation(DescribeMultiRegionAccessPointOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMultiRegionAccessPointOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiRegionAccessPointOperation operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMultiRegionAccessPointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeMultiRegionAccessPointOperation">REST API Reference for DescribeMultiRegionAccessPointOperation Operation</seealso>
        IAsyncResult BeginDescribeMultiRegionAccessPointOperation(DescribeMultiRegionAccessPointOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMultiRegionAccessPointOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMultiRegionAccessPointOperation.</param>
        /// 
        /// <returns>Returns a  DescribeMultiRegionAccessPointOperationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeMultiRegionAccessPointOperation">REST API Reference for DescribeMultiRegionAccessPointOperation Operation</seealso>
        DescribeMultiRegionAccessPointOperationResponse EndDescribeMultiRegionAccessPointOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  DissociateAccessGrantsIdentityCenter


        /// <summary>
        /// Dissociates the Amazon Web Services IAM Identity Center instance from the S3 Access
        /// Grants instance. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:DissociateAccessGrantsIdentityCenter</c> permission to use
        /// this operation. 
        /// </para>
        ///  </dd> <dt>Additional Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>sso:DeleteApplication</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociateAccessGrantsIdentityCenter service method.</param>
        /// 
        /// <returns>The response from the DissociateAccessGrantsIdentityCenter service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DissociateAccessGrantsIdentityCenter">REST API Reference for DissociateAccessGrantsIdentityCenter Operation</seealso>
        DissociateAccessGrantsIdentityCenterResponse DissociateAccessGrantsIdentityCenter(DissociateAccessGrantsIdentityCenterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DissociateAccessGrantsIdentityCenter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DissociateAccessGrantsIdentityCenter operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDissociateAccessGrantsIdentityCenter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DissociateAccessGrantsIdentityCenter">REST API Reference for DissociateAccessGrantsIdentityCenter Operation</seealso>
        IAsyncResult BeginDissociateAccessGrantsIdentityCenter(DissociateAccessGrantsIdentityCenterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DissociateAccessGrantsIdentityCenter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDissociateAccessGrantsIdentityCenter.</param>
        /// 
        /// <returns>Returns a  DissociateAccessGrantsIdentityCenterResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DissociateAccessGrantsIdentityCenter">REST API Reference for DissociateAccessGrantsIdentityCenter Operation</seealso>
        DissociateAccessGrantsIdentityCenterResponse EndDissociateAccessGrantsIdentityCenter(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessGrant


        /// <summary>
        /// Get the details of an access grant from your S3 Access Grants instance.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:GetAccessGrant</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrant service method.</param>
        /// 
        /// <returns>The response from the GetAccessGrant service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrant">REST API Reference for GetAccessGrant Operation</seealso>
        GetAccessGrantResponse GetAccessGrant(GetAccessGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrant operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrant">REST API Reference for GetAccessGrant Operation</seealso>
        IAsyncResult BeginGetAccessGrant(GetAccessGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessGrant.</param>
        /// 
        /// <returns>Returns a  GetAccessGrantResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrant">REST API Reference for GetAccessGrant Operation</seealso>
        GetAccessGrantResponse EndGetAccessGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessGrantsInstance


        /// <summary>
        /// Retrieves the S3 Access Grants instance for a Region in your account. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:GetAccessGrantsInstance</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl> <note> 
        /// <para>
        ///  <c>GetAccessGrantsInstance</c> is not supported for cross-account access. You can
        /// only call the API from the account that owns the S3 Access Grants instance.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrantsInstance service method.</param>
        /// 
        /// <returns>The response from the GetAccessGrantsInstance service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstance">REST API Reference for GetAccessGrantsInstance Operation</seealso>
        GetAccessGrantsInstanceResponse GetAccessGrantsInstance(GetAccessGrantsInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessGrantsInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrantsInstance operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessGrantsInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstance">REST API Reference for GetAccessGrantsInstance Operation</seealso>
        IAsyncResult BeginGetAccessGrantsInstance(GetAccessGrantsInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessGrantsInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessGrantsInstance.</param>
        /// 
        /// <returns>Returns a  GetAccessGrantsInstanceResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstance">REST API Reference for GetAccessGrantsInstance Operation</seealso>
        GetAccessGrantsInstanceResponse EndGetAccessGrantsInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessGrantsInstanceForPrefix


        /// <summary>
        /// Retrieve the S3 Access Grants instance that contains a particular prefix. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:GetAccessGrantsInstanceForPrefix</c> permission for the caller
        /// account to use this operation. 
        /// </para>
        ///  </dd> <dt>Additional Permissions</dt> <dd> 
        /// <para>
        /// The prefix owner account must grant you the following permissions to their S3 Access
        /// Grants instance: <c>s3:GetAccessGrantsInstanceForPrefix</c>. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrantsInstanceForPrefix service method.</param>
        /// 
        /// <returns>The response from the GetAccessGrantsInstanceForPrefix service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstanceForPrefix">REST API Reference for GetAccessGrantsInstanceForPrefix Operation</seealso>
        GetAccessGrantsInstanceForPrefixResponse GetAccessGrantsInstanceForPrefix(GetAccessGrantsInstanceForPrefixRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessGrantsInstanceForPrefix operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrantsInstanceForPrefix operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessGrantsInstanceForPrefix
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstanceForPrefix">REST API Reference for GetAccessGrantsInstanceForPrefix Operation</seealso>
        IAsyncResult BeginGetAccessGrantsInstanceForPrefix(GetAccessGrantsInstanceForPrefixRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessGrantsInstanceForPrefix operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessGrantsInstanceForPrefix.</param>
        /// 
        /// <returns>Returns a  GetAccessGrantsInstanceForPrefixResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstanceForPrefix">REST API Reference for GetAccessGrantsInstanceForPrefix Operation</seealso>
        GetAccessGrantsInstanceForPrefixResponse EndGetAccessGrantsInstanceForPrefix(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessGrantsInstanceResourcePolicy


        /// <summary>
        /// Returns the resource policy of the S3 Access Grants instance. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:GetAccessGrantsInstanceResourcePolicy</c> permission to use
        /// this operation. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrantsInstanceResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetAccessGrantsInstanceResourcePolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstanceResourcePolicy">REST API Reference for GetAccessGrantsInstanceResourcePolicy Operation</seealso>
        GetAccessGrantsInstanceResourcePolicyResponse GetAccessGrantsInstanceResourcePolicy(GetAccessGrantsInstanceResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessGrantsInstanceResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrantsInstanceResourcePolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessGrantsInstanceResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstanceResourcePolicy">REST API Reference for GetAccessGrantsInstanceResourcePolicy Operation</seealso>
        IAsyncResult BeginGetAccessGrantsInstanceResourcePolicy(GetAccessGrantsInstanceResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessGrantsInstanceResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessGrantsInstanceResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetAccessGrantsInstanceResourcePolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstanceResourcePolicy">REST API Reference for GetAccessGrantsInstanceResourcePolicy Operation</seealso>
        GetAccessGrantsInstanceResourcePolicyResponse EndGetAccessGrantsInstanceResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessGrantsLocation


        /// <summary>
        /// Retrieves the details of a particular location registered in your S3 Access Grants
        /// instance. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:GetAccessGrantsLocation</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrantsLocation service method.</param>
        /// 
        /// <returns>The response from the GetAccessGrantsLocation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsLocation">REST API Reference for GetAccessGrantsLocation Operation</seealso>
        GetAccessGrantsLocationResponse GetAccessGrantsLocation(GetAccessGrantsLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessGrantsLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessGrantsLocation operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessGrantsLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsLocation">REST API Reference for GetAccessGrantsLocation Operation</seealso>
        IAsyncResult BeginGetAccessGrantsLocation(GetAccessGrantsLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessGrantsLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessGrantsLocation.</param>
        /// 
        /// <returns>Returns a  GetAccessGrantsLocationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsLocation">REST API Reference for GetAccessGrantsLocation Operation</seealso>
        GetAccessGrantsLocationResponse EndGetAccessGrantsLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPoint


        /// <summary>
        /// Returns configuration information about the specified access point.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html#API_control_GetAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetAccessPoint</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPoint service method.</param>
        /// 
        /// <returns>The response from the GetAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPoint">REST API Reference for GetAccessPoint Operation</seealso>
        GetAccessPointResponse GetAccessPoint(GetAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPoint operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPoint">REST API Reference for GetAccessPoint Operation</seealso>
        IAsyncResult BeginGetAccessPoint(GetAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPoint.</param>
        /// 
        /// <returns>Returns a  GetAccessPointResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPoint">REST API Reference for GetAccessPoint Operation</seealso>
        GetAccessPointResponse EndGetAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPointConfigurationForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns configuration for an Object Lambda Access Point.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetAccessPointConfigurationForObjectLambda</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointConfigurationForObjectLambda.html">PutAccessPointConfigurationForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointConfigurationForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointConfigurationForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointConfigurationForObjectLambda">REST API Reference for GetAccessPointConfigurationForObjectLambda Operation</seealso>
        GetAccessPointConfigurationForObjectLambdaResponse GetAccessPointConfigurationForObjectLambda(GetAccessPointConfigurationForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPointConfigurationForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointConfigurationForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPointConfigurationForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointConfigurationForObjectLambda">REST API Reference for GetAccessPointConfigurationForObjectLambda Operation</seealso>
        IAsyncResult BeginGetAccessPointConfigurationForObjectLambda(GetAccessPointConfigurationForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPointConfigurationForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPointConfigurationForObjectLambda.</param>
        /// 
        /// <returns>Returns a  GetAccessPointConfigurationForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointConfigurationForObjectLambda">REST API Reference for GetAccessPointConfigurationForObjectLambda Operation</seealso>
        GetAccessPointConfigurationForObjectLambdaResponse EndGetAccessPointConfigurationForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPointForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns configuration information about the specified Object Lambda Access Point
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetAccessPointForObjectLambda</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPointForObjectLambda.html">CreateAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointForObjectLambda.html">DeleteAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForObjectLambda.html">ListAccessPointsForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointForObjectLambda">REST API Reference for GetAccessPointForObjectLambda Operation</seealso>
        GetAccessPointForObjectLambdaResponse GetAccessPointForObjectLambda(GetAccessPointForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPointForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPointForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointForObjectLambda">REST API Reference for GetAccessPointForObjectLambda Operation</seealso>
        IAsyncResult BeginGetAccessPointForObjectLambda(GetAccessPointForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPointForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPointForObjectLambda.</param>
        /// 
        /// <returns>Returns a  GetAccessPointForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointForObjectLambda">REST API Reference for GetAccessPointForObjectLambda Operation</seealso>
        GetAccessPointForObjectLambdaResponse EndGetAccessPointForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPointPolicy


        /// <summary>
        /// Returns the access point policy associated with the specified access point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <c>GetAccessPointPolicy</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicy.html">DeleteAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicy">REST API Reference for GetAccessPointPolicy Operation</seealso>
        GetAccessPointPolicyResponse GetAccessPointPolicy(GetAccessPointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPointPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicy">REST API Reference for GetAccessPointPolicy Operation</seealso>
        IAsyncResult BeginGetAccessPointPolicy(GetAccessPointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPointPolicy.</param>
        /// 
        /// <returns>Returns a  GetAccessPointPolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicy">REST API Reference for GetAccessPointPolicy Operation</seealso>
        GetAccessPointPolicyResponse EndGetAccessPointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPointPolicyForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the resource policy for an Object Lambda Access Point.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetAccessPointPolicyForObjectLambda</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicyForObjectLambda.html">DeleteAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicyForObjectLambda.html">PutAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyForObjectLambda">REST API Reference for GetAccessPointPolicyForObjectLambda Operation</seealso>
        GetAccessPointPolicyForObjectLambdaResponse GetAccessPointPolicyForObjectLambda(GetAccessPointPolicyForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPointPolicyForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPointPolicyForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyForObjectLambda">REST API Reference for GetAccessPointPolicyForObjectLambda Operation</seealso>
        IAsyncResult BeginGetAccessPointPolicyForObjectLambda(GetAccessPointPolicyForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPointPolicyForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPointPolicyForObjectLambda.</param>
        /// 
        /// <returns>Returns a  GetAccessPointPolicyForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyForObjectLambda">REST API Reference for GetAccessPointPolicyForObjectLambda Operation</seealso>
        GetAccessPointPolicyForObjectLambdaResponse EndGetAccessPointPolicyForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPointPolicyStatus


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Indicates whether the specified access point currently has a policy that allows public
        /// access. For more information about public access through access points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points.html">Managing
        /// Data Access with Amazon S3 access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatus service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyStatus service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatus">REST API Reference for GetAccessPointPolicyStatus Operation</seealso>
        GetAccessPointPolicyStatusResponse GetAccessPointPolicyStatus(GetAccessPointPolicyStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPointPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatus operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPointPolicyStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatus">REST API Reference for GetAccessPointPolicyStatus Operation</seealso>
        IAsyncResult BeginGetAccessPointPolicyStatus(GetAccessPointPolicyStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPointPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPointPolicyStatus.</param>
        /// 
        /// <returns>Returns a  GetAccessPointPolicyStatusResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatus">REST API Reference for GetAccessPointPolicyStatus Operation</seealso>
        GetAccessPointPolicyStatusResponse EndGetAccessPointPolicyStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPointPolicyStatusForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the status of the resource policy associated with an Object Lambda Access
        /// Point.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatusForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyStatusForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatusForObjectLambda">REST API Reference for GetAccessPointPolicyStatusForObjectLambda Operation</seealso>
        GetAccessPointPolicyStatusForObjectLambdaResponse GetAccessPointPolicyStatusForObjectLambda(GetAccessPointPolicyStatusForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPointPolicyStatusForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatusForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPointPolicyStatusForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatusForObjectLambda">REST API Reference for GetAccessPointPolicyStatusForObjectLambda Operation</seealso>
        IAsyncResult BeginGetAccessPointPolicyStatusForObjectLambda(GetAccessPointPolicyStatusForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPointPolicyStatusForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPointPolicyStatusForObjectLambda.</param>
        /// 
        /// <returns>Returns a  GetAccessPointPolicyStatusForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatusForObjectLambda">REST API Reference for GetAccessPointPolicyStatusForObjectLambda Operation</seealso>
        GetAccessPointPolicyStatusForObjectLambdaResponse EndGetAccessPointPolicyStatusForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPointScope


        /// <summary>
        /// Returns the access point scope for a directory bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the permission to perform the <c>s3express:GetAccessPointScope</c>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For information about REST API errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#RESTErrorResponses">REST
        /// error responses</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointScope service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointScope service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointScope">REST API Reference for GetAccessPointScope Operation</seealso>
        GetAccessPointScopeResponse GetAccessPointScope(GetAccessPointScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPointScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointScope operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPointScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointScope">REST API Reference for GetAccessPointScope Operation</seealso>
        IAsyncResult BeginGetAccessPointScope(GetAccessPointScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPointScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPointScope.</param>
        /// 
        /// <returns>Returns a  GetAccessPointScopeResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointScope">REST API Reference for GetAccessPointScope Operation</seealso>
        GetAccessPointScopeResponse EndGetAccessPointScope(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucket


        /// <summary>
        /// Gets an Amazon S3 on Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">
        /// Using Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you are using an identity other than the root user of the Amazon Web Services account
        /// that owns the Outposts bucket, the calling identity must have the <c>s3-outposts:GetBucket</c>
        /// permissions on the specified Outposts bucket and belong to the Outposts bucket owner's
        /// account in order to use this action. Only users from Outposts bucket owner account
        /// with the right permissions can perform actions on an Outposts bucket. 
        /// </para>
        ///  
        /// <para>
        /// If you don't have <c>s3-outposts:GetBucket</c> permissions or you're not using an
        /// identity that belongs to the bucket owner's account, Amazon S3 returns a <c>403 Access
        /// Denied</c> error.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetBucket</c> for Amazon S3 on Outposts:
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html#API_control_GetBucket_Examples">Examples</a>
        /// section.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html">CreateBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html">DeleteBucket</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucket service method.</param>
        /// 
        /// <returns>The response from the GetBucket service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucket">REST API Reference for GetBucket Operation</seealso>
        GetBucketResponse GetBucket(GetBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucket operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucket">REST API Reference for GetBucket Operation</seealso>
        IAsyncResult BeginGetBucket(GetBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucket.</param>
        /// 
        /// <returns>Returns a  GetBucketResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucket">REST API Reference for GetBucket Operation</seealso>
        GetBucketResponse EndGetBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketLifecycleConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This action gets an Amazon S3 on Outposts bucket's lifecycle configuration. To get
        /// an S3 bucket's lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the lifecycle configuration information set on the Outposts bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> and for information about lifecycle configuration, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">
        /// Object Lifecycle Management</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <c>s3-outposts:GetLifecycleConfiguration</c>
        /// action. The Outposts bucket owner has this permission, by default. The bucket owner
        /// can grant this permission to others. For more information about permissions, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html#API_control_GetBucketLifecycleConfiguration_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetBucketLifecycleConfiguration</c> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <c>NoSuchLifecycleConfiguration</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The lifecycle configuration does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SOAP Fault Code Prefix: Client
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following actions are related to <c>GetBucketLifecycleConfiguration</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketLifecycleConfiguration.html">DeleteBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketLifecycleConfiguration">REST API Reference for GetBucketLifecycleConfiguration Operation</seealso>
        GetBucketLifecycleConfigurationResponse GetBucketLifecycleConfiguration(GetBucketLifecycleConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLifecycleConfiguration operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketLifecycleConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketLifecycleConfiguration">REST API Reference for GetBucketLifecycleConfiguration Operation</seealso>
        IAsyncResult BeginGetBucketLifecycleConfiguration(GetBucketLifecycleConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a  GetBucketLifecycleConfigurationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketLifecycleConfiguration">REST API Reference for GetBucketLifecycleConfiguration Operation</seealso>
        GetBucketLifecycleConfigurationResponse EndGetBucketLifecycleConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This action gets a bucket policy for an Amazon S3 on Outposts bucket. To get a policy
        /// for an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketPolicy.html">GetBucketPolicy</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the policy of a specified Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are using an identity other than the root user of the Amazon Web Services account
        /// that owns the bucket, the calling identity must have the <c>GetBucketPolicy</c> permissions
        /// on the specified bucket and belong to the bucket owner's account in order to use this
        /// action.
        /// </para>
        ///  
        /// <para>
        /// Only users from Outposts bucket owner account with the right permissions can perform
        /// actions on an Outposts bucket. If you don't have <c>s3-outposts:GetBucketPolicy</c>
        /// permissions or you're not using an identity that belongs to the bucket owner's account,
        /// Amazon S3 returns a <c>403 Access Denied</c> error.
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the Amazon Web Services account that owns
        /// a bucket can always use this action, even if the policy explicitly denies the root
        /// user the ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html#API_control_GetBucketPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetBucketPolicy</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html">PutBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketPolicy">REST API Reference for GetBucketPolicy Operation</seealso>
        GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketPolicy">REST API Reference for GetBucketPolicy Operation</seealso>
        IAsyncResult BeginGetBucketPolicy(GetBucketPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketPolicy.</param>
        /// 
        /// <returns>Returns a  GetBucketPolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketPolicy">REST API Reference for GetBucketPolicy Operation</seealso>
        GetBucketPolicyResponse EndGetBucketPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketReplication


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation gets an Amazon S3 on Outposts bucket's replication configuration. To
        /// get an S3 bucket's replication configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketReplication.html">GetBucketReplication</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the replication configuration of an S3 on Outposts bucket. For more information
        /// about S3 on Outposts, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>. For information about
        /// S3 replication on Outposts configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsReplication.html">Replicating
        /// objects for S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// It can take a while to propagate <c>PUT</c> or <c>DELETE</c> requests for a replication
        /// configuration to all S3 on Outposts systems. Therefore, the replication configuration
        /// that's returned by a <c>GET</c> request soon after a <c>PUT</c> or <c>DELETE</c> request
        /// might return a more recent result than what's on the Outpost. If an Outpost is offline,
        /// the delay in updating the replication configuration on that Outpost can be significant.
        /// </para>
        ///  </note> 
        /// <para>
        /// This action requires permissions for the <c>s3-outposts:GetReplicationConfiguration</c>
        /// action. The Outposts bucket owner has this permission by default and can grant it
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsIAM.html">Setting
        /// up IAM with S3 on Outposts</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsBucketPolicy.html">Managing
        /// access to S3 on Outposts bucket</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketReplication.html#API_control_GetBucketReplication_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// If you include the <c>Filter</c> element in a replication configuration, you must
        /// also include the <c>DeleteMarkerReplication</c>, <c>Status</c>, and <c>Priority</c>
        /// elements. The response also returns those elements.
        /// </para>
        ///  
        /// <para>
        /// For information about S3 on Outposts replication failure reasons, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/outposts-replication-eventbridge.html#outposts-replication-failure-codes">Replication
        /// failure reasons</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>GetBucketReplication</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketReplication.html">PutBucketReplication</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketReplication.html">DeleteBucketReplication</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication service method.</param>
        /// 
        /// <returns>The response from the GetBucketReplication service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketReplication">REST API Reference for GetBucketReplication Operation</seealso>
        GetBucketReplicationResponse GetBucketReplication(GetBucketReplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketReplication">REST API Reference for GetBucketReplication Operation</seealso>
        IAsyncResult BeginGetBucketReplication(GetBucketReplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketReplication.</param>
        /// 
        /// <returns>Returns a  GetBucketReplicationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketReplication">REST API Reference for GetBucketReplication Operation</seealso>
        GetBucketReplicationResponse EndGetBucketReplication(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketTagging


        /// <summary>
        /// <note> 
        /// <para>
        /// This action gets an Amazon S3 on Outposts bucket's tags. To get an S3 bucket tags,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketTagging.html">GetBucketTagging</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the tag set associated with the Outposts bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <c>GetBucketTagging</c>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetBucketTagging</c> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <c>NoSuchTagSetError</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: There is no tag set associated with the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html#API_control_GetBucketTagging_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetBucketTagging</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html">PutBucketTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html">DeleteBucketTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging service method.</param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketTagging">REST API Reference for GetBucketTagging Operation</seealso>
        GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketTagging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketTagging">REST API Reference for GetBucketTagging Operation</seealso>
        IAsyncResult BeginGetBucketTagging(GetBucketTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketTagging.</param>
        /// 
        /// <returns>Returns a  GetBucketTaggingResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketTagging">REST API Reference for GetBucketTagging Operation</seealso>
        GetBucketTaggingResponse EndGetBucketTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketVersioning


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation returns the versioning state for S3 on Outposts buckets only. To return
        /// the versioning state for an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketVersioning.html">GetBucketVersioning</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the versioning state for an S3 on Outposts bucket. With S3 Versioning, you
        /// can save multiple distinct copies of your objects and recover from unintended user
        /// actions and application failures.
        /// </para>
        ///  
        /// <para>
        /// If you've never set versioning on your bucket, it has no versioning state. In that
        /// case, the <c>GetBucketVersioning</c> request does not return a versioning state value.
        /// </para>
        ///  
        /// <para>
        /// For more information about versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/Versioning.html">Versioning</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketVersioning.html#API_control_GetBucketVersioning_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>GetBucketVersioning</c> for S3 on Outposts.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketVersioning.html">PutBucketVersioning</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning service method.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketVersioning">REST API Reference for GetBucketVersioning Operation</seealso>
        GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketVersioning
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketVersioning">REST API Reference for GetBucketVersioning Operation</seealso>
        IAsyncResult BeginGetBucketVersioning(GetBucketVersioningRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketVersioning.</param>
        /// 
        /// <returns>Returns a  GetBucketVersioningResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketVersioning">REST API Reference for GetBucketVersioning Operation</seealso>
        GetBucketVersioningResponse EndGetBucketVersioning(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataAccess


        /// <summary>
        /// Returns a temporary access credential from S3 Access Grants to the grantee or client
        /// application. The <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_Credentials.html">temporary
        /// credential</a> is an Amazon Web Services STS token that grants them access to the
        /// S3 data. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:GetDataAccess</c> permission to use this operation. 
        /// </para>
        ///  </dd> <dt>Additional Permissions</dt> <dd> 
        /// <para>
        /// The IAM role that S3 Access Grants assumes must have the following permissions specified
        /// in the trust policy when registering the location: <c>sts:AssumeRole</c>, for directory
        /// users or groups <c>sts:SetContext</c>, and for IAM users or roles <c>sts:SetSourceIdentity</c>.
        /// 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAccess service method.</param>
        /// 
        /// <returns>The response from the GetDataAccess service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetDataAccess">REST API Reference for GetDataAccess Operation</seealso>
        GetDataAccessResponse GetDataAccess(GetDataAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataAccess operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetDataAccess">REST API Reference for GetDataAccess Operation</seealso>
        IAsyncResult BeginGetDataAccess(GetDataAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataAccess.</param>
        /// 
        /// <returns>Returns a  GetDataAccessResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetDataAccess">REST API Reference for GetDataAccess Operation</seealso>
        GetDataAccessResponse EndGetDataAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJobTagging


        /// <summary>
        /// Returns the tags on an S3 Batch Operations job. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// To use the <c>GetJobTagging</c> operation, you must have permission to perform the
        /// <c>s3:GetJobTagging</c> action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
        /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutJobTagging.html">PutJobTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobTagging service method.</param>
        /// 
        /// <returns>The response from the GetJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetJobTagging">REST API Reference for GetJobTagging Operation</seealso>
        GetJobTaggingResponse GetJobTagging(GetJobTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobTagging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetJobTagging">REST API Reference for GetJobTagging Operation</seealso>
        IAsyncResult BeginGetJobTagging(GetJobTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobTagging.</param>
        /// 
        /// <returns>Returns a  GetJobTaggingResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetJobTagging">REST API Reference for GetJobTagging Operation</seealso>
        GetJobTaggingResponse EndGetJobTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMultiRegionAccessPoint


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns configuration information about the specified Multi-Region Access Point.
        /// </para>
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around working with Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/MultiRegionAccessPointRestrictions.html">Multi-Region
        /// Access Point restrictions and limitations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetMultiRegionAccessPoint</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPoint service method.</param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPoint">REST API Reference for GetMultiRegionAccessPoint Operation</seealso>
        GetMultiRegionAccessPointResponse GetMultiRegionAccessPoint(GetMultiRegionAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMultiRegionAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPoint operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMultiRegionAccessPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPoint">REST API Reference for GetMultiRegionAccessPoint Operation</seealso>
        IAsyncResult BeginGetMultiRegionAccessPoint(GetMultiRegionAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMultiRegionAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMultiRegionAccessPoint.</param>
        /// 
        /// <returns>Returns a  GetMultiRegionAccessPointResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPoint">REST API Reference for GetMultiRegionAccessPoint Operation</seealso>
        GetMultiRegionAccessPointResponse EndGetMultiRegionAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMultiRegionAccessPointPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the access control policy of the specified Multi-Region Access Point.
        /// </para>
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around working with Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/MultiRegionAccessPointRestrictions.html">Multi-Region
        /// Access Point restrictions and limitations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetMultiRegionAccessPointPolicy</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicyStatus.html">GetMultiRegionAccessPointPolicyStatus</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutMultiRegionAccessPointPolicy.html">PutMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicy">REST API Reference for GetMultiRegionAccessPointPolicy Operation</seealso>
        GetMultiRegionAccessPointPolicyResponse GetMultiRegionAccessPointPolicy(GetMultiRegionAccessPointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMultiRegionAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMultiRegionAccessPointPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicy">REST API Reference for GetMultiRegionAccessPointPolicy Operation</seealso>
        IAsyncResult BeginGetMultiRegionAccessPointPolicy(GetMultiRegionAccessPointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMultiRegionAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMultiRegionAccessPointPolicy.</param>
        /// 
        /// <returns>Returns a  GetMultiRegionAccessPointPolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicy">REST API Reference for GetMultiRegionAccessPointPolicy Operation</seealso>
        GetMultiRegionAccessPointPolicyResponse EndGetMultiRegionAccessPointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMultiRegionAccessPointPolicyStatus


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Indicates whether the specified Multi-Region Access Point has an access control policy
        /// that allows public access.
        /// </para>
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around working with Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/MultiRegionAccessPointRestrictions.html">Multi-Region
        /// Access Point restrictions and limitations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>GetMultiRegionAccessPointPolicyStatus</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicy.html">GetMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutMultiRegionAccessPointPolicy.html">PutMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointPolicyStatus service method.</param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointPolicyStatus service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicyStatus">REST API Reference for GetMultiRegionAccessPointPolicyStatus Operation</seealso>
        GetMultiRegionAccessPointPolicyStatusResponse GetMultiRegionAccessPointPolicyStatus(GetMultiRegionAccessPointPolicyStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMultiRegionAccessPointPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointPolicyStatus operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMultiRegionAccessPointPolicyStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicyStatus">REST API Reference for GetMultiRegionAccessPointPolicyStatus Operation</seealso>
        IAsyncResult BeginGetMultiRegionAccessPointPolicyStatus(GetMultiRegionAccessPointPolicyStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMultiRegionAccessPointPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMultiRegionAccessPointPolicyStatus.</param>
        /// 
        /// <returns>Returns a  GetMultiRegionAccessPointPolicyStatusResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicyStatus">REST API Reference for GetMultiRegionAccessPointPolicyStatus Operation</seealso>
        GetMultiRegionAccessPointPolicyStatusResponse EndGetMultiRegionAccessPointPolicyStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMultiRegionAccessPointRoutes


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the routing configuration for a Multi-Region Access Point, indicating which
        /// Regions are active or passive.
        /// </para>
        ///  
        /// <para>
        /// To obtain routing control changes and failover requests, use the Amazon S3 failover
        /// control infrastructure endpoints in these five Amazon Web Services Regions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>us-east-1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>us-west-2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ap-southeast-2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ap-northeast-1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eu-west-1</c> 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointRoutes service method.</param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointRoutes service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointRoutes">REST API Reference for GetMultiRegionAccessPointRoutes Operation</seealso>
        GetMultiRegionAccessPointRoutesResponse GetMultiRegionAccessPointRoutes(GetMultiRegionAccessPointRoutesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMultiRegionAccessPointRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointRoutes operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMultiRegionAccessPointRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointRoutes">REST API Reference for GetMultiRegionAccessPointRoutes Operation</seealso>
        IAsyncResult BeginGetMultiRegionAccessPointRoutes(GetMultiRegionAccessPointRoutesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMultiRegionAccessPointRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMultiRegionAccessPointRoutes.</param>
        /// 
        /// <returns>Returns a  GetMultiRegionAccessPointRoutesResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointRoutes">REST API Reference for GetMultiRegionAccessPointRoutes Operation</seealso>
        GetMultiRegionAccessPointRoutesResponse EndGetMultiRegionAccessPointRoutes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPublicAccessBlock


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the <c>PublicAccessBlock</c> configuration for an Amazon Web Services account.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
        /// Using Amazon S3 block public access</a>.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeletePublicAccessBlock.html">DeletePublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutPublicAccessBlock.html">PutPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the GetPublicAccessBlock service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.NoSuchPublicAccessBlockConfigurationException">
        /// Amazon S3 throws this exception if you make a <c>GetPublicAccessBlock</c> request
        /// against an account that doesn't have a <c>PublicAccessBlockConfiguration</c> set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetPublicAccessBlock">REST API Reference for GetPublicAccessBlock Operation</seealso>
        GetPublicAccessBlockResponse GetPublicAccessBlock(GetPublicAccessBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPublicAccessBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetPublicAccessBlock">REST API Reference for GetPublicAccessBlock Operation</seealso>
        IAsyncResult BeginGetPublicAccessBlock(GetPublicAccessBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPublicAccessBlock.</param>
        /// 
        /// <returns>Returns a  GetPublicAccessBlockResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetPublicAccessBlock">REST API Reference for GetPublicAccessBlock Operation</seealso>
        GetPublicAccessBlockResponse EndGetPublicAccessBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStorageLensConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets the Amazon S3 Storage Lens configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>. For a complete list of S3 Storage Lens metrics, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_metrics_glossary.html">S3
        /// Storage Lens metrics glossary</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <c>s3:GetStorageLensConfiguration</c>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfiguration">REST API Reference for GetStorageLensConfiguration Operation</seealso>
        GetStorageLensConfigurationResponse GetStorageLensConfiguration(GetStorageLensConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStorageLensConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensConfiguration operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStorageLensConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfiguration">REST API Reference for GetStorageLensConfiguration Operation</seealso>
        IAsyncResult BeginGetStorageLensConfiguration(GetStorageLensConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStorageLensConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStorageLensConfiguration.</param>
        /// 
        /// <returns>Returns a  GetStorageLensConfigurationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfiguration">REST API Reference for GetStorageLensConfiguration Operation</seealso>
        GetStorageLensConfigurationResponse EndGetStorageLensConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStorageLensConfigurationTagging


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets the tags of Amazon S3 Storage Lens configuration. For more information about
        /// S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <c>s3:GetStorageLensConfigurationTagging</c>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensConfigurationTagging service method.</param>
        /// 
        /// <returns>The response from the GetStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfigurationTagging">REST API Reference for GetStorageLensConfigurationTagging Operation</seealso>
        GetStorageLensConfigurationTaggingResponse GetStorageLensConfigurationTagging(GetStorageLensConfigurationTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStorageLensConfigurationTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensConfigurationTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStorageLensConfigurationTagging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfigurationTagging">REST API Reference for GetStorageLensConfigurationTagging Operation</seealso>
        IAsyncResult BeginGetStorageLensConfigurationTagging(GetStorageLensConfigurationTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStorageLensConfigurationTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStorageLensConfigurationTagging.</param>
        /// 
        /// <returns>Returns a  GetStorageLensConfigurationTaggingResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfigurationTagging">REST API Reference for GetStorageLensConfigurationTagging Operation</seealso>
        GetStorageLensConfigurationTaggingResponse EndGetStorageLensConfigurationTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStorageLensGroup


        /// <summary>
        /// Retrieves the Storage Lens group configuration details.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the permission to perform the <c>s3:GetStorageLensGroup</c>
        /// action. For more information about the required Storage Lens Groups permissions, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
        /// account permissions to use S3 Storage Lens groups</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about Storage Lens groups errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3LensErrorCodeList">List
        /// of Amazon S3 Storage Lens error codes</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensGroup service method.</param>
        /// 
        /// <returns>The response from the GetStorageLensGroup service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensGroup">REST API Reference for GetStorageLensGroup Operation</seealso>
        GetStorageLensGroupResponse GetStorageLensGroup(GetStorageLensGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStorageLensGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensGroup operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStorageLensGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensGroup">REST API Reference for GetStorageLensGroup Operation</seealso>
        IAsyncResult BeginGetStorageLensGroup(GetStorageLensGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStorageLensGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStorageLensGroup.</param>
        /// 
        /// <returns>Returns a  GetStorageLensGroupResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensGroup">REST API Reference for GetStorageLensGroup Operation</seealso>
        GetStorageLensGroupResponse EndGetStorageLensGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessGrants


        /// <summary>
        /// Returns the list of access grants in your S3 Access Grants instance.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:ListAccessGrants</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessGrants service method.</param>
        /// 
        /// <returns>The response from the ListAccessGrants service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrants">REST API Reference for ListAccessGrants Operation</seealso>
        ListAccessGrantsResponse ListAccessGrants(ListAccessGrantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessGrants operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrants">REST API Reference for ListAccessGrants Operation</seealso>
        IAsyncResult BeginListAccessGrants(ListAccessGrantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessGrants.</param>
        /// 
        /// <returns>Returns a  ListAccessGrantsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrants">REST API Reference for ListAccessGrants Operation</seealso>
        ListAccessGrantsResponse EndListAccessGrants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessGrantsInstances


        /// <summary>
        /// Returns a list of S3 Access Grants instances. An S3 Access Grants instance serves
        /// as a logical grouping for your individual access grants. You can only have one S3
        /// Access Grants instance per Region per account.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:ListAccessGrantsInstances</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessGrantsInstances service method.</param>
        /// 
        /// <returns>The response from the ListAccessGrantsInstances service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrantsInstances">REST API Reference for ListAccessGrantsInstances Operation</seealso>
        ListAccessGrantsInstancesResponse ListAccessGrantsInstances(ListAccessGrantsInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessGrantsInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessGrantsInstances operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessGrantsInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrantsInstances">REST API Reference for ListAccessGrantsInstances Operation</seealso>
        IAsyncResult BeginListAccessGrantsInstances(ListAccessGrantsInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessGrantsInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessGrantsInstances.</param>
        /// 
        /// <returns>Returns a  ListAccessGrantsInstancesResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrantsInstances">REST API Reference for ListAccessGrantsInstances Operation</seealso>
        ListAccessGrantsInstancesResponse EndListAccessGrantsInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessGrantsLocations


        /// <summary>
        /// Returns a list of the locations registered in your S3 Access Grants instance.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:ListAccessGrantsLocations</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessGrantsLocations service method.</param>
        /// 
        /// <returns>The response from the ListAccessGrantsLocations service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrantsLocations">REST API Reference for ListAccessGrantsLocations Operation</seealso>
        ListAccessGrantsLocationsResponse ListAccessGrantsLocations(ListAccessGrantsLocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessGrantsLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessGrantsLocations operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessGrantsLocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrantsLocations">REST API Reference for ListAccessGrantsLocations Operation</seealso>
        IAsyncResult BeginListAccessGrantsLocations(ListAccessGrantsLocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessGrantsLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessGrantsLocations.</param>
        /// 
        /// <returns>Returns a  ListAccessGrantsLocationsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrantsLocations">REST API Reference for ListAccessGrantsLocations Operation</seealso>
        ListAccessGrantsLocationsResponse EndListAccessGrantsLocations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessPoints


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns a list of the access points. You can retrieve up to 1,000 access points per
        /// call. If the call returns more than 1,000 access points (or the number specified in
        /// <c>maxResults</c>, whichever is less), the response will include a continuation token
        /// that you can use to list the additional access points.
        /// </para>
        ///  
        /// <para>
        /// Returns only access points attached to S3 buckets by default. To return all access
        /// points specify <c>DataSourceType</c> as <c>ALL</c>.
        /// </para>
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html#API_control_GetAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>ListAccessPoints</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPoints service method.</param>
        /// 
        /// <returns>The response from the ListAccessPoints service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPoints">REST API Reference for ListAccessPoints Operation</seealso>
        ListAccessPointsResponse ListAccessPoints(ListAccessPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPoints operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPoints">REST API Reference for ListAccessPoints Operation</seealso>
        IAsyncResult BeginListAccessPoints(ListAccessPointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessPoints.</param>
        /// 
        /// <returns>Returns a  ListAccessPointsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPoints">REST API Reference for ListAccessPoints Operation</seealso>
        ListAccessPointsResponse EndListAccessPoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessPointsForDirectoryBuckets


        /// <summary>
        /// Returns a list of the access points that are owned by the Amazon Web Services account
        /// and that are associated with the specified directory bucket.
        /// 
        ///  
        /// <para>
        /// To list access points for general purpose buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccesspoints</a>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have the permission to perform the <c>s3express:ListAccessPointsForDirectoryBuckets</c>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For information about REST API errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#RESTErrorResponses">REST
        /// error responses</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPointsForDirectoryBuckets service method.</param>
        /// 
        /// <returns>The response from the ListAccessPointsForDirectoryBuckets service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForDirectoryBuckets">REST API Reference for ListAccessPointsForDirectoryBuckets Operation</seealso>
        ListAccessPointsForDirectoryBucketsResponse ListAccessPointsForDirectoryBuckets(ListAccessPointsForDirectoryBucketsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessPointsForDirectoryBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPointsForDirectoryBuckets operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessPointsForDirectoryBuckets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForDirectoryBuckets">REST API Reference for ListAccessPointsForDirectoryBuckets Operation</seealso>
        IAsyncResult BeginListAccessPointsForDirectoryBuckets(ListAccessPointsForDirectoryBucketsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessPointsForDirectoryBuckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessPointsForDirectoryBuckets.</param>
        /// 
        /// <returns>Returns a  ListAccessPointsForDirectoryBucketsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForDirectoryBuckets">REST API Reference for ListAccessPointsForDirectoryBuckets Operation</seealso>
        ListAccessPointsForDirectoryBucketsResponse EndListAccessPointsForDirectoryBuckets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessPointsForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns some or all (up to 1,000) access points associated with the Object Lambda
        /// Access Point per call. If there are more access points than what can be returned in
        /// one call, the response will include a continuation token that you can use to list
        /// the additional access points.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>ListAccessPointsForObjectLambda</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPointForObjectLambda.html">CreateAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointForObjectLambda.html">DeleteAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointForObjectLambda.html">GetAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPointsForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the ListAccessPointsForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForObjectLambda">REST API Reference for ListAccessPointsForObjectLambda Operation</seealso>
        ListAccessPointsForObjectLambdaResponse ListAccessPointsForObjectLambda(ListAccessPointsForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessPointsForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPointsForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessPointsForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForObjectLambda">REST API Reference for ListAccessPointsForObjectLambda Operation</seealso>
        IAsyncResult BeginListAccessPointsForObjectLambda(ListAccessPointsForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessPointsForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessPointsForObjectLambda.</param>
        /// 
        /// <returns>Returns a  ListAccessPointsForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForObjectLambda">REST API Reference for ListAccessPointsForObjectLambda Operation</seealso>
        ListAccessPointsForObjectLambdaResponse EndListAccessPointsForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCallerAccessGrants


        /// <summary>
        /// Use this API to list the access grants that grant the caller access to Amazon S3 data
        /// through S3 Access Grants. The caller (grantee) can be an Identity and Access Management
        /// (IAM) identity or Amazon Web Services Identity Center corporate directory identity.
        /// You must pass the Amazon Web Services account of the S3 data owner (grantor) in the
        /// request. You can, optionally, narrow the results by <c>GrantScope</c>, using a fragment
        /// of the data's S3 path, and S3 Access Grants will return only the grants with a path
        /// that contains the path fragment. You can also pass the <c>AllowedByApplication</c>
        /// filter in the request, which returns only the grants authorized for applications,
        /// whether the application is the caller's Identity Center application or any other application
        /// (<c>ALL</c>). For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-grants-list-grants.html">List
        /// the caller's access grants</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:ListCallerAccessGrants</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallerAccessGrants service method.</param>
        /// 
        /// <returns>The response from the ListCallerAccessGrants service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListCallerAccessGrants">REST API Reference for ListCallerAccessGrants Operation</seealso>
        ListCallerAccessGrantsResponse ListCallerAccessGrants(ListCallerAccessGrantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCallerAccessGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCallerAccessGrants operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCallerAccessGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListCallerAccessGrants">REST API Reference for ListCallerAccessGrants Operation</seealso>
        IAsyncResult BeginListCallerAccessGrants(ListCallerAccessGrantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCallerAccessGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCallerAccessGrants.</param>
        /// 
        /// <returns>Returns a  ListCallerAccessGrantsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListCallerAccessGrants">REST API Reference for ListCallerAccessGrants Operation</seealso>
        ListCallerAccessGrantsResponse EndListCallerAccessGrants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists current S3 Batch Operations jobs as well as the jobs that have ended within
        /// the last 90 days for the Amazon Web Services account making the request. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/batch-ops.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// To use the <c>ListJobs</c> operation, you must have permission to perform the <c>s3:ListJobs</c>
        /// action.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Related actions include:
        /// </para>
        ///   <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InvalidNextTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse ListJobs(ListJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListJobs">REST API Reference for ListJobs Operation</seealso>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMultiRegionAccessPoints


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns a list of the Multi-Region Access Points currently associated with the specified
        /// Amazon Web Services account. Each call can return up to 100 Multi-Region Access Points,
        /// the maximum number of Multi-Region Access Points that can be associated with a single
        /// account.
        /// </para>
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around working with Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/MultiRegionAccessPointRestrictions.html">Multi-Region
        /// Access Point restrictions and limitations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>ListMultiRegionAccessPoint</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiRegionAccessPoints service method.</param>
        /// 
        /// <returns>The response from the ListMultiRegionAccessPoints service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListMultiRegionAccessPoints">REST API Reference for ListMultiRegionAccessPoints Operation</seealso>
        ListMultiRegionAccessPointsResponse ListMultiRegionAccessPoints(ListMultiRegionAccessPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultiRegionAccessPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultiRegionAccessPoints operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMultiRegionAccessPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListMultiRegionAccessPoints">REST API Reference for ListMultiRegionAccessPoints Operation</seealso>
        IAsyncResult BeginListMultiRegionAccessPoints(ListMultiRegionAccessPointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMultiRegionAccessPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultiRegionAccessPoints.</param>
        /// 
        /// <returns>Returns a  ListMultiRegionAccessPointsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListMultiRegionAccessPoints">REST API Reference for ListMultiRegionAccessPoints Operation</seealso>
        ListMultiRegionAccessPointsResponse EndListMultiRegionAccessPoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRegionalBuckets


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns a list of all Outposts buckets in an Outpost that are owned by the authenticated
        /// sender of the request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and <c>x-amz-outpost-id</c> in your request, see
        /// the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListRegionalBuckets.html#API_control_ListRegionalBuckets_Examples">Examples</a>
        /// section.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegionalBuckets service method.</param>
        /// 
        /// <returns>The response from the ListRegionalBuckets service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListRegionalBuckets">REST API Reference for ListRegionalBuckets Operation</seealso>
        ListRegionalBucketsResponse ListRegionalBuckets(ListRegionalBucketsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegionalBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegionalBuckets operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegionalBuckets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListRegionalBuckets">REST API Reference for ListRegionalBuckets Operation</seealso>
        IAsyncResult BeginListRegionalBuckets(ListRegionalBucketsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegionalBuckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegionalBuckets.</param>
        /// 
        /// <returns>Returns a  ListRegionalBucketsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListRegionalBuckets">REST API Reference for ListRegionalBuckets Operation</seealso>
        ListRegionalBucketsResponse EndListRegionalBuckets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStorageLensConfigurations


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets a list of Amazon S3 Storage Lens configurations. For more information about S3
        /// Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <c>s3:ListStorageLensConfigurations</c>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageLensConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListStorageLensConfigurations service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensConfigurations">REST API Reference for ListStorageLensConfigurations Operation</seealso>
        ListStorageLensConfigurationsResponse ListStorageLensConfigurations(ListStorageLensConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStorageLensConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStorageLensConfigurations operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStorageLensConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensConfigurations">REST API Reference for ListStorageLensConfigurations Operation</seealso>
        IAsyncResult BeginListStorageLensConfigurations(ListStorageLensConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStorageLensConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStorageLensConfigurations.</param>
        /// 
        /// <returns>Returns a  ListStorageLensConfigurationsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensConfigurations">REST API Reference for ListStorageLensConfigurations Operation</seealso>
        ListStorageLensConfigurationsResponse EndListStorageLensConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStorageLensGroups


        /// <summary>
        /// Lists all the Storage Lens groups in the specified home Region. 
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the permission to perform the <c>s3:ListStorageLensGroups</c>
        /// action. For more information about the required Storage Lens Groups permissions, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
        /// account permissions to use S3 Storage Lens groups</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about Storage Lens groups errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3LensErrorCodeList">List
        /// of Amazon S3 Storage Lens error codes</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageLensGroups service method.</param>
        /// 
        /// <returns>The response from the ListStorageLensGroups service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensGroups">REST API Reference for ListStorageLensGroups Operation</seealso>
        ListStorageLensGroupsResponse ListStorageLensGroups(ListStorageLensGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStorageLensGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStorageLensGroups operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStorageLensGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensGroups">REST API Reference for ListStorageLensGroups Operation</seealso>
        IAsyncResult BeginListStorageLensGroups(ListStorageLensGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStorageLensGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStorageLensGroups.</param>
        /// 
        /// <returns>Returns a  ListStorageLensGroupsResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensGroups">REST API Reference for ListStorageLensGroups Operation</seealso>
        ListStorageLensGroupsResponse EndListStorageLensGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// This operation allows you to list all of the tags for a specified resource. Each tag
        /// is a label consisting of a key and value. Tags can help you organize, track costs
        /// for, and control access to resources. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation is only supported for the following Amazon S3 resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-db-tagging.html">Access
        /// Points for directory buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-tagging.html">Access
        /// Points for general purpose buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-tagging.html">Directory
        /// buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-lens-groups.html">Storage
        /// Lens groups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-grants-tagging.html">S3
        /// Access Grants instances, registered locations, and grants</a>.
        /// </para>
        ///  </li> </ul> </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For Storage Lens groups and S3 Access Grants, you must have the <c>s3:ListTagsForResource</c>
        /// permission to use this operation. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the required Storage Lens Groups permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
        /// account permissions to use S3 Storage Lens groups</a>.
        /// </para>
        ///  </dd> <dt>Directory bucket permissions</dt> <dd> 
        /// <para>
        /// For directory buckets and access points for directory buckets, you must have the <c>s3express:ListTagsForResource</c>
        /// permission to use this operation. For more information about directory buckets policies
        /// and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-permissions.html">Identity
        /// and Access Management (IAM) for S3 Express One Zone</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
        /// <para>
        ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region</i>.amazonaws.com</c>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For information about S3 Tagging errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3TaggingErrorCodeList">List
        /// of Amazon S3 Tagging error codes</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccessGrantsInstanceResourcePolicy


        /// <summary>
        /// Updates the resource policy of the S3 Access Grants instance. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:PutAccessGrantsInstanceResourcePolicy</c> permission to use
        /// this operation. 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessGrantsInstanceResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutAccessGrantsInstanceResourcePolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessGrantsInstanceResourcePolicy">REST API Reference for PutAccessGrantsInstanceResourcePolicy Operation</seealso>
        PutAccessGrantsInstanceResourcePolicyResponse PutAccessGrantsInstanceResourcePolicy(PutAccessGrantsInstanceResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccessGrantsInstanceResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccessGrantsInstanceResourcePolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccessGrantsInstanceResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessGrantsInstanceResourcePolicy">REST API Reference for PutAccessGrantsInstanceResourcePolicy Operation</seealso>
        IAsyncResult BeginPutAccessGrantsInstanceResourcePolicy(PutAccessGrantsInstanceResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccessGrantsInstanceResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccessGrantsInstanceResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutAccessGrantsInstanceResourcePolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessGrantsInstanceResourcePolicy">REST API Reference for PutAccessGrantsInstanceResourcePolicy Operation</seealso>
        PutAccessGrantsInstanceResourcePolicyResponse EndPutAccessGrantsInstanceResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccessPointConfigurationForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Replaces configuration for an Object Lambda Access Point.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>PutAccessPointConfigurationForObjectLambda</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointConfigurationForObjectLambda.html">GetAccessPointConfigurationForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointConfigurationForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the PutAccessPointConfigurationForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointConfigurationForObjectLambda">REST API Reference for PutAccessPointConfigurationForObjectLambda Operation</seealso>
        PutAccessPointConfigurationForObjectLambdaResponse PutAccessPointConfigurationForObjectLambda(PutAccessPointConfigurationForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccessPointConfigurationForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointConfigurationForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccessPointConfigurationForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointConfigurationForObjectLambda">REST API Reference for PutAccessPointConfigurationForObjectLambda Operation</seealso>
        IAsyncResult BeginPutAccessPointConfigurationForObjectLambda(PutAccessPointConfigurationForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccessPointConfigurationForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccessPointConfigurationForObjectLambda.</param>
        /// 
        /// <returns>Returns a  PutAccessPointConfigurationForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointConfigurationForObjectLambda">REST API Reference for PutAccessPointConfigurationForObjectLambda Operation</seealso>
        PutAccessPointConfigurationForObjectLambdaResponse EndPutAccessPointConfigurationForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccessPointPolicy


        /// <summary>
        /// Associates an access policy with the specified access point. Each access point can
        /// have only one policy, so a request made to this API replaces any existing policy associated
        /// with the specified access point.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html#API_control_PutAccessPointPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>PutAccessPointPolicy</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicy.html">GetAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicy.html">DeleteAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the PutAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicy">REST API Reference for PutAccessPointPolicy Operation</seealso>
        PutAccessPointPolicyResponse PutAccessPointPolicy(PutAccessPointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccessPointPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicy">REST API Reference for PutAccessPointPolicy Operation</seealso>
        IAsyncResult BeginPutAccessPointPolicy(PutAccessPointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccessPointPolicy.</param>
        /// 
        /// <returns>Returns a  PutAccessPointPolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicy">REST API Reference for PutAccessPointPolicy Operation</seealso>
        PutAccessPointPolicyResponse EndPutAccessPointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccessPointPolicyForObjectLambda


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates or replaces resource policy for an Object Lambda Access Point. For an example
        /// policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/olap-create.html#olap-create-cli">Creating
        /// Object Lambda Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>PutAccessPointPolicyForObjectLambda</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicyForObjectLambda.html">DeleteAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicyForObjectLambda.html">GetAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicyForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the PutAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicyForObjectLambda">REST API Reference for PutAccessPointPolicyForObjectLambda Operation</seealso>
        PutAccessPointPolicyForObjectLambdaResponse PutAccessPointPolicyForObjectLambda(PutAccessPointPolicyForObjectLambdaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccessPointPolicyForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicyForObjectLambda operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccessPointPolicyForObjectLambda
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicyForObjectLambda">REST API Reference for PutAccessPointPolicyForObjectLambda Operation</seealso>
        IAsyncResult BeginPutAccessPointPolicyForObjectLambda(PutAccessPointPolicyForObjectLambdaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccessPointPolicyForObjectLambda operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccessPointPolicyForObjectLambda.</param>
        /// 
        /// <returns>Returns a  PutAccessPointPolicyForObjectLambdaResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicyForObjectLambda">REST API Reference for PutAccessPointPolicyForObjectLambda Operation</seealso>
        PutAccessPointPolicyForObjectLambdaResponse EndPutAccessPointPolicyForObjectLambda(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccessPointScope


        /// <summary>
        /// Creates or replaces the access point scope for a directory bucket. You can use the
        /// access point scope to restrict access to specific prefixes, API operations, or a combination
        /// of both.
        /// 
        ///  <note> 
        /// <para>
        /// You can specify any amount of prefixes, but the total length of characters of all
        /// prefixes must be less than 256 bytes in size.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have the permission to perform the <c>s3express:PutAccessPointScope</c>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For information about REST API errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#RESTErrorResponses">REST
        /// error responses</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointScope service method.</param>
        /// 
        /// <returns>The response from the PutAccessPointScope service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointScope">REST API Reference for PutAccessPointScope Operation</seealso>
        PutAccessPointScopeResponse PutAccessPointScope(PutAccessPointScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccessPointScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointScope operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccessPointScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointScope">REST API Reference for PutAccessPointScope Operation</seealso>
        IAsyncResult BeginPutAccessPointScope(PutAccessPointScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccessPointScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccessPointScope.</param>
        /// 
        /// <returns>Returns a  PutAccessPointScopeResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointScope">REST API Reference for PutAccessPointScope Operation</seealso>
        PutAccessPointScopeResponse EndPutAccessPointScope(IAsyncResult asyncResult);

        #endregion
        
        #region  PutBucketLifecycleConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This action puts a lifecycle configuration to an Amazon S3 on Outposts bucket. To
        /// put a lifecycle configuration to an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a new lifecycle configuration for the S3 on Outposts bucket or replaces an
        /// existing lifecycle configuration. Outposts buckets only support lifecycle configurations
        /// that delete/expire objects after a certain period of time and abort incomplete multipart
        /// uploads.
        /// </para>
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html#API_control_PutBucketLifecycleConfiguration_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>PutBucketLifecycleConfiguration</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketLifecycleConfiguration.html">DeleteBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketLifecycleConfiguration">REST API Reference for PutBucketLifecycleConfiguration Operation</seealso>
        PutBucketLifecycleConfigurationResponse PutBucketLifecycleConfiguration(PutBucketLifecycleConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLifecycleConfiguration operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketLifecycleConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketLifecycleConfiguration">REST API Reference for PutBucketLifecycleConfiguration Operation</seealso>
        IAsyncResult BeginPutBucketLifecycleConfiguration(PutBucketLifecycleConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a  PutBucketLifecycleConfigurationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketLifecycleConfiguration">REST API Reference for PutBucketLifecycleConfiguration Operation</seealso>
        PutBucketLifecycleConfigurationResponse EndPutBucketLifecycleConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutBucketPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This action puts a bucket policy to an Amazon S3 on Outposts bucket. To put a policy
        /// on an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketPolicy.html">PutBucketPolicy</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Applies an Amazon S3 bucket policy to an Outposts bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are using an identity other than the root user of the Amazon Web Services account
        /// that owns the Outposts bucket, the calling identity must have the <c>PutBucketPolicy</c>
        /// permissions on the specified Outposts bucket and belong to the bucket owner's account
        /// in order to use this action.
        /// </para>
        ///  
        /// <para>
        /// If you don't have <c>PutBucketPolicy</c> permissions, Amazon S3 returns a <c>403 Access
        /// Denied</c> error. If you have the correct permissions, but you're not using an identity
        /// that belongs to the bucket owner's account, Amazon S3 returns a <c>405 Method Not
        /// Allowed</c> error.
        /// </para>
        ///  <important> 
        /// <para>
        ///  As a security precaution, the root user of the Amazon Web Services account that owns
        /// a bucket can always use this action, even if the policy explicitly denies the root
        /// user the ability to perform this action. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html#API_control_PutBucketPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>PutBucketPolicy</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html">GetBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketPolicy">REST API Reference for PutBucketPolicy Operation</seealso>
        PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketPolicy">REST API Reference for PutBucketPolicy Operation</seealso>
        IAsyncResult BeginPutBucketPolicy(PutBucketPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketPolicy.</param>
        /// 
        /// <returns>Returns a  PutBucketPolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketPolicy">REST API Reference for PutBucketPolicy Operation</seealso>
        PutBucketPolicyResponse EndPutBucketPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutBucketReplication


        /// <summary>
        /// <note> 
        /// <para>
        /// This action creates an Amazon S3 on Outposts bucket's replication configuration. To
        /// create an S3 bucket's replication configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketReplication.html">PutBucketReplication</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a replication configuration or replaces an existing one. For information about
        /// S3 replication on Outposts configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsReplication.html">Replicating
        /// objects for S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// It can take a while to propagate <c>PUT</c> or <c>DELETE</c> requests for a replication
        /// configuration to all S3 on Outposts systems. Therefore, the replication configuration
        /// that's returned by a <c>GET</c> request soon after a <c>PUT</c> or <c>DELETE</c> request
        /// might return a more recent result than what's on the Outpost. If an Outpost is offline,
        /// the delay in updating the replication configuration on that Outpost can be significant.
        /// </para>
        ///  </note> 
        /// <para>
        /// Specify the replication configuration in the request body. In the replication configuration,
        /// you provide the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The name of the destination bucket or buckets where you want S3 on Outposts to replicate
        /// objects
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Identity and Access Management (IAM) role that S3 on Outposts can assume to replicate
        /// objects on your behalf
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Other relevant information, such as replication rules
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A replication configuration must include at least one rule and can contain a maximum
        /// of 100. Each rule identifies a subset of objects to replicate by filtering the objects
        /// in the source Outposts bucket. To choose additional subsets of objects to replicate,
        /// add a rule for each subset.
        /// </para>
        ///  
        /// <para>
        /// To specify a subset of the objects in the source Outposts bucket to apply a replication
        /// rule to, add the <c>Filter</c> element as a child of the <c>Rule</c> element. You
        /// can filter objects based on an object key prefix, one or more object tags, or both.
        /// When you add the <c>Filter</c> element in the configuration, you must also add the
        /// following elements: <c>DeleteMarkerReplication</c>, <c>Status</c>, and <c>Priority</c>.
        /// </para>
        ///  
        /// <para>
        /// Using <c>PutBucketReplication</c> on Outposts requires that both the source and destination
        /// buckets must have versioning enabled. For information about enabling versioning on
        /// a bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsManagingVersioning.html">Managing
        /// S3 Versioning for your S3 on Outposts bucket</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about S3 on Outposts replication failure reasons, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/outposts-replication-eventbridge.html#outposts-replication-failure-codes">Replication
        /// failure reasons</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Handling Replication of Encrypted Objects</b> 
        /// </para>
        ///  
        /// <para>
        /// Outposts buckets are encrypted at all times. All the objects in the source Outposts
        /// bucket are encrypted and can be replicated. Also, all the replicas in the destination
        /// Outposts bucket are encrypted with the same encryption key as the objects in the source
        /// Outposts bucket.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To create a <c>PutBucketReplication</c> request, you must have <c>s3-outposts:PutReplicationConfiguration</c>
        /// permissions for the bucket. The Outposts bucket owner has this permission by default
        /// and can grant it to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsIAM.html">Setting
        /// up IAM with S3 on Outposts</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsBucketPolicy.html">Managing
        /// access to S3 on Outposts buckets</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To perform this operation, the user or role must also have the <c>iam:CreateRole</c>
        /// and <c>iam:PassRole</c> permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">Granting
        /// a user permissions to pass a role to an Amazon Web Services service</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketReplication.html#API_control_PutBucketReplication_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>PutBucketReplication</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketReplication.html">GetBucketReplication</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketReplication.html">DeleteBucketReplication</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication service method.</param>
        /// 
        /// <returns>The response from the PutBucketReplication service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketReplication">REST API Reference for PutBucketReplication Operation</seealso>
        PutBucketReplicationResponse PutBucketReplication(PutBucketReplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketReplication">REST API Reference for PutBucketReplication Operation</seealso>
        IAsyncResult BeginPutBucketReplication(PutBucketReplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketReplication.</param>
        /// 
        /// <returns>Returns a  PutBucketReplicationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketReplication">REST API Reference for PutBucketReplication Operation</seealso>
        PutBucketReplicationResponse EndPutBucketReplication(IAsyncResult asyncResult);

        #endregion
        
        #region  PutBucketTagging


        /// <summary>
        /// <note> 
        /// <para>
        /// This action puts tags on an Amazon S3 on Outposts bucket. To put tags on an S3 bucket,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketTagging.html">PutBucketTagging</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Sets the tags for an S3 on Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use tags to organize your Amazon Web Services bill to reflect your own cost structure.
        /// To do this, sign up to get your Amazon Web Services account bill with tag key values
        /// included. Then, to see the cost of combined resources, organize your billing information
        /// according to resources with the same tag key values. For example, you can tag several
        /// resources with a specific application name, and then organize your billing information
        /// to see the total cost of that application across several services. For more information,
        /// see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Cost
        /// allocation and tagging</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Within a bucket, if you add a tag that has the same key as an existing tag, the new
        /// value overwrites the old value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CostAllocTagging.html">
        /// Using cost allocation in Amazon S3 bucket tags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this action, you must have permissions to perform the <c>s3-outposts:PutBucketTagging</c>
        /// action. The Outposts bucket owner has this permission by default and can grant this
        /// permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">
        /// Permissions Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
        /// access permissions to your Amazon S3 resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>PutBucketTagging</c> has the following special errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <c>InvalidTagError</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The tag provided was not a valid tag. This error can occur if the tag
        /// did not pass input validation. For information about tag restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">
        /// User-Defined Tag Restrictions</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/aws-tag-restrictions.html">
        /// Amazon Web Services-Generated Cost Allocation Tag Restrictions</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <c>MalformedXMLError</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The XML provided does not match the schema.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <c>OperationAbortedError </c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: A conflicting conditional action is currently in progress against this
        /// resource. Try again.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <c>InternalError</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The service was unable to apply the provided tag to the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html#API_control_PutBucketTagging_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>PutBucketTagging</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html">GetBucketTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html">DeleteBucketTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging service method.</param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketTagging">REST API Reference for PutBucketTagging Operation</seealso>
        PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketTagging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketTagging">REST API Reference for PutBucketTagging Operation</seealso>
        IAsyncResult BeginPutBucketTagging(PutBucketTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketTagging.</param>
        /// 
        /// <returns>Returns a  PutBucketTaggingResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketTagging">REST API Reference for PutBucketTagging Operation</seealso>
        PutBucketTaggingResponse EndPutBucketTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  PutBucketVersioning


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation sets the versioning state for S3 on Outposts buckets only. To set the
        /// versioning state for an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketVersioning.html">PutBucketVersioning</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Sets the versioning state for an S3 on Outposts bucket. With S3 Versioning, you can
        /// save multiple distinct copies of your objects and recover from unintended user actions
        /// and application failures.
        /// </para>
        ///  
        /// <para>
        /// You can set the versioning state to one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Enabled</b> - Enables versioning for the objects in the bucket. All objects added
        /// to the bucket receive a unique version ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Suspended</b> - Suspends versioning for the objects in the bucket. All objects
        /// added to the bucket receive the version ID <c>null</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you've never set versioning on your bucket, it has no versioning state. In that
        /// case, a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketVersioning.html">
        /// GetBucketVersioning</a> request does not return a versioning state value.
        /// </para>
        ///  
        /// <para>
        /// When you enable S3 Versioning, for each object in your bucket, you have a current
        /// version and zero or more noncurrent versions. You can configure your bucket S3 Lifecycle
        /// rules to expire noncurrent versions after a specified time period. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsLifecycleManaging.html">
        /// Creating and managing a lifecycle configuration for your S3 on Outposts bucket</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you have an object expiration lifecycle configuration in your non-versioned bucket
        /// and you want to maintain the same permanent delete behavior when you enable versioning,
        /// you must add a noncurrent expiration policy. The noncurrent expiration lifecycle configuration
        /// will manage the deletes of the noncurrent object versions in the version-enabled bucket.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/Versioning.html">Versioning</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
        /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
        /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketVersioning.html#API_control_PutBucketVersioning_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>PutBucketVersioning</c> for S3 on Outposts.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketVersioning.html">GetBucketVersioning</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning service method.</param>
        /// 
        /// <returns>The response from the PutBucketVersioning service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketVersioning">REST API Reference for PutBucketVersioning Operation</seealso>
        PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucketVersioning
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketVersioning">REST API Reference for PutBucketVersioning Operation</seealso>
        IAsyncResult BeginPutBucketVersioning(PutBucketVersioningRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketVersioning.</param>
        /// 
        /// <returns>Returns a  PutBucketVersioningResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketVersioning">REST API Reference for PutBucketVersioning Operation</seealso>
        PutBucketVersioningResponse EndPutBucketVersioning(IAsyncResult asyncResult);

        #endregion
        
        #region  PutJobTagging


        /// <summary>
        /// Sets the supplied tag-set on an S3 Batch Operations job.
        /// 
        ///  
        /// <para>
        /// A tag is a key-value pair. You can associate S3 Batch Operations tags with any job
        /// by sending a PUT request against the tagging subresource that is associated with the
        /// job. To modify the existing tag set, you can either replace the existing tag set entirely,
        /// or make changes within the existing tag set by retrieving the existing tag set using
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>,
        /// modify that tag set, and use this operation to replace the tag set with the one you
        /// modified. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
        /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// If you send this request with an empty tag set, Amazon S3 deletes the existing tag
        /// set on the Batch Operations job. If you use this method, you are charged for a Tier
        /// 1 Request (PUT). For more information, see <a href="http://aws.amazon.com/s3/pricing/">Amazon
        /// S3 pricing</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For deleting existing tags for your Batch Operations job, a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
        /// request is preferred because it achieves the same result without incurring charges.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A few things to consider about using tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon S3 limits the maximum number of tags to 50 tags per job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can associate up to 50 tags with a job as long as they have unique tag keys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A tag key can be up to 128 Unicode characters in length, and tag values can be up
        /// to 256 Unicode characters in length.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For tagging-related restrictions related to characters and encodings, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        ///  </li> </ul> </li> </ul> </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// To use the <c>PutJobTagging</c> operation, you must have permission to perform the
        /// <c>s3:PutJobTagging</c> action.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobTagging service method.</param>
        /// 
        /// <returns>The response from the PutJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyTagsException">
        /// Amazon S3 throws this exception if you have too many tags in your tag set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutJobTagging">REST API Reference for PutJobTagging Operation</seealso>
        PutJobTaggingResponse PutJobTagging(PutJobTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutJobTagging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutJobTagging">REST API Reference for PutJobTagging Operation</seealso>
        IAsyncResult BeginPutJobTagging(PutJobTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutJobTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutJobTagging.</param>
        /// 
        /// <returns>Returns a  PutJobTaggingResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutJobTagging">REST API Reference for PutJobTagging Operation</seealso>
        PutJobTaggingResponse EndPutJobTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMultiRegionAccessPointPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates an access control policy with the specified Multi-Region Access Point.
        /// Each Multi-Region Access Point can have only one policy, so a request made to this
        /// action replaces any existing policy that is associated with the specified Multi-Region
        /// Access Point.
        /// </para>
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around working with Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/MultiRegionAccessPointRestrictions.html">Multi-Region
        /// Access Point restrictions and limitations</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>PutMultiRegionAccessPointPolicy</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicy.html">GetMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicyStatus.html">GetMultiRegionAccessPointPolicyStatus</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMultiRegionAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the PutMultiRegionAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutMultiRegionAccessPointPolicy">REST API Reference for PutMultiRegionAccessPointPolicy Operation</seealso>
        PutMultiRegionAccessPointPolicyResponse PutMultiRegionAccessPointPolicy(PutMultiRegionAccessPointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMultiRegionAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMultiRegionAccessPointPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMultiRegionAccessPointPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutMultiRegionAccessPointPolicy">REST API Reference for PutMultiRegionAccessPointPolicy Operation</seealso>
        IAsyncResult BeginPutMultiRegionAccessPointPolicy(PutMultiRegionAccessPointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMultiRegionAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMultiRegionAccessPointPolicy.</param>
        /// 
        /// <returns>Returns a  PutMultiRegionAccessPointPolicyResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutMultiRegionAccessPointPolicy">REST API Reference for PutMultiRegionAccessPointPolicy Operation</seealso>
        PutMultiRegionAccessPointPolicyResponse EndPutMultiRegionAccessPointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPublicAccessBlock


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates or modifies the <c>PublicAccessBlock</c> configuration for an Amazon Web Services
        /// account. For this operation, users must have the <c>s3:PutAccountPublicAccessBlock</c>
        /// permission. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
        /// Using Amazon S3 block public access</a>.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetPublicAccessBlock.html">GetPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeletePublicAccessBlock.html">DeletePublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the PutPublicAccessBlock service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutPublicAccessBlock">REST API Reference for PutPublicAccessBlock Operation</seealso>
        PutPublicAccessBlockResponse PutPublicAccessBlock(PutPublicAccessBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPublicAccessBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutPublicAccessBlock">REST API Reference for PutPublicAccessBlock Operation</seealso>
        IAsyncResult BeginPutPublicAccessBlock(PutPublicAccessBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPublicAccessBlock.</param>
        /// 
        /// <returns>Returns a  PutPublicAccessBlockResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutPublicAccessBlock">REST API Reference for PutPublicAccessBlock Operation</seealso>
        PutPublicAccessBlockResponse EndPutPublicAccessBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  PutStorageLensConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Puts an Amazon S3 Storage Lens configuration. For more information about S3 Storage
        /// Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Working
        /// with Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>. For a complete
        /// list of S3 Storage Lens metrics, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_metrics_glossary.html">S3
        /// Storage Lens metrics glossary</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <c>s3:PutStorageLensConfiguration</c>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStorageLensConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfiguration">REST API Reference for PutStorageLensConfiguration Operation</seealso>
        PutStorageLensConfigurationResponse PutStorageLensConfiguration(PutStorageLensConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutStorageLensConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutStorageLensConfiguration operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutStorageLensConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfiguration">REST API Reference for PutStorageLensConfiguration Operation</seealso>
        IAsyncResult BeginPutStorageLensConfiguration(PutStorageLensConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutStorageLensConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutStorageLensConfiguration.</param>
        /// 
        /// <returns>Returns a  PutStorageLensConfigurationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfiguration">REST API Reference for PutStorageLensConfiguration Operation</seealso>
        PutStorageLensConfigurationResponse EndPutStorageLensConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutStorageLensConfigurationTagging


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Put or replace tags on an existing Amazon S3 Storage Lens configuration. For more
        /// information about S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <c>s3:PutStorageLensConfigurationTagging</c>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStorageLensConfigurationTagging service method.</param>
        /// 
        /// <returns>The response from the PutStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfigurationTagging">REST API Reference for PutStorageLensConfigurationTagging Operation</seealso>
        PutStorageLensConfigurationTaggingResponse PutStorageLensConfigurationTagging(PutStorageLensConfigurationTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutStorageLensConfigurationTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutStorageLensConfigurationTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutStorageLensConfigurationTagging
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfigurationTagging">REST API Reference for PutStorageLensConfigurationTagging Operation</seealso>
        IAsyncResult BeginPutStorageLensConfigurationTagging(PutStorageLensConfigurationTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutStorageLensConfigurationTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutStorageLensConfigurationTagging.</param>
        /// 
        /// <returns>Returns a  PutStorageLensConfigurationTaggingResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfigurationTagging">REST API Reference for PutStorageLensConfigurationTagging Operation</seealso>
        PutStorageLensConfigurationTaggingResponse EndPutStorageLensConfigurationTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  SubmitMultiRegionAccessPointRoutes


        /// <summary>
        /// <note> 
        /// <para>
        /// This operation is not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        /// Submits an updated route configuration for a Multi-Region Access Point. This API operation
        /// updates the routing status for the specified Regions from active to passive, or from
        /// passive to active. A value of <c>0</c> indicates a passive status, which means that
        /// traffic won't be routed to the specified Region. A value of <c>100</c> indicates an
        /// active status, which means that traffic will be routed to the specified Region. At
        /// least one Region must be active at all times.
        /// </para>
        ///  
        /// <para>
        /// When the routing configuration is changed, any in-progress operations (uploads, copies,
        /// deletes, and so on) to formerly active Regions will continue to run to their final
        /// completion state (success or failure). The routing configurations of any Regions that
        /// aren’t specified remain unchanged.
        /// </para>
        ///  <note> 
        /// <para>
        /// Updated routing configurations might not be immediately applied. It can take up to
        /// 2 minutes for your changes to take effect.
        /// </para>
        ///  </note> 
        /// <para>
        /// To submit routing control changes and failover requests, use the Amazon S3 failover
        /// control infrastructure endpoints in these five Amazon Web Services Regions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>us-east-1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>us-west-2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ap-southeast-2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ap-northeast-1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eu-west-1</c> 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitMultiRegionAccessPointRoutes service method.</param>
        /// 
        /// <returns>The response from the SubmitMultiRegionAccessPointRoutes service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/SubmitMultiRegionAccessPointRoutes">REST API Reference for SubmitMultiRegionAccessPointRoutes Operation</seealso>
        SubmitMultiRegionAccessPointRoutesResponse SubmitMultiRegionAccessPointRoutes(SubmitMultiRegionAccessPointRoutesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SubmitMultiRegionAccessPointRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubmitMultiRegionAccessPointRoutes operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubmitMultiRegionAccessPointRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/SubmitMultiRegionAccessPointRoutes">REST API Reference for SubmitMultiRegionAccessPointRoutes Operation</seealso>
        IAsyncResult BeginSubmitMultiRegionAccessPointRoutes(SubmitMultiRegionAccessPointRoutesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SubmitMultiRegionAccessPointRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubmitMultiRegionAccessPointRoutes.</param>
        /// 
        /// <returns>Returns a  SubmitMultiRegionAccessPointRoutesResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/SubmitMultiRegionAccessPointRoutes">REST API Reference for SubmitMultiRegionAccessPointRoutes Operation</seealso>
        SubmitMultiRegionAccessPointRoutesResponse EndSubmitMultiRegionAccessPointRoutes(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Creates a new user-defined tag or updates an existing tag. Each tag is a label consisting
        /// of a key and value that is applied to your resource. Tags can help you organize, track
        /// costs for, and control access to your resources. You can add up to 50 Amazon Web Services
        /// resource tags for each S3 resource. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation is only supported for the following Amazon S3 resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-db-tagging.html">Access
        /// Points for directory buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-tagging.html">Access
        /// Points for general purpose buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-tagging.html">Directory
        /// buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-lens-groups.html">S3
        /// Storage Lens groups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-grants-tagging.html">S3
        /// Access Grants instances, registered locations, or grants</a>.
        /// </para>
        ///  </li> </ul> </note> <note> 
        /// <para>
        /// This operation is only supported for the following Amazon S3 resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-tagging.html">Directory
        /// buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-lens-groups.html">S3
        /// Storage Lens groups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-grants-tagging.html">S3
        /// Access Grants instances, registered locations, or grants</a>.
        /// </para>
        ///  </li> </ul> </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For Storage Lens groups and S3 Access Grants, you must have the <c>s3:TagResource</c>
        /// permission to use this operation. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the required Storage Lens Groups permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
        /// account permissions to use S3 Storage Lens groups</a>.
        /// </para>
        ///  </dd> <dt>Directory bucket permissions</dt> <dd> 
        /// <para>
        /// For directory buckets and access points for directory buckets, you must have the <c>s3express:TagResource</c>
        /// permission to use this operation. For more information about directory buckets policies
        /// and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-permissions.html">Identity
        /// and Access Management (IAM) for S3 Express One Zone</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
        /// <para>
        ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region</i>.amazonaws.com</c>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For information about S3 Tagging errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3TaggingErrorCodeList">List
        /// of Amazon S3 Tagging error codes</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// This operation removes the specified user-defined tags from an S3 resource. You can
        /// pass one or more tag keys. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation is only supported for the following Amazon S3 resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-db-tagging.html">Access
        /// Points for directory buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-tagging.html">Access
        /// Points for general purpose buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-tagging.html">Directory
        /// buckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-lens-groups.html">Storage
        /// Lens groups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-grants-tagging.html">S3
        /// Access Grants instances, registered locations, and grants</a>.
        /// </para>
        ///  </li> </ul> </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For Storage Lens groups and S3 Access Grants, you must have the <c>s3:UntagResource</c>
        /// permission to use this operation. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the required Storage Lens Groups permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
        /// account permissions to use S3 Storage Lens groups</a>.
        /// </para>
        ///  </dd> <dt>Directory bucket permissions</dt> <dd> 
        /// <para>
        /// For directory buckets and access points for directory buckets, you must have the <c>s3express:UntagResource</c>
        /// permission to use this operation. For more information about directory buckets policies
        /// and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-permissions.html">Identity
        /// and Access Management (IAM) for S3 Express One Zone</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
        /// <para>
        ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region</i>.amazonaws.com</c>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For information about S3 Tagging errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3TaggingErrorCodeList">List
        /// of Amazon S3 Tagging error codes</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccessGrantsLocation


        /// <summary>
        /// Updates the IAM role of a registered location in your S3 Access Grants instance.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3:UpdateAccessGrantsLocation</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> <dt>Additional Permissions</dt> <dd> 
        /// <para>
        /// You must also have the following permission: <c>iam:PassRole</c> 
        /// </para>
        ///  </dd> </dl> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessGrantsLocation service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessGrantsLocation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateAccessGrantsLocation">REST API Reference for UpdateAccessGrantsLocation Operation</seealso>
        UpdateAccessGrantsLocationResponse UpdateAccessGrantsLocation(UpdateAccessGrantsLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessGrantsLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessGrantsLocation operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessGrantsLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateAccessGrantsLocation">REST API Reference for UpdateAccessGrantsLocation Operation</seealso>
        IAsyncResult BeginUpdateAccessGrantsLocation(UpdateAccessGrantsLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessGrantsLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessGrantsLocation.</param>
        /// 
        /// <returns>Returns a  UpdateAccessGrantsLocationResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateAccessGrantsLocation">REST API Reference for UpdateAccessGrantsLocation Operation</seealso>
        UpdateAccessGrantsLocationResponse EndUpdateAccessGrantsLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateJobPriority


        /// <summary>
        /// Updates an existing S3 Batch Operations job's priority. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/batch-ops.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// To use the <c>UpdateJobPriority</c> operation, you must have permission to perform
        /// the <c>s3:UpdateJobPriority</c> action.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobPriority service method.</param>
        /// 
        /// <returns>The response from the UpdateJobPriority service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobPriority">REST API Reference for UpdateJobPriority Operation</seealso>
        UpdateJobPriorityResponse UpdateJobPriority(UpdateJobPriorityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobPriority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobPriority operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJobPriority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobPriority">REST API Reference for UpdateJobPriority Operation</seealso>
        IAsyncResult BeginUpdateJobPriority(UpdateJobPriorityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobPriority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobPriority.</param>
        /// 
        /// <returns>Returns a  UpdateJobPriorityResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobPriority">REST API Reference for UpdateJobPriority Operation</seealso>
        UpdateJobPriorityResponse EndUpdateJobPriority(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateJobStatus


        /// <summary>
        /// Updates the status for the specified job. Use this operation to confirm that you want
        /// to run a job or to cancel an existing job. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/batch-ops.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// To use the <c>UpdateJobStatus</c> operation, you must have permission to perform the
        /// <c>s3:UpdateJobStatus</c> action.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateJobStatus service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.JobStatusException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobStatus">REST API Reference for UpdateJobStatus Operation</seealso>
        UpdateJobStatusResponse UpdateJobStatus(UpdateJobStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobStatus operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJobStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobStatus">REST API Reference for UpdateJobStatus Operation</seealso>
        IAsyncResult BeginUpdateJobStatus(UpdateJobStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobStatus.</param>
        /// 
        /// <returns>Returns a  UpdateJobStatusResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobStatus">REST API Reference for UpdateJobStatus Operation</seealso>
        UpdateJobStatusResponse EndUpdateJobStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStorageLensGroup


        /// <summary>
        /// Updates the existing Storage Lens group.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the permission to perform the <c>s3:UpdateStorageLensGroup</c>
        /// action. For more information about the required Storage Lens Groups permissions, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_iam_permissions.html#storage_lens_groups_permissions">Setting
        /// account permissions to use S3 Storage Lens groups</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about Storage Lens groups errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#S3LensErrorCodeList">List
        /// of Amazon S3 Storage Lens error codes</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must URL encode any signed header values that contain spaces. For example, if
        /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
        /// must URL encode this value to <c>my%20%20file.txt</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageLensGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateStorageLensGroup service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateStorageLensGroup">REST API Reference for UpdateStorageLensGroup Operation</seealso>
        UpdateStorageLensGroupResponse UpdateStorageLensGroup(UpdateStorageLensGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStorageLensGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageLensGroup operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStorageLensGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateStorageLensGroup">REST API Reference for UpdateStorageLensGroup Operation</seealso>
        IAsyncResult BeginUpdateStorageLensGroup(UpdateStorageLensGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStorageLensGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStorageLensGroup.</param>
        /// 
        /// <returns>Returns a  UpdateStorageLensGroupResult from S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateStorageLensGroup">REST API Reference for UpdateStorageLensGroup Operation</seealso>
        UpdateStorageLensGroupResponse EndUpdateStorageLensGroup(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}