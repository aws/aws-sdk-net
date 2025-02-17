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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ControlTower.Model;

#pragma warning disable CS1570
namespace Amazon.ControlTower
{
    /// <summary>
    /// <para>Interface for accessing ControlTower</para>
    ///
    /// Amazon Web Services Control Tower offers application programming interface (API) operations
    /// that support programmatic interaction with these types of resources:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/controls.html">
    /// <i>Controls</i> </a> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_DisableControl.html">DisableControl</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_EnableControl.html">EnableControl</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_GetEnabledControl.html">GetEnabledControl</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_ListControlOperations.html">ListControlOperations</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_ListEnabledControls.html">ListEnabledControls</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_UpdateEnabledControl.html">UpdateEnabledControl</a>
    /// 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/lz-api-launch.html">
    /// <i>Landing zones</i> </a> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_CreateLandingZone.html">CreateLandingZone</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_DeleteLandingZone.html">DeleteLandingZone</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_GetLandingZone.html">GetLandingZone</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_GetLandingZoneOperation.html">GetLandingZoneOperation</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_ListLandingZones.html">ListLandingZones</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_ListLandingZoneOperations.html">ListLandingZoneOperations</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_ResetLandingZone.html">ResetLandingZone</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_UpdateLandingZone.html">UpdateLandingZone</a>
    /// 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/types-of-baselines.html">
    /// <i>Baselines</i> </a> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_DisableBaseline.html">DisableBaseline</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_EnableBaseline.html">EnableBaseline</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_GetBaseline.html">GetBaseline</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_GetBaselineOperation.html">GetBaselineOperation</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_GetEnabledBaseline.html">GetEnabledBaseline</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_ListBaselines.html">ListBaselines</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_ListEnabledBaselines.html">ListEnabledBaselines</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_ResetEnabledBaseline.html">ResetEnabledBaseline</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_UpdateEnabledBaseline.html">UpdateEnabledBaseline</a>
    /// 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/tagging.html">
    /// <i>Tagging</i> </a> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_TagResource.html">TagResource</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_UntagResource.html">UntagResource</a>
    /// 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// For more information about these types of resources, see the <a href="https://docs.aws.amazon.com/controltower/latest/userguide/what-is-control-tower.html">
    /// <i>Amazon Web Services Control Tower User Guide</i> </a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>About control APIs</b> 
    /// </para>
    ///  
    /// <para>
    /// These interfaces allow you to apply the Amazon Web Services library of pre-defined
    /// <i>controls</i> to your organizational units, programmatically. In Amazon Web Services
    /// Control Tower, the terms "control" and "guardrail" are synonyms.
    /// </para>
    ///  
    /// <para>
    /// To call these APIs, you'll need to know:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// the <c>controlIdentifier</c> for the control--or guardrail--you are targeting.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// the ARN associated with the target organizational unit (OU), which we call the <c>targetIdentifier</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// the ARN associated with a resource that you wish to tag or untag.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>To get the <c>controlIdentifier</c> for your Amazon Web Services Control Tower
    /// control:</b> 
    /// </para>
    ///  
    /// <para>
    /// The <c>controlIdentifier</c> is an ARN that is specified for each control. You can
    /// view the <c>controlIdentifier</c> in the console on the <b>Control details</b> page,
    /// as well as in the documentation.
    /// </para>
    ///  
    /// <para>
    ///  <b>About identifiers for Amazon Web Services Control Tower</b> 
    /// </para>
    ///  
    /// <para>
    /// The Amazon Web Services Control Tower <c>controlIdentifier</c> is unique in each Amazon
    /// Web Services Region for each control. You can find the <c>controlIdentifier</c> for
    /// each Region and control in the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-metadata-tables.html">Tables
    /// of control metadata</a> or the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-region-tables.html">Control
    /// availability by Region tables</a> in the <i>Amazon Web Services Control Tower Controls
    /// Reference Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A quick-reference list of control identifers for the Amazon Web Services Control Tower
    /// legacy <i>Strongly recommended</i> and <i>Elective</i> controls is given in <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-identifiers.html.html">Resource
    /// identifiers for APIs and controls</a> in the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-identifiers.html">
    /// <i>Amazon Web Services Control Tower Controls Reference Guide</i> </a>. Remember that
    /// <i>Mandatory</i> controls cannot be added or removed.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Some controls have two identifiers</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>ARN format for Amazon Web Services Control Tower:</b> <c>arn:aws:controltower:{REGION}::control/{CONTROL_TOWER_OPAQUE_ID}</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Example:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:aws:controltower:us-west-2::control/AWS-GR_AUTOSCALING_LAUNCH_CONFIG_PUBLIC_IP_DISABLED</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ARN format for Amazon Web Services Control Catalog:</b> <c>arn:{PARTITION}:controlcatalog:::control/{CONTROL_CATALOG_OPAQUE_ID}</c>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can find the <c>{CONTROL_CATALOG_OPAQUE_ID}</c> in the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/all-global-identifiers.html">
    /// <i>Amazon Web Services Control Tower Controls Reference Guide</i> </a>, or in the
    /// Amazon Web Services Control Tower console, on the <b>Control details</b> page.
    /// </para>
    ///  
    /// <para>
    /// The Amazon Web Services Control Tower APIs for enabled controls, such as <c>GetEnabledControl</c>
    /// and <c>ListEnabledControls</c> always return an ARN of the same type given when the
    /// control was enabled.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>To get the <c>targetIdentifier</c>:</b> 
    /// </para>
    ///  
    /// <para>
    /// The <c>targetIdentifier</c> is the ARN for an OU.
    /// </para>
    ///  
    /// <para>
    /// In the Amazon Web Services Organizations console, you can find the ARN for the OU
    /// on the <b>Organizational unit details</b> page associated with that OU.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>OU ARN format:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:${Partition}:organizations::${MasterAccountId}:ou/o-${OrganizationId}/ou-${OrganizationalUnitId}</c>
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b> About landing zone APIs</b> 
    /// </para>
    ///  
    /// <para>
    /// You can configure and launch an Amazon Web Services Control Tower landing zone with
    /// APIs. For an introduction and steps, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/getting-started-apis.html">Getting
    /// started with Amazon Web Services Control Tower using APIs</a>.
    /// </para>
    ///  
    /// <para>
    /// For an overview of landing zone API operations, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/2023-all.html#landing-zone-apis">
    /// Amazon Web Services Control Tower supports landing zone APIs</a>. The individual API
    /// operations for landing zones are detailed in this document, the <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_Operations.html">API
    /// reference manual</a>, in the "Actions" section.
    /// </para>
    ///  
    /// <para>
    ///  <b>About baseline APIs</b> 
    /// </para>
    ///  
    /// <para>
    /// You can apply the <c>AWSControlTowerBaseline</c> baseline to an organizational unit
    /// (OU) as a way to register the OU with Amazon Web Services Control Tower, programmatically.
    /// For a general overview of this capability, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/2024-all.html#baseline-apis">Amazon
    /// Web Services Control Tower supports APIs for OU registration and configuration with
    /// baselines</a>.
    /// </para>
    ///  
    /// <para>
    /// You can call the baseline API operations to view the baselines that Amazon Web Services
    /// Control Tower enables for your landing zone, on your behalf, when setting up the landing
    /// zone. These baselines are read-only baselines.
    /// </para>
    ///  
    /// <para>
    /// The individual API operations for baselines are detailed in this document, the <a
    /// href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_Operations.html">API
    /// reference manual</a>, in the "Actions" section. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">Baseline
    /// API input and output examples with CLI</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b> About Amazon Web Services Control Catalog identifiers</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>EnableControl</c> and <c>DisableControl</c> API operations can be called by
    /// specifying either the Amazon Web Services Control Tower identifer or the Amazon Web
    /// Services Control Catalog identifier. The API response returns the same type of identifier
    /// that you specified when calling the API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you use an Amazon Web Services Control Tower identifier to call the <c>EnableControl</c>
    /// API, and then call <c>EnableControl</c> again with an Amazon Web Services Control
    /// Catalog identifier, Amazon Web Services Control Tower returns an error message stating
    /// that the control is already enabled. Similar behavior applies to the <c>DisableControl</c>
    /// API operation. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Mandatory controls and the landing-zone-level Region deny control have Amazon Web
    /// Services Control Tower identifiers only.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Details and examples</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">Control
    /// API input and output examples with CLI</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">Baseline
    /// API input and output examples with CLI</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/enable-controls.html">Enable
    /// controls with CloudFormation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/lz-apis-cfn-setup.html">Launch
    /// a landing zone with CloudFormation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-metadata-tables.html">Control
    /// metadata tables (large page)</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-region-tables.html">Control
    /// availability by Region tables (large page)</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-identifiers.html">List
    /// of identifiers for legacy controls</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/controls.html">Controls
    /// reference guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/controls-reference.html">Controls
    /// library groupings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/creating-resources-with-cloudformation.html">Creating
    /// Amazon Web Services Control Tower resources with Amazon Web Services CloudFormation</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To view the open source resource repository on GitHub, see <a href="https://github.com/aws-cloudformation/aws-cloudformation-resource-providers-controltower">aws-cloudformation/aws-cloudformation-resource-providers-controltower</a>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Control Tower supports Amazon Web Services CloudTrail, a service
    /// that records Amazon Web Services API calls for your Amazon Web Services account and
    /// delivers log files to an Amazon S3 bucket. By using information collected by CloudTrail,
    /// you can determine which requests the Amazon Web Services Control Tower service received,
    /// who made the request and when, and so on. For more about Amazon Web Services Control
    /// Tower and its support for CloudTrail, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/logging-using-cloudtrail.html">Logging
    /// Amazon Web Services Control Tower Actions with Amazon Web Services CloudTrail</a>
    /// in the Amazon Web Services Control Tower User Guide. To learn more about CloudTrail,
    /// including how to turn it on and find your log files, see the Amazon Web Services CloudTrail
    /// User Guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonControlTower : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IControlTowerPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateLandingZone


