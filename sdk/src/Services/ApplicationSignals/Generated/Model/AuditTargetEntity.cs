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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A union structure that contains the specific entity information for different types
    /// of audit targets.
    /// </summary>
    public partial class AuditTargetEntity
    {
        private ServiceEntity _service;
        private ServiceOperationEntity _serviceOperation;
        private ServiceLevelObjectiveEntity _slo;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Service entity information when the audit target is a service.
        /// </para>
        /// </summary>
        public ServiceEntity Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceOperation. 
        /// <para>
        /// Service operation entity information when the audit target is a specific service operation.
        /// </para>
        /// </summary>
        public ServiceOperationEntity ServiceOperation
        {
            get { return this._serviceOperation; }
            set { this._serviceOperation = value; }
        }

        // Check to see if ServiceOperation property is set
        internal bool IsSetServiceOperation()
        {
            return this._serviceOperation != null;
        }

        /// <summary>
        /// Gets and sets the property Slo. 
        /// <para>
        /// SLO entity information when the audit target is a service level objective.
        /// </para>
        /// </summary>
        public ServiceLevelObjectiveEntity Slo
        {
            get { return this._slo; }
            set { this._slo = value; }
        }

        // Check to see if Slo property is set
        internal bool IsSetSlo()
        {
            return this._slo != null;
        }

    }
}