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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptune.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.Neptune.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CopyDBParameterGroup Request Marshaller
    /// </summary>       
    public class CopyDBParameterGroupRequestMarshaller : IMarshaller<IRequest, CopyDBParameterGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopyDBParameterGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CopyDBParameterGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptune");
            request.Parameters.Add("Action", "CopyDBParameterGroup");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetSourceDBParameterGroupIdentifier())
                {
                    request.Parameters.Add("SourceDBParameterGroupIdentifier", StringUtils.FromString(publicRequest.SourceDBParameterGroupIdentifier));
                }
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTargetDBParameterGroupDescription())
                {
                    request.Parameters.Add("TargetDBParameterGroupDescription", StringUtils.FromString(publicRequest.TargetDBParameterGroupDescription));
                }
                if(publicRequest.IsSetTargetDBParameterGroupIdentifier())
                {
                    request.Parameters.Add("TargetDBParameterGroupIdentifier", StringUtils.FromString(publicRequest.TargetDBParameterGroupIdentifier));
                }
            }
            return request;
        }
                    private static CopyDBParameterGroupRequestMarshaller _instance = new CopyDBParameterGroupRequestMarshaller();        

        internal static CopyDBParameterGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopyDBParameterGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}