        /// <summary>
        /// Creates a new landing zone. This API call starts an asynchronous operation that creates
        /// and configures a landing zone, based on the parameters specified in the manifest JSON
        /// file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLandingZone service method.</param>
        /// 
        /// <returns>The response from the CreateLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/CreateLandingZone">REST API Reference for CreateLandingZone Operation</seealso>
        CreateLandingZoneResponse CreateLandingZone(CreateLandingZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLandingZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLandingZone operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLandingZone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/CreateLandingZone">REST API Reference for CreateLandingZone Operation</seealso>
        IAsyncResult BeginCreateLandingZone(CreateLandingZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLandingZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLandingZone.</param>
        /// 
        /// <returns>Returns a  CreateLandingZoneResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/CreateLandingZone">REST API Reference for CreateLandingZone Operation</seealso>
        CreateLandingZoneResponse EndCreateLandingZone(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLandingZone


        /// <summary>
        /// Decommissions a landing zone. This API call starts an asynchronous operation that
        /// deletes Amazon Web Services Control Tower resources deployed in accounts managed by
        /// Amazon Web Services Control Tower.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLandingZone service method.</param>
        /// 
        /// <returns>The response from the DeleteLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DeleteLandingZone">REST API Reference for DeleteLandingZone Operation</seealso>
        DeleteLandingZoneResponse DeleteLandingZone(DeleteLandingZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLandingZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLandingZone operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLandingZone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DeleteLandingZone">REST API Reference for DeleteLandingZone Operation</seealso>
        IAsyncResult BeginDeleteLandingZone(DeleteLandingZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLandingZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLandingZone.</param>
        /// 
        /// <returns>Returns a  DeleteLandingZoneResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DeleteLandingZone">REST API Reference for DeleteLandingZone Operation</seealso>
        DeleteLandingZoneResponse EndDeleteLandingZone(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableBaseline


        /// <summary>
        /// Disable an <c>EnabledBaseline</c> resource on the specified Target. This API starts
        /// an asynchronous operation to remove all resources deployed as part of the baseline
        /// enablement. The resource will vary depending on the enabled baseline. For usage examples,
        /// see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableBaseline service method.</param>
        /// 
        /// <returns>The response from the DisableBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableBaseline">REST API Reference for DisableBaseline Operation</seealso>
        DisableBaselineResponse DisableBaseline(DisableBaselineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableBaseline operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableBaseline">REST API Reference for DisableBaseline Operation</seealso>
        IAsyncResult BeginDisableBaseline(DisableBaselineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableBaseline.</param>
        /// 
        /// <returns>Returns a  DisableBaselineResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableBaseline">REST API Reference for DisableBaseline Operation</seealso>
        DisableBaselineResponse EndDisableBaseline(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableControl


        /// <summary>
        /// This API call turns off a control. It starts an asynchronous operation that deletes
        /// Amazon Web Services resources on the specified organizational unit and the accounts
        /// it contains. The resources will vary according to the control that you specify. For
        /// usage examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
        /// <i>Controls Reference Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableControl service method.</param>
        /// 
        /// <returns>The response from the DisableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableControl">REST API Reference for DisableControl Operation</seealso>
        DisableControlResponse DisableControl(DisableControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableControl operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableControl">REST API Reference for DisableControl Operation</seealso>
        IAsyncResult BeginDisableControl(DisableControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableControl.</param>
        /// 
        /// <returns>Returns a  DisableControlResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableControl">REST API Reference for DisableControl Operation</seealso>
        DisableControlResponse EndDisableControl(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableBaseline


        /// <summary>
        /// Enable (apply) a <c>Baseline</c> to a Target. This API starts an asynchronous operation
        /// to deploy resources specified by the <c>Baseline</c> to the specified Target. For
        /// usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableBaseline service method.</param>
        /// 
        /// <returns>The response from the EnableBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableBaseline">REST API Reference for EnableBaseline Operation</seealso>
        EnableBaselineResponse EnableBaseline(EnableBaselineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableBaseline operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableBaseline">REST API Reference for EnableBaseline Operation</seealso>
        IAsyncResult BeginEnableBaseline(EnableBaselineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableBaseline.</param>
        /// 
        /// <returns>Returns a  EnableBaselineResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableBaseline">REST API Reference for EnableBaseline Operation</seealso>
        EnableBaselineResponse EndEnableBaseline(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableControl


        /// <summary>
        /// This API call activates a control. It starts an asynchronous operation that creates
        /// Amazon Web Services resources on the specified organizational unit and the accounts
        /// it contains. The resources created will vary according to the control that you specify.
        /// For usage examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
        /// <i>Controls Reference Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableControl service method.</param>
        /// 
        /// <returns>The response from the EnableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableControl">REST API Reference for EnableControl Operation</seealso>
        EnableControlResponse EnableControl(EnableControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableControl operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableControl">REST API Reference for EnableControl Operation</seealso>
        IAsyncResult BeginEnableControl(EnableControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableControl.</param>
        /// 
        /// <returns>Returns a  EnableControlResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableControl">REST API Reference for EnableControl Operation</seealso>
        EnableControlResponse EndEnableControl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBaseline


        /// <summary>
        /// Retrieve details about an existing <c>Baseline</c> resource by specifying its identifier.
        /// For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBaseline service method.</param>
        /// 
        /// <returns>The response from the GetBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetBaseline">REST API Reference for GetBaseline Operation</seealso>
        GetBaselineResponse GetBaseline(GetBaselineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBaseline operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetBaseline">REST API Reference for GetBaseline Operation</seealso>
        IAsyncResult BeginGetBaseline(GetBaselineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBaseline.</param>
        /// 
        /// <returns>Returns a  GetBaselineResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetBaseline">REST API Reference for GetBaseline Operation</seealso>
        GetBaselineResponse EndGetBaseline(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBaselineOperation


        /// <summary>
        /// Returns the details of an asynchronous baseline operation, as initiated by any of
        /// these APIs: <c>EnableBaseline</c>, <c>DisableBaseline</c>, <c>UpdateEnabledBaseline</c>,
        /// <c>ResetEnabledBaseline</c>. A status message is displayed in case of operation failure.
        /// For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBaselineOperation service method.</param>
        /// 
        /// <returns>The response from the GetBaselineOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetBaselineOperation">REST API Reference for GetBaselineOperation Operation</seealso>
        GetBaselineOperationResponse GetBaselineOperation(GetBaselineOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBaselineOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBaselineOperation operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBaselineOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetBaselineOperation">REST API Reference for GetBaselineOperation Operation</seealso>
        IAsyncResult BeginGetBaselineOperation(GetBaselineOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBaselineOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBaselineOperation.</param>
        /// 
        /// <returns>Returns a  GetBaselineOperationResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetBaselineOperation">REST API Reference for GetBaselineOperation Operation</seealso>
        GetBaselineOperationResponse EndGetBaselineOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetControlOperation


        /// <summary>
        /// Returns the status of a particular <c>EnableControl</c> or <c>DisableControl</c> operation.
        /// Displays a message in case of error. Details for an operation are available for 90
        /// days. For usage examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
        /// <i>Controls Reference Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControlOperation service method.</param>
        /// 
        /// <returns>The response from the GetControlOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetControlOperation">REST API Reference for GetControlOperation Operation</seealso>
        GetControlOperationResponse GetControlOperation(GetControlOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetControlOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetControlOperation operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetControlOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetControlOperation">REST API Reference for GetControlOperation Operation</seealso>
        IAsyncResult BeginGetControlOperation(GetControlOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetControlOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetControlOperation.</param>
        /// 
        /// <returns>Returns a  GetControlOperationResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetControlOperation">REST API Reference for GetControlOperation Operation</seealso>
        GetControlOperationResponse EndGetControlOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEnabledBaseline


        /// <summary>
        /// Retrieve details of an <c>EnabledBaseline</c> resource by specifying its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledBaseline service method.</param>
        /// 
        /// <returns>The response from the GetEnabledBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledBaseline">REST API Reference for GetEnabledBaseline Operation</seealso>
        GetEnabledBaselineResponse GetEnabledBaseline(GetEnabledBaselineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnabledBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledBaseline operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnabledBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledBaseline">REST API Reference for GetEnabledBaseline Operation</seealso>
        IAsyncResult BeginGetEnabledBaseline(GetEnabledBaselineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnabledBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnabledBaseline.</param>
        /// 
        /// <returns>Returns a  GetEnabledBaselineResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledBaseline">REST API Reference for GetEnabledBaseline Operation</seealso>
        GetEnabledBaselineResponse EndGetEnabledBaseline(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEnabledControl


        /// <summary>
        /// Retrieves details about an enabled control. For usage examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
        /// <i>Controls Reference Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledControl service method.</param>
        /// 
        /// <returns>The response from the GetEnabledControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledControl">REST API Reference for GetEnabledControl Operation</seealso>
        GetEnabledControlResponse GetEnabledControl(GetEnabledControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnabledControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledControl operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnabledControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledControl">REST API Reference for GetEnabledControl Operation</seealso>
        IAsyncResult BeginGetEnabledControl(GetEnabledControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnabledControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnabledControl.</param>
        /// 
        /// <returns>Returns a  GetEnabledControlResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledControl">REST API Reference for GetEnabledControl Operation</seealso>
        GetEnabledControlResponse EndGetEnabledControl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLandingZone


        /// <summary>
        /// Returns details about the landing zone. Displays a message in case of error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLandingZone service method.</param>
        /// 
        /// <returns>The response from the GetLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZone">REST API Reference for GetLandingZone Operation</seealso>
        GetLandingZoneResponse GetLandingZone(GetLandingZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLandingZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLandingZone operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLandingZone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZone">REST API Reference for GetLandingZone Operation</seealso>
        IAsyncResult BeginGetLandingZone(GetLandingZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLandingZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLandingZone.</param>
        /// 
        /// <returns>Returns a  GetLandingZoneResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZone">REST API Reference for GetLandingZone Operation</seealso>
        GetLandingZoneResponse EndGetLandingZone(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLandingZoneOperation


        /// <summary>
        /// Returns the status of the specified landing zone operation. Details for an operation
        /// are available for 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLandingZoneOperation service method.</param>
        /// 
        /// <returns>The response from the GetLandingZoneOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZoneOperation">REST API Reference for GetLandingZoneOperation Operation</seealso>
        GetLandingZoneOperationResponse GetLandingZoneOperation(GetLandingZoneOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLandingZoneOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLandingZoneOperation operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLandingZoneOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZoneOperation">REST API Reference for GetLandingZoneOperation Operation</seealso>
        IAsyncResult BeginGetLandingZoneOperation(GetLandingZoneOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLandingZoneOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLandingZoneOperation.</param>
        /// 
        /// <returns>Returns a  GetLandingZoneOperationResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZoneOperation">REST API Reference for GetLandingZoneOperation Operation</seealso>
        GetLandingZoneOperationResponse EndGetLandingZoneOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBaselines


        /// <summary>
        /// Returns a summary list of all available baselines. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBaselines service method.</param>
        /// 
        /// <returns>The response from the ListBaselines service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListBaselines">REST API Reference for ListBaselines Operation</seealso>
        ListBaselinesResponse ListBaselines(ListBaselinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBaselines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBaselines operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBaselines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListBaselines">REST API Reference for ListBaselines Operation</seealso>
        IAsyncResult BeginListBaselines(ListBaselinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBaselines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBaselines.</param>
        /// 
        /// <returns>Returns a  ListBaselinesResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListBaselines">REST API Reference for ListBaselines Operation</seealso>
        ListBaselinesResponse EndListBaselines(IAsyncResult asyncResult);

        #endregion
        
        #region  ListControlOperations


        /// <summary>
        /// Provides a list of operations in progress or queued. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html#list-control-operations-api-examples">ListControlOperation
        /// examples</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlOperations service method.</param>
        /// 
        /// <returns>The response from the ListControlOperations service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListControlOperations">REST API Reference for ListControlOperations Operation</seealso>
        ListControlOperationsResponse ListControlOperations(ListControlOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListControlOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControlOperations operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControlOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListControlOperations">REST API Reference for ListControlOperations Operation</seealso>
        IAsyncResult BeginListControlOperations(ListControlOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListControlOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControlOperations.</param>
        /// 
        /// <returns>Returns a  ListControlOperationsResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListControlOperations">REST API Reference for ListControlOperations Operation</seealso>
        ListControlOperationsResponse EndListControlOperations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEnabledBaselines


        /// <summary>
        /// Returns a list of summaries describing <c>EnabledBaseline</c> resources. You can filter
        /// the list by the corresponding <c>Baseline</c> or <c>Target</c> of the <c>EnabledBaseline</c>
        /// resources. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledBaselines service method.</param>
        /// 
        /// <returns>The response from the ListEnabledBaselines service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledBaselines">REST API Reference for ListEnabledBaselines Operation</seealso>
        ListEnabledBaselinesResponse ListEnabledBaselines(ListEnabledBaselinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnabledBaselines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledBaselines operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnabledBaselines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledBaselines">REST API Reference for ListEnabledBaselines Operation</seealso>
        IAsyncResult BeginListEnabledBaselines(ListEnabledBaselinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnabledBaselines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnabledBaselines.</param>
        /// 
        /// <returns>Returns a  ListEnabledBaselinesResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledBaselines">REST API Reference for ListEnabledBaselines Operation</seealso>
        ListEnabledBaselinesResponse EndListEnabledBaselines(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEnabledControls


        /// <summary>
        /// Lists the controls enabled by Amazon Web Services Control Tower on the specified organizational
        /// unit and the accounts it contains. For usage examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
        /// <i>Controls Reference Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledControls service method.</param>
        /// 
        /// <returns>The response from the ListEnabledControls service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledControls">REST API Reference for ListEnabledControls Operation</seealso>
        ListEnabledControlsResponse ListEnabledControls(ListEnabledControlsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnabledControls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledControls operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnabledControls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledControls">REST API Reference for ListEnabledControls Operation</seealso>
        IAsyncResult BeginListEnabledControls(ListEnabledControlsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnabledControls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnabledControls.</param>
        /// 
        /// <returns>Returns a  ListEnabledControlsResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledControls">REST API Reference for ListEnabledControls Operation</seealso>
        ListEnabledControlsResponse EndListEnabledControls(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLandingZoneOperations


        /// <summary>
        /// Lists all landing zone operations from the past 90 days. Results are sorted by time,
        /// with the most recent operation first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLandingZoneOperations service method.</param>
        /// 
        /// <returns>The response from the ListLandingZoneOperations service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListLandingZoneOperations">REST API Reference for ListLandingZoneOperations Operation</seealso>
        ListLandingZoneOperationsResponse ListLandingZoneOperations(ListLandingZoneOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLandingZoneOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLandingZoneOperations operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLandingZoneOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListLandingZoneOperations">REST API Reference for ListLandingZoneOperations Operation</seealso>
        IAsyncResult BeginListLandingZoneOperations(ListLandingZoneOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLandingZoneOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLandingZoneOperations.</param>
        /// 
        /// <returns>Returns a  ListLandingZoneOperationsResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListLandingZoneOperations">REST API Reference for ListLandingZoneOperations Operation</seealso>
        ListLandingZoneOperationsResponse EndListLandingZoneOperations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLandingZones


        /// <summary>
        /// Returns the landing zone ARN for the landing zone deployed in your managed account.
        /// This API also creates an ARN for existing accounts that do not yet have a landing
        /// zone ARN. 
        /// 
        ///  
        /// <para>
        /// Returns one landing zone ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLandingZones service method.</param>
        /// 
        /// <returns>The response from the ListLandingZones service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListLandingZones">REST API Reference for ListLandingZones Operation</seealso>
        ListLandingZonesResponse ListLandingZones(ListLandingZonesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLandingZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLandingZones operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLandingZones
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListLandingZones">REST API Reference for ListLandingZones Operation</seealso>
        IAsyncResult BeginListLandingZones(ListLandingZonesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLandingZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLandingZones.</param>
        /// 
        /// <returns>Returns a  ListLandingZonesResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListLandingZones">REST API Reference for ListLandingZones Operation</seealso>
        ListLandingZonesResponse EndListLandingZones(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags associated with the resource. For usage examples, see the <a
        /// href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
        /// <i>Controls Reference Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetEnabledBaseline


        /// <summary>
        /// Re-enables an <c>EnabledBaseline</c> resource. For example, this API can re-apply
        /// the existing <c>Baseline</c> after a new member account is moved to the target OU.
        /// For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEnabledBaseline service method.</param>
        /// 
        /// <returns>The response from the ResetEnabledBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetEnabledBaseline">REST API Reference for ResetEnabledBaseline Operation</seealso>
        ResetEnabledBaselineResponse ResetEnabledBaseline(ResetEnabledBaselineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetEnabledBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetEnabledBaseline operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetEnabledBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetEnabledBaseline">REST API Reference for ResetEnabledBaseline Operation</seealso>
        IAsyncResult BeginResetEnabledBaseline(ResetEnabledBaselineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetEnabledBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetEnabledBaseline.</param>
        /// 
        /// <returns>Returns a  ResetEnabledBaselineResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetEnabledBaseline">REST API Reference for ResetEnabledBaseline Operation</seealso>
        ResetEnabledBaselineResponse EndResetEnabledBaseline(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetEnabledControl


        /// <summary>
        /// Resets an enabled control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEnabledControl service method.</param>
        /// 
        /// <returns>The response from the ResetEnabledControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetEnabledControl">REST API Reference for ResetEnabledControl Operation</seealso>
        ResetEnabledControlResponse ResetEnabledControl(ResetEnabledControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetEnabledControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetEnabledControl operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetEnabledControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetEnabledControl">REST API Reference for ResetEnabledControl Operation</seealso>
        IAsyncResult BeginResetEnabledControl(ResetEnabledControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetEnabledControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetEnabledControl.</param>
        /// 
        /// <returns>Returns a  ResetEnabledControlResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetEnabledControl">REST API Reference for ResetEnabledControl Operation</seealso>
        ResetEnabledControlResponse EndResetEnabledControl(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetLandingZone


        /// <summary>
        /// This API call resets a landing zone. It starts an asynchronous operation that resets
        /// the landing zone to the parameters specified in the original configuration, which
        /// you specified in the manifest file. Nothing in the manifest file's original landing
        /// zone configuration is changed during the reset process, by default. This API is not
        /// the same as a rollback of a landing zone version, which is not a supported operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetLandingZone service method.</param>
        /// 
        /// <returns>The response from the ResetLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetLandingZone">REST API Reference for ResetLandingZone Operation</seealso>
        ResetLandingZoneResponse ResetLandingZone(ResetLandingZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetLandingZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetLandingZone operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetLandingZone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetLandingZone">REST API Reference for ResetLandingZone Operation</seealso>
        IAsyncResult BeginResetLandingZone(ResetLandingZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetLandingZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetLandingZone.</param>
        /// 
        /// <returns>Returns a  ResetLandingZoneResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetLandingZone">REST API Reference for ResetLandingZone Operation</seealso>
        ResetLandingZoneResponse EndResetLandingZone(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies tags to a resource. For usage examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
        /// <i>Controls Reference Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource. For usage examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
        /// <i>Controls Reference Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEnabledBaseline


        /// <summary>
        /// Updates an <c>EnabledBaseline</c> resource's applied parameters or version. For usage
        /// examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnabledBaseline service method.</param>
        /// 
        /// <returns>The response from the UpdateEnabledBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateEnabledBaseline">REST API Reference for UpdateEnabledBaseline Operation</seealso>
        UpdateEnabledBaselineResponse UpdateEnabledBaseline(UpdateEnabledBaselineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnabledBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnabledBaseline operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnabledBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateEnabledBaseline">REST API Reference for UpdateEnabledBaseline Operation</seealso>
        IAsyncResult BeginUpdateEnabledBaseline(UpdateEnabledBaselineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnabledBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnabledBaseline.</param>
        /// 
        /// <returns>Returns a  UpdateEnabledBaselineResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateEnabledBaseline">REST API Reference for UpdateEnabledBaseline Operation</seealso>
        UpdateEnabledBaselineResponse EndUpdateEnabledBaseline(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEnabledControl


        /// <summary>
        /// Updates the configuration of an already enabled control.
        /// 
        ///  
        /// <para>
        /// If the enabled control shows an <c>EnablementStatus</c> of SUCCEEDED, supply parameters
        /// that are different from the currently configured parameters. Otherwise, Amazon Web
        /// Services Control Tower will not accept the request.
        /// </para>
        ///  
        /// <para>
        /// If the enabled control shows an <c>EnablementStatus</c> of FAILED, Amazon Web Services
        /// Control Tower updates the control to match any valid parameters that you supply.
        /// </para>
        ///  
        /// <para>
        /// If the <c>DriftSummary</c> status for the control shows as <c>DRIFTED</c>, you cannot
        /// call this API. Instead, you can update the control by calling the <c>ResetEnabledControl</c>
        /// API. Alternatively, you can call <c>DisableControl</c> and then call <c>EnableControl</c>
        /// again. Also, you can run an extending governance operation to repair drift. For usage
        /// examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
        /// <i>Controls Reference Guide</i> </a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnabledControl service method.</param>
        /// 
        /// <returns>The response from the UpdateEnabledControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateEnabledControl">REST API Reference for UpdateEnabledControl Operation</seealso>
        UpdateEnabledControlResponse UpdateEnabledControl(UpdateEnabledControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnabledControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnabledControl operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnabledControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateEnabledControl">REST API Reference for UpdateEnabledControl Operation</seealso>
        IAsyncResult BeginUpdateEnabledControl(UpdateEnabledControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnabledControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnabledControl.</param>
        /// 
        /// <returns>Returns a  UpdateEnabledControlResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateEnabledControl">REST API Reference for UpdateEnabledControl Operation</seealso>
        UpdateEnabledControlResponse EndUpdateEnabledControl(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLandingZone


        /// <summary>
        /// This API call updates the landing zone. It starts an asynchronous operation that updates
        /// the landing zone based on the new landing zone version, or on the changed parameters
        /// specified in the updated manifest file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLandingZone service method.</param>
        /// 
        /// <returns>The response from the UpdateLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateLandingZone">REST API Reference for UpdateLandingZone Operation</seealso>
        UpdateLandingZoneResponse UpdateLandingZone(UpdateLandingZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLandingZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLandingZone operation on AmazonControlTowerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLandingZone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateLandingZone">REST API Reference for UpdateLandingZone Operation</seealso>
        IAsyncResult BeginUpdateLandingZone(UpdateLandingZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLandingZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLandingZone.</param>
        /// 
        /// <returns>Returns a  UpdateLandingZoneResult from ControlTower.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateLandingZone">REST API Reference for UpdateLandingZone Operation</seealso>
        UpdateLandingZoneResponse EndUpdateLandingZone(IAsyncResult asyncResult);

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