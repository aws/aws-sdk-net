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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplaceImageCriteriaInAllowedImagesSettings Request Marshaller
    /// </summary>
    public partial class ReplaceImageCriteriaInAllowedImagesSettingsRequestMarshaller : IMarshaller<IRequest, ReplaceImageCriteriaInAllowedImagesSettingsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReplaceImageCriteriaInAllowedImagesSettingsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ReplaceImageCriteriaInAllowedImagesSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ReplaceImageCriteriaInAllowedImagesSettings");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetImageCriteria())
            {
                if (publicRequest.ImageCriteria.Count == 0)
                {
                    request.Parameters.Add("ImageCriterion", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ImageCriteria)
                    {
                        if (item0.IsSetCreationDateCondition())
                        {
                            if (item0.CreationDateCondition.IsSetMaximumDaysSinceCreated())
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".CreationDateCondition" + ".MaximumDaysSinceCreated", StringUtils.FromInt(item0.CreationDateCondition.MaximumDaysSinceCreated.Value));
                            }
                        }
                        if (item0.IsSetDeprecationTimeCondition())
                        {
                            if (item0.DeprecationTimeCondition.IsSetMaximumDaysSinceDeprecated())
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".DeprecationTimeCondition" + ".MaximumDaysSinceDeprecated", StringUtils.FromInt(item0.DeprecationTimeCondition.MaximumDaysSinceDeprecated.Value));
                            }
                        }
                        if (item0.IsSetImageNames())
                        {
                            if (item0.ImageNames.Count == 0)
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ImageName", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ImageNames)
                                {
                                    request.Parameters.Add("ImageCriterion" + "." + index0 + ".ImageName" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetImageProviders())
                        {
                            if (item0.ImageProviders.Count == 0)
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ImageProvider", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ImageProviders)
                                {
                                    request.Parameters.Add("ImageCriterion" + "." + index0 + ".ImageProvider" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetImageWatermarks())
                        {
                            if (item0.ImageWatermarks.Count == 0)
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ImageWatermark", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ImageWatermarks)
                                {
                                    if (item1.IsSetMaximumDaysSinceSourceImageCreated())
                                    {
                                        request.Parameters.Add("ImageCriterion" + "." + index0 + ".ImageWatermark" + "." + index1 + ".MaximumDaysSinceSourceImageCreated", StringUtils.FromInt(item1.MaximumDaysSinceSourceImageCreated.Value));
                                    }
                                    if (item1.IsSetMaximumDaysSinceWatermarkCreated())
                                    {
                                        request.Parameters.Add("ImageCriterion" + "." + index0 + ".ImageWatermark" + "." + index1 + ".MaximumDaysSinceWatermarkCreated", StringUtils.FromInt(item1.MaximumDaysSinceWatermarkCreated.Value));
                                    }
                                    if (item1.IsSetSourceImageRegion())
                                    {
                                        request.Parameters.Add("ImageCriterion" + "." + index0 + ".ImageWatermark" + "." + index1 + ".SourceImageRegion", StringUtils.FromString(item1.SourceImageRegion));
                                    }
                                    if (item1.IsSetWatermarkKey())
                                    {
                                        request.Parameters.Add("ImageCriterion" + "." + index0 + ".ImageWatermark" + "." + index1 + ".WatermarkKey", StringUtils.FromString(item1.WatermarkKey));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetMarketplaceProductCodes())
                        {
                            if (item0.MarketplaceProductCodes.Count == 0)
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".MarketplaceProductCode", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.MarketplaceProductCodes)
                                {
                                    request.Parameters.Add("ImageCriterion" + "." + index0 + ".MarketplaceProductCode" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetScanResultCondition())
                        {
                            if (item0.ScanResultCondition.IsSetMaxDaysSinceCriticalFixAvailable())
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ScanResultCondition" + ".MaxDaysSinceCriticalFixAvailable", StringUtils.FromInt(item0.ScanResultCondition.MaxDaysSinceCriticalFixAvailable.Value));
                            }
                            if (item0.ScanResultCondition.IsSetMaxDaysSinceHighFixAvailable())
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ScanResultCondition" + ".MaxDaysSinceHighFixAvailable", StringUtils.FromInt(item0.ScanResultCondition.MaxDaysSinceHighFixAvailable.Value));
                            }
                            if (item0.ScanResultCondition.IsSetMaxDaysSinceInformationalFixAvailable())
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ScanResultCondition" + ".MaxDaysSinceInformationalFixAvailable", StringUtils.FromInt(item0.ScanResultCondition.MaxDaysSinceInformationalFixAvailable.Value));
                            }
                            if (item0.ScanResultCondition.IsSetMaxDaysSinceLastFindingScan())
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ScanResultCondition" + ".MaxDaysSinceLastFindingScan", StringUtils.FromInt(item0.ScanResultCondition.MaxDaysSinceLastFindingScan.Value));
                            }
                            if (item0.ScanResultCondition.IsSetMaxDaysSinceLowFixAvailable())
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ScanResultCondition" + ".MaxDaysSinceLowFixAvailable", StringUtils.FromInt(item0.ScanResultCondition.MaxDaysSinceLowFixAvailable.Value));
                            }
                            if (item0.ScanResultCondition.IsSetMaxDaysSinceMediumFixAvailable())
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ScanResultCondition" + ".MaxDaysSinceMediumFixAvailable", StringUtils.FromInt(item0.ScanResultCondition.MaxDaysSinceMediumFixAvailable.Value));
                            }
                            if (item0.ScanResultCondition.IsSetMaximumSeverityLabel())
                            {
                                request.Parameters.Add("ImageCriterion" + "." + index0 + ".ScanResultCondition" + ".MaximumSeverityLabel", StringUtils.FromString(item0.ScanResultCondition.MaximumSeverityLabel));
                            }
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ReplaceImageCriteriaInAllowedImagesSettingsRequestMarshaller _instance = new();

        internal static ReplaceImageCriteriaInAllowedImagesSettingsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ReplaceImageCriteriaInAllowedImagesSettingsRequestMarshaller Instance => _instance;
    }
}
