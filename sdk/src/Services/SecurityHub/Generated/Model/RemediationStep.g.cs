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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A step in the remediation guidance.
    /// </summary>
    public partial class RemediationStep
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to be taken for this step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what the step does.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Inverse. 
        /// <para>
        /// The inverse of the step, to be used if the step needs to be rolled back.
        /// </para>
        /// </summary>
        public string Inverse { get; set; }

        /// <summary>
        /// Checks to see if the Inverse property is set.
        /// </summary>
        internal bool IsSetInverse() => this.Inverse != null;

        /// <summary>
        /// Gets and sets the property Logic. 
        /// <para>
        /// The logic behind the existence of this step.
        /// </para>
        /// </summary>
        public string Logic { get; set; }

        /// <summary>
        /// Checks to see if the Logic property is set.
        /// </summary>
        internal bool IsSetLogic() => this.Logic != null;

        /// <summary>
        /// Gets and sets the property Phase. 
        /// <para>
        /// The phase of the remediation plan that this step belongs to (for example, <c>FIX</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Phase { get; set; }

        /// <summary>
        /// Checks to see if the Phase property is set.
        /// </summary>
        internal bool IsSetPhase() => this.Phase != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Which service this step is performed in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property VerifyAfter. 
        /// <para>
        /// The action to take after the step to verify its success.
        /// </para>
        /// </summary>
        public string VerifyAfter { get; set; }

        /// <summary>
        /// Checks to see if the VerifyAfter property is set.
        /// </summary>
        internal bool IsSetVerifyAfter() => this.VerifyAfter != null;
    }
}
