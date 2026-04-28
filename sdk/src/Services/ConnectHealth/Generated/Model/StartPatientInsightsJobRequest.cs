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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
    /// Container for the parameters to the StartPatientInsightsJob operation.
    /// Starts a new patient insights job.
    /// </summary>
    public partial class StartPatientInsightsJobRequest : AmazonConnectHealthRequest
    {
        private string _clientToken;
        private string _domainId;
        private PatientInsightsEncounterContext _encounterContext;
        private InputDataConfig _inputDataConfig;
        private InsightsContext _insightsContext;
        private OutputDataConfig _outputDataConfig;
        private PatientInsightsPatientContext _patientContext;
        private UserContext _userContext;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DomainId.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=25)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property EncounterContext.
        /// </summary>
        [AWSProperty(Required=true)]
        public PatientInsightsEncounterContext EncounterContext
        {
            get { return this._encounterContext; }
            set { this._encounterContext = value; }
        }

        // Check to see if EncounterContext property is set
        internal bool IsSetEncounterContext()
        {
            return this._encounterContext != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public InputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InsightsContext.
        /// </summary>
        [AWSProperty(Required=true)]
        public InsightsContext InsightsContext
        {
            get { return this._insightsContext; }
            set { this._insightsContext = value; }
        }

        // Check to see if InsightsContext property is set
        internal bool IsSetInsightsContext()
        {
            return this._insightsContext != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PatientContext.
        /// </summary>
        [AWSProperty(Required=true)]
        public PatientInsightsPatientContext PatientContext
        {
            get { return this._patientContext; }
            set { this._patientContext = value; }
        }

        // Check to see if PatientContext property is set
        internal bool IsSetPatientContext()
        {
            return this._patientContext != null;
        }

        /// <summary>
        /// Gets and sets the property UserContext.
        /// </summary>
        [AWSProperty(Required=true)]
        public UserContext UserContext
        {
            get { return this._userContext; }
            set { this._userContext = value; }
        }

        // Check to see if UserContext property is set
        internal bool IsSetUserContext()
        {
            return this._userContext != null;
        }

    }
}