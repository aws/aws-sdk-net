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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */

using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
    /// <summary>
    /// Interface for accessing SecurityTokenService
    ///
    /// AWS Security Token Service 
    /// <para>
    /// The AWS Security Token Service (STS) is a web service that enables you to request
    /// temporary, limited-privilege credentials for AWS Identity and Access Management (IAM)
    /// users or for users that you authenticate (federated users). This guide provides descriptions
    /// of the STS API. For more detailed information about using this service, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a>. 
    /// </para>
    ///  
    /// <para>
    /// For information about setting up signatures and authorization through the API, go
    /// to <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
    /// about the Query API, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in <i>Using IAM</i>. For information about using security tokens
    /// with other AWS products, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-services-that-work-with-iam.html">AWS
    /// Services That Work with IAM</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// If you're new to AWS and need additional technical information about a specific AWS
    /// product, you can find the product's technical documentation at <a href="http://aws.amazon.com/documentation/">http://aws.amazon.com/documentation/</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// By default, AWS Security Token Service (STS) is available as a global service, and
    /// all AWS STS requests go to a single endpoint at <code>https://sts.amazonaws.com</code>.
    /// Global requests map to the US East (N. Virginia) region. AWS recommends using Regional
    /// AWS STS endpoints instead of the global endpoint to reduce latency, build in redundancy,
    /// and increase session token validity. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Managing
    /// AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Most AWS Regions are enabled for operations in all AWS services by default. Those
    /// Regions are automatically activated for use with AWS STS. Some Regions, such as Asia
    /// Pacific (Hong Kong), must be manually enabled. To learn more about enabling and disabling
    /// AWS Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
    /// AWS Regions</a> in the <i>AWS General Reference</i>. When you enable these AWS Regions,
    /// they are automatically activated for use with AWS STS. You cannot activate the STS
    /// endpoint for a Region that is disabled. Tokens that are valid in all AWS Regions are
    /// longer than tokens that are valid in Regions that are enabled by default. Changing
    /// this setting might affect existing systems where you temporarily store tokens. For
    /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html#sts-regions-manage-tokens">Managing
    /// Global Endpoint Session Tokens</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// After you activate a Region for use with AWS STS, you can direct AWS STS API calls
    /// to that Region. AWS STS recommends that you provide both the Region and endpoint when
    /// you make calls to a Regional endpoint. You can provide the Region alone for manually
    /// enabled Regions, such as Asia Pacific (Hong Kong). In this case, the calls are directed
    /// to the STS Regional endpoint. However, if you provide the Region alone for Regions
    /// enabled by default, the calls are directed to the global endpoint of <code>https://sts.amazonaws.com</code>.
    /// </para>
    ///  
    /// <para>
    /// To view the list of AWS STS endpoints and whether they are active by default, see
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html#id_credentials_temp_enable-regions_writing_code">Writing
    /// Code to Use AWS STS Regions</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API requests</b> 
    /// </para>
    ///  
    /// <para>
    /// STS supports AWS CloudTrail, which is a service that records AWS calls for your AWS
    /// account and delivers log files to an Amazon S3 bucket. By using information collected
    /// by CloudTrail, you can determine what requests were successfully made to STS, who
    /// made the request, when it was made, and so on.
    /// </para>
    ///  
    /// <para>
    /// If you activate AWS STS endpoints in Regions other than the default global endpoint,
    /// then you must also turn on CloudTrail logging in those Regions. This is necessary
    /// to record any AWS STS API calls that are made in those Regions. For more information,
    /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/aggregating_logs_regions_turn_on_ct.html">Turning
    /// On CloudTrail in Additional Regions</a> in the <i>AWS CloudTrail User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// AWS Security Token Service (STS) is a global service with a single endpoint at <code>https://sts.amazonaws.com</code>.
    /// Calls to this endpoint are logged as calls to a global service. However, because this
    /// endpoint is physically located in the US East (N. Virginia) Region, your logs list
    /// <code>us-east-1</code> as the event Region. CloudTrail does not write these logs to
    /// the US East (Ohio) Region unless you choose to include global service logs in that
    /// Region. CloudTrail writes calls to all Regional endpoints to their respective Regions.
    /// For example, calls to sts.us-east-2.amazonaws.com are published to the US East (Ohio)
    /// Region and calls to sts.eu-central-1.amazonaws.com are published to the EU (Frankfurt)
    /// Region.
    /// </para>
    ///  
    /// <para>
    /// To learn more about CloudTrail, including how to turn it on and find your log files,
    /// see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">AWS
    /// CloudTrail User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonSecurityTokenService : IAmazonService, IDisposable
    {

        
        #region  AssumeRole


        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRole">REST API Reference for AssumeRole Operation</seealso>
        void AssumeRoleAsync(AssumeRoleRequest request, AmazonServiceCallback<AssumeRoleRequest, AssumeRoleResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AssumeRoleWithSAML


        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithSAML operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithSAML">REST API Reference for AssumeRoleWithSAML Operation</seealso>
        void AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, AmazonServiceCallback<AssumeRoleWithSAMLRequest, AssumeRoleWithSAMLResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  AssumeRoleWithWebIdentity


        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithWebIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithWebIdentity">REST API Reference for AssumeRoleWithWebIdentity Operation</seealso>
        void AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, AmazonServiceCallback<AssumeRoleWithWebIdentityRequest, AssumeRoleWithWebIdentityResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DecodeAuthorizationMessage


        /// <summary>
        /// Initiates the asynchronous execution of the DecodeAuthorizationMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecodeAuthorizationMessage operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/DecodeAuthorizationMessage">REST API Reference for DecodeAuthorizationMessage Operation</seealso>
        void DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, AmazonServiceCallback<DecodeAuthorizationMessageRequest, DecodeAuthorizationMessageResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetCallerIdentity


        /// <summary>
        /// Initiates the asynchronous execution of the GetCallerIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCallerIdentity operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetCallerIdentity">REST API Reference for GetCallerIdentity Operation</seealso>
        void GetCallerIdentityAsync(GetCallerIdentityRequest request, AmazonServiceCallback<GetCallerIdentityRequest, GetCallerIdentityResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetFederationToken


        /// <summary>
        /// Initiates the asynchronous execution of the GetFederationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        void GetFederationTokenAsync(GetFederationTokenRequest request, AmazonServiceCallback<GetFederationTokenRequest, GetFederationTokenResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetSessionToken


        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        void GetSessionTokenAsync(GetSessionTokenRequest request, AmazonServiceCallback<GetSessionTokenRequest, GetSessionTokenResponse> callback, AsyncOptions options = null);


        #endregion
        
    }
}