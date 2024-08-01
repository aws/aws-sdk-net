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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProvisionedModelThroughput operation.
    /// Updates the name or associated model for a Provisioned Throughput. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
    /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </summary>
    public partial class UpdateProvisionedModelThroughputRequest : AmazonBedrockRequest
    {
        private string _desiredModelId;
        private string _desiredProvisionedModelName;
        private string _provisionedModelId;

        /// <summary>
        /// Gets and sets the property DesiredModelId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the new model to associate with this Provisioned
        /// Throughput. You can't specify this field if this Provisioned Throughput is associated
        /// with a base model.
        /// </para>
        ///  
        /// <para>
        /// If this Provisioned Throughput is associated with a custom model, you can specify
        /// one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The base model from which the custom model was customized.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Another custom model that was customized from the same base model as the custom model.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DesiredModelId
        {
            get { return this._desiredModelId; }
            set { this._desiredModelId = value; }
        }

        // Check to see if DesiredModelId property is set
        internal bool IsSetDesiredModelId()
        {
            return this._desiredModelId != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredProvisionedModelName. 
        /// <para>
        /// The new name for this Provisioned Throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DesiredProvisionedModelName
        {
            get { return this._desiredProvisionedModelName; }
            set { this._desiredProvisionedModelName = value; }
        }

        // Check to see if DesiredProvisionedModelName property is set
        internal bool IsSetDesiredProvisionedModelName()
        {
            return this._desiredProvisionedModelName != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedModelId. 
        /// <para>
        /// The Amazon Resource Name (ARN) or name of the Provisioned Throughput to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProvisionedModelId
        {
            get { return this._provisionedModelId; }
            set { this._provisionedModelId = value; }
        }

        // Check to see if ProvisionedModelId property is set
        internal bool IsSetProvisionedModelId()
        {
            return this._provisionedModelId != null;
        }

    }
}