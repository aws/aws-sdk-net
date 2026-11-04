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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.DocDB.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.DocDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyDBInstance Request Marshaller
    /// </summary>
    public partial class ModifyDBInstanceRequestMarshaller : IMarshaller<IRequest, ModifyDBInstanceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBInstanceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyDBInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DocDB");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyDBInstance");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately.Value));
            }
            if (publicRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade.Value));
            }
            if (publicRequest.IsSetCACertificateIdentifier())
            {
                request.Parameters.Add("CACertificateIdentifier", StringUtils.FromString(publicRequest.CACertificateIdentifier));
            }
            if (publicRequest.IsSetCertificateRotationRestart())
            {
                request.Parameters.Add("CertificateRotationRestart", StringUtils.FromBool(publicRequest.CertificateRotationRestart.Value));
            }
            if (publicRequest.IsSetCopyTagsToSnapshot())
            {
                request.Parameters.Add("CopyTagsToSnapshot", StringUtils.FromBool(publicRequest.CopyTagsToSnapshot.Value));
            }
            if (publicRequest.IsSetDBInstanceClass())
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(publicRequest.DBInstanceClass));
            }
            if (publicRequest.IsSetDBInstanceIdentifier())
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(publicRequest.DBInstanceIdentifier));
            }
            if (publicRequest.IsSetEnablePerformanceInsights())
            {
                request.Parameters.Add("EnablePerformanceInsights", StringUtils.FromBool(publicRequest.EnablePerformanceInsights.Value));
            }
            if (publicRequest.IsSetNewDBInstanceIdentifier())
            {
                request.Parameters.Add("NewDBInstanceIdentifier", StringUtils.FromString(publicRequest.NewDBInstanceIdentifier));
            }
            if (publicRequest.IsSetPerformanceInsightsKMSKeyId())
            {
                request.Parameters.Add("PerformanceInsightsKMSKeyId", StringUtils.FromString(publicRequest.PerformanceInsightsKMSKeyId));
            }
            if (publicRequest.IsSetPreferredMaintenanceWindow())
            {
                request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
            }
            if (publicRequest.IsSetPromotionTier())
            {
                request.Parameters.Add("PromotionTier", StringUtils.FromInt(publicRequest.PromotionTier.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyDBInstanceRequestMarshaller _instance = new();

        internal static ModifyDBInstanceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyDBInstanceRequestMarshaller Instance => _instance;
    }
}
