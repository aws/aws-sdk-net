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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LocalizedBrandingStrings Marshaller
    /// </summary>
    public class LocalizedBrandingStringsMarshaller : IRequestMarshaller<LocalizedBrandingStrings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LocalizedBrandingStrings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBrowserTabTitle())
            {
                context.Writer.WritePropertyName("browserTabTitle");
                context.Writer.Write(requestObject.BrowserTabTitle);
            }

            if(requestObject.IsSetContactButtonText())
            {
                context.Writer.WritePropertyName("contactButtonText");
                context.Writer.Write(requestObject.ContactButtonText);
            }

            if(requestObject.IsSetContactLink())
            {
                context.Writer.WritePropertyName("contactLink");
                context.Writer.Write(requestObject.ContactLink);
            }

            if(requestObject.IsSetLoadingText())
            {
                context.Writer.WritePropertyName("loadingText");
                context.Writer.Write(requestObject.LoadingText);
            }

            if(requestObject.IsSetLoginButtonText())
            {
                context.Writer.WritePropertyName("loginButtonText");
                context.Writer.Write(requestObject.LoginButtonText);
            }

            if(requestObject.IsSetLoginDescription())
            {
                context.Writer.WritePropertyName("loginDescription");
                context.Writer.Write(requestObject.LoginDescription);
            }

            if(requestObject.IsSetLoginTitle())
            {
                context.Writer.WritePropertyName("loginTitle");
                context.Writer.Write(requestObject.LoginTitle);
            }

            if(requestObject.IsSetWelcomeText())
            {
                context.Writer.WritePropertyName("welcomeText");
                context.Writer.Write(requestObject.WelcomeText);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LocalizedBrandingStringsMarshaller Instance = new LocalizedBrandingStringsMarshaller();

    }
}