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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWebFunctionEndpoint operation. Updates the
    /// configuration of a web function endpoint. You can modify the authorization type, auto-deployment
    /// mode, revision weights, scaling, and throttling settings.
    /// </summary>
    public partial class UpdateWebFunctionEndpointRequest : AmazonLambdaWebRequest
    {
        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authorization type for the endpoint. Omit this field to keep the current authorization
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ApplicationManaged</c> – Your application handles authorization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IamAuth</c> – Lambda uses IAM to authorize requests, which must be signed with
        /// Signature Version 4 (SigV4).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property AutoDeploymentMode. 
        /// <para>
        /// The auto-deployment mode for the endpoint. Omit this field to keep the current auto-deployment
        /// mode.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LatestRevision</c> – The endpoint automatically serves the newest revision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Disabled</c> – Revision routing stays fixed until you change it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AutoDeploymentMode AutoDeploymentMode { get; set; }

        /// <summary>
        /// Checks to see if the AutoDeploymentMode property is set.
        /// </summary>
        internal bool IsSetAutoDeploymentMode() => this.AutoDeploymentMode != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the endpoint. Omit this field to keep the current description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The endpoint to update.
        /// </para>
        ///  
        /// <para>
        /// You can specify either of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The endpoint name, for example <c>my-endpoint</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The endpoint ARN.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the endpoint
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The web function.
        /// </para>
        ///  
        /// <para>
        /// You can specify either of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The function name, for example <c>my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The function ARN.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property RevisionWeights. 
        /// <para>
        /// A list of revision weights that determine how traffic is distributed across revisions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<RevisionWeight> RevisionWeights { get; set; } = AWSConfigs.InitializeCollections ? new List<RevisionWeight>() : null;

        /// <summary>
        /// Checks to see if the RevisionWeights property is set.
        /// </summary>
        internal bool IsSetRevisionWeights() => this.RevisionWeights != null && (this.RevisionWeights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration for the endpoint. Omit this field to keep the current scaling
        /// configuration. To clear a previously set <c>maxEnvironments</c> value, specify an
        /// empty object.
        /// </para>
        /// </summary>
        public ScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfig property is set.
        /// </summary>
        internal bool IsSetScalingConfig() => this.ScalingConfig != null;

        /// <summary>
        /// Gets and sets the property ThrottleConfig. 
        /// <para>
        /// The throttling configuration for the endpoint. Omit this field to keep the current
        /// throttling configuration. To clear a previously set <c>rateLimit</c> value, specify
        /// an empty object.
        /// </para>
        /// </summary>
        public ThrottleConfig ThrottleConfig { get; set; }

        /// <summary>
        /// Checks to see if the ThrottleConfig property is set.
        /// </summary>
        internal bool IsSetThrottleConfig() => this.ThrottleConfig != null;
    }
}
