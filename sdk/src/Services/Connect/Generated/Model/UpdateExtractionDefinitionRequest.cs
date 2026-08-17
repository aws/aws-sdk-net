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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateExtractionDefinition operation.
    /// Updates an extraction definition in the specified Connect Customer instance.
    /// </summary>
    public partial class UpdateExtractionDefinitionRequest : AmazonConnectRequest
    {
        private string _clientToken;
        private ExtractionDefinitionDisplay _display;
        private ExtractionConfiguration _extractionConfiguration;
        private string _extractionDefinitionId;
        private string _instanceId;
        private string _name;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Display. 
        /// <para>
        /// The display settings for the extraction definition.
        /// </para>
        /// </summary>
        public ExtractionDefinitionDisplay Display
        {
            get { return this._display; }
            set { this._display = value; }
        }

        // Check to see if Display property is set
        internal bool IsSetDisplay()
        {
            return this._display != null;
        }

        /// <summary>
        /// Gets and sets the property ExtractionConfiguration. 
        /// <para>
        /// The configuration that defines how data is extracted, including the prompt hint and
        /// not-found behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExtractionConfiguration ExtractionConfiguration
        {
            get { return this._extractionConfiguration; }
            set { this._extractionConfiguration = value; }
        }

        // Check to see if ExtractionConfiguration property is set
        internal bool IsSetExtractionConfiguration()
        {
            return this._extractionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionId. 
        /// <para>
        /// The identifier of the extraction definition to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ExtractionDefinitionId
        {
            get { return this._extractionDefinitionId; }
            set { this._extractionDefinitionId = value; }
        }

        // Check to see if ExtractionDefinitionId property is set
        internal bool IsSetExtractionDefinitionId()
        {
            return this._extractionDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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