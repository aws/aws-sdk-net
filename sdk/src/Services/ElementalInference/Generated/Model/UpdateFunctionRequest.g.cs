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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFunction operation. Updates a function.
    /// Include only the parameters that you want to change; parameters that you don't include
    /// aren't affected. Elemental Inference validates the updated expressions in the same
    /// way as CreateFunction. <para> While a feed references the function, you can change
    /// only its expressions and its description, and you can set eventBridgeDelivery to DISABLED
    /// but not to ENABLED. The request expression must keep referencing the same media context,
    /// as reported in contextTypes. Changing an expression changes the behavior of every
    /// feed that references the function. </para>
    /// </summary>
    public partial class UpdateFunctionRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the function.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBridgeDelivery. 
        /// <para>
        /// Specifies whether Elemental Inference also sends this function's marked results to
        /// Amazon EventBridge, as described for CreateFunction. If you omit this parameter, the
        /// current value is kept. While a feed references the function, you can change this value
        /// to DISABLED, but not to ENABLED. 
        /// </para>
        /// </summary>
        public EventBridgeDeliveryMode EventBridgeDelivery { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeDelivery property is set.
        /// </summary>
        internal bool IsSetEventBridgeDelivery() => this.EventBridgeDelivery != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the function. You can't change the name while the function is referenced
        /// by a feed. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestExpression. 
        /// <para>
        /// A new request expression for the function. Elemental Inference derives contextTypes
        /// again from the new expression. While a feed references the function, the new expression
        /// must reference the same media context as the current one. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 5120)]
        public string RequestExpression { get; set; }

        /// <summary>
        /// Checks to see if the RequestExpression property is set.
        /// </summary>
        internal bool IsSetRequestExpression() => this.RequestExpression != null;

        /// <summary>
        /// Gets and sets the property ResponseExpression. 
        /// <para>
        /// A new response expression for the function. To remove the response expression, specify
        /// an empty string. A function with a Bedrock target and eventBridgeDelivery set to ENABLED
        /// must keep a response expression. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 5120)]
        public string ResponseExpression { get; set; }

        /// <summary>
        /// Checks to see if the ResponseExpression property is set.
        /// </summary>
        internal bool IsSetResponseExpression() => this.ResponseExpression != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// A new target for the function. You can't change the target while the function is referenced
        /// by a feed. 
        /// </para>
        /// </summary>
        public FunctionTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
