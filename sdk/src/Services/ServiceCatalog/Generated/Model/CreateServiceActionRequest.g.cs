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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceAction operation. Creates a self-service
    /// action.
    /// </summary>
    public partial class CreateServiceActionRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AcceptLanguage property is set.
        /// </summary>
        internal bool IsSetAcceptLanguage() => this.AcceptLanguage != null;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The self-service action definition. Can be one of the following:
        /// </para>
        ///  <dl> <dt>Name</dt> <dd> 
        /// <para>
        /// The name of the Amazon Web Services Systems Manager document (SSM document). For example,
        /// <c>AWS-RestartEC2Instance</c>.
        /// </para>
        ///  
        /// <para>
        /// If you are using a shared SSM document, you must provide the ARN instead of the name.
        /// </para>
        ///  </dd> <dt>Version</dt> <dd> 
        /// <para>
        /// The Amazon Web Services Systems Manager automation document version. For example,
        /// <c>"Version": "1"</c> 
        /// </para>
        ///  </dd> <dt>AssumeRole</dt> <dd> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that performs the self-service actions
        /// on your behalf. For example, <c>"AssumeRole": "arn:aws:iam::12345678910:role/ActionRole"</c>.
        /// </para>
        ///  
        /// <para>
        /// To reuse the provisioned product launch role, set to <c>"AssumeRole": "LAUNCH_ROLE"</c>.
        /// </para>
        ///  </dd> <dt>Parameters</dt> <dd> 
        /// <para>
        /// The list of parameters in JSON format.
        /// </para>
        ///  
        /// <para>
        /// For example: <c>[{\"Name\":\"InstanceId\",\"Type\":\"TARGET\"}]</c> or <c>[{\"Name\":\"InstanceId\",\"Type\":\"TEXT_VALUE\"}]</c>.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public Dictionary<string, string> Definition { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null && (this.Definition.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefinitionType. 
        /// <para>
        /// The service action definition type. For example, <c>SSM_AUTOMATION</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceActionDefinitionType DefinitionType { get; set; }

        /// <summary>
        /// Checks to see if the DefinitionType property is set.
        /// </summary>
        internal bool IsSetDefinitionType() => this.DefinitionType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The self-service action description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique identifier that you provide to ensure idempotency. If multiple requests differ
        /// only by the idempotency token, the same response is returned for each repeated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The self-service action name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
