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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateTrialComponent operation. Disassociates
    /// a trial component from a trial. This doesn't effect other trials the component is
    /// associated with. Before you can delete a component, you must disassociate the component
    /// from all trials it is associated with. To associate a trial component with a trial,
    /// call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AssociateTrialComponent.html">AssociateTrialComponent</a>
    /// API. <para> To get a list of the trials a component is associated with, use the <a
    /// href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
    /// API. Specify <c>ExperimentTrialComponent</c> for the <c>Resource</c> parameter. The
    /// list appears in the response under <c>Results.TrialComponent.Parents</c>. </para>
    /// </summary>
    public partial class DisassociateTrialComponentRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property TrialComponentName. 
        /// <para>
        /// The name of the component to disassociate from the trial.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 120)]
        public string TrialComponentName { get; set; }

        /// <summary>
        /// Checks to see if the TrialComponentName property is set.
        /// </summary>
        internal bool IsSetTrialComponentName() => this.TrialComponentName != null;

        /// <summary>
        /// Gets and sets the property TrialName. 
        /// <para>
        /// The name of the trial to disassociate from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 120)]
        public string TrialName { get; set; }

        /// <summary>
        /// Checks to see if the TrialName property is set.
        /// </summary>
        internal bool IsSetTrialName() => this.TrialName != null;
    }
}
