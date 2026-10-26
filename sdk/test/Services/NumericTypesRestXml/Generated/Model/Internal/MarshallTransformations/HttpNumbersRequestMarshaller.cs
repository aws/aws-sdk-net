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
 * Do not modify this file. This file is generated from the numerictypesrestxml-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesRestXml.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.NumericTypesRestXml.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpNumbers Request Marshaller
    /// </summary>       
    public partial class HttpNumbersRequestMarshaller : IMarshaller<IRequest, HttpNumbersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((HttpNumbersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(HttpNumbersRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.NumericTypesRestXml");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetHeaderBigDecimal()) 
            {
                request.Headers["X-BigDecimal"] = StringUtils.FromBigDecimal(publicRequest.HeaderBigDecimal);
            }
        
            if (publicRequest.IsSetHeaderBigDecimalList()) 
            {
                        request.Headers["X-BigDecimalList"] = StringUtils.FromValueTypeList(publicRequest.HeaderBigDecimalList, StringUtils.FromBigDecimal);
            }
        
            if (publicRequest.IsSetHeaderBigInteger()) 
            {
                request.Headers["X-BigInteger"] = StringUtils.FromBigInteger(publicRequest.HeaderBigInteger);
            }
        
            if (publicRequest.IsSetHeaderBigIntegerList()) 
            {
                        request.Headers["X-BigIntegerList"] = StringUtils.FromValueTypeList(publicRequest.HeaderBigIntegerList, StringUtils.FromBigInteger);
            }
        
            if (publicRequest.IsSetHeaderByte()) 
            {
                request.Headers["X-Byte"] = StringUtils.FromSByte(publicRequest.HeaderByte);
            }
        
            if (publicRequest.IsSetHeaderShort()) 
            {
                request.Headers["X-Short"] = StringUtils.FromShort(publicRequest.HeaderShort);
            }
        
            if (publicRequest.IsSetHeaderShortList()) 
            {
                        request.Headers["X-ShortList"] = StringUtils.FromValueTypeList(publicRequest.HeaderShortList, StringUtils.FromShort);
            }
            if (!publicRequest.IsSetLabelBigDecimal())
                throw new AmazonNumericTypesRestXmlException("Request object does not have required field LabelBigDecimal set");
            request.AddPathResource("{BigDecimalLabel}", StringUtils.FromBigDecimal(publicRequest.LabelBigDecimal));
            if (!publicRequest.IsSetLabelBigInteger())
                throw new AmazonNumericTypesRestXmlException("Request object does not have required field LabelBigInteger set");
            request.AddPathResource("{BigIntegerLabel}", StringUtils.FromBigInteger(publicRequest.LabelBigInteger));
            if (!publicRequest.IsSetLabelByte())
                throw new AmazonNumericTypesRestXmlException("Request object does not have required field LabelByte set");
            request.AddPathResource("{ByteLabel}", StringUtils.FromSByte(publicRequest.LabelByte));
            if (!publicRequest.IsSetLabelShort())
                throw new AmazonNumericTypesRestXmlException("Request object does not have required field LabelShort set");
            request.AddPathResource("{ShortLabel}", StringUtils.FromShort(publicRequest.LabelShort));
            
            if (publicRequest.IsSetQueryBigDecimal())
                request.Parameters.Add("BigDecimal", StringUtils.FromBigDecimal(publicRequest.QueryBigDecimal));
            
            if (publicRequest.IsSetQueryBigDecimalList())
                request.ParameterCollection.Add("BigDecimalList", publicRequest.QueryBigDecimalList.ConvertAll<string>(item => StringUtils.FromBigDecimal(item)));
            
            if (publicRequest.IsSetQueryBigInteger())
                request.Parameters.Add("BigInteger", StringUtils.FromBigInteger(publicRequest.QueryBigInteger));
            
            if (publicRequest.IsSetQueryBigIntegerList())
                request.ParameterCollection.Add("BigIntegerList", publicRequest.QueryBigIntegerList.ConvertAll<string>(item => StringUtils.FromBigInteger(item)));
            
            if (publicRequest.IsSetQueryByte())
                request.Parameters.Add("Byte", StringUtils.FromSByte(publicRequest.QueryByte));
            
            if (publicRequest.IsSetQueryByteList())
                request.ParameterCollection.Add("ByteList", publicRequest.QueryByteList.ConvertAll<string>(item => StringUtils.FromSByte(item)));
            
            if (publicRequest.IsSetQueryShort())
                request.Parameters.Add("Short", StringUtils.FromShort(publicRequest.QueryShort));
            
            if (publicRequest.IsSetQueryShortList())
                request.ParameterCollection.Add("ShortList", publicRequest.QueryShortList.ConvertAll<string>(item => StringUtils.FromShort(item)));
            request.ResourcePath = "/HttpNumbers/{ByteLabel}/{ShortLabel}/{BigIntegerLabel}/{BigDecimalLabel}";


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static HttpNumbersRequestMarshaller _instance = new HttpNumbersRequestMarshaller();        

        internal static HttpNumbersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpNumbersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, HttpNumbersRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, HttpNumbersRequest publicRequest);
    }    
}