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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Domains.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TransferDomain Request Marshaller
    /// </summary>       
    public class TransferDomainRequestMarshaller : IMarshaller<IRequest, TransferDomainRequest> 
    {
        public IRequest Marshall(TransferDomainRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Domains");
            string target = "Route53Domains_v20140515.TransferDomain";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetAdminContact())
                {
                    writer.WritePropertyName("AdminContact");
                    writer.WriteObjectStart();
                    if(publicRequest.AdminContact.IsSetAddressLine1())
                    {
                        writer.WritePropertyName("AddressLine1");
                        writer.Write(publicRequest.AdminContact.AddressLine1);
                    }

                    if(publicRequest.AdminContact.IsSetAddressLine2())
                    {
                        writer.WritePropertyName("AddressLine2");
                        writer.Write(publicRequest.AdminContact.AddressLine2);
                    }

                    if(publicRequest.AdminContact.IsSetCity())
                    {
                        writer.WritePropertyName("City");
                        writer.Write(publicRequest.AdminContact.City);
                    }

                    if(publicRequest.AdminContact.IsSetContactType())
                    {
                        writer.WritePropertyName("ContactType");
                        writer.Write(publicRequest.AdminContact.ContactType);
                    }

                    if(publicRequest.AdminContact.IsSetCountryCode())
                    {
                        writer.WritePropertyName("CountryCode");
                        writer.Write(publicRequest.AdminContact.CountryCode);
                    }

                    if(publicRequest.AdminContact.IsSetEmail())
                    {
                        writer.WritePropertyName("Email");
                        writer.Write(publicRequest.AdminContact.Email);
                    }

                    if(publicRequest.AdminContact.IsSetExtraParams())
                    {
                        writer.WritePropertyName("ExtraParams");
                        writer.WriteArrayStart();
                        foreach(var publicRequestAdminContactExtraParamsListValue in publicRequest.AdminContact.ExtraParams)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestAdminContactExtraParamsListValue.IsSetName())
                            {
                                writer.WritePropertyName("Name");
                                writer.Write(publicRequestAdminContactExtraParamsListValue.Name);
                            }

                            if(publicRequestAdminContactExtraParamsListValue.IsSetValue())
                            {
                                writer.WritePropertyName("Value");
                                writer.Write(publicRequestAdminContactExtraParamsListValue.Value);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.AdminContact.IsSetFax())
                    {
                        writer.WritePropertyName("Fax");
                        writer.Write(publicRequest.AdminContact.Fax);
                    }

                    if(publicRequest.AdminContact.IsSetFirstName())
                    {
                        writer.WritePropertyName("FirstName");
                        writer.Write(publicRequest.AdminContact.FirstName);
                    }

                    if(publicRequest.AdminContact.IsSetLastName())
                    {
                        writer.WritePropertyName("LastName");
                        writer.Write(publicRequest.AdminContact.LastName);
                    }

                    if(publicRequest.AdminContact.IsSetOrganizationName())
                    {
                        writer.WritePropertyName("OrganizationName");
                        writer.Write(publicRequest.AdminContact.OrganizationName);
                    }

                    if(publicRequest.AdminContact.IsSetPhoneNumber())
                    {
                        writer.WritePropertyName("PhoneNumber");
                        writer.Write(publicRequest.AdminContact.PhoneNumber);
                    }

                    if(publicRequest.AdminContact.IsSetState())
                    {
                        writer.WritePropertyName("State");
                        writer.Write(publicRequest.AdminContact.State);
                    }

                    if(publicRequest.AdminContact.IsSetZipCode())
                    {
                        writer.WritePropertyName("ZipCode");
                        writer.Write(publicRequest.AdminContact.ZipCode);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAuthCode())
                {
                    writer.WritePropertyName("AuthCode");
                    writer.Write(publicRequest.AuthCode);
                }

                if(publicRequest.IsSetAutoRenew())
                {
                    writer.WritePropertyName("AutoRenew");
                    writer.Write(publicRequest.AutoRenew);
                }

                if(publicRequest.IsSetDomainName())
                {
                    writer.WritePropertyName("DomainName");
                    writer.Write(publicRequest.DomainName);
                }

                if(publicRequest.IsSetDurationInYears())
                {
                    writer.WritePropertyName("DurationInYears");
                    writer.Write(publicRequest.DurationInYears);
                }

                if(publicRequest.IsSetIdnLangCode())
                {
                    writer.WritePropertyName("IdnLangCode");
                    writer.Write(publicRequest.IdnLangCode);
                }

                if(publicRequest.IsSetNameservers())
                {
                    writer.WritePropertyName("Nameservers");
                    writer.WriteArrayStart();
                    foreach(var publicRequestNameserversListValue in publicRequest.Nameservers)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestNameserversListValue.IsSetGlueIps())
                        {
                            writer.WritePropertyName("GlueIps");
                            writer.WriteArrayStart();
                            foreach(var publicRequestNameserversListValueGlueIpsListValue in publicRequestNameserversListValue.GlueIps)
                            {
                                writer.Write(publicRequestNameserversListValueGlueIpsListValue);
                            }
                            writer.WriteArrayEnd();
                        }

                        if(publicRequestNameserversListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestNameserversListValue.Name);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPrivacyProtectAdminContact())
                {
                    writer.WritePropertyName("PrivacyProtectAdminContact");
                    writer.Write(publicRequest.PrivacyProtectAdminContact);
                }

                if(publicRequest.IsSetPrivacyProtectRegistrantContact())
                {
                    writer.WritePropertyName("PrivacyProtectRegistrantContact");
                    writer.Write(publicRequest.PrivacyProtectRegistrantContact);
                }

                if(publicRequest.IsSetPrivacyProtectTechContact())
                {
                    writer.WritePropertyName("PrivacyProtectTechContact");
                    writer.Write(publicRequest.PrivacyProtectTechContact);
                }

                if(publicRequest.IsSetRegistrantContact())
                {
                    writer.WritePropertyName("RegistrantContact");
                    writer.WriteObjectStart();
                    if(publicRequest.RegistrantContact.IsSetAddressLine1())
                    {
                        writer.WritePropertyName("AddressLine1");
                        writer.Write(publicRequest.RegistrantContact.AddressLine1);
                    }

                    if(publicRequest.RegistrantContact.IsSetAddressLine2())
                    {
                        writer.WritePropertyName("AddressLine2");
                        writer.Write(publicRequest.RegistrantContact.AddressLine2);
                    }

                    if(publicRequest.RegistrantContact.IsSetCity())
                    {
                        writer.WritePropertyName("City");
                        writer.Write(publicRequest.RegistrantContact.City);
                    }

                    if(publicRequest.RegistrantContact.IsSetContactType())
                    {
                        writer.WritePropertyName("ContactType");
                        writer.Write(publicRequest.RegistrantContact.ContactType);
                    }

                    if(publicRequest.RegistrantContact.IsSetCountryCode())
                    {
                        writer.WritePropertyName("CountryCode");
                        writer.Write(publicRequest.RegistrantContact.CountryCode);
                    }

                    if(publicRequest.RegistrantContact.IsSetEmail())
                    {
                        writer.WritePropertyName("Email");
                        writer.Write(publicRequest.RegistrantContact.Email);
                    }

                    if(publicRequest.RegistrantContact.IsSetExtraParams())
                    {
                        writer.WritePropertyName("ExtraParams");
                        writer.WriteArrayStart();
                        foreach(var publicRequestRegistrantContactExtraParamsListValue in publicRequest.RegistrantContact.ExtraParams)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestRegistrantContactExtraParamsListValue.IsSetName())
                            {
                                writer.WritePropertyName("Name");
                                writer.Write(publicRequestRegistrantContactExtraParamsListValue.Name);
                            }

                            if(publicRequestRegistrantContactExtraParamsListValue.IsSetValue())
                            {
                                writer.WritePropertyName("Value");
                                writer.Write(publicRequestRegistrantContactExtraParamsListValue.Value);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.RegistrantContact.IsSetFax())
                    {
                        writer.WritePropertyName("Fax");
                        writer.Write(publicRequest.RegistrantContact.Fax);
                    }

                    if(publicRequest.RegistrantContact.IsSetFirstName())
                    {
                        writer.WritePropertyName("FirstName");
                        writer.Write(publicRequest.RegistrantContact.FirstName);
                    }

                    if(publicRequest.RegistrantContact.IsSetLastName())
                    {
                        writer.WritePropertyName("LastName");
                        writer.Write(publicRequest.RegistrantContact.LastName);
                    }

                    if(publicRequest.RegistrantContact.IsSetOrganizationName())
                    {
                        writer.WritePropertyName("OrganizationName");
                        writer.Write(publicRequest.RegistrantContact.OrganizationName);
                    }

                    if(publicRequest.RegistrantContact.IsSetPhoneNumber())
                    {
                        writer.WritePropertyName("PhoneNumber");
                        writer.Write(publicRequest.RegistrantContact.PhoneNumber);
                    }

                    if(publicRequest.RegistrantContact.IsSetState())
                    {
                        writer.WritePropertyName("State");
                        writer.Write(publicRequest.RegistrantContact.State);
                    }

                    if(publicRequest.RegistrantContact.IsSetZipCode())
                    {
                        writer.WritePropertyName("ZipCode");
                        writer.Write(publicRequest.RegistrantContact.ZipCode);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTechContact())
                {
                    writer.WritePropertyName("TechContact");
                    writer.WriteObjectStart();
                    if(publicRequest.TechContact.IsSetAddressLine1())
                    {
                        writer.WritePropertyName("AddressLine1");
                        writer.Write(publicRequest.TechContact.AddressLine1);
                    }

                    if(publicRequest.TechContact.IsSetAddressLine2())
                    {
                        writer.WritePropertyName("AddressLine2");
                        writer.Write(publicRequest.TechContact.AddressLine2);
                    }

                    if(publicRequest.TechContact.IsSetCity())
                    {
                        writer.WritePropertyName("City");
                        writer.Write(publicRequest.TechContact.City);
                    }

                    if(publicRequest.TechContact.IsSetContactType())
                    {
                        writer.WritePropertyName("ContactType");
                        writer.Write(publicRequest.TechContact.ContactType);
                    }

                    if(publicRequest.TechContact.IsSetCountryCode())
                    {
                        writer.WritePropertyName("CountryCode");
                        writer.Write(publicRequest.TechContact.CountryCode);
                    }

                    if(publicRequest.TechContact.IsSetEmail())
                    {
                        writer.WritePropertyName("Email");
                        writer.Write(publicRequest.TechContact.Email);
                    }

                    if(publicRequest.TechContact.IsSetExtraParams())
                    {
                        writer.WritePropertyName("ExtraParams");
                        writer.WriteArrayStart();
                        foreach(var publicRequestTechContactExtraParamsListValue in publicRequest.TechContact.ExtraParams)
                        {
                            writer.WriteObjectStart();
                            if(publicRequestTechContactExtraParamsListValue.IsSetName())
                            {
                                writer.WritePropertyName("Name");
                                writer.Write(publicRequestTechContactExtraParamsListValue.Name);
                            }

                            if(publicRequestTechContactExtraParamsListValue.IsSetValue())
                            {
                                writer.WritePropertyName("Value");
                                writer.Write(publicRequestTechContactExtraParamsListValue.Value);
                            }

                            writer.WriteObjectEnd();
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.TechContact.IsSetFax())
                    {
                        writer.WritePropertyName("Fax");
                        writer.Write(publicRequest.TechContact.Fax);
                    }

                    if(publicRequest.TechContact.IsSetFirstName())
                    {
                        writer.WritePropertyName("FirstName");
                        writer.Write(publicRequest.TechContact.FirstName);
                    }

                    if(publicRequest.TechContact.IsSetLastName())
                    {
                        writer.WritePropertyName("LastName");
                        writer.Write(publicRequest.TechContact.LastName);
                    }

                    if(publicRequest.TechContact.IsSetOrganizationName())
                    {
                        writer.WritePropertyName("OrganizationName");
                        writer.Write(publicRequest.TechContact.OrganizationName);
                    }

                    if(publicRequest.TechContact.IsSetPhoneNumber())
                    {
                        writer.WritePropertyName("PhoneNumber");
                        writer.Write(publicRequest.TechContact.PhoneNumber);
                    }

                    if(publicRequest.TechContact.IsSetState())
                    {
                        writer.WritePropertyName("State");
                        writer.Write(publicRequest.TechContact.State);
                    }

                    if(publicRequest.TechContact.IsSetZipCode())
                    {
                        writer.WritePropertyName("ZipCode");
                        writer.Write(publicRequest.TechContact.ZipCode);
                    }

                    writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}