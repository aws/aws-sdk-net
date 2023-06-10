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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceAction operation.
    /// Creates a self-service action.
    /// </summary>
    public partial class CreateServiceActionRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private Dictionary<string, string> _definition = new Dictionary<string, string>();
        private ServiceActionDefinitionType _definitionType;
        private string _description;
        private string _idempotencyToken;
        private string _name;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>jp</code> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh</code> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=100)]
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The self-service action definition. Can be one of the following:
        /// </para>
        ///  <dl> <dt>Name</dt> <dd> 
        /// <para>
        /// The name of the Amazon Web Services Systems Manager document (SSM document). For example,
        /// <code>AWS-RestartEC2Instance</code>.
        /// </para>
        ///  
        /// <para>
        /// If you are using a shared SSM document, you must provide the ARN instead of the name.
        /// </para>
        ///  </dd> <dt>Version</dt> <dd> 
        /// <para>
        /// The Amazon Web Services Systems Manager automation document version. For example,
        /// <code>"Version": "1"</code> 
        /// </para>
        ///  </dd> <dt>AssumeRole</dt> <dd> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that performs the self-service actions
        /// on your behalf. For example, <code>"AssumeRole": "arn:aws:iam::12345678910:role/ActionRole"</code>.
        /// </para>
        ///  
        /// <para>
        /// To reuse the provisioned product launch role, set to <code>"AssumeRole": "LAUNCH_ROLE"</code>.
        /// </para>
        ///  </dd> <dt>Parameters</dt> <dd> 
        /// <para>
        /// The list of parameters in JSON format.
        /// </para>
        ///  
        /// <para>
        /// For example: <code>[{\"Name\":\"InstanceId\",\"Type\":\"TARGET\"}]</code> or <code>[{\"Name\":\"InstanceId\",\"Type\":\"TEXT_VALUE\"}]</code>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public Dictionary<string, string> Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null && this._definition.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefinitionType. 
        /// <para>
        /// The service action definition type. For example, <code>SSM_AUTOMATION</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceActionDefinitionType DefinitionType
        {
            get { return this._definitionType; }
            set { this._definitionType = value; }
        }

        // Check to see if DefinitionType property is set
        internal bool IsSetDefinitionType()
        {
            return this._definitionType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The self-service action description.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique identifier that you provide to ensure idempotency. If multiple requests differ
        /// only by the idempotency token, the same response is returned for each repeated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The self-service action name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}