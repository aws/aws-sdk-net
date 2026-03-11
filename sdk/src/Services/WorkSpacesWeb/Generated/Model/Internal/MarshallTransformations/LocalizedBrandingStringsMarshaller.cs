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
                context.Writer.WriteStringValue(requestObject.BrowserTabTitle);
            }

            if(requestObject.IsSetContactButtonText())
            {
                context.Writer.WritePropertyName("contactButtonText");
                context.Writer.WriteStringValue(requestObject.ContactButtonText);
            }

            if(requestObject.IsSetContactLink())
            {
                context.Writer.WritePropertyName("contactLink");
                context.Writer.WriteStringValue(requestObject.ContactLink);
            }

            if(requestObject.IsSetLoadingText())
            {
                context.Writer.WritePropertyName("loadingText");
                context.Writer.WriteStringValue(requestObject.LoadingText);
            }

            if(requestObject.IsSetLoginButtonText())
            {
                context.Writer.WritePropertyName("loginButtonText");
                context.Writer.WriteStringValue(requestObject.LoginButtonText);
            }

            if(requestObject.IsSetLoginDescription())
            {
                context.Writer.WritePropertyName("loginDescription");
                context.Writer.WriteStringValue(requestObject.LoginDescription);
            }

            if(requestObject.IsSetLoginTitle())
            {
                context.Writer.WritePropertyName("loginTitle");
                context.Writer.WriteStringValue(requestObject.LoginTitle);
            }

            if(requestObject.IsSetWelcomeText())
            {
                context.Writer.WritePropertyName("welcomeText");
                context.Writer.WriteStringValue(requestObject.WelcomeText);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LocalizedBrandingStringsMarshaller Instance = new LocalizedBrandingStringsMarshaller();

    }
}