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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.TaxSettings.Model;

#pragma warning disable CS1570
namespace Amazon.TaxSettings
{
    /// <summary>
    /// <para>Interface for accessing TaxSettings</para>
    ///
    /// You can use the tax setting API to programmatically set, modify, and delete the tax
    /// registration number (TRN), associated business legal name, and address (Collectively
    /// referred to as "TRN information"). You can also programmatically view TRN information
    /// and tax addresses ("Tax profiles"). 
    /// 
    ///  
    /// <para>
    /// You can use this API to automate your TRN information settings instead of manually
    /// using the console.
    /// </para>
    ///  
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://tax.us-east-1.amazonaws.com
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonTaxSettings : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITaxSettingsPaginatorFactory Paginators { get; }

        
        #region  BatchDeleteTaxRegistration


        /// <summary>
        /// Deletes tax registration for multiple accounts in batch. This can be used to delete
        /// tax registrations for up to five accounts in one batch. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can't be used to delete your tax registration in Brazil. Use the
        /// <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTaxRegistration service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/BatchDeleteTaxRegistration">REST API Reference for BatchDeleteTaxRegistration Operation</seealso>
        BatchDeleteTaxRegistrationResponse BatchDeleteTaxRegistration(BatchDeleteTaxRegistrationRequest request);



