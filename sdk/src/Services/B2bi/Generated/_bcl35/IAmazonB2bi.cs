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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.B2bi.Model;

#pragma warning disable CS1570
namespace Amazon.B2bi
{
    /// <summary>
    /// <para>Interface for accessing B2bi</para>
    ///
    /// This is the <i>Amazon Web Services B2B Data Interchange API Reference</i>. It provides
    /// descriptions, API request parameters, and the XML response for each of the B2BI API
    /// actions.
    /// 
    ///  
    /// <para>
    /// B2BI enables automated exchange of EDI (electronic data interchange) based business-critical
    /// transactions at cloud scale, with elasticity and pay-as-you-go pricing. Businesses
    /// use EDI documents to exchange transactional data with trading partners, such as suppliers
    /// and end customers, using standardized formats such as X12.
    /// </para>
    ///  <note> 
    /// <para>
    /// Rather than actually running a command, you can use the <c>--generate-cli-skeleton</c>
    /// parameter with any API call to generate and display a parameter template. You can
    /// then use the generated template to customize and use as input on a later command.
    /// For details, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-skeleton.html#cli-usage-skeleton-generate">Generate
    /// and use a parameter skeleton file</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonB2bi : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IB2biPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateCapability


        /// <summary>
        /// Instantiates a capability based on the specified parameters. A trading capability
        /// contains the information required to transform incoming EDI documents into JSON or
        /// XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapability service method.</param>
        /// 
        /// <returns>The response from the CreateCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        CreateCapabilityResponse CreateCapability(CreateCapabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCapability operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        IAsyncResult BeginCreateCapability(CreateCapabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCapability.</param>
        /// 
        /// <returns>Returns a  CreateCapabilityResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateCapability">REST API Reference for CreateCapability Operation</seealso>
        CreateCapabilityResponse EndCreateCapability(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePartnership


        /// <summary>
        /// Creates a partnership between a customer and a trading partner, based on the supplied
        /// parameters. A partnership represents the connection between you and your trading partner.
        /// It ties together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnership service method.</param>
        /// 
        /// <returns>The response from the CreatePartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreatePartnership">REST API Reference for CreatePartnership Operation</seealso>
        CreatePartnershipResponse CreatePartnership(CreatePartnershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartnership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnership operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePartnership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreatePartnership">REST API Reference for CreatePartnership Operation</seealso>
        IAsyncResult BeginCreatePartnership(CreatePartnershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePartnership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePartnership.</param>
        /// 
        /// <returns>Returns a  CreatePartnershipResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreatePartnership">REST API Reference for CreatePartnership Operation</seealso>
        CreatePartnershipResponse EndCreatePartnership(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProfile


        /// <summary>
        /// Creates a customer profile. You can have up to five customer profiles, each representing
        /// a distinct private network. A profile is the mechanism used to create the concept
        /// of a private network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        CreateProfileResponse CreateProfile(CreateProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        IAsyncResult BeginCreateProfile(CreateProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfile.</param>
        /// 
        /// <returns>Returns a  CreateProfileResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        CreateProfileResponse EndCreateProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStarterMappingTemplate


        /// <summary>
        /// Amazon Web Services B2B Data Interchange uses a mapping template in JSONata or XSLT
        /// format to transform a customer input file into a JSON or XML file that can be converted
        /// to EDI.
        /// 
        ///  
        /// <para>
        /// If you provide a sample EDI file with the same structure as the EDI files that you
        /// wish to generate, then the service can generate a mapping template. The starter template
        /// contains placeholder values which you can replace with JSONata or XSLT expressions
        /// to take data from your input file and insert it into the JSON or XML file that is
        /// used to generate the EDI.
        /// </para>
        ///  
        /// <para>
        /// If you do not provide a sample EDI file, then the service can generate a mapping template
        /// based on the EDI settings in the <c>templateDetails</c> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  Currently, we only support generating a template that can generate the input to produce
        /// an Outbound X12 EDI file.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStarterMappingTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateStarterMappingTemplate service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateStarterMappingTemplate">REST API Reference for CreateStarterMappingTemplate Operation</seealso>
        CreateStarterMappingTemplateResponse CreateStarterMappingTemplate(CreateStarterMappingTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStarterMappingTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStarterMappingTemplate operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStarterMappingTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateStarterMappingTemplate">REST API Reference for CreateStarterMappingTemplate Operation</seealso>
        IAsyncResult BeginCreateStarterMappingTemplate(CreateStarterMappingTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStarterMappingTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStarterMappingTemplate.</param>
        /// 
        /// <returns>Returns a  CreateStarterMappingTemplateResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateStarterMappingTemplate">REST API Reference for CreateStarterMappingTemplate Operation</seealso>
        CreateStarterMappingTemplateResponse EndCreateStarterMappingTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTransformer


        /// <summary>
        /// Creates a transformer. Amazon Web Services B2B Data Interchange currently supports
        /// two scenarios:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i>Inbound EDI</i>: the Amazon Web Services customer receives an EDI file from their
        /// trading partner. Amazon Web Services B2B Data Interchange converts this EDI file into
        /// a JSON or XML file with a service-defined structure. A mapping template provided by
        /// the customer, in JSONata or XSLT format, is optionally applied to this file to produce
        /// a JSON or XML file with the structure the customer requires.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Outbound EDI</i>: the Amazon Web Services customer has a JSON or XML file containing
        /// data that they wish to use in an EDI file. A mapping template, provided by the customer
        /// (in either JSONata or XSLT format) is applied to this file to generate a JSON or XML
        /// file in the service-defined structure. This file is then converted to an EDI file.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The following fields are provided for backwards compatibility only: <c>fileFormat</c>,
        /// <c>mappingTemplate</c>, <c>ediType</c>, and <c>sampleDocument</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <c>mapping</c> data type in place of <c>mappingTemplate</c> and <c>fileFormat</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>sampleDocuments</c> data type in place of <c>sampleDocument</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use either the <c>inputConversion</c> or <c>outputConversion</c> in place of <c>ediType</c>
        /// 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformer service method.</param>
        /// 
        /// <returns>The response from the CreateTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateTransformer">REST API Reference for CreateTransformer Operation</seealso>
        CreateTransformerResponse CreateTransformer(CreateTransformerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransformer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformer operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransformer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateTransformer">REST API Reference for CreateTransformer Operation</seealso>
        IAsyncResult BeginCreateTransformer(CreateTransformerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransformer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransformer.</param>
        /// 
        /// <returns>Returns a  CreateTransformerResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/CreateTransformer">REST API Reference for CreateTransformer Operation</seealso>
        CreateTransformerResponse EndCreateTransformer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCapability


        /// <summary>
        /// Deletes the specified capability. A trading capability contains the information required
        /// to transform incoming EDI documents into JSON or XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapability service method.</param>
        /// 
        /// <returns>The response from the DeleteCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        DeleteCapabilityResponse DeleteCapability(DeleteCapabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCapability operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        IAsyncResult BeginDeleteCapability(DeleteCapabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCapability.</param>
        /// 
        /// <returns>Returns a  DeleteCapabilityResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteCapability">REST API Reference for DeleteCapability Operation</seealso>
        DeleteCapabilityResponse EndDeleteCapability(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePartnership


        /// <summary>
        /// Deletes the specified partnership. A partnership represents the connection between
        /// you and your trading partner. It ties together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnership service method.</param>
        /// 
        /// <returns>The response from the DeletePartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeletePartnership">REST API Reference for DeletePartnership Operation</seealso>
        DeletePartnershipResponse DeletePartnership(DeletePartnershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartnership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnership operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePartnership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeletePartnership">REST API Reference for DeletePartnership Operation</seealso>
        IAsyncResult BeginDeletePartnership(DeletePartnershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePartnership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePartnership.</param>
        /// 
        /// <returns>Returns a  DeletePartnershipResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeletePartnership">REST API Reference for DeletePartnership Operation</seealso>
        DeletePartnershipResponse EndDeletePartnership(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProfile


        /// <summary>
        /// Deletes the specified profile. A profile is the mechanism used to create the concept
        /// of a private network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        DeleteProfileResponse DeleteProfile(DeleteProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        IAsyncResult BeginDeleteProfile(DeleteProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProfileResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        DeleteProfileResponse EndDeleteProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTransformer


        /// <summary>
        /// Deletes the specified transformer. A transformer can take an EDI file as input and
        /// transform it into a JSON-or XML-formatted document. Alternatively, a transformer can
        /// take a JSON-or XML-formatted document as input and transform it into an EDI file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransformer service method.</param>
        /// 
        /// <returns>The response from the DeleteTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        DeleteTransformerResponse DeleteTransformer(DeleteTransformerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTransformer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransformer operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTransformer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        IAsyncResult BeginDeleteTransformer(DeleteTransformerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTransformer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTransformer.</param>
        /// 
        /// <returns>Returns a  DeleteTransformerResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        DeleteTransformerResponse EndDeleteTransformer(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateMapping


        /// <summary>
        /// Takes sample input and output documents and uses Amazon Bedrock to generate a mapping
        /// automatically. Depending on the accuracy and other factors, you can then edit the
        /// mapping for your needs.
        /// 
        ///  <note> 
        /// <para>
        /// Before you can use the AI-assisted feature for Amazon Web Services B2B Data Interchange
        /// you must enable models in Amazon Bedrock. For details, see <a href="https://docs.aws.amazon.com/b2bi/latest/userguide/ai-assisted-mapping.html#ai-assist-prereq">AI-assisted
        /// template mapping prerequisites</a> in the <i>Amazon Web Services B2B Data Interchange
        /// User guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMapping service method.</param>
        /// 
        /// <returns>The response from the GenerateMapping service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GenerateMapping">REST API Reference for GenerateMapping Operation</seealso>
        GenerateMappingResponse GenerateMapping(GenerateMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateMapping operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GenerateMapping">REST API Reference for GenerateMapping Operation</seealso>
        IAsyncResult BeginGenerateMapping(GenerateMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateMapping.</param>
        /// 
        /// <returns>Returns a  GenerateMappingResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GenerateMapping">REST API Reference for GenerateMapping Operation</seealso>
        GenerateMappingResponse EndGenerateMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCapability


        /// <summary>
        /// Retrieves the details for the specified capability. A trading capability contains
        /// the information required to transform incoming EDI documents into JSON or XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCapability service method.</param>
        /// 
        /// <returns>The response from the GetCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetCapability">REST API Reference for GetCapability Operation</seealso>
        GetCapabilityResponse GetCapability(GetCapabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCapability operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetCapability">REST API Reference for GetCapability Operation</seealso>
        IAsyncResult BeginGetCapability(GetCapabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCapability.</param>
        /// 
        /// <returns>Returns a  GetCapabilityResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetCapability">REST API Reference for GetCapability Operation</seealso>
        GetCapabilityResponse EndGetCapability(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPartnership


        /// <summary>
        /// Retrieves the details for a partnership, based on the partner and profile IDs specified.
        /// A partnership represents the connection between you and your trading partner. It ties
        /// together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartnership service method.</param>
        /// 
        /// <returns>The response from the GetPartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetPartnership">REST API Reference for GetPartnership Operation</seealso>
        GetPartnershipResponse GetPartnership(GetPartnershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartnership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartnership operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartnership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetPartnership">REST API Reference for GetPartnership Operation</seealso>
        IAsyncResult BeginGetPartnership(GetPartnershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartnership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartnership.</param>
        /// 
        /// <returns>Returns a  GetPartnershipResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetPartnership">REST API Reference for GetPartnership Operation</seealso>
        GetPartnershipResponse EndGetPartnership(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProfile


        /// <summary>
        /// Retrieves the details for the profile specified by the profile ID. A profile is the
        /// mechanism used to create the concept of a private network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetProfile">REST API Reference for GetProfile Operation</seealso>
        GetProfileResponse GetProfile(GetProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfile operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetProfile">REST API Reference for GetProfile Operation</seealso>
        IAsyncResult BeginGetProfile(GetProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfile.</param>
        /// 
        /// <returns>Returns a  GetProfileResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetProfile">REST API Reference for GetProfile Operation</seealso>
        GetProfileResponse EndGetProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTransformer


        /// <summary>
        /// Retrieves the details for the transformer specified by the transformer ID. A transformer
        /// can take an EDI file as input and transform it into a JSON-or XML-formatted document.
        /// Alternatively, a transformer can take a JSON-or XML-formatted document as input and
        /// transform it into an EDI file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransformer service method.</param>
        /// 
        /// <returns>The response from the GetTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        GetTransformerResponse GetTransformer(GetTransformerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransformer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransformer operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransformer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        IAsyncResult BeginGetTransformer(GetTransformerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransformer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransformer.</param>
        /// 
        /// <returns>Returns a  GetTransformerResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        GetTransformerResponse EndGetTransformer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTransformerJob


        /// <summary>
        /// Returns the details of the transformer run, based on the Transformer job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransformerJob service method.</param>
        /// 
        /// <returns>The response from the GetTransformerJob service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformerJob">REST API Reference for GetTransformerJob Operation</seealso>
        GetTransformerJobResponse GetTransformerJob(GetTransformerJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransformerJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransformerJob operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransformerJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformerJob">REST API Reference for GetTransformerJob Operation</seealso>
        IAsyncResult BeginGetTransformerJob(GetTransformerJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransformerJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransformerJob.</param>
        /// 
        /// <returns>Returns a  GetTransformerJobResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/GetTransformerJob">REST API Reference for GetTransformerJob Operation</seealso>
        GetTransformerJobResponse EndGetTransformerJob(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCapabilities


        /// <summary>
        /// Lists the capabilities associated with your Amazon Web Services account for your current
        /// or specified region. A trading capability contains the information required to transform
        /// incoming EDI documents into JSON or XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCapabilities service method.</param>
        /// 
        /// <returns>The response from the ListCapabilities service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        ListCapabilitiesResponse ListCapabilities(ListCapabilitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCapabilities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCapabilities operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCapabilities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        IAsyncResult BeginListCapabilities(ListCapabilitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCapabilities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCapabilities.</param>
        /// 
        /// <returns>Returns a  ListCapabilitiesResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListCapabilities">REST API Reference for ListCapabilities Operation</seealso>
        ListCapabilitiesResponse EndListCapabilities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPartnerships


        /// <summary>
        /// Lists the partnerships associated with your Amazon Web Services account for your current
        /// or specified region. A partnership represents the connection between you and your
        /// trading partner. It ties together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerships service method.</param>
        /// 
        /// <returns>The response from the ListPartnerships service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListPartnerships">REST API Reference for ListPartnerships Operation</seealso>
        ListPartnershipsResponse ListPartnerships(ListPartnershipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPartnerships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerships operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPartnerships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListPartnerships">REST API Reference for ListPartnerships Operation</seealso>
        IAsyncResult BeginListPartnerships(ListPartnershipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartnerships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartnerships.</param>
        /// 
        /// <returns>Returns a  ListPartnershipsResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListPartnerships">REST API Reference for ListPartnerships Operation</seealso>
        ListPartnershipsResponse EndListPartnerships(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProfiles


        /// <summary>
        /// Lists the profiles associated with your Amazon Web Services account for your current
        /// or specified region. A profile is the mechanism used to create the concept of a private
        /// network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        ListProfilesResponse ListProfiles(ListProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        IAsyncResult BeginListProfiles(ListProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfiles.</param>
        /// 
        /// <returns>Returns a  ListProfilesResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        ListProfilesResponse EndListProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a capability, partnership, profile, or transformer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTransformers


        /// <summary>
        /// Lists the available transformers. A transformer can take an EDI file as input and
        /// transform it into a JSON-or XML-formatted document. Alternatively, a transformer can
        /// take a JSON-or XML-formatted document as input and transform it into an EDI file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransformers service method.</param>
        /// 
        /// <returns>The response from the ListTransformers service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTransformers">REST API Reference for ListTransformers Operation</seealso>
        ListTransformersResponse ListTransformers(ListTransformersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTransformers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransformers operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTransformers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTransformers">REST API Reference for ListTransformers Operation</seealso>
        IAsyncResult BeginListTransformers(ListTransformersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTransformers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTransformers.</param>
        /// 
        /// <returns>Returns a  ListTransformersResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/ListTransformers">REST API Reference for ListTransformers Operation</seealso>
        ListTransformersResponse EndListTransformers(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTransformerJob


        /// <summary>
        /// Runs a job, using a transformer, to parse input EDI (electronic data interchange)
        /// file into the output structures used by Amazon Web Services B2B Data Interchange.
        /// 
        ///  
        /// <para>
        /// If you only want to transform EDI (electronic data interchange) documents, you don't
        /// need to create profiles, partnerships or capabilities. Just create and configure a
        /// transformer, and then run the <c>StartTransformerJob</c> API to process your files.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTransformerJob service method.</param>
        /// 
        /// <returns>The response from the StartTransformerJob service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/StartTransformerJob">REST API Reference for StartTransformerJob Operation</seealso>
        StartTransformerJobResponse StartTransformerJob(StartTransformerJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartTransformerJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTransformerJob operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTransformerJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/StartTransformerJob">REST API Reference for StartTransformerJob Operation</seealso>
        IAsyncResult BeginStartTransformerJob(StartTransformerJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTransformerJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTransformerJob.</param>
        /// 
        /// <returns>Returns a  StartTransformerJobResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/StartTransformerJob">REST API Reference for StartTransformerJob Operation</seealso>
        StartTransformerJobResponse EndStartTransformerJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are capability, partnership, profile, transformers and other entities.
        /// 
        ///  
        /// <para>
        /// There is no response returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestConversion


        /// <summary>
        /// This operation mimics the latter half of a typical Outbound EDI request. It takes
        /// an input JSON/XML in the B2Bi shape as input, converts it to an X12 EDI string, and
        /// return that string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConversion service method.</param>
        /// 
        /// <returns>The response from the TestConversion service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestConversion">REST API Reference for TestConversion Operation</seealso>
        TestConversionResponse TestConversion(TestConversionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestConversion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestConversion operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestConversion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestConversion">REST API Reference for TestConversion Operation</seealso>
        IAsyncResult BeginTestConversion(TestConversionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestConversion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestConversion.</param>
        /// 
        /// <returns>Returns a  TestConversionResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestConversion">REST API Reference for TestConversion Operation</seealso>
        TestConversionResponse EndTestConversion(IAsyncResult asyncResult);

        #endregion
        
        #region  TestMapping


        /// <summary>
        /// Maps the input file according to the provided template file. The API call downloads
        /// the file contents from the Amazon S3 location, and passes the contents in as a string,
        /// to the <c>inputFileContent</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestMapping service method.</param>
        /// 
        /// <returns>The response from the TestMapping service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestMapping">REST API Reference for TestMapping Operation</seealso>
        TestMappingResponse TestMapping(TestMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestMapping operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestMapping">REST API Reference for TestMapping Operation</seealso>
        IAsyncResult BeginTestMapping(TestMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestMapping.</param>
        /// 
        /// <returns>Returns a  TestMappingResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestMapping">REST API Reference for TestMapping Operation</seealso>
        TestMappingResponse EndTestMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  TestParsing


        /// <summary>
        /// Parses the input EDI (electronic data interchange) file. The input file has a file
        /// size limit of 250 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestParsing service method.</param>
        /// 
        /// <returns>The response from the TestParsing service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestParsing">REST API Reference for TestParsing Operation</seealso>
        TestParsingResponse TestParsing(TestParsingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestParsing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestParsing operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestParsing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestParsing">REST API Reference for TestParsing Operation</seealso>
        IAsyncResult BeginTestParsing(TestParsingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestParsing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestParsing.</param>
        /// 
        /// <returns>Returns a  TestParsingResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/TestParsing">REST API Reference for TestParsing Operation</seealso>
        TestParsingResponse EndTestParsing(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Detaches a key-value pair from the specified resource, as identified by its Amazon
        /// Resource Name (ARN). Resources are capability, partnership, profile, transformers
        /// and other entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCapability


        /// <summary>
        /// Updates some of the parameters for a capability, based on the specified parameters.
        /// A trading capability contains the information required to transform incoming EDI documents
        /// into JSON or XML outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapability service method.</param>
        /// 
        /// <returns>The response from the UpdateCapability service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        UpdateCapabilityResponse UpdateCapability(UpdateCapabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCapability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCapability operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCapability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        IAsyncResult BeginUpdateCapability(UpdateCapabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCapability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCapability.</param>
        /// 
        /// <returns>Returns a  UpdateCapabilityResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateCapability">REST API Reference for UpdateCapability Operation</seealso>
        UpdateCapabilityResponse EndUpdateCapability(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePartnership


        /// <summary>
        /// Updates some of the parameters for a partnership between a customer and trading partner.
        /// A partnership represents the connection between you and your trading partner. It ties
        /// together a profile and one or more trading capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnership service method.</param>
        /// 
        /// <returns>The response from the UpdatePartnership service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdatePartnership">REST API Reference for UpdatePartnership Operation</seealso>
        UpdatePartnershipResponse UpdatePartnership(UpdatePartnershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartnership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnership operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePartnership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdatePartnership">REST API Reference for UpdatePartnership Operation</seealso>
        IAsyncResult BeginUpdatePartnership(UpdatePartnershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePartnership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePartnership.</param>
        /// 
        /// <returns>Returns a  UpdatePartnershipResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdatePartnership">REST API Reference for UpdatePartnership Operation</seealso>
        UpdatePartnershipResponse EndUpdatePartnership(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProfile


        /// <summary>
        /// Updates the specified parameters for a profile. A profile is the mechanism used to
        /// create the concept of a private network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        UpdateProfileResponse UpdateProfile(UpdateProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        IAsyncResult BeginUpdateProfile(UpdateProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfile.</param>
        /// 
        /// <returns>Returns a  UpdateProfileResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        UpdateProfileResponse EndUpdateProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTransformer


        /// <summary>
        /// Updates the specified parameters for a transformer. A transformer can take an EDI
        /// file as input and transform it into a JSON-or XML-formatted document. Alternatively,
        /// a transformer can take a JSON-or XML-formatted document as input and transform it
        /// into an EDI file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTransformer service method.</param>
        /// 
        /// <returns>The response from the UpdateTransformer service method, as returned by B2bi.</returns>
        /// <exception cref="Amazon.B2bi.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ConflictException">
        /// A conflict exception is thrown when you attempt to delete a resource (such as a profile
        /// or a capability) that is being used by other resources.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.InternalServerException">
        /// This exception is thrown when an error occurs in the Amazon Web Services B2B Data
        /// Interchange service.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ResourceNotFoundException">
        /// Occurs when the requested resource does not exist, or cannot be found. In some cases,
        /// the resource exists in a region other than the region specified in the API call.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ServiceQuotaExceededException">
        /// Occurs when the calling command attempts to exceed one of the service quotas, for
        /// example trying to create a capability when you already have the maximum number of
        /// capabilities allowed.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ThrottlingException">
        /// The request was denied due to throttling: the data speed and rendering may be limited
        /// depending on various parameters and conditions.
        /// </exception>
        /// <exception cref="Amazon.B2bi.Model.ValidationException">
        /// Occurs when a B2BI object cannot be validated against a request from another object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateTransformer">REST API Reference for UpdateTransformer Operation</seealso>
        UpdateTransformerResponse UpdateTransformer(UpdateTransformerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTransformer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTransformer operation on AmazonB2biClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTransformer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateTransformer">REST API Reference for UpdateTransformer Operation</seealso>
        IAsyncResult BeginUpdateTransformer(UpdateTransformerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTransformer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTransformer.</param>
        /// 
        /// <returns>Returns a  UpdateTransformerResult from B2bi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/b2bi-2022-06-23/UpdateTransformer">REST API Reference for UpdateTransformer Operation</seealso>
        UpdateTransformerResponse EndUpdateTransformer(IAsyncResult asyncResult);

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