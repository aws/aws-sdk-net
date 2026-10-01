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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Container for the parameters to the StartPatientInsightsJob operation. Starts a new
    /// patient insights job.
    /// </summary>
    public partial class StartPatientInsightsJobRequest : AmazonConnectHealthRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DomainId.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 25)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EncounterContext.
        /// </summary>
        [AWSProperty(Required = true)]
        public PatientInsightsEncounterContext EncounterContext { get; set; }

        /// <summary>
        /// Checks to see if the EncounterContext property is set.
        /// </summary>
        internal bool IsSetEncounterContext() => this.EncounterContext != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property InsightsContext.
        /// </summary>
        [AWSProperty(Required = true)]
        public InsightsContext InsightsContext { get; set; }

        /// <summary>
        /// Checks to see if the InsightsContext property is set.
        /// </summary>
        internal bool IsSetInsightsContext() => this.InsightsContext != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property PatientContext.
        /// </summary>
        [AWSProperty(Required = true)]
        public PatientInsightsPatientContext PatientContext { get; set; }

        /// <summary>
        /// Checks to see if the PatientContext property is set.
        /// </summary>
        internal bool IsSetPatientContext() => this.PatientContext != null;

        /// <summary>
        /// Gets and sets the property UserContext.
        /// </summary>
        [AWSProperty(Required = true)]
        public UserContext UserContext { get; set; }

        /// <summary>
        /// Checks to see if the UserContext property is set.
        /// </summary>
        internal bool IsSetUserContext() => this.UserContext != null;
    }
}
