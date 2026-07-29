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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Contains information about the service-linked recorder paired with a service view.
    /// </summary>
    public partial class ServiceLinkedRecorderInfo
    {
        private string _recorderName;
        private RecorderType _recorderType;
        private string _servicePrincipal;

        /// <summary>
        /// Gets and sets the property RecorderName. 
        /// <para>
        /// The name of the service-linked recorder, such as <c>AWSConfigurationRecorderForObservabilityAdmin</c>.
        /// </para>
        /// </summary>
        public string RecorderName
        {
            get { return this._recorderName; }
            set { this._recorderName = value; }
        }

        // Check to see if RecorderName property is set
        internal bool IsSetRecorderName()
        {
            return this._recorderName != null;
        }

        /// <summary>
        /// Gets and sets the property RecorderType. 
        /// <para>
        /// The type of the recorder. Valid values are <c>AWS</c> and <c>THIRD_PARTY</c>.
        /// </para>
        /// </summary>
        public RecorderType RecorderType
        {
            get { return this._recorderType; }
            set { this._recorderType = value; }
        }

        // Check to see if RecorderType property is set
        internal bool IsSetRecorderType()
        {
            return this._recorderType != null;
        }

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// The service principal of the Amazon Web Services service that owns the service-linked
        /// recorder, such as <c>observabilityadmin.amazonaws.com</c>.
        /// </para>
        /// </summary>
        public string ServicePrincipal
        {
            get { return this._servicePrincipal; }
            set { this._servicePrincipal = value; }
        }

        // Check to see if ServicePrincipal property is set
        internal bool IsSetServicePrincipal()
        {
            return this._servicePrincipal != null;
        }

    }
}