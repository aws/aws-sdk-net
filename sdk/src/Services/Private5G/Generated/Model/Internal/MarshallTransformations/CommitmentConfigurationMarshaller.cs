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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Private5G.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Private5G.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CommitmentConfiguration Marshaller
    /// </summary>
    public class CommitmentConfigurationMarshaller : IRequestMarshaller<CommitmentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CommitmentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAutomaticRenewal())
            {
                context.Writer.WritePropertyName("automaticRenewal");
                context.Writer.Write(requestObject.AutomaticRenewal);
            }

            if(requestObject.IsSetCommitmentLength())
            {
                context.Writer.WritePropertyName("commitmentLength");
                context.Writer.Write(requestObject.CommitmentLength);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CommitmentConfigurationMarshaller Instance = new CommitmentConfigurationMarshaller();

    }
}