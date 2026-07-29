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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAutonomousDatabase Request Marshaller
    /// </summary>       
    public class CreateAutonomousDatabaseRequestMarshaller : IMarshaller<IRequest, CreateAutonomousDatabaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAutonomousDatabaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAutonomousDatabaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.CreateAutonomousDatabase";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-08-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdminPassword())
            {
                context.Writer.WritePropertyName("adminPassword");
                context.Writer.WriteStringValue(publicRequest.AdminPassword);
            }

            if(publicRequest.IsSetAdminPasswordSource())
            {
                context.Writer.WritePropertyName("adminPasswordSource");
                context.Writer.WriteStringValue(publicRequest.AdminPasswordSource);
            }

            if(publicRequest.IsSetAdminPasswordSourceConfiguration())
            {
                context.Writer.WritePropertyName("adminPasswordSourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AdminPasswordSourceConfigurationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.AdminPasswordSourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAllowlistedIps())
            {
                context.Writer.WritePropertyName("allowlistedIps");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowlistedIpsListValue in publicRequest.AllowlistedIps)
                {
                        context.Writer.WriteStringValue(publicRequestAllowlistedIpsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAutonomousMaintenanceScheduleType())
            {
                context.Writer.WritePropertyName("autonomousMaintenanceScheduleType");
                context.Writer.WriteStringValue(publicRequest.AutonomousMaintenanceScheduleType);
            }

            if(publicRequest.IsSetBackupRetentionPeriodInDays())
            {
                context.Writer.WritePropertyName("backupRetentionPeriodInDays");
                context.Writer.WriteNumberValue(publicRequest.BackupRetentionPeriodInDays.Value);
            }

            if(publicRequest.IsSetByolComputeCountLimit())
            {
                context.Writer.WritePropertyName("byolComputeCountLimit");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.ByolComputeCountLimit.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.ByolComputeCountLimit.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.ByolComputeCountLimit.Value);
                }
            }

            if(publicRequest.IsSetCharacterSet())
            {
                context.Writer.WritePropertyName("characterSet");
                context.Writer.WriteStringValue(publicRequest.CharacterSet);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetComputeCount())
            {
                context.Writer.WritePropertyName("computeCount");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.ComputeCount.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.ComputeCount.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.ComputeCount.Value);
                }
            }

            if(publicRequest.IsSetCpuCoreCount())
            {
                context.Writer.WritePropertyName("cpuCoreCount");
                context.Writer.WriteNumberValue(publicRequest.CpuCoreCount.Value);
            }

            if(publicRequest.IsSetCustomerContactsToSendToOCI())
            {
                context.Writer.WritePropertyName("customerContactsToSendToOCI");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCustomerContactsToSendToOCIListValue in publicRequest.CustomerContactsToSendToOCI)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomerContactMarshaller.Instance;
                    marshaller.Marshall(publicRequestCustomerContactsToSendToOCIListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDatabaseEdition())
            {
                context.Writer.WritePropertyName("databaseEdition");
                context.Writer.WriteStringValue(publicRequest.DatabaseEdition);
            }

            if(publicRequest.IsSetDataStorageSizeInGBs())
            {
                context.Writer.WritePropertyName("dataStorageSizeInGBs");
                context.Writer.WriteNumberValue(publicRequest.DataStorageSizeInGBs.Value);
            }

            if(publicRequest.IsSetDataStorageSizeInTBs())
            {
                context.Writer.WritePropertyName("dataStorageSizeInTBs");
                context.Writer.WriteNumberValue(publicRequest.DataStorageSizeInTBs.Value);
            }

            if(publicRequest.IsSetDbName())
            {
                context.Writer.WritePropertyName("dbName");
                context.Writer.WriteStringValue(publicRequest.DbName);
            }

            if(publicRequest.IsSetDbToolsDetails())
            {
                context.Writer.WritePropertyName("dbToolsDetails");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDbToolsDetailsListValue in publicRequest.DbToolsDetails)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DatabaseToolMarshaller.Instance;
                    marshaller.Marshall(publicRequestDbToolsDetailsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDbVersion())
            {
                context.Writer.WritePropertyName("dbVersion");
                context.Writer.WriteStringValue(publicRequest.DbVersion);
            }

            if(publicRequest.IsSetDbWorkload())
            {
                context.Writer.WritePropertyName("dbWorkload");
                context.Writer.WriteStringValue(publicRequest.DbWorkload);
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetEncryptionKeyConfiguration())
            {
                context.Writer.WritePropertyName("encryptionKeyConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionKeyConfigurationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionKeyConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEncryptionKeyProvider())
            {
                context.Writer.WritePropertyName("encryptionKeyProvider");
                context.Writer.WriteStringValue(publicRequest.EncryptionKeyProvider);
            }

            if(publicRequest.IsSetIsAutoScalingEnabled())
            {
                context.Writer.WritePropertyName("isAutoScalingEnabled");
                context.Writer.WriteBooleanValue(publicRequest.IsAutoScalingEnabled.Value);
            }

            if(publicRequest.IsSetIsAutoScalingForStorageEnabled())
            {
                context.Writer.WritePropertyName("isAutoScalingForStorageEnabled");
                context.Writer.WriteBooleanValue(publicRequest.IsAutoScalingForStorageEnabled.Value);
            }

            if(publicRequest.IsSetIsBackupRetentionLocked())
            {
                context.Writer.WritePropertyName("isBackupRetentionLocked");
                context.Writer.WriteBooleanValue(publicRequest.IsBackupRetentionLocked.Value);
            }

            if(publicRequest.IsSetIsLocalDataGuardEnabled())
            {
                context.Writer.WritePropertyName("isLocalDataGuardEnabled");
                context.Writer.WriteBooleanValue(publicRequest.IsLocalDataGuardEnabled.Value);
            }

            if(publicRequest.IsSetIsMtlsConnectionRequired())
            {
                context.Writer.WritePropertyName("isMtlsConnectionRequired");
                context.Writer.WriteBooleanValue(publicRequest.IsMtlsConnectionRequired.Value);
            }

            if(publicRequest.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("licenseModel");
                context.Writer.WriteStringValue(publicRequest.LicenseModel);
            }

            if(publicRequest.IsSetNcharacterSet())
            {
                context.Writer.WritePropertyName("ncharacterSet");
                context.Writer.WriteStringValue(publicRequest.NcharacterSet);
            }

            if(publicRequest.IsSetOdbNetworkId())
            {
                context.Writer.WritePropertyName("odbNetworkId");
                context.Writer.WriteStringValue(publicRequest.OdbNetworkId);
            }

            if(publicRequest.IsSetPrivateEndpointIp())
            {
                context.Writer.WritePropertyName("privateEndpointIp");
                context.Writer.WriteStringValue(publicRequest.PrivateEndpointIp);
            }

            if(publicRequest.IsSetPrivateEndpointLabel())
            {
                context.Writer.WritePropertyName("privateEndpointLabel");
                context.Writer.WriteStringValue(publicRequest.PrivateEndpointLabel);
            }

            if(publicRequest.IsSetResourcePoolLeaderId())
            {
                context.Writer.WritePropertyName("resourcePoolLeaderId");
                context.Writer.WriteStringValue(publicRequest.ResourcePoolLeaderId);
            }

            if(publicRequest.IsSetResourcePoolSummary())
            {
                context.Writer.WritePropertyName("resourcePoolSummary");
                context.Writer.WriteStartObject();

                var marshaller = ResourcePoolSummaryMarshaller.Instance;
                marshaller.Marshall(publicRequest.ResourcePoolSummary, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScheduledOperations())
            {
                context.Writer.WritePropertyName("scheduledOperations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestScheduledOperationsListValue in publicRequest.ScheduledOperations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ScheduledOperationDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequestScheduledOperationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteStringValue(publicRequest.Source);
            }

            if(publicRequest.IsSetSourceConfiguration())
            {
                context.Writer.WritePropertyName("sourceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStandbyAllowlistedIps())
            {
                context.Writer.WritePropertyName("standbyAllowlistedIps");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStandbyAllowlistedIpsListValue in publicRequest.StandbyAllowlistedIps)
                {
                        context.Writer.WriteStringValue(publicRequestStandbyAllowlistedIpsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStandbyAllowlistedIpsSource())
            {
                context.Writer.WritePropertyName("standbyAllowlistedIpsSource");
                context.Writer.WriteStringValue(publicRequest.StandbyAllowlistedIpsSource);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTransportableTablespace())
            {
                context.Writer.WritePropertyName("transportableTablespace");
                context.Writer.WriteStartObject();

                var marshaller = TransportableTablespaceMarshaller.Instance;
                marshaller.Marshall(publicRequest.TransportableTablespace, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateAutonomousDatabaseRequestMarshaller _instance = new CreateAutonomousDatabaseRequestMarshaller();        

        internal static CreateAutonomousDatabaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAutonomousDatabaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}