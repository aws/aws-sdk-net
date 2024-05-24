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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreTestingRecoveryPointSelection Marshaller
    /// </summary>
    public class RestoreTestingRecoveryPointSelectionMarshaller : IRequestMarshaller<RestoreTestingRecoveryPointSelection, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RestoreTestingRecoveryPointSelection requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlgorithm())
            {
                context.Writer.WritePropertyName("Algorithm");
                context.Writer.Write(requestObject.Algorithm);
            }

            if(requestObject.IsSetExcludeVaults())
            {
                context.Writer.WritePropertyName("ExcludeVaults");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExcludeVaultsListValue in requestObject.ExcludeVaults)
                {
                        context.Writer.Write(requestObjectExcludeVaultsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIncludeVaults())
            {
                context.Writer.WritePropertyName("IncludeVaults");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIncludeVaultsListValue in requestObject.IncludeVaults)
                {
                        context.Writer.Write(requestObjectIncludeVaultsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRecoveryPointTypes())
            {
                context.Writer.WritePropertyName("RecoveryPointTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRecoveryPointTypesListValue in requestObject.RecoveryPointTypes)
                {
                        context.Writer.Write(requestObjectRecoveryPointTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSelectionWindowDays())
            {
                context.Writer.WritePropertyName("SelectionWindowDays");
                context.Writer.Write(requestObject.SelectionWindowDays);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RestoreTestingRecoveryPointSelectionMarshaller Instance = new RestoreTestingRecoveryPointSelectionMarshaller();

    }
}