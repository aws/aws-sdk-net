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

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details tactics, techniques, and procedures (TTPs) used in a potential security event.
    /// Tactics are based on <a href="https://attack.mitre.org/matrices/enterprise/">MITRE
    /// ATT&amp;CK Matrix for Enterprise</a>.
    /// </summary>
    public partial class TTPsObservedDetail
    {
        /// <summary>
        /// Gets and sets the property APIFailureCount. 
        /// <para>
        /// The total number of failed API requests.
        /// </para>
        /// </summary>
        public long? APIFailureCount { get; set; }

        /// <summary>
        /// Checks to see if the APIFailureCount property is set.
        /// </summary>
        internal bool IsSetAPIFailureCount() => this.APIFailureCount.HasValue;

        /// <summary>
        /// Gets and sets the property APIName. 
        /// <para>
        /// The name of the API where the tactics, techniques, and procedure (TTP) was observed.
        /// </para>
        /// </summary>
        public string APIName { get; set; }

        /// <summary>
        /// Checks to see if the APIName property is set.
        /// </summary>
        internal bool IsSetAPIName() => this.APIName != null;

        /// <summary>
        /// Gets and sets the property APISuccessCount. 
        /// <para>
        /// The total number of successful API requests.
        /// </para>
        /// </summary>
        public long? APISuccessCount { get; set; }

        /// <summary>
        /// Checks to see if the APISuccessCount property is set.
        /// </summary>
        internal bool IsSetAPISuccessCount() => this.APISuccessCount.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address where the tactics, techniques, and procedure (TTP) was observed.
        /// </para>
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property Procedure. 
        /// <para>
        /// The procedure used, identified by the investigation.
        /// </para>
        /// </summary>
        public string Procedure { get; set; }

        /// <summary>
        /// Checks to see if the Procedure property is set.
        /// </summary>
        internal bool IsSetProcedure() => this.Procedure != null;

        /// <summary>
        /// Gets and sets the property Tactic. 
        /// <para>
        /// The tactic used, identified by the investigation.
        /// </para>
        /// </summary>
        public string Tactic { get; set; }

        /// <summary>
        /// Checks to see if the Tactic property is set.
        /// </summary>
        internal bool IsSetTactic() => this.Tactic != null;

        /// <summary>
        /// Gets and sets the property Technique. 
        /// <para>
        /// The technique used, identified by the investigation. 
        /// </para>
        /// </summary>
        public string Technique { get; set; }

        /// <summary>
        /// Checks to see if the Technique property is set.
        /// </summary>
        internal bool IsSetTechnique() => this.Technique != null;
    }
}
