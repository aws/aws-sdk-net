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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// A structure that contains details of a service principal that represents an Amazon
    /// Web Services service that is enabled to integrate with Organizations.
    /// </summary>
    public partial class EnabledServicePrincipal
    {
        private DateTime? _dateEnabled;
        private string _servicePrincipal;

        /// <summary>
        /// Gets and sets the property DateEnabled. 
        /// <para>
        /// The date that the service principal was enabled for integration with Organizations.
        /// </para>
        /// </summary>
        public DateTime? DateEnabled
        {
            get { return this._dateEnabled; }
            set { this._dateEnabled = value; }
        }

        // Check to see if DateEnabled property is set
        internal bool IsSetDateEnabled()
        {
            return this._dateEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// The name of the service principal. This is typically in the form of a URL, such as:
        /// <c> <i>servicename</i>.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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