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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IS3ControlPaginatorFactory Paginators { get; }

        
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAccessGrantsIdentityCenter service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/AssociateAccessGrantsIdentityCenter">REST API Reference for AssociateAccessGrantsIdentityCenter Operation</seealso>
        Task<AssociateAccessGrantsIdentityCenterResponse> AssociateAccessGrantsIdentityCenterAsync(AssociateAccessGrantsIdentityCenterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessGrant service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrant">REST API Reference for CreateAccessGrant Operation</seealso>
        Task<CreateAccessGrantResponse> CreateAccessGrantAsync(CreateAccessGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessGrantsInstance service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrantsInstance">REST API Reference for CreateAccessGrantsInstance Operation</seealso>
        Task<CreateAccessGrantsInstanceResponse> CreateAccessGrantsInstanceAsync(CreateAccessGrantsInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessGrantsLocation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessGrantsLocation">REST API Reference for CreateAccessGrantsLocation Operation</seealso>
        Task<CreateAccessGrantsLocationResponse> CreateAccessGrantsLocationAsync(CreateAccessGrantsLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        Task<CreateAccessPointResponse> CreateAccessPointAsync(CreateAccessPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPointForObjectLambda">REST API Reference for CreateAccessPointForObjectLambda Operation</seealso>
        Task<CreateAccessPointForObjectLambdaResponse> CreateAccessPointForObjectLambdaAsync(CreateAccessPointForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBucketResponse> CreateBucketAsync(CreateBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateMultiRegionAccessPoint">REST API Reference for CreateMultiRegionAccessPoint Operation</seealso>
        Task<CreateMultiRegionAccessPointResponse> CreateMultiRegionAccessPointAsync(CreateMultiRegionAccessPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageLensGroup service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateStorageLensGroup">REST API Reference for CreateStorageLensGroup Operation</seealso>
        Task<CreateStorageLensGroupResponse> CreateStorageLensGroupAsync(CreateStorageLensGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessGrant service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrant">REST API Reference for DeleteAccessGrant Operation</seealso>
        Task<DeleteAccessGrantResponse> DeleteAccessGrantAsync(DeleteAccessGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessGrantsInstance service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsInstance">REST API Reference for DeleteAccessGrantsInstance Operation</seealso>
        Task<DeleteAccessGrantsInstanceResponse> DeleteAccessGrantsInstanceAsync(DeleteAccessGrantsInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessGrantsInstanceResourcePolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsInstanceResourcePolicy">REST API Reference for DeleteAccessGrantsInstanceResourcePolicy Operation</seealso>
        Task<DeleteAccessGrantsInstanceResourcePolicyResponse> DeleteAccessGrantsInstanceResourcePolicyAsync(DeleteAccessGrantsInstanceResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessGrantsLocation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessGrantsLocation">REST API Reference for DeleteAccessGrantsLocation Operation</seealso>
        Task<DeleteAccessGrantsLocationResponse> DeleteAccessGrantsLocationAsync(DeleteAccessGrantsLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        Task<DeleteAccessPointResponse> DeleteAccessPointAsync(DeleteAccessPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointForObjectLambda">REST API Reference for DeleteAccessPointForObjectLambda Operation</seealso>
        Task<DeleteAccessPointForObjectLambdaResponse> DeleteAccessPointForObjectLambdaAsync(DeleteAccessPointForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicy">REST API Reference for DeleteAccessPointPolicy Operation</seealso>
        Task<DeleteAccessPointPolicyResponse> DeleteAccessPointPolicyAsync(DeleteAccessPointPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicyForObjectLambda">REST API Reference for DeleteAccessPointPolicyForObjectLambda Operation</seealso>
        Task<DeleteAccessPointPolicyForObjectLambdaResponse> DeleteAccessPointPolicyForObjectLambdaAsync(DeleteAccessPointPolicyForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPointScope service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointScope">REST API Reference for DeleteAccessPointScope Operation</seealso>
        Task<DeleteAccessPointScopeResponse> DeleteAccessPointScopeAsync(DeleteAccessPointScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketLifecycleConfiguration">REST API Reference for DeleteBucketLifecycleConfiguration Operation</seealso>
        Task<DeleteBucketLifecycleConfigurationResponse> DeleteBucketLifecycleConfigurationAsync(DeleteBucketLifecycleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketPolicy">REST API Reference for DeleteBucketPolicy Operation</seealso>
        Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketReplication service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketReplication">REST API Reference for DeleteBucketReplication Operation</seealso>
        Task<DeleteBucketReplicationResponse> DeleteBucketReplicationAsync(DeleteBucketReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketTagging">REST API Reference for DeleteBucketTagging Operation</seealso>
        Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteJobTaggingResponse> DeleteJobTaggingAsync(DeleteJobTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteMultiRegionAccessPoint">REST API Reference for DeleteMultiRegionAccessPoint Operation</seealso>
        Task<DeleteMultiRegionAccessPointResponse> DeleteMultiRegionAccessPointAsync(DeleteMultiRegionAccessPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePublicAccessBlock service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeletePublicAccessBlock">REST API Reference for DeletePublicAccessBlock Operation</seealso>
        Task<DeletePublicAccessBlockResponse> DeletePublicAccessBlockAsync(DeletePublicAccessBlockRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfiguration">REST API Reference for DeleteStorageLensConfiguration Operation</seealso>
        Task<DeleteStorageLensConfigurationResponse> DeleteStorageLensConfigurationAsync(DeleteStorageLensConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfigurationTagging">REST API Reference for DeleteStorageLensConfigurationTagging Operation</seealso>
        Task<DeleteStorageLensConfigurationTaggingResponse> DeleteStorageLensConfigurationTaggingAsync(DeleteStorageLensConfigurationTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStorageLensGroup service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensGroup">REST API Reference for DeleteStorageLensGroup Operation</seealso>
        Task<DeleteStorageLensGroupResponse> DeleteStorageLensGroupAsync(DeleteStorageLensGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMultiRegionAccessPointOperation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeMultiRegionAccessPointOperation">REST API Reference for DescribeMultiRegionAccessPointOperation Operation</seealso>
        Task<DescribeMultiRegionAccessPointOperationResponse> DescribeMultiRegionAccessPointOperationAsync(DescribeMultiRegionAccessPointOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DissociateAccessGrantsIdentityCenter service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DissociateAccessGrantsIdentityCenter">REST API Reference for DissociateAccessGrantsIdentityCenter Operation</seealso>
        Task<DissociateAccessGrantsIdentityCenterResponse> DissociateAccessGrantsIdentityCenterAsync(DissociateAccessGrantsIdentityCenterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessGrant service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrant">REST API Reference for GetAccessGrant Operation</seealso>
        Task<GetAccessGrantResponse> GetAccessGrantAsync(GetAccessGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessGrantsInstance service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstance">REST API Reference for GetAccessGrantsInstance Operation</seealso>
        Task<GetAccessGrantsInstanceResponse> GetAccessGrantsInstanceAsync(GetAccessGrantsInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessGrantsInstanceForPrefix service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstanceForPrefix">REST API Reference for GetAccessGrantsInstanceForPrefix Operation</seealso>
        Task<GetAccessGrantsInstanceForPrefixResponse> GetAccessGrantsInstanceForPrefixAsync(GetAccessGrantsInstanceForPrefixRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessGrantsInstanceResourcePolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsInstanceResourcePolicy">REST API Reference for GetAccessGrantsInstanceResourcePolicy Operation</seealso>
        Task<GetAccessGrantsInstanceResourcePolicyResponse> GetAccessGrantsInstanceResourcePolicyAsync(GetAccessGrantsInstanceResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessGrantsLocation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessGrantsLocation">REST API Reference for GetAccessGrantsLocation Operation</seealso>
        Task<GetAccessGrantsLocationResponse> GetAccessGrantsLocationAsync(GetAccessGrantsLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPoint">REST API Reference for GetAccessPoint Operation</seealso>
        Task<GetAccessPointResponse> GetAccessPointAsync(GetAccessPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointConfigurationForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointConfigurationForObjectLambda">REST API Reference for GetAccessPointConfigurationForObjectLambda Operation</seealso>
        Task<GetAccessPointConfigurationForObjectLambdaResponse> GetAccessPointConfigurationForObjectLambdaAsync(GetAccessPointConfigurationForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointForObjectLambda">REST API Reference for GetAccessPointForObjectLambda Operation</seealso>
        Task<GetAccessPointForObjectLambdaResponse> GetAccessPointForObjectLambdaAsync(GetAccessPointForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicy">REST API Reference for GetAccessPointPolicy Operation</seealso>
        Task<GetAccessPointPolicyResponse> GetAccessPointPolicyAsync(GetAccessPointPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyForObjectLambda">REST API Reference for GetAccessPointPolicyForObjectLambda Operation</seealso>
        Task<GetAccessPointPolicyForObjectLambdaResponse> GetAccessPointPolicyForObjectLambdaAsync(GetAccessPointPolicyForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyStatus service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatus">REST API Reference for GetAccessPointPolicyStatus Operation</seealso>
        Task<GetAccessPointPolicyStatusResponse> GetAccessPointPolicyStatusAsync(GetAccessPointPolicyStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyStatusForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatusForObjectLambda">REST API Reference for GetAccessPointPolicyStatusForObjectLambda Operation</seealso>
        Task<GetAccessPointPolicyStatusForObjectLambdaResponse> GetAccessPointPolicyStatusForObjectLambdaAsync(GetAccessPointPolicyStatusForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointScope service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointScope">REST API Reference for GetAccessPointScope Operation</seealso>
        Task<GetAccessPointScopeResponse> GetAccessPointScopeAsync(GetAccessPointScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucket service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucket">REST API Reference for GetBucket Operation</seealso>
        Task<GetBucketResponse> GetBucketAsync(GetBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketLifecycleConfiguration">REST API Reference for GetBucketLifecycleConfiguration Operation</seealso>
        Task<GetBucketLifecycleConfigurationResponse> GetBucketLifecycleConfigurationAsync(GetBucketLifecycleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketPolicy">REST API Reference for GetBucketPolicy Operation</seealso>
        Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketReplication service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketReplication">REST API Reference for GetBucketReplication Operation</seealso>
        Task<GetBucketReplicationResponse> GetBucketReplicationAsync(GetBucketReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketTagging">REST API Reference for GetBucketTagging Operation</seealso>
        Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketVersioning">REST API Reference for GetBucketVersioning Operation</seealso>
        Task<GetBucketVersioningResponse> GetBucketVersioningAsync(GetBucketVersioningRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataAccess service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetDataAccess">REST API Reference for GetDataAccess Operation</seealso>
        Task<GetDataAccessResponse> GetDataAccessAsync(GetDataAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetJobTaggingResponse> GetJobTaggingAsync(GetJobTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPoint">REST API Reference for GetMultiRegionAccessPoint Operation</seealso>
        Task<GetMultiRegionAccessPointResponse> GetMultiRegionAccessPointAsync(GetMultiRegionAccessPointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicy">REST API Reference for GetMultiRegionAccessPointPolicy Operation</seealso>
        Task<GetMultiRegionAccessPointPolicyResponse> GetMultiRegionAccessPointPolicyAsync(GetMultiRegionAccessPointPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointPolicyStatus service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicyStatus">REST API Reference for GetMultiRegionAccessPointPolicyStatus Operation</seealso>
        Task<GetMultiRegionAccessPointPolicyStatusResponse> GetMultiRegionAccessPointPolicyStatusAsync(GetMultiRegionAccessPointPolicyStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointRoutes service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointRoutes">REST API Reference for GetMultiRegionAccessPointRoutes Operation</seealso>
        Task<GetMultiRegionAccessPointRoutesResponse> GetMultiRegionAccessPointRoutesAsync(GetMultiRegionAccessPointRoutesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPublicAccessBlock service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.NoSuchPublicAccessBlockConfigurationException">
        /// Amazon S3 throws this exception if you make a <c>GetPublicAccessBlock</c> request
        /// against an account that doesn't have a <c>PublicAccessBlockConfiguration</c> set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetPublicAccessBlock">REST API Reference for GetPublicAccessBlock Operation</seealso>
        Task<GetPublicAccessBlockResponse> GetPublicAccessBlockAsync(GetPublicAccessBlockRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfiguration">REST API Reference for GetStorageLensConfiguration Operation</seealso>
        Task<GetStorageLensConfigurationResponse> GetStorageLensConfigurationAsync(GetStorageLensConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfigurationTagging">REST API Reference for GetStorageLensConfigurationTagging Operation</seealso>
        Task<GetStorageLensConfigurationTaggingResponse> GetStorageLensConfigurationTaggingAsync(GetStorageLensConfigurationTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStorageLensGroup service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensGroup">REST API Reference for GetStorageLensGroup Operation</seealso>
        Task<GetStorageLensGroupResponse> GetStorageLensGroupAsync(GetStorageLensGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessGrants service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrants">REST API Reference for ListAccessGrants Operation</seealso>
        Task<ListAccessGrantsResponse> ListAccessGrantsAsync(ListAccessGrantsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessGrantsInstances service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrantsInstances">REST API Reference for ListAccessGrantsInstances Operation</seealso>
        Task<ListAccessGrantsInstancesResponse> ListAccessGrantsInstancesAsync(ListAccessGrantsInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessGrantsLocations service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessGrantsLocations">REST API Reference for ListAccessGrantsLocations Operation</seealso>
        Task<ListAccessGrantsLocationsResponse> ListAccessGrantsLocationsAsync(ListAccessGrantsLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPoints service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPoints">REST API Reference for ListAccessPoints Operation</seealso>
        Task<ListAccessPointsResponse> ListAccessPointsAsync(ListAccessPointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPointsForDirectoryBuckets service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForDirectoryBuckets">REST API Reference for ListAccessPointsForDirectoryBuckets Operation</seealso>
        Task<ListAccessPointsForDirectoryBucketsResponse> ListAccessPointsForDirectoryBucketsAsync(ListAccessPointsForDirectoryBucketsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPointsForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForObjectLambda">REST API Reference for ListAccessPointsForObjectLambda Operation</seealso>
        Task<ListAccessPointsForObjectLambdaResponse> ListAccessPointsForObjectLambdaAsync(ListAccessPointsForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCallerAccessGrants service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListCallerAccessGrants">REST API Reference for ListCallerAccessGrants Operation</seealso>
        Task<ListCallerAccessGrantsResponse> ListCallerAccessGrantsAsync(ListCallerAccessGrantsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultiRegionAccessPoints service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListMultiRegionAccessPoints">REST API Reference for ListMultiRegionAccessPoints Operation</seealso>
        Task<ListMultiRegionAccessPointsResponse> ListMultiRegionAccessPointsAsync(ListMultiRegionAccessPointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegionalBuckets service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListRegionalBuckets">REST API Reference for ListRegionalBuckets Operation</seealso>
        Task<ListRegionalBucketsResponse> ListRegionalBucketsAsync(ListRegionalBucketsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStorageLensConfigurations service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensConfigurations">REST API Reference for ListStorageLensConfigurations Operation</seealso>
        Task<ListStorageLensConfigurationsResponse> ListStorageLensConfigurationsAsync(ListStorageLensConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStorageLensGroups service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensGroups">REST API Reference for ListStorageLensGroups Operation</seealso>
        Task<ListStorageLensGroupsResponse> ListStorageLensGroupsAsync(ListStorageLensGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccessGrantsInstanceResourcePolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessGrantsInstanceResourcePolicy">REST API Reference for PutAccessGrantsInstanceResourcePolicy Operation</seealso>
        Task<PutAccessGrantsInstanceResourcePolicyResponse> PutAccessGrantsInstanceResourcePolicyAsync(PutAccessGrantsInstanceResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccessPointConfigurationForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointConfigurationForObjectLambda">REST API Reference for PutAccessPointConfigurationForObjectLambda Operation</seealso>
        Task<PutAccessPointConfigurationForObjectLambdaResponse> PutAccessPointConfigurationForObjectLambdaAsync(PutAccessPointConfigurationForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicy">REST API Reference for PutAccessPointPolicy Operation</seealso>
        Task<PutAccessPointPolicyResponse> PutAccessPointPolicyAsync(PutAccessPointPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicyForObjectLambda">REST API Reference for PutAccessPointPolicyForObjectLambda Operation</seealso>
        Task<PutAccessPointPolicyForObjectLambdaResponse> PutAccessPointPolicyForObjectLambdaAsync(PutAccessPointPolicyForObjectLambdaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccessPointScope service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointScope">REST API Reference for PutAccessPointScope Operation</seealso>
        Task<PutAccessPointScopeResponse> PutAccessPointScopeAsync(PutAccessPointScopeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketLifecycleConfiguration">REST API Reference for PutBucketLifecycleConfiguration Operation</seealso>
        Task<PutBucketLifecycleConfigurationResponse> PutBucketLifecycleConfigurationAsync(PutBucketLifecycleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketPolicy">REST API Reference for PutBucketPolicy Operation</seealso>
        Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketReplication service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketReplication">REST API Reference for PutBucketReplication Operation</seealso>
        Task<PutBucketReplicationResponse> PutBucketReplicationAsync(PutBucketReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketTagging">REST API Reference for PutBucketTagging Operation</seealso>
        Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketVersioning service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketVersioning">REST API Reference for PutBucketVersioning Operation</seealso>
        Task<PutBucketVersioningResponse> PutBucketVersioningAsync(PutBucketVersioningRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutJobTaggingResponse> PutJobTaggingAsync(PutJobTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMultiRegionAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutMultiRegionAccessPointPolicy">REST API Reference for PutMultiRegionAccessPointPolicy Operation</seealso>
        Task<PutMultiRegionAccessPointPolicyResponse> PutMultiRegionAccessPointPolicyAsync(PutMultiRegionAccessPointPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPublicAccessBlock service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutPublicAccessBlock">REST API Reference for PutPublicAccessBlock Operation</seealso>
        Task<PutPublicAccessBlockResponse> PutPublicAccessBlockAsync(PutPublicAccessBlockRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfiguration">REST API Reference for PutStorageLensConfiguration Operation</seealso>
        Task<PutStorageLensConfigurationResponse> PutStorageLensConfigurationAsync(PutStorageLensConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfigurationTagging">REST API Reference for PutStorageLensConfigurationTagging Operation</seealso>
        Task<PutStorageLensConfigurationTaggingResponse> PutStorageLensConfigurationTaggingAsync(PutStorageLensConfigurationTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitMultiRegionAccessPointRoutes service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/SubmitMultiRegionAccessPointRoutes">REST API Reference for SubmitMultiRegionAccessPointRoutes Operation</seealso>
        Task<SubmitMultiRegionAccessPointRoutesResponse> SubmitMultiRegionAccessPointRoutesAsync(SubmitMultiRegionAccessPointRoutesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessGrantsLocation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateAccessGrantsLocation">REST API Reference for UpdateAccessGrantsLocation Operation</seealso>
        Task<UpdateAccessGrantsLocationResponse> UpdateAccessGrantsLocationAsync(UpdateAccessGrantsLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateJobPriorityResponse> UpdateJobPriorityAsync(UpdateJobPriorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateJobStatusResponse> UpdateJobStatusAsync(UpdateJobStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStorageLensGroup service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateStorageLensGroup">REST API Reference for UpdateStorageLensGroup Operation</seealso>
        Task<UpdateStorageLensGroupResponse> UpdateStorageLensGroupAsync(UpdateStorageLensGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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