        /// <summary>
        /// Deletes tax registration for multiple accounts in batch. This can be used to delete
        /// tax registrations for up to five accounts in one batch. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can't be used to delete your tax registration in Brazil. Use the
        /// <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/BatchDeleteTaxRegistration">REST API Reference for BatchDeleteTaxRegistration Operation</seealso>
        Task<BatchDeleteTaxRegistrationResponse> BatchDeleteTaxRegistrationAsync(BatchDeleteTaxRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchPutTaxRegistration


        /// <summary>
        /// Adds or updates tax registration for multiple accounts in batch. This can be used
        /// to add or update tax registrations for up to five accounts in one batch. You can't
        /// set a TRN if there's a pending TRN. You'll need to delete the pending TRN first.
        /// 
        ///  
        /// <para>
        /// To call this API operation for specific countries, see the following country-specific
        /// requirements.
        /// </para>
        ///  
        /// <para>
        ///  <b>Bangladesh</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Brazil</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must complete the tax registration process in the <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console. After your TRN and
        /// billing address are verified, you can call this API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Web Services accounts created through Organizations, you can call this
        /// API operation when you don't have a billing address.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Georgia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The valid <c>personType</c> values are <c>Physical Person</c> and <c>Business</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Kenya</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>personType</c> in the <c>kenyaAdditionalInfo</c> field of
        /// the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>personType</c> is <c>Physical Person</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Malaysia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RegistrationType</c> valid values are <c>NRIC</c> for individual, and TIN and
        /// sales and service tax (SST) for Business.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For individual, you can specify the <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with NRIC type, and a valid <c>MyKad</c> or NRIC number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business, you must specify a <c>businessRegistrationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a TIN type and tax identification number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers, you must specify a <c>businessRegistrationNumber</c> and <c>taxInformationNumber</c>
        /// in <c>MalaysiaAdditionalInfo</c> with a sales and service tax (SST) type and a valid
        /// SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers with service codes, you must specify <c>businessRegistrationNumber</c>,
        /// <c>taxInformationNumber</c>, and distinct <c>serviceTaxCodes</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a SST type and valid sales and service tax (SST) number. By using this API operation,
        /// Amazon Web Services registers your self-declaration that you’re an authorized business
        /// reseller registered with the Royal Malaysia Customs Department (RMCD), and have a
        /// valid SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services reserves the right to seek additional information and/or take
        /// other actions to support your self-declaration as appropriate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services is currently registered under the following service tax codes.
        /// You must include at least one of the service tax codes in the service tax code strings
        /// to declare yourself as an authorized registered business reseller.
        /// </para>
        ///  
        /// <para>
        /// Taxable service and service tax codes:
        /// </para>
        ///  
        /// <para>
        /// Consultancy - 9907061674
        /// </para>
        ///  
        /// <para>
        /// Training or coaching service - 9907071685
        /// </para>
        ///  
        /// <para>
        /// IT service - 9907101676
        /// </para>
        ///  
        /// <para>
        /// Digital services and electronic medium - 9907121690
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Nepal</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Saudi Arabia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>addressLine3</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>South Korea</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>certifiedEmailId</c> and <c>legalName</c> in the <c>TaxRegistrationEntry</c>
        /// object. Use Korean characters for <c>legalName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the <c>businessRepresentativeName</c>, <c>itemOfBusiness</c>, and
        /// <c>lineOfBusiness</c> in the <c>southKoreaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object. Use Korean characters for these fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>address</c> object, use Korean characters for <c>addressLine1</c>, <c>addressLine2</c>
        /// <c>city</c>, <c>postalCode</c>, and <c>stateOrRegion</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Spain</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>registrationType</c> in the <c>spainAdditionalInfo</c> field
        /// of the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>registrationType</c> is <c>Local</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Turkey</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>sector</c> in the <c>taxRegistrationEntry</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c>, <c>Individual</c>, or <c>Government</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>taxOffice</c>. If your <c>sector</c> is <c>Individual</c>, don't enter
        /// this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Specify the <c>kepEmailId</c>. If your <c>sector</c> is <c>Individual</c>,
        /// don't enter this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Note:</b> In the <b>Tax Settings</b> page of the Billing console, <c>Government</c>
        /// appears as <b>Public institutions</b> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c> and you're subject to KDV tax, you must specify
        /// your industry in the <c>industries</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>districtOrCounty</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Ukraine</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutTaxRegistration service method.</param>
        /// 
        /// <returns>The response from the BatchPutTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/BatchPutTaxRegistration">REST API Reference for BatchPutTaxRegistration Operation</seealso>
        BatchPutTaxRegistrationResponse BatchPutTaxRegistration(BatchPutTaxRegistrationRequest request);



        /// <summary>
        /// Adds or updates tax registration for multiple accounts in batch. This can be used
        /// to add or update tax registrations for up to five accounts in one batch. You can't
        /// set a TRN if there's a pending TRN. You'll need to delete the pending TRN first.
        /// 
        ///  
        /// <para>
        /// To call this API operation for specific countries, see the following country-specific
        /// requirements.
        /// </para>
        ///  
        /// <para>
        ///  <b>Bangladesh</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Brazil</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must complete the tax registration process in the <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console. After your TRN and
        /// billing address are verified, you can call this API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Web Services accounts created through Organizations, you can call this
        /// API operation when you don't have a billing address.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Georgia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The valid <c>personType</c> values are <c>Physical Person</c> and <c>Business</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Kenya</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>personType</c> in the <c>kenyaAdditionalInfo</c> field of
        /// the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>personType</c> is <c>Physical Person</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Malaysia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RegistrationType</c> valid values are <c>NRIC</c> for individual, and TIN and
        /// sales and service tax (SST) for Business.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For individual, you can specify the <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with NRIC type, and a valid <c>MyKad</c> or NRIC number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business, you must specify a <c>businessRegistrationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a TIN type and tax identification number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers, you must specify a <c>businessRegistrationNumber</c> and <c>taxInformationNumber</c>
        /// in <c>MalaysiaAdditionalInfo</c> with a sales and service tax (SST) type and a valid
        /// SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers with service codes, you must specify <c>businessRegistrationNumber</c>,
        /// <c>taxInformationNumber</c>, and distinct <c>serviceTaxCodes</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a SST type and valid sales and service tax (SST) number. By using this API operation,
        /// Amazon Web Services registers your self-declaration that you’re an authorized business
        /// reseller registered with the Royal Malaysia Customs Department (RMCD), and have a
        /// valid SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services reserves the right to seek additional information and/or take
        /// other actions to support your self-declaration as appropriate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services is currently registered under the following service tax codes.
        /// You must include at least one of the service tax codes in the service tax code strings
        /// to declare yourself as an authorized registered business reseller.
        /// </para>
        ///  
        /// <para>
        /// Taxable service and service tax codes:
        /// </para>
        ///  
        /// <para>
        /// Consultancy - 9907061674
        /// </para>
        ///  
        /// <para>
        /// Training or coaching service - 9907071685
        /// </para>
        ///  
        /// <para>
        /// IT service - 9907101676
        /// </para>
        ///  
        /// <para>
        /// Digital services and electronic medium - 9907121690
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Nepal</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Saudi Arabia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>addressLine3</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>South Korea</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>certifiedEmailId</c> and <c>legalName</c> in the <c>TaxRegistrationEntry</c>
        /// object. Use Korean characters for <c>legalName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the <c>businessRepresentativeName</c>, <c>itemOfBusiness</c>, and
        /// <c>lineOfBusiness</c> in the <c>southKoreaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object. Use Korean characters for these fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>address</c> object, use Korean characters for <c>addressLine1</c>, <c>addressLine2</c>
        /// <c>city</c>, <c>postalCode</c>, and <c>stateOrRegion</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Spain</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>registrationType</c> in the <c>spainAdditionalInfo</c> field
        /// of the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>registrationType</c> is <c>Local</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Turkey</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>sector</c> in the <c>taxRegistrationEntry</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c>, <c>Individual</c>, or <c>Government</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>taxOffice</c>. If your <c>sector</c> is <c>Individual</c>, don't enter
        /// this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Specify the <c>kepEmailId</c>. If your <c>sector</c> is <c>Individual</c>,
        /// don't enter this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Note:</b> In the <b>Tax Settings</b> page of the Billing console, <c>Government</c>
        /// appears as <b>Public institutions</b> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c> and you're subject to KDV tax, you must specify
        /// your industry in the <c>industries</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>districtOrCounty</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Ukraine</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/BatchPutTaxRegistration">REST API Reference for BatchPutTaxRegistration Operation</seealso>
        Task<BatchPutTaxRegistrationResponse> BatchPutTaxRegistrationAsync(BatchPutTaxRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSupplementalTaxRegistration


        /// <summary>
        /// Deletes a supplemental tax registration for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSupplementalTaxRegistration service method.</param>
        /// 
        /// <returns>The response from the DeleteSupplementalTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/DeleteSupplementalTaxRegistration">REST API Reference for DeleteSupplementalTaxRegistration Operation</seealso>
        DeleteSupplementalTaxRegistrationResponse DeleteSupplementalTaxRegistration(DeleteSupplementalTaxRegistrationRequest request);



        /// <summary>
        /// Deletes a supplemental tax registration for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSupplementalTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSupplementalTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/DeleteSupplementalTaxRegistration">REST API Reference for DeleteSupplementalTaxRegistration Operation</seealso>
        Task<DeleteSupplementalTaxRegistrationResponse> DeleteSupplementalTaxRegistrationAsync(DeleteSupplementalTaxRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTaxRegistration


        /// <summary>
        /// Deletes tax registration for a single account. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can't be used to delete your tax registration in Brazil. Use the
        /// <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaxRegistration service method.</param>
        /// 
        /// <returns>The response from the DeleteTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/DeleteTaxRegistration">REST API Reference for DeleteTaxRegistration Operation</seealso>
        DeleteTaxRegistrationResponse DeleteTaxRegistration(DeleteTaxRegistrationRequest request);



        /// <summary>
        /// Deletes tax registration for a single account. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can't be used to delete your tax registration in Brazil. Use the
        /// <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/DeleteTaxRegistration">REST API Reference for DeleteTaxRegistration Operation</seealso>
        Task<DeleteTaxRegistrationResponse> DeleteTaxRegistrationAsync(DeleteTaxRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTaxRegistration


        /// <summary>
        /// Retrieves tax registration for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaxRegistration service method.</param>
        /// 
        /// <returns>The response from the GetTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/GetTaxRegistration">REST API Reference for GetTaxRegistration Operation</seealso>
        GetTaxRegistrationResponse GetTaxRegistration(GetTaxRegistrationRequest request);



        /// <summary>
        /// Retrieves tax registration for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/GetTaxRegistration">REST API Reference for GetTaxRegistration Operation</seealso>
        Task<GetTaxRegistrationResponse> GetTaxRegistrationAsync(GetTaxRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTaxRegistrationDocument


        /// <summary>
        /// Downloads your tax documents to the Amazon S3 bucket that you specify in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaxRegistrationDocument service method.</param>
        /// 
        /// <returns>The response from the GetTaxRegistrationDocument service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/GetTaxRegistrationDocument">REST API Reference for GetTaxRegistrationDocument Operation</seealso>
        GetTaxRegistrationDocumentResponse GetTaxRegistrationDocument(GetTaxRegistrationDocumentRequest request);



        /// <summary>
        /// Downloads your tax documents to the Amazon S3 bucket that you specify in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaxRegistrationDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTaxRegistrationDocument service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/GetTaxRegistrationDocument">REST API Reference for GetTaxRegistrationDocument Operation</seealso>
        Task<GetTaxRegistrationDocumentResponse> GetTaxRegistrationDocumentAsync(GetTaxRegistrationDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSupplementalTaxRegistrations


        /// <summary>
        /// Retrieves supplemental tax registrations for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupplementalTaxRegistrations service method.</param>
        /// 
        /// <returns>The response from the ListSupplementalTaxRegistrations service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/ListSupplementalTaxRegistrations">REST API Reference for ListSupplementalTaxRegistrations Operation</seealso>
        ListSupplementalTaxRegistrationsResponse ListSupplementalTaxRegistrations(ListSupplementalTaxRegistrationsRequest request);



        /// <summary>
        /// Retrieves supplemental tax registrations for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupplementalTaxRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupplementalTaxRegistrations service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/ListSupplementalTaxRegistrations">REST API Reference for ListSupplementalTaxRegistrations Operation</seealso>
        Task<ListSupplementalTaxRegistrationsResponse> ListSupplementalTaxRegistrationsAsync(ListSupplementalTaxRegistrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTaxRegistrations


        /// <summary>
        /// Retrieves the tax registration of accounts listed in a consolidated billing family.
        /// This can be used to retrieve up to 100 accounts' tax registrations in one call (default
        /// 50).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaxRegistrations service method.</param>
        /// 
        /// <returns>The response from the ListTaxRegistrations service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/ListTaxRegistrations">REST API Reference for ListTaxRegistrations Operation</seealso>
        ListTaxRegistrationsResponse ListTaxRegistrations(ListTaxRegistrationsRequest request);



        /// <summary>
        /// Retrieves the tax registration of accounts listed in a consolidated billing family.
        /// This can be used to retrieve up to 100 accounts' tax registrations in one call (default
        /// 50).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaxRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaxRegistrations service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ResourceNotFoundException">
        /// The exception thrown when the input doesn't have a resource associated to it.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/ListTaxRegistrations">REST API Reference for ListTaxRegistrations Operation</seealso>
        Task<ListTaxRegistrationsResponse> ListTaxRegistrationsAsync(ListTaxRegistrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutSupplementalTaxRegistration


        /// <summary>
        /// Stores supplemental tax registration for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSupplementalTaxRegistration service method.</param>
        /// 
        /// <returns>The response from the PutSupplementalTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/PutSupplementalTaxRegistration">REST API Reference for PutSupplementalTaxRegistration Operation</seealso>
        PutSupplementalTaxRegistrationResponse PutSupplementalTaxRegistration(PutSupplementalTaxRegistrationRequest request);



        /// <summary>
        /// Stores supplemental tax registration for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSupplementalTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSupplementalTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/PutSupplementalTaxRegistration">REST API Reference for PutSupplementalTaxRegistration Operation</seealso>
        Task<PutSupplementalTaxRegistrationResponse> PutSupplementalTaxRegistrationAsync(PutSupplementalTaxRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutTaxRegistration


        /// <summary>
        /// Adds or updates tax registration for a single account. You can't set a TRN if there's
        /// a pending TRN. You'll need to delete the pending TRN first.
        /// 
        ///  
        /// <para>
        /// To call this API operation for specific countries, see the following country-specific
        /// requirements.
        /// </para>
        ///  
        /// <para>
        ///  <b>Bangladesh</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Brazil</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must complete the tax registration process in the <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console. After your TRN and
        /// billing address are verified, you can call this API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Web Services accounts created through Organizations, you can call this
        /// API operation when you don't have a billing address.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Georgia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The valid <c>personType</c> values are <c>Physical Person</c> and <c>Business</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Kenya</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>personType</c> in the <c>kenyaAdditionalInfo</c> field of
        /// the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>personType</c> is <c>Physical Person</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Malaysia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RegistrationType</c> valid values are <c>NRIC</c> for individual, and TIN and
        /// sales and service tax (SST) for Business.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For individual, you can specify the <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with NRIC type, and a valid <c>MyKad</c> or NRIC number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business, you must specify a <c>businessRegistrationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a TIN type and tax identification number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers, you must specify a <c>businessRegistrationNumber</c> and <c>taxInformationNumber</c>
        /// in <c>MalaysiaAdditionalInfo</c> with a sales and service tax (SST) type and a valid
        /// SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers with service codes, you must specify <c>businessRegistrationNumber</c>,
        /// <c>taxInformationNumber</c>, and distinct <c>serviceTaxCodes</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a SST type and valid sales and service tax (SST) number. By using this API operation,
        /// Amazon Web Services registers your self-declaration that you’re an authorized business
        /// reseller registered with the Royal Malaysia Customs Department (RMCD), and have a
        /// valid SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services reserves the right to seek additional information and/or take
        /// other actions to support your self-declaration as appropriate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services is currently registered under the following service tax codes.
        /// You must include at least one of the service tax codes in the service tax code strings
        /// to declare yourself as an authorized registered business reseller.
        /// </para>
        ///  
        /// <para>
        /// Taxable service and service tax codes:
        /// </para>
        ///  
        /// <para>
        /// Consultancy - 9907061674
        /// </para>
        ///  
        /// <para>
        /// Training or coaching service - 9907071685
        /// </para>
        ///  
        /// <para>
        /// IT service - 9907101676
        /// </para>
        ///  
        /// <para>
        /// Digital services and electronic medium - 9907121690
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Nepal</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Saudi Arabia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>addressLine3</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>South Korea</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>certifiedEmailId</c> and <c>legalName</c> in the <c>TaxRegistrationEntry</c>
        /// object. Use Korean characters for <c>legalName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the <c>businessRepresentativeName</c>, <c>itemOfBusiness</c>, and
        /// <c>lineOfBusiness</c> in the <c>southKoreaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object. Use Korean characters for these fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>address</c> object, use Korean characters for <c>addressLine1</c>, <c>addressLine2</c>
        /// <c>city</c>, <c>postalCode</c>, and <c>stateOrRegion</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Spain</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>registrationType</c> in the <c>spainAdditionalInfo</c> field
        /// of the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>registrationType</c> is <c>Local</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Turkey</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>sector</c> in the <c>taxRegistrationEntry</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c>, <c>Individual</c>, or <c>Government</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>taxOffice</c>. If your <c>sector</c> is <c>Individual</c>, don't enter
        /// this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Specify the <c>kepEmailId</c>. If your <c>sector</c> is <c>Individual</c>,
        /// don't enter this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Note:</b> In the <b>Tax Settings</b> page of the Billing console, <c>Government</c>
        /// appears as <b>Public institutions</b> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c> and you're subject to KDV tax, you must specify
        /// your industry in the <c>industries</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>districtOrCounty</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Ukraine</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTaxRegistration service method.</param>
        /// 
        /// <returns>The response from the PutTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/PutTaxRegistration">REST API Reference for PutTaxRegistration Operation</seealso>
        PutTaxRegistrationResponse PutTaxRegistration(PutTaxRegistrationRequest request);



        /// <summary>
        /// Adds or updates tax registration for a single account. You can't set a TRN if there's
        /// a pending TRN. You'll need to delete the pending TRN first.
        /// 
        ///  
        /// <para>
        /// To call this API operation for specific countries, see the following country-specific
        /// requirements.
        /// </para>
        ///  
        /// <para>
        ///  <b>Bangladesh</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Brazil</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must complete the tax registration process in the <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
        /// preferences</a> page in the Billing and Cost Management console. After your TRN and
        /// billing address are verified, you can call this API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Web Services accounts created through Organizations, you can call this
        /// API operation when you don't have a billing address.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Georgia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The valid <c>personType</c> values are <c>Physical Person</c> and <c>Business</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Kenya</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>personType</c> in the <c>kenyaAdditionalInfo</c> field of
        /// the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>personType</c> is <c>Physical Person</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Malaysia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RegistrationType</c> valid values are <c>NRIC</c> for individual, and TIN and
        /// sales and service tax (SST) for Business.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For individual, you can specify the <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with NRIC type, and a valid <c>MyKad</c> or NRIC number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business, you must specify a <c>businessRegistrationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a TIN type and tax identification number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers, you must specify a <c>businessRegistrationNumber</c> and <c>taxInformationNumber</c>
        /// in <c>MalaysiaAdditionalInfo</c> with a sales and service tax (SST) type and a valid
        /// SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For business resellers with service codes, you must specify <c>businessRegistrationNumber</c>,
        /// <c>taxInformationNumber</c>, and distinct <c>serviceTaxCodes</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a SST type and valid sales and service tax (SST) number. By using this API operation,
        /// Amazon Web Services registers your self-declaration that you’re an authorized business
        /// reseller registered with the Royal Malaysia Customs Department (RMCD), and have a
        /// valid SST number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services reserves the right to seek additional information and/or take
        /// other actions to support your self-declaration as appropriate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services is currently registered under the following service tax codes.
        /// You must include at least one of the service tax codes in the service tax code strings
        /// to declare yourself as an authorized registered business reseller.
        /// </para>
        ///  
        /// <para>
        /// Taxable service and service tax codes:
        /// </para>
        ///  
        /// <para>
        /// Consultancy - 9907061674
        /// </para>
        ///  
        /// <para>
        /// Training or coaching service - 9907071685
        /// </para>
        ///  
        /// <para>
        /// IT service - 9907101676
        /// </para>
        ///  
        /// <para>
        /// Digital services and electronic medium - 9907121690
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Nepal</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Saudi Arabia</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>addressLine3</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>South Korea</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>certifiedEmailId</c> and <c>legalName</c> in the <c>TaxRegistrationEntry</c>
        /// object. Use Korean characters for <c>legalName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the <c>businessRepresentativeName</c>, <c>itemOfBusiness</c>, and
        /// <c>lineOfBusiness</c> in the <c>southKoreaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
        /// object. Use Korean characters for these fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
        /// field of the <c>VerificationDetails</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>address</c> object, use Korean characters for <c>addressLine1</c>, <c>addressLine2</c>
        /// <c>city</c>, <c>postalCode</c>, and <c>stateOrRegion</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Spain</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>registrationType</c> in the <c>spainAdditionalInfo</c> field
        /// of the <c>additionalTaxInformation</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>registrationType</c> is <c>Local</c>, you must specify the tax registration
        /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
        /// object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Turkey</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must specify the <c>sector</c> in the <c>taxRegistrationEntry</c> object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c>, <c>Individual</c>, or <c>Government</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>taxOffice</c>. If your <c>sector</c> is <c>Individual</c>, don't enter
        /// this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Specify the <c>kepEmailId</c>. If your <c>sector</c> is <c>Individual</c>,
        /// don't enter this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Note:</b> In the <b>Tax Settings</b> page of the Billing console, <c>Government</c>
        /// appears as <b>Public institutions</b> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If your <c>sector</c> is <c>Business</c> and you're subject to KDV tax, you must specify
        /// your industry in the <c>industries</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>address</c>, you must specify <c>districtOrCounty</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Ukraine</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sector valid values are <c>Business</c> and <c>Individual</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTaxRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTaxRegistration service method, as returned by TaxSettings.</returns>
        /// <exception cref="Amazon.TaxSettings.Model.ConflictException">
        /// The exception when the input is creating conflict with the given state.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.InternalServerException">
        /// The exception thrown when an unexpected error occurs when processing a request.
        /// </exception>
        /// <exception cref="Amazon.TaxSettings.Model.ValidationException">
        /// The exception when the input doesn't pass validation for at least one of the input
        /// parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/taxsettings-2018-05-10/PutTaxRegistration">REST API Reference for PutTaxRegistration Operation</seealso>
        Task<PutTaxRegistrationResponse> PutTaxRegistrationAsync(PutTaxRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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