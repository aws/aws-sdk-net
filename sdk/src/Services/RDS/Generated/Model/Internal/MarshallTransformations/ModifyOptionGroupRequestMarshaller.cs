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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyOptionGroup Request Marshaller
    /// </summary>       
    public class ModifyOptionGroupRequestMarshaller : IMarshaller<IRequest, ModifyOptionGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyOptionGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyOptionGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "ModifyOptionGroup");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplyImmediately())
                {
                    request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOptionGroupName())
                {
                    request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOptionsToInclude())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.OptionsToInclude)
                    {
                        if(publicRequestlistValue.IsSetDBSecurityGroupMemberships())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.DBSecurityGroupMemberships)
                            {
                                request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DBSecurityGroupMemberships" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetOptionName())
                        {
                            request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionName", StringUtils.FromString(publicRequestlistValue.OptionName));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetOptionSettings())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.OptionSettings)
                            {
                                if(publicRequestlistValuelistValue.IsSetAllowedValues())
                                {
                                    request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionSettings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "AllowedValues", StringUtils.FromString(publicRequestlistValuelistValue.AllowedValues));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetApplyType())
                                {
                                    request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionSettings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "ApplyType", StringUtils.FromString(publicRequestlistValuelistValue.ApplyType));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetDataType())
                                {
                                    request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionSettings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "DataType", StringUtils.FromString(publicRequestlistValuelistValue.DataType));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetDefaultValue())
                                {
                                    request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionSettings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "DefaultValue", StringUtils.FromString(publicRequestlistValuelistValue.DefaultValue));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetDescription())
                                {
                                    request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionSettings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValuelistValue.Description));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetIsCollection())
                                {
                                    request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionSettings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "IsCollection", StringUtils.FromBool(publicRequestlistValuelistValue.IsCollection));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetIsModifiable())
                                {
                                    request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionSettings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "IsModifiable", StringUtils.FromBool(publicRequestlistValuelistValue.IsModifiable));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetName())
                                {
                                    request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionSettings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValuelistValue.Name));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionSettings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetOptionVersion())
                        {
                            request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionVersion", StringUtils.FromString(publicRequestlistValue.OptionVersion));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetPort())
                        {
                            request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Port", StringUtils.FromInt(publicRequestlistValue.Port));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetVpcSecurityGroupMemberships())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.VpcSecurityGroupMemberships)
                            {
                                request.Parameters.Add("OptionsToInclude" + "." + "member" + "." + publicRequestlistValueIndex + "." + "VpcSecurityGroupMemberships" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOptionsToRemove())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.OptionsToRemove)
                    {
                        request.Parameters.Add("OptionsToRemove" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static ModifyOptionGroupRequestMarshaller _instance = new ModifyOptionGroupRequestMarshaller();        

        internal static ModifyOptionGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyOptionGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}