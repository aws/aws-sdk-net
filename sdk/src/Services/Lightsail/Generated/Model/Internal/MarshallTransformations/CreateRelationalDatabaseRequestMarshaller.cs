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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRelationalDatabase Request Marshaller
    /// </summary>       
    public class CreateRelationalDatabaseRequestMarshaller : IMarshaller<IRequest, CreateRelationalDatabaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRelationalDatabaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRelationalDatabaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.CreateRelationalDatabase";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("availabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetMasterDatabaseName())
                {
                    context.Writer.WritePropertyName("masterDatabaseName");
                    context.Writer.Write(publicRequest.MasterDatabaseName);
                }

                if(publicRequest.IsSetMasterUsername())
                {
                    context.Writer.WritePropertyName("masterUsername");
                    context.Writer.Write(publicRequest.MasterUsername);
                }

                if(publicRequest.IsSetMasterUserPassword())
                {
                    context.Writer.WritePropertyName("masterUserPassword");
                    context.Writer.Write(publicRequest.MasterUserPassword);
                }

                if(publicRequest.IsSetPreferredBackupWindow())
                {
                    context.Writer.WritePropertyName("preferredBackupWindow");
                    context.Writer.Write(publicRequest.PreferredBackupWindow);
                }

                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    context.Writer.WritePropertyName("preferredMaintenanceWindow");
                    context.Writer.Write(publicRequest.PreferredMaintenanceWindow);
                }

                if(publicRequest.IsSetPubliclyAccessible())
                {
                    context.Writer.WritePropertyName("publiclyAccessible");
                    context.Writer.Write(publicRequest.PubliclyAccessible);
                }

                if(publicRequest.IsSetRelationalDatabaseBlueprintId())
                {
                    context.Writer.WritePropertyName("relationalDatabaseBlueprintId");
                    context.Writer.Write(publicRequest.RelationalDatabaseBlueprintId);
                }

                if(publicRequest.IsSetRelationalDatabaseBundleId())
                {
                    context.Writer.WritePropertyName("relationalDatabaseBundleId");
                    context.Writer.Write(publicRequest.RelationalDatabaseBundleId);
                }

                if(publicRequest.IsSetRelationalDatabaseName())
                {
                    context.Writer.WritePropertyName("relationalDatabaseName");
                    context.Writer.Write(publicRequest.RelationalDatabaseName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateRelationalDatabaseRequestMarshaller _instance = new CreateRelationalDatabaseRequestMarshaller();        

        internal static CreateRelationalDatabaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRelationalDatabaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}