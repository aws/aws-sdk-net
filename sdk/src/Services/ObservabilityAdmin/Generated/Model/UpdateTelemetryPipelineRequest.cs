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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTelemetryPipeline operation.
    /// Updates the configuration of an existing telemetry pipeline.
    /// 
    ///  <note> 
    /// <para>
    /// The following attributes cannot be updated after pipeline creation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Pipeline name</b> - The pipeline name is immutable
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Pipeline ARN</b> - The ARN is automatically generated and cannot be changed
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Source type</b> - Once a pipeline is created with a specific source type (such
    /// as S3, CloudWatch Logs, GitHub, or third-party sources), it cannot be changed to a
    /// different source type
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Processors can be added, removed, or modified. However, some processors are not supported
    /// for third-party pipelines and cannot be added through updates.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Source-Specific Update Rules</b> 
    /// </para>
    ///  <dl> <dt>CloudWatch Logs Sources (Vended and Custom)</dt> <dd> 
    /// <para>
    ///  <b>Updatable:</b> <c>sts_role_arn</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Fixed:</b> <c>data_source_name</c>, <c>data_source_type</c>, sink (must remain
    /// <c>@original</c>)
    /// </para>
    ///  </dd> <dt>S3 Sources (Crowdstrike, Zscaler, SentinelOne, Custom)</dt> <dd> 
    /// <para>
    ///  <b>Updatable:</b> All SQS configuration parameters, <c>sts_role_arn</c>, codec settings,
    /// compression type, bucket ownership settings, sink log group
    /// </para>
    ///  
    /// <para>
    ///  <b>Fixed:</b> <c>notification_type</c>, <c>aws.region</c> 
    /// </para>
    ///  </dd> <dt>GitHub Audit Logs</dt> <dd> 
    /// <para>
    ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>scope</c>
    /// (can switch between ORGANIZATION/ENTERPRISE), <c>organization</c> or <c>enterprise</c>
    /// name, <c>range</c>, authentication credentials (PAT or GitHub App)
    /// </para>
    ///  </dd> <dt>Microsoft Sources (Entra ID, Office365, Windows)</dt> <dd> 
    /// <para>
    ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>tenant_id</c>,
    /// <c>workspace_id</c> (Windows only), OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
    /// </para>
    ///  </dd> <dt>Okta Sources (SSO, Auth0)</dt> <dd> 
    /// <para>
    ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>domain</c>,
    /// <c>range</c> (SSO only), OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
    /// </para>
    ///  </dd> <dt>Palo Alto Networks</dt> <dd> 
    /// <para>
    ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>hostname</c>,
    /// basic authentication credentials (<c>username</c>, <c>password</c>)
    /// </para>
    ///  </dd> <dt>ServiceNow CMDB</dt> <dd> 
    /// <para>
    ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>instance_url</c>,
    /// <c>range</c>, OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
    /// </para>
    ///  </dd> <dt>Wiz CNAPP</dt> <dd> 
    /// <para>
    ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>region</c>,
    /// <c>range</c>, OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class UpdateTelemetryPipelineRequest : AmazonObservabilityAdminRequest
    {
        private TelemetryPipelineConfiguration _configuration;
        private string _pipelineIdentifier;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The new configuration for the telemetry pipeline, including updated sources, processors,
        /// and destinations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TelemetryPipelineConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineIdentifier. 
        /// <para>
        /// The ARN of the telemetry pipeline to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string PipelineIdentifier
        {
            get { return this._pipelineIdentifier; }
            set { this._pipelineIdentifier = value; }
        }

        // Check to see if PipelineIdentifier property is set
        internal bool IsSetPipelineIdentifier()
        {
            return this._pipelineIdentifier != null;
        }

    }
}